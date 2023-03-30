namespace Wiki
{
    partial class WikiApplication
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.labelDataTable = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.ListViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(254, 67);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(45, 28);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(102, 67);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(116, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(254, 113);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 29);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(237, 158);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(62, 32);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(567, 200);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(52, 33);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "SORT";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(557, 31);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 29);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(567, 244);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(51, 33);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(567, 290);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 32);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(102, 113);
            this.TextBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(116, 20);
            this.TextBoxCategory.TabIndex = 9;
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(102, 158);
            this.TextBoxStructure.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(116, 20);
            this.TextBoxStructure.TabIndex = 10;
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(102, 207);
            this.TextBoxDefinition.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(197, 115);
            this.TextBoxDefinition.TabIndex = 11;
            // 
            // labelDataTable
            // 
            this.labelDataTable.AutoSize = true;
            this.labelDataTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataTable.Location = new System.Drawing.Point(317, 37);
            this.labelDataTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataTable.Name = "labelDataTable";
            this.labelDataTable.Size = new System.Drawing.Size(104, 15);
            this.labelDataTable.TabIndex = 12;
            this.labelDataTable.Text = "Data Table List";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 67);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(23, 113);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 14;
            this.labelCategory.Text = "Category:";
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.Location = new System.Drawing.Point(22, 158);
            this.labelStructure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(53, 13);
            this.labelStructure.TabIndex = 15;
            this.labelStructure.Text = "Structure:";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(21, 207);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(54, 13);
            this.labelDefinition.TabIndex = 16;
            this.labelDefinition.Text = "Definition:";
            // 
            // ListViewDisplay
            // 
            this.ListViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewDisplay.HideSelection = false;
            this.ListViewDisplay.Location = new System.Drawing.Point(320, 67);
            this.ListViewDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewDisplay.Name = "ListViewDisplay";
            this.ListViewDisplay.Size = new System.Drawing.Size(233, 255);
            this.ListViewDisplay.TabIndex = 19;
            this.ListViewDisplay.UseCompatibleStateImageBehavior = false;
            this.ListViewDisplay.View = System.Windows.Forms.View.Details;
            this.ListViewDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewItems_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(437, 36);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(116, 20);
            this.TextBoxSearch.TabIndex = 20;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 359);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(654, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // WikiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 381);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListViewDisplay);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDataTable);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WikiApplication";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxStructure;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label labelDataTable;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.ListView ListViewDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

