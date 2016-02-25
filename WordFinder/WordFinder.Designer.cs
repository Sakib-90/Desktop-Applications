namespace WordFinder
{
    partial class WordFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordFinder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButoon = new System.Windows.Forms.Button();
            this.wordSearchingTextBox = new System.Windows.Forms.TextBox();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.articleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sentenceListBox = new System.Windows.Forms.ListBox();
            this.sentenceCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordCountLabel);
            this.groupBox1.Controls.Add(this.searchButoon);
            this.groupBox1.Controls.Add(this.wordSearchingTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Word";
            // 
            // searchButoon
            // 
            this.searchButoon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButoon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButoon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButoon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.searchButoon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButoon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButoon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButoon.Location = new System.Drawing.Point(532, 47);
            this.searchButoon.Name = "searchButoon";
            this.searchButoon.Size = new System.Drawing.Size(69, 31);
            this.searchButoon.TabIndex = 2;
            this.searchButoon.Text = "Search";
            this.searchButoon.UseVisualStyleBackColor = false;
            this.searchButoon.Click += new System.EventHandler(this.searchButoon_Click);
            // 
            // wordSearchingTextBox
            // 
            this.wordSearchingTextBox.Location = new System.Drawing.Point(89, 20);
            this.wordSearchingTextBox.Name = "wordSearchingTextBox";
            this.wordSearchingTextBox.Size = new System.Drawing.Size(513, 21);
            this.wordSearchingTextBox.TabIndex = 1;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountLabel.ForeColor = System.Drawing.Color.Red;
            this.wordCountLabel.Location = new System.Drawing.Point(204, 56);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(39, 13);
            this.wordCountLabel.TabIndex = 2;
            this.wordCountLabel.Text = " 0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key Word";
            // 
            // articleRichTextBox
            // 
            this.articleRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.articleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.articleRichTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleRichTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.articleRichTextBox.Location = new System.Drawing.Point(15, 28);
            this.articleRichTextBox.Name = "articleRichTextBox";
            this.articleRichTextBox.Size = new System.Drawing.Size(619, 178);
            this.articleRichTextBox.TabIndex = 1;
            this.articleRichTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sentenceCountLabel);
            this.groupBox2.Controls.Add(this.sentenceListBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matched Setence(s)";
            // 
            // sentenceListBox
            // 
            this.sentenceListBox.FormattingEnabled = true;
            this.sentenceListBox.ItemHeight = 14;
            this.sentenceListBox.Location = new System.Drawing.Point(11, 48);
            this.sentenceListBox.Name = "sentenceListBox";
            this.sentenceListBox.Size = new System.Drawing.Size(590, 102);
            this.sentenceListBox.TabIndex = 1;
            // 
            // sentenceCountLabel
            // 
            this.sentenceCountLabel.AutoSize = true;
            this.sentenceCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceCountLabel.ForeColor = System.Drawing.Color.Red;
            this.sentenceCountLabel.Location = new System.Drawing.Point(148, 22);
            this.sentenceCountLabel.Name = "sentenceCountLabel";
            this.sentenceCountLabel.Size = new System.Drawing.Size(35, 13);
            this.sentenceCountLabel.TabIndex = 0;
            this.sentenceCountLabel.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paste Your Article Here :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Word(s) Found : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sentence(s) Found : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(128, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Word Finder ©  2016 | Developed by Sakibur Rahman | +880 16723802313";
            // 
            // WordFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(650, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articleRichTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WordFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Finder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButoon;
        private System.Windows.Forms.TextBox wordSearchingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox articleRichTextBox;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sentenceCountLabel;
        private System.Windows.Forms.ListBox sentenceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

