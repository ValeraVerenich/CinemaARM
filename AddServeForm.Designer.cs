﻿namespace cinemaARM
{
    partial class AddServeForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(106, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 50);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(112, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(112, 152);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 3;
            label2.Text = "Место";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(52, 264);
            label3.MaximumSize = new Size(400, 0);
            label3.MinimumSize = new Size(400, 100);
            label3.Name = "label3";
            label3.Size = new Size(400, 100);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.UseCompatibleTextRendering = true;
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(112, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 50);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(12, 384);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 6;
            button1.Text = "Записать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add_Serve;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(252, 384);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 7;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddServeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AddServeForm";
            Text = "AddServeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}