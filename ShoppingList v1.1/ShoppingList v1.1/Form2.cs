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
    public partial class Form2 : Form
    {
        string path = @"Protocol.txt";
        public Form2()
        {
            InitializeComponent();
            using (StreamWriter sw = File.CreateText(path))
            { }
        }


        private void returnbutton_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            this.Visible = false;
            back.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip backtoMM = new ToolTip();
            backtoMM.SetToolTip(returnbutton, "Возврат в главное меню");
        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            //if (CreateList.Text != "" && CreateList.Text != null)
            //{
                
            //}
            File.AppendAllText(path, "Название списка покупок: " + NameOfNewList.Text + Environment.NewLine);
            ShoppingList RunToNewList = new ShoppingList();
            this.Visible = false;
            RunToNewList.ShowDialog();
            this.Close();
        }
    }
}
