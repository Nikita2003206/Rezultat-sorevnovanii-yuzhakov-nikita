using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rezultat_sorevnovanii_yuzhakov_nikita
{
    public partial class Form1 : Form
    {
        int maxRez;//макс доп результат
        string name;//Фио
        string Filetxt;//переменная для текста из файла
        private List<string> lst = new List<string>(); //лист 

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTxt.Text = "";//Очистка результата
        }

        private void textBoxFio_TextChanged(object sender, EventArgs e)
        {
            name = textBoxFio.Text;
        }

        private void textBoxMaxRez_TextChanged(object sender, EventArgs e)
        {
            try  //проверка,что введено число 
            {
                maxRez = Convert.ToInt32(textBoxMaxRez.Text);
            }
            catch
            {
                MessageBox.Show("Введите число");//выводит сообщение
            }
        }

        private void buttonOtchet_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filway = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(Filway))
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\211924\Desktop\otchet.txt"))
                    {
                        while (reader.EndOfStream == false)
                        {
                            Filetxt = reader.ReadLine();
                            if (name == GetName(Filetxt) && GetCount(Filetxt) <= maxRez)
                            {
                                lst.Add(Filetxt);
                                textBoxTxt.Text += Filetxt + "" + "\r" + "\n";
                                sw.WriteLine(Filetxt);
                            }
                        }
                    }
                }
            }
        }
        private string GetName(string str)
        {
            string[] a = str.Split(',');//разделение по запятой
            return a[0];//возвращает имя и фамилию
        }
        private int GetCount(string str)
        {
            string[] a = str.Split(',');//разделение по запятой
            return Convert.ToInt32(a[2]);//возвращает результат забега
        }
    }
}
