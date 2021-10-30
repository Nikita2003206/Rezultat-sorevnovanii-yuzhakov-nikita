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
        int maxRez;
        string name;
        string Filetxt;
        private List<string> lst = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTxt.Text = "";
        }

        private void textBoxFio_TextChanged(object sender, EventArgs e)
        {
            name = textBoxFio.Text;
        }

        private void textBoxMaxRez_TextChanged(object sender, EventArgs e)
        {
            try
            {
                maxRez = Convert.ToInt32(textBoxMaxRez.Text);
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        private void buttonOtchet_Click(object sender, EventArgs e)
        {
       
        }
        private string GetName(string str)
        {
            string[] a = str.Split(',');
            return a[0];
        }
        private int GetCount(string str)
        {
            string[] a = str.Split(',');
            return Convert.ToInt32(a[2]);
        }
    }
}
