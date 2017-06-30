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
    public partial class ShoppingList : Form
    {
        string path = @"Protocol.txt";
        public ShoppingList()
        {
            InitializeComponent();
            using (StreamWriter sw = File.CreateText(path))
            { }
        }

        private void BackToCreate_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            this.Visible = false;
            back.ShowDialog();
            this.Close();
        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
            ToolTip backtoCreate = new ToolTip();
            backtoCreate.SetToolTip(BackToCreate, "Возврат к названию списка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveList_Click(object sender, EventArgs e)
        {
            File.AppendAllText(path, "1. ");
            File.AppendAllText(path, "Категория товара: " + UserCategoryGoods.Text + Environment.NewLine);
            File.AppendAllText(path, "Наименование товара: " + UserNameGoods.Text + Environment.NewLine);
            File.AppendAllText(path, "Количество товара: " + UserNumberOfGoods.Text + Environment.NewLine);
            File.AppendAllText(path, "Цена товара: " + UserCostGoods.Text + Environment.NewLine);
            File.AppendAllText(path, "Стоимость товара: " + UserStoimostGoods.Text + Environment.NewLine);
            File.AppendAllText(path, "Комментарий к покупке: " + UserCommentsToGoods.Text + Environment.NewLine);
        }
    }
}
