﻿namespace Jogo_Pedra_Papel_Tesoura
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_pedra = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_tesoura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_player1 = new System.Windows.Forms.PictureBox();
            this.img_cpu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_tesoura);
            this.splitContainer1.Panel2.Controls.Add(this.btn_papel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pedra);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_pedra
            // 
            this.btn_pedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pedra.BackgroundImage")));
            this.btn_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_pedra.Location = new System.Drawing.Point(0, 0);
            this.btn_pedra.Name = "btn_pedra";
            this.btn_pedra.Size = new System.Drawing.Size(213, 163);
            this.btn_pedra.TabIndex = 0;
            this.btn_pedra.UseVisualStyleBackColor = true;
            this.btn_pedra.Click += new System.EventHandler(this.btn_pedra_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_papel.BackgroundImage")));
            this.btn_papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_papel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_papel.Location = new System.Drawing.Point(213, 0);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(213, 163);
            this.btn_papel.TabIndex = 1;
            this.btn_papel.UseVisualStyleBackColor = true;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_tesoura
            // 
            this.btn_tesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tesoura.BackgroundImage")));
            this.btn_tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_tesoura.Location = new System.Drawing.Point(426, 0);
            this.btn_tesoura.Name = "btn_tesoura";
            this.btn_tesoura.Size = new System.Drawing.Size(198, 163);
            this.btn_tesoura.TabIndex = 2;
            this.btn_tesoura.UseVisualStyleBackColor = true;
            this.btn_tesoura.Click += new System.EventHandler(this.btn_tesoura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img_player1);
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_cpu);
            this.groupBox2.Location = new System.Drawing.Point(426, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // img_player1
            // 
            this.img_player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_player1.Location = new System.Drawing.Point(0, 28);
            this.img_player1.Name = "img_player1";
            this.img_player1.Size = new System.Drawing.Size(194, 154);
            this.img_player1.TabIndex = 0;
            this.img_player1.TabStop = false;
            // 
            // img_cpu
            // 
            this.img_cpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_cpu.Location = new System.Drawing.Point(6, 28);
            this.img_cpu.Name = "img_cpu";
            this.img_cpu.Size = new System.Drawing.Size(186, 154);
            this.img_cpu.TabIndex = 1;
            this.img_cpu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel Tesoura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_cpu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_tesoura;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_pedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox img_cpu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox img_player1;
    }
}

