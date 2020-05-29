namespace BookShop
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.booksLV = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPublishingHouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.GenreCB = new System.Windows.Forms.ComboBox();
            this.PriceToTB = new System.Windows.Forms.TextBox();
            this.PriceFromTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.labelPriceToSearch = new System.Windows.Forms.Label();
            this.labelPriceFromSearch = new System.Windows.Forms.Label();
            this.labelTypeSearch = new System.Windows.Forms.Label();
            this.labelGenreSearch = new System.Windows.Forms.Label();
            this.labelAutorSearch = new System.Windows.Forms.Label();
            this.labelNameSearch = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.columnNumberToSell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButtonAddToCart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenCart = new System.Windows.Forms.ToolStripButton();
            this.columnPriceForSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksLV
            // 
            this.booksLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.booksLV.FullRowSelect = true;
            this.booksLV.GridLines = true;
            this.booksLV.HideSelection = false;
            this.booksLV.Location = new System.Drawing.Point(12, 39);
            this.booksLV.MultiSelect = false;
            this.booksLV.Name = "booksLV";
            this.booksLV.Size = new System.Drawing.Size(805, 363);
            this.booksLV.TabIndex = 0;
            this.booksLV.UseCompatibleStateImageBehavior = false;
            this.booksLV.View = System.Windows.Forms.View.Details;
            this.booksLV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.booksLV_ColumnClick);
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
            // 
            // columnType
            // 
            this.columnType.Text = "Тип издания";
            this.columnType.Width = 80;
            // 
            // columnPublishingHouse
            // 
            this.columnPublishingHouse.Text = "Издательство";
            this.columnPublishingHouse.Width = 100;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Год";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Кол-во";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonSaveAs,
            this.toolStripSeparator1,
            this.toolStripButtonAdd,
            this.toolStripDelete,
            this.toolStripEdit,
            this.toolStripButtonAddToCart,
            this.toolStripButtonOpenCart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1379, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Открыть";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonSaveAs
            // 
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAs.Image")));
            this.toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveAs.Text = "Сохранить как";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripDelete.Text = "Удалить";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripEdit.Text = "Редактировать";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.TypeCB);
            this.panelSearch.Controls.Add(this.GenreCB);
            this.panelSearch.Controls.Add(this.PriceToTB);
            this.panelSearch.Controls.Add(this.PriceFromTB);
            this.panelSearch.Controls.Add(this.AutorTB);
            this.panelSearch.Controls.Add(this.NameTB);
            this.panelSearch.Controls.Add(this.labelPriceToSearch);
            this.panelSearch.Controls.Add(this.labelPriceFromSearch);
            this.panelSearch.Controls.Add(this.labelTypeSearch);
            this.panelSearch.Controls.Add(this.labelGenreSearch);
            this.panelSearch.Controls.Add(this.labelAutorSearch);
            this.panelSearch.Controls.Add(this.labelNameSearch);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Location = new System.Drawing.Point(858, 39);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(316, 363);
            this.panelSearch.TabIndex = 2;
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
            this.TypeCB.Location = new System.Drawing.Point(86, 138);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(212, 21);
            this.TypeCB.TabIndex = 14;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            this.TypeCB.TextUpdate += new System.EventHandler(this.TypeCB_TextUpdate);
            // 
            // GenreCB
            // 
            this.GenreCB.FormattingEnabled = true;
            this.GenreCB.Items.AddRange(new object[] {
            "Научная литература",
            "Роман",
            "Детектив",
            "Триллер",
            "Для детей",
            "Биография",
            "Приключения",
            "Фантастика"});
            this.GenreCB.Location = new System.Drawing.Point(86, 111);
            this.GenreCB.Name = "GenreCB";
            this.GenreCB.Size = new System.Drawing.Size(212, 21);
            this.GenreCB.TabIndex = 13;
            this.GenreCB.SelectedIndexChanged += new System.EventHandler(this.GenreCB_SelectedIndexChanged);
            this.GenreCB.TextUpdate += new System.EventHandler(this.GenreCB_TextUpdate);
            // 
            // PriceToTB
            // 
            this.PriceToTB.Location = new System.Drawing.Point(86, 206);
            this.PriceToTB.Name = "PriceToTB";
            this.PriceToTB.Size = new System.Drawing.Size(212, 20);
            this.PriceToTB.TabIndex = 12;
            this.PriceToTB.TextChanged += new System.EventHandler(this.PriceToTB_TextChanged);
            // 
            // PriceFromTB
            // 
            this.PriceFromTB.Location = new System.Drawing.Point(86, 180);
            this.PriceFromTB.Name = "PriceFromTB";
            this.PriceFromTB.Size = new System.Drawing.Size(212, 20);
            this.PriceFromTB.TabIndex = 11;
            this.PriceFromTB.TextChanged += new System.EventHandler(this.PriceFromTB_TextChanged);
            // 
            // AutorTB
            // 
            this.AutorTB.Location = new System.Drawing.Point(86, 74);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(212, 20);
            this.AutorTB.TabIndex = 10;
            this.AutorTB.TextChanged += new System.EventHandler(this.AutorTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(86, 48);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(212, 20);
            this.NameTB.TabIndex = 9;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // labelPriceToSearch
            // 
            this.labelPriceToSearch.AutoSize = true;
            this.labelPriceToSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceToSearch.Location = new System.Drawing.Point(3, 210);
            this.labelPriceToSearch.Name = "labelPriceToSearch";
            this.labelPriceToSearch.Size = new System.Drawing.Size(60, 16);
            this.labelPriceToSearch.TabIndex = 6;
            this.labelPriceToSearch.Text = "Цена до";
            // 
            // labelPriceFromSearch
            // 
            this.labelPriceFromSearch.AutoSize = true;
            this.labelPriceFromSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceFromSearch.Location = new System.Drawing.Point(3, 184);
            this.labelPriceFromSearch.Name = "labelPriceFromSearch";
            this.labelPriceFromSearch.Size = new System.Drawing.Size(60, 16);
            this.labelPriceFromSearch.TabIndex = 5;
            this.labelPriceFromSearch.Text = "Цена от";
            // 
            // labelTypeSearch
            // 
            this.labelTypeSearch.AutoSize = true;
            this.labelTypeSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeSearch.Location = new System.Drawing.Point(3, 143);
            this.labelTypeSearch.Name = "labelTypeSearch";
            this.labelTypeSearch.Size = new System.Drawing.Size(85, 16);
            this.labelTypeSearch.TabIndex = 4;
            this.labelTypeSearch.Text = "Тип издания";
            // 
            // labelGenreSearch
            // 
            this.labelGenreSearch.AutoSize = true;
            this.labelGenreSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenreSearch.Location = new System.Drawing.Point(6, 116);
            this.labelGenreSearch.Name = "labelGenreSearch";
            this.labelGenreSearch.Size = new System.Drawing.Size(40, 16);
            this.labelGenreSearch.TabIndex = 3;
            this.labelGenreSearch.Text = "Жанр";
            // 
            // labelAutorSearch
            // 
            this.labelAutorSearch.AutoSize = true;
            this.labelAutorSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutorSearch.Location = new System.Drawing.Point(3, 78);
            this.labelAutorSearch.Name = "labelAutorSearch";
            this.labelAutorSearch.Size = new System.Drawing.Size(43, 16);
            this.labelAutorSearch.TabIndex = 2;
            this.labelAutorSearch.Text = "Автор";
            // 
            // labelNameSearch
            // 
            this.labelNameSearch.AutoSize = true;
            this.labelNameSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSearch.Location = new System.Drawing.Point(3, 52);
            this.labelNameSearch.Name = "labelNameSearch";
            this.labelNameSearch.Size = new System.Drawing.Size(65, 16);
            this.labelNameSearch.TabIndex = 1;
            this.labelNameSearch.Text = "Название";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(123, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(75, 24);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "ПОИСК";
            // 
            // columnNumberToSell
            // 
            this.columnNumberToSell.Width = 0;
            // 
            // toolStripButtonAddToCart
            // 
            this.toolStripButtonAddToCart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddToCart.Image")));
            this.toolStripButtonAddToCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddToCart.Name = "toolStripButtonAddToCart";
            this.toolStripButtonAddToCart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddToCart.Text = "Добавить в корзину";
            this.toolStripButtonAddToCart.Click += new System.EventHandler(this.toolStripButtonAddToCart_Click);
            // 
            // toolStripButtonOpenCart
            // 
            this.toolStripButtonOpenCart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenCart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenCart.Image")));
            this.toolStripButtonOpenCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenCart.Name = "toolStripButtonOpenCart";
            this.toolStripButtonOpenCart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenCart.Text = "Открыть корзину";
            this.toolStripButtonOpenCart.Click += new System.EventHandler(this.toolStripButtonOpenCart_Click);
            // 
            // columnPriceForSale
            // 
            this.columnPriceForSale.Text = "Итог";
            this.columnPriceForSale.Width = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 450);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.booksLV);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView booksLV;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAutor;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnPublishingHouse;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelPriceToSearch;
        private System.Windows.Forms.Label labelPriceFromSearch;
        private System.Windows.Forms.Label labelTypeSearch;
        private System.Windows.Forms.Label labelGenreSearch;
        private System.Windows.Forms.Label labelAutorSearch;
        private System.Windows.Forms.Label labelNameSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceToTB;
        private System.Windows.Forms.TextBox PriceFromTB;
        private System.Windows.Forms.ComboBox GenreCB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ColumnHeader columnNumberToSell;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddToCart;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenCart;
        private System.Windows.Forms.ColumnHeader columnPriceForSale;
    }
}

