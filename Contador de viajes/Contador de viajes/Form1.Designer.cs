﻿namespace Contador_de_viajes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtPtoInicio = new TextBox();
            txtPtoFinal = new TextBox();
            txtvmedia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 113);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "Contador de Viajes ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 214);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Punto de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 350);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 2;
            label3.Text = "Punto destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 543);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 3;
            label4.Text = "Velocidad media ";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(441, 705);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPtoInicio
            // 
            txtPtoInicio.BackColor = SystemColors.Info;
            txtPtoInicio.Location = new Point(403, 214);
            txtPtoInicio.Name = "txtPtoInicio";
            txtPtoInicio.Size = new Size(150, 31);
            txtPtoInicio.TabIndex = 5;
            // 
            // txtPtoFinal
            // 
            txtPtoFinal.BackColor = SystemColors.Info;
            txtPtoFinal.Location = new Point(403, 344);
            txtPtoFinal.Name = "txtPtoFinal";
            txtPtoFinal.Size = new Size(150, 31);
            txtPtoFinal.TabIndex = 6;
            // 
            // txtvmedia
            // 
            txtvmedia.BackColor = SystemColors.Info;
            txtvmedia.Location = new Point(403, 537);
            txtvmedia.Name = "txtvmedia";
            txtvmedia.Size = new Size(150, 31);
            txtvmedia.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1793, 957);
            Controls.Add(txtvmedia);
            Controls.Add(txtPtoFinal);
            Controls.Add(txtPtoInicio);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtPtoInicio;
        private TextBox txtPtoFinal;
        private TextBox txtvmedia;
    }
}
