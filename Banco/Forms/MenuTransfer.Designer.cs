namespace Banco
{
    partial class MenuTransfer
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(296, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(311, 16);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(296, 274);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(311, 16);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(296, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 16);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(296, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 16);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(296, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 16);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(78, 307);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 10;
            label6.Text = "Monto a transferir:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 266);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 9;
            label5.Text = "DUI de cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 226);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 8;
            label4.Text = "Nombre del recibidor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 191);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 7;
            label3.Text = "Cuenta destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 158);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 6;
            label2.Text = "Cuenta origen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 110);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 5;
            label1.Text = "Transferencia entre cuentas";
            // 
            // button2
            // 
            button2.Location = new Point(400, 358);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 12;
            button2.Text = "Transferir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(161, 358);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 11;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_Illustration_Money_Talk_Podcast_Logo_removebg_preview;
            pictureBox1.Location = new Point(296, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // MenuTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 413);
            ControlBox = false;
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuTransfer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tranferir dinero";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}