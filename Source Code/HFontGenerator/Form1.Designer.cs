namespace HFontGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._filePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._blockSize = new System.Windows.Forms.Label();
            this._wastedBitsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._bmpHeightLabel = new System.Windows.Forms.Label();
            this._bmpWidthLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._blockDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._comment = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this._charHeight = new System.Windows.Forms.NumericUpDown();
            this._charWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._size = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this._blockType = new System.Windows.Forms.ComboBox();
            this._name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this._memSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._wastedMem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._charHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._charWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._size)).BeginInit();
            this.SuspendLayout();
            // 
            // _filePath
            // 
            this._filePath.Location = new System.Drawing.Point(20, 13);
            this._filePath.Name = "_filePath";
            this._filePath.ReadOnly = true;
            this._filePath.Size = new System.Drawing.Size(324, 20);
            this._filePath.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select BMP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 290);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Copy Struct Definition";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "CREATE FONT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._wastedMem);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this._memSize);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this._blockSize);
            this.groupBox2.Controls.Add(this._wastedBitsLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._bmpHeightLabel);
            this.groupBox2.Controls.Add(this._bmpWidthLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._blockDisplay);
            this.groupBox2.Location = new System.Drawing.Point(239, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 221);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Information ";
            // 
            // _blockSize
            // 
            this._blockSize.AutoSize = true;
            this._blockSize.Location = new System.Drawing.Point(7, 99);
            this._blockSize.Name = "_blockSize";
            this._blockSize.Size = new System.Drawing.Size(35, 13);
            this._blockSize.TabIndex = 7;
            this._blockSize.Text = "label9";
            // 
            // _wastedBitsLabel
            // 
            this._wastedBitsLabel.AutoSize = true;
            this._wastedBitsLabel.Location = new System.Drawing.Point(4, 161);
            this._wastedBitsLabel.Name = "_wastedBitsLabel";
            this._wastedBitsLabel.Size = new System.Drawing.Size(73, 13);
            this._wastedBitsLabel.TabIndex = 6;
            this._wastedBitsLabel.Text = "_wastedLabel";
            this._wastedBitsLabel.Click += new System.EventHandler(this._wastedBitsLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Wasted Memory per Char:";
            // 
            // _bmpHeightLabel
            // 
            this._bmpHeightLabel.AutoSize = true;
            this._bmpHeightLabel.Location = new System.Drawing.Point(7, 68);
            this._bmpHeightLabel.Name = "_bmpHeightLabel";
            this._bmpHeightLabel.Size = new System.Drawing.Size(35, 13);
            this._bmpHeightLabel.TabIndex = 4;
            this._bmpHeightLabel.Text = "label9";
            this._bmpHeightLabel.Click += new System.EventHandler(this._bmpHeightLabel_Click);
            // 
            // _bmpWidthLabel
            // 
            this._bmpWidthLabel.AutoSize = true;
            this._bmpWidthLabel.Location = new System.Drawing.Point(7, 33);
            this._bmpWidthLabel.Name = "_bmpWidthLabel";
            this._bmpWidthLabel.Size = new System.Drawing.Size(35, 13);
            this._bmpWidthLabel.TabIndex = 3;
            this._bmpWidthLabel.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Required BMP Height:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Required BMP Width : ";
            // 
            // _blockDisplay
            // 
            this._blockDisplay.AutoSize = true;
            this._blockDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._blockDisplay.Location = new System.Drawing.Point(6, 86);
            this._blockDisplay.Name = "_blockDisplay";
            this._blockDisplay.Size = new System.Drawing.Size(75, 13);
            this._blockDisplay.TabIndex = 0;
            this._blockDisplay.Text = "Block Size :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._comment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._charHeight);
            this.groupBox1.Controls.Add(this._charWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._size);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this._blockType);
            this.groupBox1.Controls.Add(this._name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 284);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Arguments";
            // 
            // _comment
            // 
            this._comment.AutoSize = true;
            this._comment.Checked = true;
            this._comment.CheckState = System.Windows.Forms.CheckState.Checked;
            this._comment.Location = new System.Drawing.Point(16, 138);
            this._comment.Name = "_comment";
            this._comment.Size = new System.Drawing.Size(191, 17);
            this._comment.TabIndex = 12;
            this._comment.Text = "Insert Comment for Each Character";
            this._comment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Char Height";
            // 
            // _charHeight
            // 
            this._charHeight.Location = new System.Drawing.Point(151, 72);
            this._charHeight.Name = "_charHeight";
            this._charHeight.Size = new System.Drawing.Size(60, 20);
            this._charHeight.TabIndex = 10;
            this._charHeight.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this._charHeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // _charWidth
            // 
            this._charWidth.Location = new System.Drawing.Point(85, 72);
            this._charWidth.Name = "_charWidth";
            this._charWidth.Size = new System.Drawing.Size(60, 20);
            this._charWidth.TabIndex = 9;
            this._charWidth.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this._charWidth.ValueChanged += new System.EventHandler(this._charWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Char Width";
            // 
            // _size
            // 
            this._size.Location = new System.Drawing.Point(16, 72);
            this._size.Maximum = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this._size.Name = "_size";
            this._size.Size = new System.Drawing.Size(63, 20);
            this._size.TabIndex = 7;
            this._size.Value = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this._size.ValueChanged += new System.EventHandler(this._size_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(16, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Create Text Report [UNDER DEV]";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // _blockType
            // 
            this._blockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._blockType.FormattingEnabled = true;
            this._blockType.Items.AddRange(new object[] {
            "UInt8_t",
            "UInt16_t",
            "Uint32_t"});
            this._blockType.Location = new System.Drawing.Point(16, 111);
            this._blockType.Name = "_blockType";
            this._blockType.Size = new System.Drawing.Size(195, 21);
            this._blockType.TabIndex = 5;
            this._blockType.SelectedIndexChanged += new System.EventHandler(this._blockType_SelectedIndexChanged);
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(16, 32);
            this._name.MaxLength = 50;
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(195, 20);
            this._name.TabIndex = 3;
            this._name.Text = "UnknownFont";
            this._name.MouseClick += new System.Windows.Forms.MouseEventHandler(this._name_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Block Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Char Count";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name (Max Chr = 50)";
            // 
            // _fileDialog
            // 
            this._fileDialog.Title = "Select a Bitmap File";
            this._fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._fileDialog_FileOk);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Size of the Font :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // _memSize
            // 
            this._memSize.AutoSize = true;
            this._memSize.Location = new System.Drawing.Point(7, 129);
            this._memSize.Name = "_memSize";
            this._memSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._memSize.Size = new System.Drawing.Size(41, 13);
            this._memSize.TabIndex = 9;
            this._memSize.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Wasted Memory :";
            // 
            // _wastedMem
            // 
            this._wastedMem.AutoSize = true;
            this._wastedMem.Location = new System.Drawing.Point(7, 192);
            this._wastedMem.Name = "_wastedMem";
            this._wastedMem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._wastedMem.Size = new System.Drawing.Size(41, 13);
            this._wastedMem.TabIndex = 11;
            this._wastedMem.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._filePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Font Generator for Hoca Watch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._charHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._charWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _filePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _blockType;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label _blockDisplay;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown _size;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog _fileDialog;
        private System.Windows.Forms.NumericUpDown _charHeight;
        private System.Windows.Forms.NumericUpDown _charWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _bmpHeightLabel;
        private System.Windows.Forms.Label _bmpWidthLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _wastedBitsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _blockSize;
        private System.Windows.Forms.CheckBox _comment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label _memSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _wastedMem;
        private System.Windows.Forms.Label label10;
    }
}

