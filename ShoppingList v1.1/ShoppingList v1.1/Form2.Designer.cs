namespace ShoppingList_v1._1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.returnbutton = new System.Windows.Forms.Button();
            this.CreateList = new System.Windows.Forms.Button();
            this.NameOfNewList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(197, 34);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(75, 23);
            this.returnbutton.TabIndex = 1;
            this.returnbutton.Text = "Отмена";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // CreateList
            // 
            this.CreateList.Location = new System.Drawing.Point(12, 34);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(75, 23);
            this.CreateList.TabIndex = 2;
            this.CreateList.Text = "Создать";
            this.CreateList.UseVisualStyleBackColor = true;
            this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // NameOfNewList
            // 
            this.NameOfNewList.Location = new System.Drawing.Point(12, 8);
            this.NameOfNewList.Name = "NameOfNewList";
            this.NameOfNewList.Size = new System.Drawing.Size(260, 20);
            this.NameOfNewList.TabIndex = 3;
            this.NameOfNewList.Text = "СписокПокупок1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 69);
            this.Controls.Add(this.NameOfNewList);
            this.Controls.Add(this.CreateList);
            this.Controls.Add(this.returnbutton);
            this.Name = "Form2";
            this.Text = "Создание списка покупок";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button CreateList;
        private System.Windows.Forms.TextBox NameOfNewList;
    }
}