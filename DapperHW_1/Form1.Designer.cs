namespace DapperHW_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_EditProduct = new System.Windows.Forms.Button();
            this.btn_RemoveProduct = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 304);
            this.listBox1.TabIndex = 0;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(12, 322);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(325, 26);
            this.btn_AddProduct.TabIndex = 1;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_EditProduct
            // 
            this.btn_EditProduct.Location = new System.Drawing.Point(12, 354);
            this.btn_EditProduct.Name = "btn_EditProduct";
            this.btn_EditProduct.Size = new System.Drawing.Size(325, 26);
            this.btn_EditProduct.TabIndex = 2;
            this.btn_EditProduct.Text = "Edit Product";
            this.btn_EditProduct.UseVisualStyleBackColor = true;
            this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditProduct_Click);
            // 
            // btn_RemoveProduct
            // 
            this.btn_RemoveProduct.Location = new System.Drawing.Point(12, 386);
            this.btn_RemoveProduct.Name = "btn_RemoveProduct";
            this.btn_RemoveProduct.Size = new System.Drawing.Size(325, 26);
            this.btn_RemoveProduct.TabIndex = 3;
            this.btn_RemoveProduct.Text = "Remove Product";
            this.btn_RemoveProduct.UseVisualStyleBackColor = true;
            this.btn_RemoveProduct.Click += new System.EventHandler(this.btn_RemoveProduct_Click);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.Location = new System.Drawing.Point(12, 418);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(325, 26);
            this.btn_ClearList.TabIndex = 4;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = true;
            this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 457);
            this.Controls.Add(this.btn_ClearList);
            this.Controls.Add(this.btn_RemoveProduct);
            this.Controls.Add(this.btn_EditProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button btn_AddProduct;
        private Button btn_EditProduct;
        private Button btn_RemoveProduct;
        private Button btn_ClearList;
    }
}