namespace DapperHW_1.Views
{
    partial class ManagerView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_Page = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_Author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBox_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBox_Stock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(12, 27);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(304, 23);
            this.tBox_Name.TabIndex = 1;
            // 
            // tBox_Page
            // 
            this.tBox_Page.Location = new System.Drawing.Point(12, 72);
            this.tBox_Page.Name = "tBox_Page";
            this.tBox_Page.Size = new System.Drawing.Size(304, 23);
            this.tBox_Page.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Page";
            // 
            // tBox_Author
            // 
            this.tBox_Author.Location = new System.Drawing.Point(12, 115);
            this.tBox_Author.Name = "tBox_Author";
            this.tBox_Author.Size = new System.Drawing.Size(304, 23);
            this.tBox_Author.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Author";
            // 
            // tBox_Price
            // 
            this.tBox_Price.Location = new System.Drawing.Point(12, 159);
            this.tBox_Price.Name = "tBox_Price";
            this.tBox_Price.Size = new System.Drawing.Size(304, 23);
            this.tBox_Price.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Price";
            // 
            // tBox_Stock
            // 
            this.tBox_Stock.Location = new System.Drawing.Point(12, 203);
            this.tBox_Stock.Name = "tBox_Stock";
            this.tBox_Stock.Size = new System.Drawing.Size(304, 23);
            this.tBox_Stock.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Stock";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 232);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 88);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(171, 232);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 88);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 332);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tBox_Stock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBox_Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBox_Author);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBox_Page);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tBox_Name;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Button btn_Add;
        private Button btn_Cancel;
        private TextBox tBox_Page;
        private Label label6;
        private TextBox tBox_Author;
        private Label label7;
        private TextBox tBox_Price;
        private Label label8;
        private TextBox tBox_Stock;
        private Label label9;
    }
}