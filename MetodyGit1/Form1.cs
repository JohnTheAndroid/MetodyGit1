using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime narozen1 = DateTime.Parse(textBox1.Text);
            DateTime narozen2 = DateTime.Parse(textBox2.Text);
            DateTime narozen3 = DateTime.Parse(textBox3.Text);
            DateTime nejstarsi = narozen1;
            if (narozen2 < nejstarsi)
            {
                nejstarsi = narozen2;
            }
            if (narozen3 < nejstarsi)
            {
                nejstarsi = narozen3;
            }
            MessageBox.Show("Nejstarsi je: " + nejstarsi.ToString("dd MM yyy"));
            

        }
    }
}
