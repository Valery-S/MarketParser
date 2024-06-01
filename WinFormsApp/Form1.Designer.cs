namespace WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputTextBox = new RichTextBox();
            SearchButton = new Button();
            ProductDataGridView = new DataGridView();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            URLColumn = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            CitilinkCheckBox = new CheckBox();
            WbCheckBox = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            YandexCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = Color.White;
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Cursor = Cursors.IBeam;
            inputTextBox.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            inputTextBox.ForeColor = SystemColors.ControlText;
            inputTextBox.Location = new Point(286, 12);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(639, 54);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Yellow;
            SearchButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(948, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(145, 54);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { DescriptionColumn, PriceColumn, URLColumn });
            ProductDataGridView.Location = new Point(286, 91);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowTemplate.Height = 25;
            ProductDataGridView.Size = new Size(807, 371);
            ProductDataGridView.TabIndex = 2;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Описание";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.Width = 350;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 120;
            // 
            // URLColumn
            // 
            URLColumn.HeaderText = "URL";
            URLColumn.Name = "URLColumn";
            URLColumn.Width = 300;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 63);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CitilinkCheckBox
            // 
            CitilinkCheckBox.AutoSize = true;
            CitilinkCheckBox.Location = new Point(12, 115);
            CitilinkCheckBox.Name = "CitilinkCheckBox";
            CitilinkCheckBox.Size = new Size(15, 14);
            CitilinkCheckBox.TabIndex = 4;
            CitilinkCheckBox.UseVisualStyleBackColor = true;
            // 
            // WbCheckBox
            // 
            WbCheckBox.AutoSize = true;
            WbCheckBox.Location = new Point(12, 306);
            WbCheckBox.Name = "WbCheckBox";
            WbCheckBox.Size = new Size(15, 14);
            WbCheckBox.TabIndex = 6;
            WbCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 53);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 50);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // YandexCheckBox
            // 
            YandexCheckBox.AutoSize = true;
            YandexCheckBox.Location = new Point(12, 223);
            YandexCheckBox.Name = "YandexCheckBox";
            YandexCheckBox.Size = new Size(15, 14);
            YandexCheckBox.TabIndex = 9;
            YandexCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1134, 474);
            Controls.Add(YandexCheckBox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(WbCheckBox);
            Controls.Add(CitilinkCheckBox);
            Controls.Add(pictureBox1);
            Controls.Add(ProductDataGridView);
            Controls.Add(SearchButton);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "MarketParser";
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputTextBox;
        private Button SearchButton;
        private DataGridView ProductDataGridView;
        private PictureBox pictureBox1;
        private CheckBox CitilinkCheckBox;
        private CheckBox checkBox1;
        private CheckBox WbCheckBox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox YandexCheckBox;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn URLColumn;
    }
}
