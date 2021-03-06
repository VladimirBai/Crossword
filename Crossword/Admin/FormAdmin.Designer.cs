﻿namespace Crossword
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.buttonOpenCreateCros = new System.Windows.Forms.Button();
            this.buttonOpenEditCros = new System.Windows.Forms.Button();
            this.buttonOpenCreateDict = new System.Windows.Forms.Button();
            this.buttonOpenEditDict = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenCreateCros
            // 
            this.buttonOpenCreateCros.Location = new System.Drawing.Point(12, 56);
            this.buttonOpenCreateCros.Name = "buttonOpenCreateCros";
            this.buttonOpenCreateCros.Size = new System.Drawing.Size(194, 23);
            this.buttonOpenCreateCros.TabIndex = 0;
            this.buttonOpenCreateCros.Text = "Создать кроссворд";
            this.buttonOpenCreateCros.UseVisualStyleBackColor = true;
            this.buttonOpenCreateCros.Click += new System.EventHandler(this.buttonOpenCreateCros_Click);
            // 
            // buttonOpenEditCros
            // 
            this.buttonOpenEditCros.Location = new System.Drawing.Point(12, 95);
            this.buttonOpenEditCros.Name = "buttonOpenEditCros";
            this.buttonOpenEditCros.Size = new System.Drawing.Size(194, 23);
            this.buttonOpenEditCros.TabIndex = 1;
            this.buttonOpenEditCros.Text = "Редактировать кроссворд";
            this.buttonOpenEditCros.UseVisualStyleBackColor = true;
            this.buttonOpenEditCros.Click += new System.EventHandler(this.buttonOpenEditCros_Click);
            // 
            // buttonOpenCreateDict
            // 
            this.buttonOpenCreateDict.Location = new System.Drawing.Point(12, 135);
            this.buttonOpenCreateDict.Name = "buttonOpenCreateDict";
            this.buttonOpenCreateDict.Size = new System.Drawing.Size(194, 23);
            this.buttonOpenCreateDict.TabIndex = 2;
            this.buttonOpenCreateDict.Text = "Создать словарь понятий";
            this.buttonOpenCreateDict.UseVisualStyleBackColor = true;
            this.buttonOpenCreateDict.Click += new System.EventHandler(this.buttonOpenCreateDict_Click);
            // 
            // buttonOpenEditDict
            // 
            this.buttonOpenEditDict.Location = new System.Drawing.Point(12, 177);
            this.buttonOpenEditDict.Name = "buttonOpenEditDict";
            this.buttonOpenEditDict.Size = new System.Drawing.Size(194, 23);
            this.buttonOpenEditDict.TabIndex = 3;
            this.buttonOpenEditDict.Text = "Редактировать словарь понятий";
            this.buttonOpenEditDict.UseVisualStyleBackColor = true;
            this.buttonOpenEditDict.Click += new System.EventHandler(this.buttonOpenEditDict_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(71, 220);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Выйти";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(166, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpenEditDict);
            this.Controls.Add(this.buttonOpenCreateDict);
            this.Controls.Add(this.buttonOpenEditCros);
            this.Controls.Add(this.buttonOpenCreateCros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "РЕЖИМ АДМИНИСТРАТОРА";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenCreateCros;
        private System.Windows.Forms.Button buttonOpenEditCros;
        private System.Windows.Forms.Button buttonOpenCreateDict;
        private System.Windows.Forms.Button buttonOpenEditDict;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
    }
}