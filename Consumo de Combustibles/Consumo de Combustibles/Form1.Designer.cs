namespace Consumo_de_Combustibles
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
            button1 = new Button();
            txtdistancia = new TextBox();
            txtrendimiento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(681, 51);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 54);
            label1.TabIndex = 0;
            label1.Text = "Consumo de Combustible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(67, 193);
            label2.Name = "label2";
            label2.Size = new Size(226, 28);
            label2.TabIndex = 1;
            label2.Text = "Distancia Recorrida (KM)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(612, 193);
            label3.Name = "label3";
            label3.Size = new Size(191, 28);
            label3.TabIndex = 2;
            label3.Text = "Rendimiento (Km/G)";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(394, 482);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtdistancia
            // 
            txtdistancia.BackColor = SystemColors.InactiveCaption;
            txtdistancia.Location = new Point(67, 241);
            txtdistancia.Name = "txtdistancia";
            txtdistancia.Size = new Size(266, 61);
            txtdistancia.TabIndex = 4;
            // 
            // txtrendimiento
            // 
            txtrendimiento.BackColor = SystemColors.InactiveCaption;
            txtrendimiento.Location = new Point(612, 241);
            txtrendimiento.Name = "txtrendimiento";
            txtrendimiento.Size = new Size(266, 61);
            txtrendimiento.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(2564, 1570);
            Controls.Add(txtrendimiento);
            Controls.Add(txtdistancia);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtdistancia;
        private TextBox txtrendimiento;
    }
}
