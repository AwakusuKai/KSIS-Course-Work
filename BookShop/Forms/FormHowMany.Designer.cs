namespace BookShop
{
    partial class FormHowMany
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
            this.trackBarNumber = new System.Windows.Forms.TrackBar();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarNumber
            // 
            this.trackBarNumber.Location = new System.Drawing.Point(46, 12);
            this.trackBarNumber.Minimum = 1;
            this.trackBarNumber.Name = "trackBarNumber";
            this.trackBarNumber.Size = new System.Drawing.Size(104, 45);
            this.trackBarNumber.TabIndex = 0;
            this.trackBarNumber.Value = 3;
            this.trackBarNumber.ValueChanged += new System.EventHandler(this.trackBarNumber_ValueChanged);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(60, 91);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCart.TabIndex = 1;
            this.buttonAddToCart.Text = "Добавить";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(67, 60);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(58, 21);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "dftgth";
            // 
            // FormHowMany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 126);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.trackBarNumber);
            this.Name = "FormHowMany";
            this.Text = "FormHowMany";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarNumber;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelCount;
    }
}