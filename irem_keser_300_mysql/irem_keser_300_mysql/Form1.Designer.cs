﻿namespace irem_keser_300_mysql
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnElestiriFrom = new System.Windows.Forms.Button();
            this.btnFilmElestiri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(12, 243);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.Size = new System.Drawing.Size(562, 160);
            this.dgwFilmler.TabIndex = 0;
            // 
            // btnElestiriFrom
            // 
            this.btnElestiriFrom.Location = new System.Drawing.Point(30, 150);
            this.btnElestiriFrom.Name = "btnElestiriFrom";
            this.btnElestiriFrom.Size = new System.Drawing.Size(109, 54);
            this.btnElestiriFrom.TabIndex = 1;
            this.btnElestiriFrom.Text = "eleştiriler";
            this.btnElestiriFrom.UseVisualStyleBackColor = true;
            this.btnElestiriFrom.Click += new System.EventHandler(this.btnElestiriFrom_Click);
            // 
            // btnFilmElestiri
            // 
            this.btnFilmElestiri.Location = new System.Drawing.Point(414, 150);
            this.btnFilmElestiri.Name = "btnFilmElestiri";
            this.btnFilmElestiri.Size = new System.Drawing.Size(109, 54);
            this.btnFilmElestiri.TabIndex = 2;
            this.btnFilmElestiri.Text = "film eleştiri";
            this.btnFilmElestiri.UseVisualStyleBackColor = true;
            this.btnFilmElestiri.Click += new System.EventHandler(this.btnFilmElestiri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 415);
            this.Controls.Add(this.btnFilmElestiri);
            this.Controls.Add(this.btnElestiriFrom);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnElestiriFrom;
        private System.Windows.Forms.Button btnFilmElestiri;
    }
}

