﻿namespace Banco
{
    partial class Menu
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_Illustration_Money_Talk_Podcast_Logo_removebg_preview;
            pictureBox1.Location = new Point(283, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 116);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu principal";
            // 
            // button1
            // 
            button1.Location = new Point(188, 162);
            button1.Name = "button1";
            button1.Size = new Size(299, 23);
            button1.TabIndex = 7;
            button1.Text = "Depositar dinero";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 200);
            button2.Name = "button2";
            button2.Size = new Size(299, 23);
            button2.TabIndex = 8;
            button2.Text = "Retirar dinero";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(188, 237);
            button3.Name = "button3";
            button3.Size = new Size(299, 23);
            button3.TabIndex = 9;
            button3.Text = "Comprobar estado de cuenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(249, 350);
            button4.Name = "button4";
            button4.Size = new Size(176, 29);
            button4.TabIndex = 12;
            button4.Text = "Cerrar sesión";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(188, 312);
            button5.Name = "button5";
            button5.Size = new Size(299, 23);
            button5.TabIndex = 11;
            button5.Text = "Registrar nuevo cliente";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(188, 274);
            button6.Name = "button6";
            button6.Size = new Size(299, 23);
            button6.TabIndex = 10;
            button6.Text = "Transferir fondos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 419);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(283, 16);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}