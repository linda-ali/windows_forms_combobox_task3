using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] a = new string[] { "Tamil", "Keral" };

            foreach (string s in a)
            {
                comboBox1.Items.Add(s); 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Tamil")
            {
                comboBox2.Items.Add("Channal");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("pondi");
            }

            if (comboBox1.SelectedItem.ToString() == "Keral")
            {
                comboBox2.Items.Add("Kolam");
                comboBox2.Items.Add("cochin");
            }    
        }
    }
}
