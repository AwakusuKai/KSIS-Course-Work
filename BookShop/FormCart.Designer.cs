namespace BookShop
{
    partial class FormCart
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
            this.booksInCartLV = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPublishingHouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumberToSell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriceForSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteFromCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelItogo = new System.Windows.Forms.Label();
            this.buttonSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksInCartLV
            // 
            this.booksInCartLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnAutor,
            this.columnGenre,
            this.columnType,
            this.columnPublishingHouse,
            this.columnYear,
            this.columnPrice,
            this.columnNumber,
            this.columnNumberToSell,
            this.columnPriceForSale});
            this.booksInCartLV.FullRowSelect = true;
            this.booksInCartLV.GridLines = true;
            this.booksInCartLV.HideSelection = false;
            this.booksInCartLV.Location = new System.Drawing.Point(12, 12);
            this.booksInCartLV.MultiSelect = false;
            this.booksInCartLV.Name = "booksInCartLV";
            this.booksInCartLV.Size = new System.Drawing.Size(550, 287);
            this.booksInCartLV.TabIndex = 1;
            this.booksInCartLV.UseCompatibleStateImageBehavior = false;
            this.booksInCartLV.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Название";
            this.columnName.Width = 200;
            // 
            // columnAutor
            // 
            this.columnAutor.Text = "Автор";
            this.columnAutor.Width = 150;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Жанр";
            this.columnGenre.Width = 0;
            // 
            // columnType
            // 
            this.columnType.Text = "Тип издания";
            this.columnType.Width = 0;
            // 
            // columnPublishingHouse
            // 
            this.columnPublishingHouse.Text = "Издательство";
            this.columnPublishingHouse.Width = 0;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Год";
            this.columnYear.Width = 0;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Кол-во";
            this.columnNumber.Width = 0;
            // 
            // columnNumberToSell
            // 
            this.columnNumberToSell.Text = "Кол-во";
            // 
            // columnPriceForSale
            // 
            this.columnPriceForSale.Text = "Итог";
            // 
            // buttonDeleteFromCart
            // 
            this.buttonDeleteFromCart.Location = new System.Drawing.Point(12, 305);
            this.buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            this.buttonDeleteFromCart.Size = new System.Drawing.Size(113, 42);
            this.buttonDeleteFromCart.TabIndex = 2;
            this.buttonDeleteFromCart.Text = "Удалить из корзины";
            this.buttonDeleteFromCart.UseVisualStyleBackColor = true;
            this.buttonDeleteFromCart.Click += new System.EventHandler(this.buttonDeleteFromCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Итого";
            // 
            // labelItogo
            // 
            this.labelItogo.AutoSize = true;
            this.labelItogo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItogo.Location = new System.Drawing.Point(487, 311);
            this.labelItogo.Name = "labelItogo";
            this.labelItogo.Size = new System.Drawing.Size(68, 25);
            this.labelItogo.TabIndex = 4;
            this.labelItogo.Text = "Итого";
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(131, 305);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(113, 42);
            this.buttonSale.TabIndex = 5;
            this.buttonSale.Text = "Оформить покупку";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 430);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.labelItogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteFromCart);
            this.Controls.Add(this.booksInCartLV);
            this.Name = "FormCart";
            this.Text = "CartForm";
            this.Click += new System.EventHandler(this.FormCart_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView booksInCartLV;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAutor;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnPublishingHouse;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnNumberToSell;
        private System.Windows.Forms.ColumnHeader columnPriceForSale;
        private System.Windows.Forms.Button buttonDeleteFromCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelItogo;
        private System.Windows.Forms.Button buttonSale;
    }
}