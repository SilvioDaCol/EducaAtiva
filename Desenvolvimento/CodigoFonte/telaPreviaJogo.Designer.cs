﻿namespace gameLearning
{
    partial class telaPreviaJogo
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
            this.imagemPrevia1 = new System.Windows.Forms.PictureBox();
            this.logoJogo = new System.Windows.Forms.PictureBox();
            this.nomeJogo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imagemPrevia2 = new System.Windows.Forms.PictureBox();
            this.descricaoJogo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPrevia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPrevia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemPrevia1
            // 
            this.imagemPrevia1.Location = new System.Drawing.Point(12, 11);
            this.imagemPrevia1.MaximumSize = new System.Drawing.Size(400, 250);
            this.imagemPrevia1.Name = "imagemPrevia1";
            this.imagemPrevia1.Size = new System.Drawing.Size(400, 250);
            this.imagemPrevia1.TabIndex = 0;
            this.imagemPrevia1.TabStop = false;
            // 
            // logoJogo
            // 
            this.logoJogo.Location = new System.Drawing.Point(510, 81);
            this.logoJogo.MaximumSize = new System.Drawing.Size(180, 180);
            this.logoJogo.Name = "logoJogo";
            this.logoJogo.Size = new System.Drawing.Size(180, 180);
            this.logoJogo.TabIndex = 3;
            this.logoJogo.TabStop = false;
            // 
            // nomeJogo
            // 
            this.nomeJogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeJogo.AutoSize = true;
            this.nomeJogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeJogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeJogo.Location = new System.Drawing.Point(456, 12);
            this.nomeJogo.MaximumSize = new System.Drawing.Size(300, 40);
            this.nomeJogo.Name = "nomeJogo";
            this.nomeJogo.Size = new System.Drawing.Size(283, 39);
            this.nomeJogo.TabIndex = 4;
            this.nomeJogo.Text = "NOME DO JOGO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(770, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(400, 604);
            this.dataGridView1.TabIndex = 5;
            // 
            // imagemPrevia2
            // 
            this.imagemPrevia2.Location = new System.Drawing.Point(12, 366);
            this.imagemPrevia2.MaximumSize = new System.Drawing.Size(400, 250);
            this.imagemPrevia2.Name = "imagemPrevia2";
            this.imagemPrevia2.Size = new System.Drawing.Size(400, 250);
            this.imagemPrevia2.TabIndex = 6;
            this.imagemPrevia2.TabStop = false;
            // 
            // descricaoJogo
            // 
            this.descricaoJogo.Location = new System.Drawing.Point(418, 366);
            this.descricaoJogo.Name = "descricaoJogo";
            this.descricaoJogo.Size = new System.Drawing.Size(346, 250);
            this.descricaoJogo.TabIndex = 7;
            this.descricaoJogo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::gameLearning.Properties.Resources.btnJogar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(534, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 68);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::gameLearning.Properties.Resources.btnVoltar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(144, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 68);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // telaPreviaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gameLearning.Properties.Resources.mainBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descricaoJogo);
            this.Controls.Add(this.imagemPrevia2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeJogo);
            this.Controls.Add(this.logoJogo);
            this.Controls.Add(this.imagemPrevia1);
            this.Name = "telaPreviaJogo";
            this.Text = "telaPreviaJogo";
            ((System.ComponentModel.ISupportInitialize)(this.imagemPrevia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPrevia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemPrevia1;
        private System.Windows.Forms.PictureBox logoJogo;
        private System.Windows.Forms.Label nomeJogo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imagemPrevia2;
        private System.Windows.Forms.RichTextBox descricaoJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}