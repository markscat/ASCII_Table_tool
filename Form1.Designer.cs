namespace ASCIIT_table
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
            ListViewAscii = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            TabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ASCII2HEX = new TabPage();
            Lable1 = new Label();
            ASCII_TextBox = new TextBox();
            ButTran = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ASCII2HEX.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewAscii
            // 
            ListViewAscii.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListViewAscii.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            ListViewAscii.FullRowSelect = true;
            ListViewAscii.GridLines = true;
            ListViewAscii.Location = new Point(2, 2);
            ListViewAscii.Margin = new Padding(2);
            ListViewAscii.Name = "ListViewAscii";
            ListViewAscii.Size = new Size(953, 599);
            ListViewAscii.TabIndex = 0;
            ListViewAscii.UseCompatibleStateImageBehavior = false;
            ListViewAscii.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Char1";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dec1";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Hex1";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Oct1";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Char2";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Dec2";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Hex1";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "oct2";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Char3";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "DEC3";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Hex3";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Oct3";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "char4";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "dec4";
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Hex4";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Oct4";
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(ASCII2HEX);
            TabControl1.Location = new Point(12, 3);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1082, 631);
            TabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ListViewAscii);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1074, 603);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ASCII Table";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ASCII2HEX
            // 
            ASCII2HEX.Controls.Add(label1);
            ASCII2HEX.Controls.Add(textBox1);
            ASCII2HEX.Controls.Add(ButTran);
            ASCII2HEX.Controls.Add(Lable1);
            ASCII2HEX.Controls.Add(ASCII_TextBox);
            ASCII2HEX.Location = new Point(4, 24);
            ASCII2HEX.Name = "ASCII2HEX";
            ASCII2HEX.Padding = new Padding(3);
            ASCII2HEX.Size = new Size(1084, 550);
            ASCII2HEX.TabIndex = 1;
            ASCII2HEX.Text = "ASCII to HEX";
            ASCII2HEX.UseVisualStyleBackColor = true;
            // 
            // Lable1
            // 
            Lable1.AutoSize = true;
            Lable1.Location = new Point(8, 35);
            Lable1.Name = "Lable1";
            Lable1.Size = new Size(36, 15);
            Lable1.TabIndex = 1;
            Lable1.Text = "ASCII";
            // 
            // ASCII_TextBox
            // 
            ASCII_TextBox.Location = new Point(63, 34);
            ASCII_TextBox.Name = "ASCII_TextBox";
            ASCII_TextBox.Size = new Size(476, 23);
            ASCII_TextBox.TabIndex = 0;
            // 
            // ButTran
            // 
            ButTran.Location = new Point(545, 35);
            ButTran.Name = "ButTran";
            ButTran.Size = new Size(112, 23);
            ButTran.TabIndex = 2;
            ButTran.Text = "ASCII to HEX";
            ButTran.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(476, 264);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 109);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "HEX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 634);
            Controls.Add(TabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ASCII2HEX.ResumeLayout(false);
            ASCII2HEX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView ListViewAscii;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage ASCII2HEX;
        private Label Lable1;
        private TextBox ASCII_TextBox;
        private TextBox textBox1;
        private Button ButTran;
        private Label label1;
    }
}
