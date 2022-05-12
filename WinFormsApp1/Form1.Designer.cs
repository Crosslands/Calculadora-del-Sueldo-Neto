namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SueldoNeto = new System.Windows.Forms.Label();
            this.NetSalary = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-55, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE DECONTADO SOBRE SALARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextSalario
            // 
            this.TextSalario.Location = new System.Drawing.Point(36, 65);
            this.TextSalario.Name = "TextSalario";
            this.TextSalario.Size = new System.Drawing.Size(371, 23);
            this.TextSalario.TabIndex = 1;
            this.TextSalario.TextChanged += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salario bruto del empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.AutoSize = true;
            this.SueldoNeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SueldoNeto.Location = new System.Drawing.Point(36, 105);
            this.SueldoNeto.Name = "SueldoNeto";
            this.SueldoNeto.Size = new System.Drawing.Size(73, 15);
            this.SueldoNeto.TabIndex = 3;
            this.SueldoNeto.Text = "Salario neto";
            // 
            // NetSalary
            // 
            this.NetSalary.AutoSize = true;
            this.NetSalary.ForeColor = System.Drawing.Color.Green;
            this.NetSalary.Location = new System.Drawing.Point(36, 132);
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.Size = new System.Drawing.Size(45, 15);
            this.NetSalary.TabIndex = 6;
            this.NetSalary.Text = "00.00$";
            this.NetSalary.Click += new System.EventHandler(this.NetSalary_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(36, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "00.00$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decontacion AFP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(36, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "00.00$";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Decontacion ARS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(111, 281);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(282, 76);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "CALCULAR";
            this.Calculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Decontacion IRS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(36, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "00.00$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NetSalary);
            this.Controls.Add(this.SueldoNeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TextSalario;
        private Label label2;
        private Label SueldoNeto;
        private Label NetSalary;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button Calculate;
        private Label label3;
        private Label label4;
    }
}