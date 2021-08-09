using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace HeartMath
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Bitmap Tab;
        Graphics Tabg;
        SolidBrush myBrush;
        private void FormMain_Load(object sender, EventArgs e)
        {
            Fat.Cursor = DefaultCursor;
            #region Тестовые значения
            KolText.Text = "100";
            MnojText.Text = "2";
            UpMnoj.Value = 10;
            #endregion
            Tab = new Bitmap(pb.Width, pb.Height);
            Tabg = Graphics.FromImage(Tab);
            pb.Image = Tab;
            pen = new Pen(Brushes.Red, (float)(Convert.ToDouble(Fat.Value) / 10));
            #region Всплывающие подсказки
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = false;
            toolTip1.SetToolTip(this.StartPosition, "Угол начала отсчёта");
            toolTip1.SetToolTip(this.StartPoint, "Число с которого начнается счёт");
            toolTip1.SetToolTip(this.Create, "Начинает построение, также является паузой");
            toolTip1.SetToolTip(this.UpMnoj, "Увеличмвает множитель на значение/100");
            toolTip1.SetToolTip(this.KonMnoj, "До кого множителя выполняется программа");
            toolTip1.SetToolTip(this.DLFile, "Сохранитьизображение на холсте");
            #endregion
        }
        /// <summary>
        /// Метод вычисляет точки на окружности
        /// </summary>
        /// <param name="dot">Массив Структур точек</param>
        /// <param name="dot1">Начальный угл</param>
        /// <param name="a">Модификатор чисел</param>
        /// <returns>Заполненый Массив Структур</returns>
        private Dot[] Doty(Dot[] dot, float dot1, float a)
        {
            for (UInt16 i = 0; i < dot.Length; i++)
            {
                if (i != 0)
                    dot1 = dot1 + 360.0f / (float)dot.Length;
                if (dot1 > 360)
                    dot1 -= 360;
                dot[i] = new Dot(dot1, a / 2);
            }
            return dot;
        }
        /// <summary>
        /// Создание битового образа линий на полотне
        /// </summary>
        /// <param name="Tab">Битовый образ</param>
        /// <param name="dot">Массив структур координат</param>
        /// <param name="pen">Кисть для линий</param>
        /// <returns></returns>
        private Bitmap Taby(Bitmap Tab,Dot[] dot, Pen pen,float rt)
        {
            Int32 rtt = 0, or = 0;
            for (UInt16 i = Convert.ToUInt16(StartPoint.Text); i < dot.Length; i++)
            {
                or = (Int32)Math.Round((float)i * rt);
                if (or == 0)
                    continue;
                if (or >= dot.Length)
                    do
                    {
                        rtt = Math.Abs(or - (dot.Length * (or / dot.Length)));
                    } while (rtt >= dot.Length);
                else
                    rtt = (Int32)Math.Round((float)i * rt);
                Tabg.DrawLine(pen, dot[i].X, dot[i].Y, dot[rtt].X, dot[rtt].Y);
                //Скорость
                if (Dinamic.Checked && ModGroup.Visible == false)
                {
                    pb.Image = Tab;
                    pb.Update();
                    Thread.Sleep(SpeedBar.Value);
                }
            }
            return Tab;
        }
        Dot[] dot;
        Pen pen;
        private void Cler()
        {
            pb.Image = null;
            Tabg.Clear(System.Drawing.Color.White);

        }
        float Num = 0;
        /// <summary>
        ///Стандартное создание таблицы
        /// </summary>
        private void Act1()
        {
            #region Создание линий на полотне
            Tab = Taby(Tab, dot, pen, Convert.ToUInt16(MnojText.Value));
            pb.Image = Tab;
            #endregion
        }
        private void BedasVvodom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
                e.Handled = true;
            if (e.KeyChar == '\b')
                e.Handled = false;
        }
        /// <summary>
        /// Cтура координат точек на окружности
        /// </summary>
        public struct Dot
        {
            public Dot(float n, float r)
            {
                Y = (float)Math.Abs(Math.Ceiling(r * Math.Cos(n * 3.141 / 180.0d)) - 250.0f);
                X = (float)Math.Ceiling(r * Math.Sin(n * 3.141 / 180.0d)) + 250.0f;
            }

            public float X { get; }
            public float Y { get; }
        }
        float a;
        private void Create_MouseClick(object sender, MouseEventArgs e)
        {
            count = 0;
            if (p == 1)
            {
                #region очистить полотно
                Cler();
                myBrush = new SolidBrush(Colorb.BackColor);
                #endregion 
                #region Проверка на числа
                Num = 0;
                if (Number.Checked)
                    Num = 20.0f;
                a = 500 - Num * 2;
                #endregion 
                #region Зарисовка окружности с учётом чисел
                pen = new Pen(myBrush, (float)(Convert.ToDouble(Fat.Value) / 10));
                Tabg.DrawEllipse(pen, 0.0f + Num, 0.0f + Num, a, a);
                pb.Image = Tab;
                #endregion 
                #region Создание коорд точек на окружности
                dot = new Dot[Convert.ToUInt16(KolText.Value)];
                dot = Doty(dot, (float)StartPosition.Value, a);
                #endregion 
                #region Создание чисел на окружности
                if (Number.Checked)
                    ActNum(Convert.ToUInt16(KolText.Value), dot, (UInt16)(a / 2));
                #endregion 
                if (ModGroup.Visible)
                {
                    MainGroup.Enabled = false;
                    p = 0;
                    Color color = Colorb.BackColor;
                    Mn.Visible = true;
                    sai = (float)MnojText.Value;
                    aTimer = new System.Timers.Timer(SpeedBar.Value * 10);
                    aTimer.Elapsed += ATimer_Elapsed;

                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                }
                else
                    Act1();
            }
            else
            {
                if (aTimer.Enabled)
                    aTimer.Enabled = false;
                else
                    aTimer.Enabled = true;
            }
        }
        public System.Timers.Timer aTimer;
        float sai;
        public delegate void InvokeDelegate();
        public void InvokeMethod()
        {
            Mn.Text = "" + Math.Round(sai,2);
            Mn.Update();
        }
        public void InvokeMethod2()
        {
            MainGroup.Enabled = true;
        }

        byte p = 1;
        sbyte rgb = 0;
        int count = 0;
        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            if(ColorRandom.Checked)
            if(Math.Round(sai,2)%Math.Floor(sai)==0)
            {
                Random random = new Random();
                rgb = (sbyte)random.Next(-3, 4);

            }
            else
            {
                    switch (rgb)
                    {
                        case 1: if (pen.Color.R + UpMnoj.Value > 255) rgb *= -1; else pen.Color = Color.FromArgb((byte)(pen.Color.R + UpMnoj.Value), pen.Color.G, pen.Color.B); break;
                        case 2: if (pen.Color.G + UpMnoj.Value > 255) rgb *= -1; else pen.Color = Color.FromArgb(pen.Color.R, (byte)(pen.Color.G + UpMnoj.Value), pen.Color.B); break;
                        case 3: if (pen.Color.B + UpMnoj.Value > 255) rgb *= -1; else pen.Color = Color.FromArgb(pen.Color.R, pen.Color.G, (byte)(pen.Color.B + UpMnoj.Value)); break;
                        case -1: if (pen.Color.R - UpMnoj.Value < 0) rgb *= -1; else pen.Color = Color.FromArgb((byte)(pen.Color.R - UpMnoj.Value), pen.Color.G, pen.Color.B); break;
                        case -2: if (pen.Color.G - UpMnoj.Value < 0) rgb *= -1; else pen.Color = Color.FromArgb(pen.Color.R, (byte)(pen.Color.G - UpMnoj.Value), pen.Color.B); break;
                        case -3: if (pen.Color.B - UpMnoj.Value < 0) rgb *= -1; else pen.Color = Color.FromArgb(pen.Color.R, pen.Color.G, (byte)(pen.Color.B - UpMnoj.Value)); break;
                    }
                    
            }
            sai += (float)UpMnoj.Value/100.0f;

            Mn.BeginInvoke(new InvokeDelegate(InvokeMethod));
            Tabg.FillEllipse(Brushes.White, 1.0f + Num, 1.0f + Num, a-2, a-2);
            Tab = Taby(Tab, dot, pen, sai);
            pb.Image = Tab;
            if (sai >= (float)KonMnoj.Value)
            {
                p = 1;
                MainGroup.BeginInvoke(new InvokeDelegate(InvokeMethod2));
                return;
            }
            if (SaveScreen.Checked)
            {
                pb.BeginInvoke(new InvokeDelegate(InvokeMethod3));
                //Tab.Save("D:\\HeartMath\\Img" + count + ".jpg");
                count++;
            }
            aTimer.Enabled = true;
        }

        public void InvokeMethod3()
        {
            pb.Image.Save("fileImg" + count + ".jpg");
        }

        private void ModBut_MouseClick(object sender, MouseEventArgs e)
        {
            if (ModGroup.Visible)
            {
                ModGroup.Visible = false;
                Create.Enabled = true;
                Prov.Value = 0;
            }
            else
            {
                ModGroup.Visible = true;
                Create.Enabled = false;
                Prov.Value = 1;
            }
        }

        private void Color_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Colorb.BackColor = colorDialog.Color;
            }
        }

        private void ActNum(UInt16 k, Dot[] d, UInt16 r)
        {
            if (k > d.Length)
                k = (ushort)d.Length;
            UInt16 e = Convert.ToUInt16(StartPoint.Text);
            r += 20;
            for (UInt16 i = 0; i < k; i++)
            {
                if (d[i].Y <= r && d[i].X < r)
                    Tabg.DrawString(e.ToString(), new Font("Times New Romans", 9), myBrush, d[i].X - 16, d[i].Y - 16);
                else
                    if (d[i].Y < r && d[i].X > r)
                    Tabg.DrawString(e.ToString(), new Font("Times New Romans", 9), myBrush, d[i].X, d[i].Y - 16);
                else
                    if (d[i].Y > r && d[i].X > r)
                    Tabg.DrawString(e.ToString(), new Font("Times New Romans", 9), myBrush, d[i].X, d[i].Y);
                else
                    if (d[i].Y > r && d[i].X <= r)
                    Tabg.DrawString(e.ToString(), new Font("Times New Romans", 9), myBrush, d[i].X - 16, d[i].Y);
                e++;
            }
        }

        private void KonMnoj_ValueChanged(object sender, EventArgs e)
        {
            if (KonMnoj.Value > MnojText.Value)
            {
                Prov.Value = 2;
                Create.Enabled = true;
            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aTimer!=null)
            aTimer.Stop();
        }

        private void DLFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.Tab.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.Tab.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.Tab.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    if ((myStream = saveFileDialog.OpenFile()) != null)
            //    {
            //        // Code to write the stream goes here.
            //        myStream.Close();
            //    }
            //}
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            if (p == 0)
            {
                aTimer.Stop();
                MainGroup.Enabled = true;
                sai = (float)MnojText.Value;
                aTimer.Close();
            }
        }
    }
}
