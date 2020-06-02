namespace BookShop
{
    partial class FormSearch
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
            this.YearTB = new System.Windows.Forms.TextBox();
            this.buttonSendSearchRequest = new System.Windows.Forms.Button();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.PublishingHouseTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.labeYear = new System.Windows.Forms.Label();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YearTB
            // 
            this.YearTB.Location = new System.Drawing.Point(125, 140);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(212, 20);
            this.YearTB.TabIndex = 34;
            // 
            // buttonSendSearchRequest
            // 
            this.buttonSendSearchRequest.Location = new System.Drawing.Point(148, 182);
            this.buttonSendSearchRequest.Name = "buttonSendSearchRequest";
            this.buttonSendSearchRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSearchRequest.TabIndex = 33;
            this.buttonSendSearchRequest.Text = "Искать";
            this.buttonSendSearchRequest.UseVisualStyleBackColor = true;
            this.buttonSendSearchRequest.Click += new System.EventHandler(this.buttonSendSearchRequest_Click);
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
            this.TypeCB.Location = new System.Drawing.Point(125, 87);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(212, 21);
            this.TypeCB.TabIndex = 30;
            // 
            // PublishingHouseTB
            // 
            this.PublishingHouseTB.Location = new System.Drawing.Point(125, 114);
            this.PublishingHouseTB.Name = "PublishingHouseTB";
            this.PublishingHouseTB.Size = new System.Drawing.Size(212, 20);
            this.PublishingHouseTB.TabIndex = 28;
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(125, 61);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(212, 20);
            this.AutorTB.TabIndex = 27;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(125, 35);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(212, 20);
            this.NameTB.TabIndex = 26;
            // 
            // labeYear
            // 
            this.labeYear.AutoSize = true;
            this.labeYear.Location = new System.Drawing.Point(28, 140);
            this.labeYear.Name = "labeYear";
            this.labeYear.Size = new System.Drawing.Size(25, 13);
            this.labeYear.TabIndex = 23;
            this.labeYear.Text = "Год";
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.AutoSize = true;
            this.labelPublishingHouse.Location = new System.Drawing.Point(28, 114);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(79, 13);
            this.labelPublishingHouse.TabIndex = 22;
            this.labelPublishingHouse.Text = "Издательство";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(28, 87);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(71, 13);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Тип издания";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(28, 61);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(37, 13);
            this.labelAutor.TabIndex = 19;
            this.labelAutor.Text = "Автор";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Название";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 222);
            this.Controls.Add(this.YearTB);
            this.Controls.Add(this.buttonSendSearchRequest);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.PublishingHouseTB);
            this.Controls.Add(this.AutorTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.labeYear);
            this.Controls.Add(this.labelPublishingHouse);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelName);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Button buttonSendSearchRequest;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.TextBox PublishingHouseTB;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label labeYear;
        private System.Windows.Forms.Label labelPublishingHouse;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelName;
    }
}