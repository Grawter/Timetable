using System;
using System.Drawing;
using System.Windows.Forms;

namespace MTUCI_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int start_time = 0, min_ekz = 0; // глобальные переменные для отслеживания времени экзамена

        void Reset_label() // Устанавливаем общий цвет всем номерам пар
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e) // При загрузке формы
        {
            pictureBox1.Image = Properties.Resources.d_img; // Загрузка картинки циферблата часов из ресурсов
            progressBar1.Maximum = 45; // 1 часть 1 пары
            progressBar2.Maximum = 5; // перерыв
            progressBar3.Maximum = 45; // 2 часть 1 пары

            progressBar4.Maximum = 10; // 1 перемена
            
            progressBar5.Maximum = 45; // 1 часть 2 пары
            progressBar6.Maximum = 5; // Большая перемена
            progressBar7.Maximum = 45; // 2 часть 2 пары

            progressBar8.Maximum = 10; // 2 перемена

            progressBar9.Maximum = 45; // 1 часть 3 пары
            progressBar10.Maximum = 5; // Большая перемена
            progressBar11.Maximum = 45; // 2 часть 3 пары

            progressBar12.Maximum = 40; // 3 перемена

            progressBar13.Maximum = 45; // 1 часть 4 пары
            progressBar14.Maximum = 5; // Большая перемена
            progressBar15.Maximum = 40; // 2 часть 4 пары

            progressBar16.Maximum = 10; // 4 перемена

            progressBar17.Maximum = 45; // 1 часть 5 пары
            progressBar18.Maximum = 5; // Большая перемена
            progressBar19.Maximum = 40; // 2 часть 5 пары

            progressBar20.Maximum = 10; // 5 перемена

            progressBar21.Maximum = 45; // 1 часть 6 пары
            progressBar22.Maximum = 5; // Большая перемена
            progressBar23.Maximum = 40; // 2 часть 6 пары

            progressBar24.Maximum = 10; // 6 перемена

            progressBar25.Maximum = 45; // 1 часть 7 пары
            progressBar26.Maximum = 5; // Большая перемена
            progressBar27.Maximum = 40; // 2 часть 7 пары

             timer1.Start(); // Запуска таймера 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label49.Text = DateTime.Now.ToString("HH:mm:ss"); // Получение и вывод текущего времени в формате час, минута, секунда
            label50.Text = DateTime.Now.ToString("dd MMMM yyyy"); // Получение и вывод текущей даты в формате день, месяц, год
            int hour = DateTime.Now.Hour; // Получение текущего часа
            int minute = DateTime.Now.Minute; // Получение текущей минуты

            int obmin = hour * 60 + minute; // Перевод часов в минуты. Получение общего количества минут

            if (obmin >= 570 && obmin <= 665) // 1 пара
            {
                Reset_label(); // Устанавливаем общий цвет всем номерам пар
                label1.BackColor = Color.Coral; // Устанавливаем особый цвет текущей паре

                if (obmin >= 570 && obmin <= 615)
                    progressBar1.Value = obmin - 570; // Заполнение прогресс бара, на основании прошедшего времени
                else if (obmin >= 615 && obmin <= 620)
                    progressBar2.Value = obmin - 615;
                else if (obmin >= 620 && obmin <= 665)
                    progressBar3.Value = obmin - 620;
            }
            else if (obmin >= 665 && obmin <= 675) // 1 перемена
            {
                progressBar4.Value = obmin - 665;
            }
            else if (obmin >= 675 && obmin <= 770) // 2 пара
            {
                Reset_label();
                label2.BackColor = Color.Coral;

                if (obmin >= 675 && obmin <= 720)
                    progressBar5.Value = obmin - 675;
                else if (obmin >= 720 && obmin <= 725)
                    progressBar6.Value = obmin - 720;
                else if (obmin >= 725 && obmin <= 770)
                    progressBar7.Value = obmin - 725;
            }
            else if (obmin >= 770 && obmin <= 780) // 2 перемена
            {
                progressBar8.Value = obmin - 770;
            }
            else if (obmin >= 780 && obmin <= 875) // 3 пара
            {
                Reset_label();
                label3.BackColor = Color.Coral;

                if (obmin >= 780 && obmin <= 825)
                    progressBar9.Value = obmin - 780;
                else if (obmin >= 825 && obmin <= 830)
                    progressBar10.Value = obmin - 825;
                else if (obmin >= 830 && obmin <= 875)
                    progressBar11.Value = obmin - 830;
            }
            else if (obmin >= 875 && obmin <= 915) // 3 перемена
            {
                progressBar12.Value = obmin - 875;
            }
            else if (obmin >= 915 && obmin <= 1005) // 4 пара
            {
                Reset_label();
                label4.BackColor = Color.Coral;

                if (obmin >= 915 && obmin <= 960)
                    progressBar13.Value = obmin - 915;
                else if (obmin >= 960 && obmin <= 965)
                    progressBar14.Value = obmin - 960;
                else if (obmin >= 965 && obmin <= 1005)
                    progressBar15.Value = obmin - 965;
            }
            else if (obmin >= 1005 && obmin <= 1015) // 4 перемена
            {
                progressBar16.Value = obmin - 1005;
            }
            else if (obmin >= 1015 && obmin <= 1105) // 5 пара
            {
                Reset_label();
                label5.BackColor = Color.Coral;

                if (obmin >= 1015 && obmin <= 1060)
                    progressBar17.Value = obmin - 1015;
                else if (obmin >= 1060 && obmin <= 1065)
                    progressBar18.Value = obmin - 1060;
                else if (obmin >= 1065 && obmin <= 1105)
                    progressBar19.Value = obmin - 1065;
            }
            else if (obmin >= 1105 && obmin <= 1115) // 5 перемена
            {
                progressBar20.Value = obmin - 1105;
            }
            else if (obmin >= 1115 && obmin <= 1205)  // 6 пара
            {
                Reset_label();
                label6.BackColor = Color.Coral;

                if (obmin >= 1115 && obmin <= 1160)
                    progressBar21.Value = obmin - 1115;
                else if (obmin >= 1160 && obmin <= 1165)
                    progressBar22.Value = obmin - 1160;
                else if (obmin >= 1165 && obmin <= 1205)
                    progressBar23.Value = obmin - 1165;
            }
            else if (obmin >= 1205 && obmin <= 1215) // 6 перемена
            {
                progressBar24.Value = obmin - 1205;
            }
            else if (obmin >= 1215 && obmin <= 1305) // 7 пара
            {
                Reset_label();
                label7.BackColor = Color.Coral;

                if (obmin >= 1215 && obmin <= 1260)
                    progressBar25.Value = obmin - 1215;
                else if (obmin >= 1260 && obmin <= 1265)
                    progressBar26.Value = obmin - 1260;
                else if (obmin >= 1265 && obmin <= 1305)
                    progressBar27.Value = obmin - 1265;
            }
            else if (obmin < 570) // до начала пар
            {
                Reset_label();
                label51.Visible = true;
                label51.Text = "Пары ещё не начались";
            }
            else if (obmin > 1305) // после окончания пар
            {
                Reset_label();
                label51.Visible = true;
                label51.Text = "Рабочий день окончен";
            }
        }
   
        private void юПаруToolStripMenuItem_Click_1(object sender, EventArgs e) // Удаление 1 прогресс бара
        {
            label1.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }

        private void юПаруToolStripMenuItem5_Click(object sender, EventArgs e) // Возвращение 1 прогресс бара
        {
            label1.Visible = true;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true; 
            progressBar4.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
        }

        private void юПаруToolStripMenuItem1_Click(object sender, EventArgs e) // Удаление 2 прогресс бара
        {
            label2.Visible = false;
            progressBar5.Visible = false;
            progressBar6.Visible = false;
            progressBar7.Visible = false;
            progressBar8.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
        }

        private void юПаруToolStripMenuItem6_Click(object sender, EventArgs e) // Возвращение 2 прогресс бара
        {
            label2.Visible = true;
            progressBar5.Visible = true;
            progressBar6.Visible = true;
            progressBar7.Visible = true;
            progressBar8.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
        }

        private void юПаруToolStripMenuItem2_Click(object sender, EventArgs e) // Удаление 3 прогресс бара
        {
            label3.Visible = false;
            progressBar9.Visible = false;
            progressBar10.Visible = false;
            progressBar11.Visible = false;
            progressBar12.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false; 
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
        }

        private void юПаруToolStripMenuItem7_Click(object sender, EventArgs e) // Возвращение 3 прогресс бара
        {
            label3.Visible = true;
            progressBar9.Visible = true;
            progressBar10.Visible = true;
            progressBar11.Visible = true;
            progressBar12.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
        }

        private void юПаруToolStripMenuItem3_Click(object sender, EventArgs e) // Удаление 4 прогресс бара
        {
            label4.Visible = false;
            progressBar13.Visible = false;
            progressBar14.Visible = false;
            progressBar15.Visible = false;
            progressBar16.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
        }

        private void юПаруToolStripMenuItem8_Click(object sender, EventArgs e) // Возвращение 4 прогресс бара
        {
            label4.Visible = true;
            progressBar13.Visible = true;
            progressBar14.Visible = true;
            progressBar15.Visible = true;
            progressBar16.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
        }

        private void юПаруToolStripMenuItem4_Click(object sender, EventArgs e) // Удаление 5 прогресс бара
        {
            label5.Visible = false;
            progressBar17.Visible = false;
            progressBar18.Visible = false;
            progressBar19.Visible = false;
            progressBar20.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
        }

        private void юПаруToolStripMenuItem9_Click(object sender, EventArgs e) // Возвращение 5 прогресс бара
        {
            label5.Visible = true;
            progressBar17.Visible = true;
            progressBar18.Visible = true;
            progressBar19.Visible = true;
            progressBar20.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
        }

        private void юПаруToolStripMenuItem10_Click(object sender, EventArgs e) // Удаление 6 прогресс бара
        {
            label6.Visible = false;
            progressBar21.Visible = false;
            progressBar22.Visible = false;
            progressBar23.Visible = false;
            progressBar24.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
        }

        private void юПаруToolStripMenuItem12_Click_1(object sender, EventArgs e) // Возвращение 6 прогресс бара
        {
            label6.Visible = true;
            progressBar21.Visible = true;
            progressBar22.Visible = true;
            progressBar23.Visible = true;
            progressBar24.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
            label41.Visible = true;
            label42.Visible = true;
            label43.Visible = true;
        }

        private void юПаруToolStripMenuItem11_Click(object sender, EventArgs e) // Удаление 7 прогресс бара
        {
            label7.Visible = false;
            progressBar25.Visible = false;
            progressBar26.Visible = false;
            progressBar27.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
        }       

        private void юПаруToolStripMenuItem13_Click(object sender, EventArgs e) // Возвращение 7 прогресс бара
        {
            label7.Visible = true;
            progressBar25.Visible = true;
            progressBar26.Visible = true;
            progressBar27.Visible = true;
            label44.Visible = true;
            label45.Visible = true;
            label46.Visible = true;
            label47.Visible = true;
        }

        private void убратьВсеПарыToolStripMenuItem_Click(object sender, EventArgs e) // Удаление все пар
        {
            юПаруToolStripMenuItem_Click_1(sender, e);
            юПаруToolStripMenuItem1_Click(sender, e);
            юПаруToolStripMenuItem2_Click(sender, e);
            юПаруToolStripMenuItem3_Click(sender, e);
            юПаруToolStripMenuItem4_Click(sender, e);
            юПаруToolStripMenuItem10_Click(sender, e);
            юПаруToolStripMenuItem11_Click(sender, e);
        }

        private void добавитьВсеПарыToolStripMenuItem_Click(object sender, EventArgs e) // Возвращение всех пар
        {
            юПаруToolStripMenuItem5_Click(sender, e);
            юПаруToolStripMenuItem6_Click(sender, e);
            юПаруToolStripMenuItem7_Click(sender, e);
            юПаруToolStripMenuItem8_Click(sender, e);
            юПаруToolStripMenuItem9_Click(sender, e);
            юПаруToolStripMenuItem12_Click_1(sender, e);
            юПаруToolStripMenuItem13_Click(sender, e);
        }

        private void остановитьToolStripMenuItem_Click(object sender, EventArgs e) // Остановить 
        {
            timer1.Stop();
        }

        private void продолжитьToolStripMenuItem_Click(object sender, EventArgs e) // Продолжить
        {
            timer1.Start();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) // О программе
        {
            MessageBox.Show("Программа используется для отслеживания учебного времени.\n\n" + 
                "Функционал добавления, удаления пары; остановки времени; активации экзаменя доступен во вкладке \"Настройки\"", "Информация");
        }

        /*private void button1_Click(object sender, EventArgs e) // для отладки расписания
        {
            label49.Text = DateTime.Now.ToString("HH:mm:ss"); // Получение и вывод текущего времени в формате час, минута, секунда
            label50.Text = DateTime.Now.ToString("dd MMMM yyyy"); // Получение и вывод текущей даты в формате день, месяц, год
            int hour = Convert.ToInt32(textBox1.Text); // Получение текущего часа
            int minute = Convert.ToInt32(textBox2.Text); // Получение текущей минуты

            int obmin = hour * 60 + minute; // Перевод часов в минуты. Получение общего количества минут

            if (obmin >= 570 && obmin <= 665) // 1 пара
            {
                Reset_label(); // Устанавливаем общий цвет всем номерам пар
                label1.BackColor = Color.Coral; // Устанавливаем особый цвет текущей паре
                
                if(obmin>= 570 && obmin <=615)
                    progressBar1.Value = obmin - 570; // Заполнение прогресс бара, на основании прошедшего времени
                else if(obmin >= 615 && obmin <= 620)
                    progressBar2.Value = obmin - 615;
                else if (obmin >= 620 && obmin <= 665)
                    progressBar3.Value = obmin - 620;
            }  
            else if (obmin >= 665 && obmin <= 675) // 1 перемена
            {            
                progressBar4.Value = obmin - 665;
            }
            else if (obmin >= 675 && obmin <= 770) // 2 пара
            {
                Reset_label();
                label2.BackColor = Color.Coral;

                if (obmin >=675  && obmin <= 720)
                    progressBar5.Value = obmin - 675;
                else if (obmin >= 720 && obmin <= 725)
                    progressBar6.Value = obmin - 720;
                else if (obmin >=725  && obmin <= 770 )
                    progressBar7.Value = obmin - 725;
            }
            else if (obmin >= 770 && obmin <= 780) // 2 перемена
            {
                progressBar8.Value = obmin - 770;
            }
            else if (obmin >= 780 && obmin <= 875) // 3 пара
            {
                Reset_label();
                label3.BackColor = Color.Coral;

                if (obmin >= 780 && obmin <= 825)
                    progressBar9.Value = obmin - 780;
                else if (obmin >= 825 && obmin <= 830)
                    progressBar10.Value = obmin - 825;
                else if (obmin >= 830 && obmin <= 875)
                    progressBar11.Value = obmin - 830;
            }
            else if (obmin >= 875 && obmin <= 915) // 3 перемена
            {
                progressBar12.Value = obmin - 875;
            }
            else if (obmin >= 915 && obmin <= 1005) // 4 пара
            {
                Reset_label();
                label4.BackColor = Color.Coral;

                if (obmin >= 915 && obmin <= 960)
                    progressBar13.Value = obmin - 915;
                else if (obmin >= 960 && obmin <= 965)
                    progressBar14.Value = obmin - 960;
                else if (obmin >= 965 && obmin <= 1005)
                    progressBar15.Value = obmin - 965;
            }
            else if (obmin >= 1005 && obmin <= 1015) // 4 перемена
            {
                progressBar16.Value = obmin - 1005;
            }
            else if (obmin >= 1015 && obmin <= 1105) // 5 пара
            {
                Reset_label();
                label5.BackColor = Color.Coral;

                if (obmin >= 1015 && obmin <= 1060)
                    progressBar17.Value = obmin - 1015;
                else if (obmin >= 1060 && obmin <= 1065)
                    progressBar18.Value = obmin - 1060;
                else if (obmin >= 1065 && obmin <= 1105)
                    progressBar19.Value = obmin - 1065;
            }
            else if (obmin >= 1105 && obmin <= 1115) // 5 перемена
            {
                progressBar20.Value = obmin - 1105;
            }
            else if (obmin >= 1115 && obmin <= 1205)  // 6 пара
            {
                Reset_label();
                label6.BackColor = Color.Coral;

                if (obmin >= 1115 && obmin <= 1160)
                    progressBar21.Value = obmin - 1115;
                else if (obmin >= 1160 && obmin <= 1165)
                    progressBar22.Value = obmin - 1160;
                else if (obmin >= 1165 && obmin <= 1205)
                    progressBar23.Value = obmin - 1165;
            }
            else if (obmin >= 1205 && obmin <= 1215) // 6 перемена
            {
                progressBar24.Value = obmin - 1205;
            }
            else if (obmin >= 1215 && obmin <= 1305) // 7 пара
            {
                Reset_label();
                label7.BackColor = Color.Coral;

                if (obmin >= 1215 && obmin <= 1260)
                    progressBar25.Value = obmin - 1215;
                else if (obmin >= 1260 && obmin <= 1265)
                    progressBar26.Value = obmin - 1260;
                else if (obmin >= 1265 && obmin <= 1305)
                    progressBar27.Value = obmin - 1265;
            }
            else if (obmin < 570) // до начала пар
            {
                Reset_label();
                label51.Visible = true;
                label51.Text = "Пары ещё не начались";
            }
            else if (obmin > 1305) // после окончания пар
            {
                Reset_label();
                label51.Visible = true;
                label51.Text = "Рабочий день окончен";
            }
        }*/

        public void часToolStripMenuItem_Click(object sender, EventArgs e) // экзамен длительностью 1 час
        {
            int start_hour = DateTime.Now.Hour, start_minute = DateTime.Now.Minute; 
            start_time = start_hour * 60 + start_minute;
            min_ekz = 60;

            label52.Visible = true;
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            progressBar28.Visible = true;

            progressBar28.Maximum = min_ekz;

            label54.Text = DateTime.Now.ToString("HH:mm:ss");
            if(start_hour <9)
                label55.Text = "0" + (DateTime.Now.Hour + 1) + DateTime.Now.ToString(":mm:ss");
            else if(start_hour ==23)
                label55.Text = "00" + DateTime.Now.ToString(":mm:ss");
            else
                label55.Text = (DateTime.Now.Hour + 1) + DateTime.Now.ToString(":mm:ss");
            
            timer2.Start();   
        }

        private void часаToolStripMenuItem_Click(object sender, EventArgs e) // экзамен длительностью 1.5 час
        {
            int start_hour = DateTime.Now.Hour, start_minute = DateTime.Now.Minute;
            start_time = start_hour * 60 + start_minute;
            min_ekz = 90;

            label52.Visible = true;
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            progressBar28.Visible = true;

            progressBar28.Maximum = min_ekz;

            label54.Text = DateTime.Now.ToString("HH:mm:ss");
            if (start_minute > 30)
            {
                start_minute = start_minute - 30;
                if (start_hour < 8)
                    label55.Text = "0" + (DateTime.Now.Hour + 2) + ":" + start_minute + DateTime.Now.ToString(":ss");
                else if(start_hour == 22)
                    label55.Text = "00" + ":" + start_minute + DateTime.Now.ToString(":ss");
                else if (start_hour == 23)
                    label55.Text = "01" + ":" + start_minute + DateTime.Now.ToString(":ss");
                else
                    label55.Text = (DateTime.Now.Hour + 2) + ":" + start_minute + DateTime.Now.ToString(":ss");

            }
            else if (start_minute < 30)
            {
                if (start_hour <= 8)
                    label55.Text = "0" + (DateTime.Now.Hour + 1) + ":" + (DateTime.Now.Minute + 30) + DateTime.Now.ToString(":ss");
                else if (start_hour == 23)
                    label55.Text = "00" + ":" + (DateTime.Now.Minute + 30) + DateTime.Now.ToString(":ss");
                else
                    label55.Text = (DateTime.Now.Hour + 1) + ":" + (DateTime.Now.Minute + 30) + DateTime.Now.ToString(":ss");
            }
            else if (start_minute == 30)
            {
                if (start_hour < 8)
                    label55.Text = "0" + (DateTime.Now.Hour + 2) + ":00" + DateTime.Now.ToString(":ss");
                else if (start_hour == 22)
                    label55.Text = "00" + ":00" + DateTime.Now.ToString(":ss");
                else if (start_hour == 23)
                    label55.Text = "01" + ":00" + DateTime.Now.ToString(":ss");
                else
                    label55.Text = (DateTime.Now.Hour + 2) + ":00" + DateTime.Now.ToString(":ss");
            }

            timer2.Start();  
        }

        private void часаToolStripMenuItem1_Click(object sender, EventArgs e) // экзамен длительностью 2 час
        {
            int start_hour = DateTime.Now.Hour, start_minute = DateTime.Now.Minute;
            start_time = start_hour * 60 + start_minute;
            min_ekz = 120;

            label52.Visible = true;
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            progressBar28.Visible = true;

            progressBar28.Maximum = min_ekz;

            label54.Text = DateTime.Now.ToString("HH:mm:ss");
            if (start_hour < 8)
                label55.Text = "0" + (DateTime.Now.Hour + 2) + DateTime.Now.ToString(":mm:ss");
            else if (start_hour == 22)
                label55.Text ="00" + DateTime.Now.ToString(":mm:ss");
            else if(start_hour == 23)
                label55.Text = "01" + DateTime.Now.ToString(":mm:ss");
            else
                label55.Text = (DateTime.Now.Hour + 2) + DateTime.Now.ToString(":mm:ss");

            timer2.Start();  
        }

        private void timer2_Tick(object sender, EventArgs e) // отслеживание времени экзамена
        {
            int start_hour = DateTime.Now.Hour, start_minute = DateTime.Now.Minute;
            int obmin = start_hour * 60 + start_minute;

            if (obmin >= start_time && obmin <= start_time + min_ekz)
                progressBar28.Value = obmin - start_time;
            else
            {
                label51.Visible = true;
                label51.Text = "Время экзамена окончено";
            }
        }

        private void убратьЭкзаменToolStripMenuItem_Click(object sender, EventArgs e) // убрать информацию об экзамене
        {
            timer2.Stop();
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false; 
            label54.Visible = false;
            label55.Visible = false;
            progressBar28.Visible = false;
        }

        //private void button2_Click(object sender, EventArgs e) // для отладки экзамена
        //{
        //    int start_hour = Convert.ToInt32(textBox3.Text), start_minute = Convert.ToInt32(textBox4.Text); 
        //    int obmin = start_hour * 60 + start_minute;

        //    if (obmin >= start_time && obmin <= start_time + min_ekz)
        //        progressBar28.Value = obmin - start_time;
        //    else
        //    {
        //        label51.Visible = true;
        //        label51.Text = "Время экзамена окончено";
        //    }    
        //}
    }
}