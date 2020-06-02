namespace BookShop
{
    partial class FormAddEdit
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.labeYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.PublishingHouseTB = new System.Windows.Forms.TextBox();
            this.GenteCB = new System.Windows.Forms.ComboBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(12, 60);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(37, 13);
            this.labelAutor.TabIndex = 1;
            this.labelAutor.Text = "Автор";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 86);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Жанр";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 113);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(71, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Тип издания";
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.AutoSize = true;
            this.labelPublishingHouse.Location = new System.Drawing.Point(12, 140);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(79, 13);
            this.labelPublishingHouse.TabIndex = 4;
            this.labelPublishingHouse.Text = "Издательство";
            // 
            // labeYear
            // 
            this.labeYear.AutoSize = true;
            this.labeYear.Location = new System.Drawing.Point(12, 166);
            this.labeYear.Name = "labeYear";
            this.labeYear.Size = new System.Drawing.Size(25, 13);
            this.labeYear.TabIndex = 5;
            this.labeYear.Text = "Год";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 192);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Цена";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 218);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(41, 13);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "Кол-во";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(109, 34);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(212, 20);
            this.NameTB.TabIndex = 8;
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(109, 60);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(212, 20);
            this.AutorTB.TabIndex = 9;
            // 
            // PublishingHouseTB
            // 
            this.PublishingHouseTB.Location = new System.Drawing.Point(109, 140);
            this.PublishingHouseTB.Name = "PublishingHouseTB";
            this.PublishingHouseTB.Size = new System.Drawing.Size(212, 20);
            this.PublishingHouseTB.TabIndex = 10;
            // 
            // GenteCB
            // 
            this.GenteCB.FormattingEnabled = true;
            this.GenteCB.Items.AddRange(new object[] {
            "Научная литература",
            "Роман",
            "Детектив",
            "Триллер",
            "Для детей",
            "Биография",
            "Приключения",
            "Фантастика"});
            this.GenteCB.Location = new System.Drawing.Point(109, 86);
            this.GenteCB.Name = "GenteCB";
            this.GenteCB.Size = new System.Drawing.Size(212, 21);
            this.GenteCB.TabIndex = 11;
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "Книга(тв. обложка)",
            "Книга(журн. обложка)",
            "Брошура",
            "Журнал",
            "Газета",
            "Комиксы",
            "Манга"});
            this.TypeCB.Location = new System.Drawing.Point(109, 113);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(212, 21);
            this.TypeCB.TabIndex = 12;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(109, 192);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(212, 20);
            this.PriceTB.TabIndex = 14;
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(109, 218);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(212, 20);
            this.NumberTB.TabIndex = 15;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(141, 248);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEdit.TabIndex = 16;
            this.buttonAddEdit.Text = "Добавить";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // YearTB
            // 
            this.YearTB.Location = new System.Drawing.Point(109, 166);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(212, 20);
            this.YearTB.TabIndex = 17;
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 283);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.GenteCB);
            this.Controls.Add(this.PublishingHouseTB);
            this.Controls.Add(this.AutorTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labeYear);
            this.Controls.Add(this.labelPublishingHouse);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelName);
            this.Name = "FormAddEdit";
            this.Text = "FormAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPublishingHouse;
        private System.Windows.Forms.Label labeYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.TextBox PublishingHouseTB;
        private System.Windows.Forms.ComboBox GenteCB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.TextBox YearTB;
    }
}