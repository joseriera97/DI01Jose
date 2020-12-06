namespace DI01Jose
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.productsCategoryTabControl = new System.Windows.Forms.TabControl();
            this.allProductsTabPage = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.allCategoryLabel = new System.Windows.Forms.Label();
            this.bikeCategoryTabPage = new System.Windows.Forms.TabPage();
            this.subCategorylabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bikesLabel = new System.Windows.Forms.Label();
            this.bikesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.componentsCategoryTabPage = new System.Windows.Forms.TabPage();
            this.componentLabel = new System.Windows.Forms.Label();
            this.componentsListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clothingCategoryTabPage = new System.Windows.Forms.TabPage();
            this.clothingLabel = new System.Windows.Forms.Label();
            this.clothingListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessoriesCategoryTabPage = new System.Windows.Forms.TabPage();
            this.accessoriesLabel = new System.Windows.Forms.Label();
            this.accessoriesListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.filmsForPageComboBox = new System.Windows.Forms.ComboBox();
            this.productsPageLabel = new System.Windows.Forms.Label();
            this.actualPageLabel = new System.Windows.Forms.Label();
            this.productListListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productsCategoryTabControl.SuspendLayout();
            this.allProductsTabPage.SuspendLayout();
            this.bikeCategoryTabPage.SuspendLayout();
            this.componentsCategoryTabPage.SuspendLayout();
            this.clothingCategoryTabPage.SuspendLayout();
            this.accessoriesCategoryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsCategoryTabControl
            // 
            this.productsCategoryTabControl.AllowDrop = true;
            this.productsCategoryTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.productsCategoryTabControl.Controls.Add(this.allProductsTabPage);
            this.productsCategoryTabControl.Controls.Add(this.bikeCategoryTabPage);
            this.productsCategoryTabControl.Controls.Add(this.componentsCategoryTabPage);
            this.productsCategoryTabControl.Controls.Add(this.clothingCategoryTabPage);
            this.productsCategoryTabControl.Controls.Add(this.accessoriesCategoryTabPage);
            this.productsCategoryTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsCategoryTabControl.ItemSize = new System.Drawing.Size(31, 40);
            this.productsCategoryTabControl.Location = new System.Drawing.Point(2, 34);
            this.productsCategoryTabControl.Multiline = true;
            this.productsCategoryTabControl.Name = "productsCategoryTabControl";
            this.productsCategoryTabControl.Padding = new System.Drawing.Point(0, 0);
            this.productsCategoryTabControl.RightToLeftLayout = true;
            this.productsCategoryTabControl.SelectedIndex = 0;
            this.productsCategoryTabControl.Size = new System.Drawing.Size(846, 476);
            this.productsCategoryTabControl.TabIndex = 1;
            this.productsCategoryTabControl.SelectedIndexChanged += new System.EventHandler(this.productsCategoryTabControl_SelectedIndexChanged);
            // 
            // allProductsTabPage
            // 
            this.allProductsTabPage.BackColor = System.Drawing.Color.Lavender;
            this.allProductsTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.allProductsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allProductsTabPage.Controls.Add(this.productListListView);
            this.allProductsTabPage.Controls.Add(this.actualPageLabel);
            this.allProductsTabPage.Controls.Add(this.productsPageLabel);
            this.allProductsTabPage.Controls.Add(this.filmsForPageComboBox);
            this.allProductsTabPage.Controls.Add(this.nextPageButton);
            this.allProductsTabPage.Controls.Add(this.backPageButton);
            this.allProductsTabPage.Controls.Add(this.searchButton);
            this.allProductsTabPage.Controls.Add(this.searchTextBox);
            this.allProductsTabPage.Controls.Add(this.searchLabel);
            this.allProductsTabPage.Controls.Add(this.allCategoryLabel);
            this.allProductsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductsTabPage.Location = new System.Drawing.Point(4, 44);
            this.allProductsTabPage.Name = "allProductsTabPage";
            this.allProductsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allProductsTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allProductsTabPage.Size = new System.Drawing.Size(838, 428);
            this.allProductsTabPage.TabIndex = 0;
            this.allProductsTabPage.Text = "All Category";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(565, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(77, 26);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Find";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(83, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(476, 26);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(71, 20);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search:";
            // 
            // allCategoryLabel
            // 
            this.allCategoryLabel.AutoSize = true;
            this.allCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCategoryLabel.Location = new System.Drawing.Point(6, 391);
            this.allCategoryLabel.Name = "allCategoryLabel";
            this.allCategoryLabel.Size = new System.Drawing.Size(96, 16);
            this.allCategoryLabel.TabIndex = 2;
            this.allCategoryLabel.Text = "products found";
            // 
            // bikeCategoryTabPage
            // 
            this.bikeCategoryTabPage.BackColor = System.Drawing.Color.Lavender;
            this.bikeCategoryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bikeCategoryTabPage.Controls.Add(this.subCategorylabel);
            this.bikeCategoryTabPage.Controls.Add(this.comboBox1);
            this.bikeCategoryTabPage.Controls.Add(this.bikesLabel);
            this.bikeCategoryTabPage.Controls.Add(this.bikesListView);
            this.bikeCategoryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeCategoryTabPage.Location = new System.Drawing.Point(4, 44);
            this.bikeCategoryTabPage.Name = "bikeCategoryTabPage";
            this.bikeCategoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bikeCategoryTabPage.Size = new System.Drawing.Size(838, 428);
            this.bikeCategoryTabPage.TabIndex = 1;
            this.bikeCategoryTabPage.Text = "Bikes";
            // 
            // subCategorylabel
            // 
            this.subCategorylabel.AutoSize = true;
            this.subCategorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategorylabel.Location = new System.Drawing.Point(637, -2);
            this.subCategorylabel.Name = "subCategorylabel";
            this.subCategorylabel.Size = new System.Drawing.Size(179, 20);
            this.subCategorylabel.TabIndex = 3;
            this.subCategorylabel.Text = "Choose SubCategory";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(663, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // bikesLabel
            // 
            this.bikesLabel.AutoSize = true;
            this.bikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikesLabel.Location = new System.Drawing.Point(6, 401);
            this.bikesLabel.Name = "bikesLabel";
            this.bikesLabel.Size = new System.Drawing.Size(45, 16);
            this.bikesLabel.TabIndex = 3;
            this.bikesLabel.Text = "label1";
            // 
            // bikesListView
            // 
            this.bikesListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.bikesListView.AllowColumnReorder = true;
            this.bikesListView.AllowDrop = true;
            this.bikesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.bikesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikesListView.GridLines = true;
            this.bikesListView.HideSelection = false;
            this.bikesListView.Location = new System.Drawing.Point(6, 91);
            this.bikesListView.Name = "bikesListView";
            this.bikesListView.Size = new System.Drawing.Size(822, 307);
            this.bikesListView.TabIndex = 2;
            this.bikesListView.UseCompatibleStateImageBehavior = false;
            this.bikesListView.View = System.Windows.Forms.View.List;
            this.bikesListView.VirtualListSize = 10;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 823;
            // 
            // componentsCategoryTabPage
            // 
            this.componentsCategoryTabPage.BackColor = System.Drawing.Color.Lavender;
            this.componentsCategoryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.componentsCategoryTabPage.Controls.Add(this.componentLabel);
            this.componentsCategoryTabPage.Controls.Add(this.componentsListView);
            this.componentsCategoryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsCategoryTabPage.Location = new System.Drawing.Point(4, 44);
            this.componentsCategoryTabPage.Name = "componentsCategoryTabPage";
            this.componentsCategoryTabPage.Size = new System.Drawing.Size(838, 428);
            this.componentsCategoryTabPage.TabIndex = 2;
            this.componentsCategoryTabPage.Text = "Components";
            // 
            // componentLabel
            // 
            this.componentLabel.AutoSize = true;
            this.componentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentLabel.Location = new System.Drawing.Point(4, 401);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(45, 16);
            this.componentLabel.TabIndex = 4;
            this.componentLabel.Text = "label1";
            // 
            // componentsListView
            // 
            this.componentsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.componentsListView.AllowColumnReorder = true;
            this.componentsListView.AllowDrop = true;
            this.componentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.componentsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsListView.GridLines = true;
            this.componentsListView.HideSelection = false;
            this.componentsListView.Location = new System.Drawing.Point(6, 91);
            this.componentsListView.Name = "componentsListView";
            this.componentsListView.Size = new System.Drawing.Size(822, 307);
            this.componentsListView.TabIndex = 3;
            this.componentsListView.UseCompatibleStateImageBehavior = false;
            this.componentsListView.View = System.Windows.Forms.View.List;
            this.componentsListView.VirtualListSize = 10;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 823;
            // 
            // clothingCategoryTabPage
            // 
            this.clothingCategoryTabPage.BackColor = System.Drawing.Color.Lavender;
            this.clothingCategoryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clothingCategoryTabPage.Controls.Add(this.clothingLabel);
            this.clothingCategoryTabPage.Controls.Add(this.clothingListView);
            this.clothingCategoryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingCategoryTabPage.Location = new System.Drawing.Point(4, 44);
            this.clothingCategoryTabPage.Name = "clothingCategoryTabPage";
            this.clothingCategoryTabPage.Size = new System.Drawing.Size(838, 428);
            this.clothingCategoryTabPage.TabIndex = 3;
            this.clothingCategoryTabPage.Text = "Clothing";
            // 
            // clothingLabel
            // 
            this.clothingLabel.AutoSize = true;
            this.clothingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingLabel.Location = new System.Drawing.Point(4, 401);
            this.clothingLabel.Name = "clothingLabel";
            this.clothingLabel.Size = new System.Drawing.Size(45, 16);
            this.clothingLabel.TabIndex = 5;
            this.clothingLabel.Text = "label1";
            // 
            // clothingListView
            // 
            this.clothingListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.clothingListView.AllowColumnReorder = true;
            this.clothingListView.AllowDrop = true;
            this.clothingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.clothingListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingListView.GridLines = true;
            this.clothingListView.HideSelection = false;
            this.clothingListView.Location = new System.Drawing.Point(6, 91);
            this.clothingListView.Name = "clothingListView";
            this.clothingListView.Size = new System.Drawing.Size(822, 307);
            this.clothingListView.TabIndex = 4;
            this.clothingListView.UseCompatibleStateImageBehavior = false;
            this.clothingListView.View = System.Windows.Forms.View.List;
            this.clothingListView.VirtualListSize = 10;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 823;
            // 
            // accessoriesCategoryTabPage
            // 
            this.accessoriesCategoryTabPage.BackColor = System.Drawing.Color.Lavender;
            this.accessoriesCategoryTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accessoriesCategoryTabPage.Controls.Add(this.accessoriesLabel);
            this.accessoriesCategoryTabPage.Controls.Add(this.accessoriesListView);
            this.accessoriesCategoryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessoriesCategoryTabPage.Location = new System.Drawing.Point(4, 44);
            this.accessoriesCategoryTabPage.Name = "accessoriesCategoryTabPage";
            this.accessoriesCategoryTabPage.Size = new System.Drawing.Size(838, 428);
            this.accessoriesCategoryTabPage.TabIndex = 4;
            this.accessoriesCategoryTabPage.Text = "Accessories";
            // 
            // accessoriesLabel
            // 
            this.accessoriesLabel.AutoSize = true;
            this.accessoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessoriesLabel.Location = new System.Drawing.Point(4, 401);
            this.accessoriesLabel.Name = "accessoriesLabel";
            this.accessoriesLabel.Size = new System.Drawing.Size(45, 16);
            this.accessoriesLabel.TabIndex = 5;
            this.accessoriesLabel.Text = "label1";
            // 
            // accessoriesListView
            // 
            this.accessoriesListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.accessoriesListView.AllowColumnReorder = true;
            this.accessoriesListView.AllowDrop = true;
            this.accessoriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.accessoriesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessoriesListView.GridLines = true;
            this.accessoriesListView.HideSelection = false;
            this.accessoriesListView.Location = new System.Drawing.Point(6, 91);
            this.accessoriesListView.Name = "accessoriesListView";
            this.accessoriesListView.Size = new System.Drawing.Size(822, 307);
            this.accessoriesListView.TabIndex = 4;
            this.accessoriesListView.UseCompatibleStateImageBehavior = false;
            this.accessoriesListView.View = System.Windows.Forms.View.List;
            this.accessoriesListView.VirtualListSize = 10;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 823;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(121, 7);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(171, 24);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Choose Category";
            // 
            // backPageButton
            // 
            this.backPageButton.Enabled = false;
            this.backPageButton.Location = new System.Drawing.Point(307, 398);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(75, 23);
            this.backPageButton.TabIndex = 3;
            this.backPageButton.Text = "<";
            this.backPageButton.UseVisualStyleBackColor = true;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(388, 398);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 6;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // filmsForPageComboBox
            // 
            this.filmsForPageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmsForPageComboBox.FormattingEnabled = true;
            this.filmsForPageComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
            this.filmsForPageComboBox.Location = new System.Drawing.Point(691, 47);
            this.filmsForPageComboBox.Name = "filmsForPageComboBox";
            this.filmsForPageComboBox.Size = new System.Drawing.Size(121, 28);
            this.filmsForPageComboBox.TabIndex = 7;
            this.filmsForPageComboBox.Text = "20";
            // 
            // productsPageLabel
            // 
            this.productsPageLabel.AutoSize = true;
            this.productsPageLabel.Location = new System.Drawing.Point(671, 23);
            this.productsPageLabel.Name = "productsPageLabel";
            this.productsPageLabel.Size = new System.Drawing.Size(157, 20);
            this.productsPageLabel.TabIndex = 8;
            this.productsPageLabel.Text = "Products per Page";
            // 
            // actualPageLabel
            // 
            this.actualPageLabel.AutoSize = true;
            this.actualPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPageLabel.Location = new System.Drawing.Point(732, 398);
            this.actualPageLabel.Name = "actualPageLabel";
            this.actualPageLabel.Size = new System.Drawing.Size(84, 16);
            this.actualPageLabel.TabIndex = 9;
            this.actualPageLabel.Text = "0 of 0 pages ";
            // 
            // productListListView
            // 
            this.productListListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.productListListView.AllowColumnReorder = true;
            this.productListListView.AllowDrop = true;
            this.productListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.productListListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListListView.GridLines = true;
            this.productListListView.HideSelection = false;
            this.productListListView.Location = new System.Drawing.Point(4, 81);
            this.productListListView.Name = "productListListView";
            this.productListListView.Size = new System.Drawing.Size(822, 307);
            this.productListListView.TabIndex = 10;
            this.productListListView.UseCompatibleStateImageBehavior = false;
            this.productListListView.View = System.Windows.Forms.View.List;
            this.productListListView.VirtualListSize = 10;
            this.productListListView.DoubleClick += new System.EventHandler(this.productListListView_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 823;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(852, 506);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.productsCategoryTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "DI01 Jose Alberto";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.productsCategoryTabControl.ResumeLayout(false);
            this.allProductsTabPage.ResumeLayout(false);
            this.allProductsTabPage.PerformLayout();
            this.bikeCategoryTabPage.ResumeLayout(false);
            this.bikeCategoryTabPage.PerformLayout();
            this.componentsCategoryTabPage.ResumeLayout(false);
            this.componentsCategoryTabPage.PerformLayout();
            this.clothingCategoryTabPage.ResumeLayout(false);
            this.clothingCategoryTabPage.PerformLayout();
            this.accessoriesCategoryTabPage.ResumeLayout(false);
            this.accessoriesCategoryTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl productsCategoryTabControl;
        private System.Windows.Forms.TabPage allProductsTabPage;
        private System.Windows.Forms.TabPage componentsCategoryTabPage;
        private System.Windows.Forms.TabPage clothingCategoryTabPage;
        private System.Windows.Forms.TabPage accessoriesCategoryTabPage;
        private System.Windows.Forms.ListView bikesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView componentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView clothingListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView accessoriesListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label allCategoryLabel;
        private System.Windows.Forms.Label bikesLabel;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label clothingLabel;
        private System.Windows.Forms.Label accessoriesLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TabPage bikeCategoryTabPage;
        private System.Windows.Forms.Label subCategorylabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Label actualPageLabel;
        private System.Windows.Forms.Label productsPageLabel;
        private System.Windows.Forms.ComboBox filmsForPageComboBox;
        private System.Windows.Forms.ListView productListListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

