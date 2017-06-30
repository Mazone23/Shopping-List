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

namespace ShoppingList_v1._1
{
    public partial class Form1 : Form
    {
       string path = @"Protocol.txt";
            public Form1()
        {

            InitializeComponent();
            
            this.FormClosed += Form1_FormClosed;

        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip newlist = new ToolTip();
            newlist.SetToolTip(button1, "Создание нового списка покупок");
            ToolTip exit = new ToolTip();
            exit.SetToolTip(Exit, "Выход из программы");
            ToolTip info = new ToolTip();
            info.SetToolTip(button3, "Справка о программе");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2();
            this.Visible = false;
            NewForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 infabout = new AboutBox1();
            this.Visible = false;
            infabout.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
