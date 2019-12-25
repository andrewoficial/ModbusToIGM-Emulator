using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Http_Post : Form
    {
        string[] dataF;
        

        [HttpPost]
        public string PostData(string parametrName)
        {
            return "Параметр запроса: " + parametrName;
        }

        public Http_Post()
        {
            InitializeComponent();
            CreateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendPut.Enabled = false;
        }
        void CreateString()
        {
            int countLine;

            try
            {
                countLine = Convert.ToInt32(tbCountLine.Text);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "HTTP Post. Ошибка!", MessageBoxButtons.OK);
                countLine = 500;
            }

            dataF = new string[countLine];

            //Создание объекта для генерации чисел
            Random rndTemp = new Random();
            Random rndConc = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int temp = rndTemp.Next(1555, 1666);

            int conc = rndConc.Next(0, 15);

            string buferDataF = "";

            rtbDataF.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);

            rtbDataF.Clear();

            for (int i = 0; i < dataF.Length; i++)
            {
                temp = rndTemp.Next(1555, 1666);
                conc = rndConc.Next(0, 15);
                dataF[i] = temp.ToString("d5") + " 00000 00241 00080 01031 00343 00000 00000 " + conc.ToString("d5") + " 00000 08505432";
                buferDataF = dataF[i];
                rtbDataF.AppendText("Строка " + (i + 1).ToString("d3") + ":  " + buferDataF + "\n");
            }
        }

        private static async Task PostRequestAsync(string adrServer,string login, string password,string identificator,string[] dataF, RichTextBox richTextBox,ToolStripLabel lsendTime, ToolStripLabel lRecieveTime)
        {
            WebRequest request = WebRequest.Create(adrServer);

            // для отправки используется метод Post
            request.Method = "POST";

            //Имя + Пароль + Идентификатор
            string NamePasswordIdentificator = "♫ "+login +" "+ password+" "+ identificator;

            

            //Формируем 500 строк для отправки
            string data = "";
            for (int i = 0; i < dataF.Length; i++){
                //Время
                string timeNow = DateTime.Now.ToString(" HH:mm:ss:ff dd.MM.yyyy ");
                data += NamePasswordIdentificator + timeNow + " " + dataF[i];
                Thread.Sleep(105);
            }
                

            // преобразуем данные в массив байтов
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            // устанавливаем тип содержимого - параметр ContentType
            request.ContentType = "application/x-www-form-urlencoded";
            // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            request.ContentLength = byteArray.Length;

            lsendTime.Text = DateTime.Now.ToString("HH:mm:ss:fff");
            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            richTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    //richTextBox.Text += reader.ReadToEnd();
                    richTextBox.AppendText(reader.ReadToEnd());
                }
            }
            lRecieveTime.Text = DateTime.Now.ToString("HH:mm:ss:fff");

            response.Close();
            richTextBox.Text += "\r\n";
            //richTextBox.Text +="Запрос выполнен...";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            CreateString();

            try
            {
                richTextBox1.Clear();

                PostRequestAsync(tbAdrServer.Text, tbLogin.Text, tbPassword.Text, tbIdentificator.Text, dataF, richTextBox1,lsendtime,lRecievTime);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "HTTP Post. Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string timeNow = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
            toolStripLabel1.Text = timeNow;
        }

        private void TbCountLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод кол-во строк
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://192.168.1.190/Utilites/Settings/Settings.php?PageSelect=PersonalArea.php");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Войти")
            {
                button2.Text = "Выйти";
                groupBox1.Text = "Hello, " + tbLogin.Text + "!";

                tbLogin.Enabled = false;
                tbPassword.Enabled = false;
                SendPut.Enabled = true;
            }
            else
            {
                button2.Text = "Войти";

                groupBox1.Text = "Вход";

                tbLogin.Enabled = true;
                tbPassword.Enabled = true;
                SendPut.Enabled = false;
            }

                
        }

        private void TbIdentificator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод кол-во строк
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m\b]");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbIdentificator_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbDataF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
