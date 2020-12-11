﻿namespace IRF_Project_DCWC5L
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
            this.labelOpenFile = new System.Windows.Forms.Label();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.dataGridViewCD = new System.Windows.Forms.DataGridView();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelShortName = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.dataGridViewPersonList = new System.Windows.Forms.DataGridView();
            this.buttonSaveList = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.richTextBoxRandomCD = new System.Windows.Forms.RichTextBox();
            this.buttonAddPresent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOpenFile
            // 
            this.labelOpenFile.AutoSize = true;
            this.labelOpenFile.Location = new System.Drawing.Point(24, 19);
            this.labelOpenFile.Name = "labelOpenFile";
            this.labelOpenFile.Size = new System.Drawing.Size(86, 13);
            this.labelOpenFile.TabIndex = 0;
            this.labelOpenFile.Text = "Zenei lista helye:";
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(116, 12);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpenFile.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(231, 9);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Tallózás";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // dataGridViewCD
            // 
            this.dataGridViewCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCD.Location = new System.Drawing.Point(27, 54);
            this.dataGridViewCD.Name = "dataGridViewCD";
            this.dataGridViewCD.Size = new System.Drawing.Size(279, 369);
            this.dataGridViewCD.TabIndex = 3;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(352, 19);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(146, 13);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "Megajándékozott teljes neve:";
            // 
            // labelShortName
            // 
            this.labelShortName.AutoSize = true;
            this.labelShortName.Location = new System.Drawing.Point(352, 52);
            this.labelShortName.Name = "labelShortName";
            this.labelShortName.Size = new System.Drawing.Size(59, 13);
            this.labelShortName.TabIndex = 5;
            this.labelShortName.Text = "Beceneve:";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(352, 79);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(128, 13);
            this.labelAccount.TabIndex = 6;
            this.labelAccount.Text = "iTunes accountja (e-mail):";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(513, 11);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 7;
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Location = new System.Drawing.Point(513, 45);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(100, 20);
            this.textBoxShortName.TabIndex = 8;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(513, 72);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccount.TabIndex = 9;
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(355, 112);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(258, 28);
            this.buttonAddList.TabIndex = 10;
            this.buttonAddList.Text = "Hozzáadás a megadjándékozottak listájához";
            this.buttonAddList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersonList
            // 
            this.dataGridViewPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonList.Location = new System.Drawing.Point(355, 167);
            this.dataGridViewPersonList.Name = "dataGridViewPersonList";
            this.dataGridViewPersonList.Size = new System.Drawing.Size(258, 256);
            this.dataGridViewPersonList.TabIndex = 11;
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.Location = new System.Drawing.Point(650, 112);
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Size = new System.Drawing.Size(119, 29);
            this.buttonSaveList.TabIndex = 12;
            this.buttonSaveList.Text = "Ajándéklista mentése";
            this.buttonSaveList.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(650, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 90);
            this.pictureBoxLogo.TabIndex = 13;
            this.pictureBoxLogo.TabStop = false;
            // 
            // richTextBoxRandomCD
            // 
            this.richTextBoxRandomCD.Location = new System.Drawing.Point(650, 257);
            this.richTextBoxRandomCD.Name = "richTextBoxRandomCD";
            this.richTextBoxRandomCD.Size = new System.Drawing.Size(119, 166);
            this.richTextBoxRandomCD.TabIndex = 14;
            this.richTextBoxRandomCD.Text = "";
            // 
            // buttonAddPresent
            // 
            this.buttonAddPresent.Location = new System.Drawing.Point(650, 167);
            this.buttonAddPresent.Name = "buttonAddPresent";
            this.buttonAddPresent.Size = new System.Drawing.Size(119, 70);
            this.buttonAddPresent.TabIndex = 15;
            this.buttonAddPresent.Text = "Megajándékozom őt a kiválasztott CD-vel";
            this.buttonAddPresent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddPresent);
            this.Controls.Add(this.richTextBoxRandomCD);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonSaveList);
            this.Controls.Add(this.dataGridViewPersonList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelShortName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dataGridViewCD);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxOpenFile);
            this.Controls.Add(this.labelOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpenFile;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.DataGridView dataGridViewCD;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelShortName;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.DataGridView dataGridViewPersonList;
        private System.Windows.Forms.Button buttonSaveList;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.RichTextBox richTextBoxRandomCD;
        private System.Windows.Forms.Button buttonAddPresent;
    }
}

