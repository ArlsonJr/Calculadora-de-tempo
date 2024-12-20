namespace Calculadora_de_tempo
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
            panel1 = new Panel();
            nS2 = new NumericUpDown();
            nM2 = new NumericUpDown();
            nH2 = new NumericUpDown();
            nS1 = new NumericUpDown();
            nM1 = new NumericUpDown();
            nH1 = new NumericUpDown();
            label9 = new Label();
            btnGuardar = new Button();
            label7 = new Label();
            label8 = new Label();
            txtSResult = new TextBox();
            txtMResult = new TextBox();
            txtHResult = new TextBox();
            btnResetar = new Button();
            btnSomar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nS2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nM2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nH2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nS1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nM1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nH1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(nS2);
            panel1.Controls.Add(nM2);
            panel1.Controls.Add(nH2);
            panel1.Controls.Add(nS1);
            panel1.Controls.Add(nM1);
            panel1.Controls.Add(nH1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtSResult);
            panel1.Controls.Add(txtMResult);
            panel1.Controls.Add(txtHResult);
            panel1.Controls.Add(btnResetar);
            panel1.Controls.Add(btnSomar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 416);
            panel1.TabIndex = 0;
            // 
            // nS2
            // 
            nS2.Location = new Point(478, 113);
            nS2.Name = "nS2";
            nS2.Size = new Size(100, 31);
            nS2.TabIndex = 10;
            // 
            // nM2
            // 
            nM2.Location = new Point(272, 113);
            nM2.Name = "nM2";
            nM2.Size = new Size(100, 31);
            nM2.TabIndex = 8;
            // 
            // nH2
            // 
            nH2.Location = new Point(66, 113);
            nH2.Name = "nH2";
            nH2.Size = new Size(100, 31);
            nH2.TabIndex = 6;
            // 
            // nS1
            // 
            nS1.Location = new Point(478, 34);
            nS1.Name = "nS1";
            nS1.Size = new Size(100, 31);
            nS1.TabIndex = 4;
            // 
            // nM1
            // 
            nM1.Location = new Point(272, 34);
            nM1.Name = "nM1";
            nM1.Size = new Size(100, 31);
            nM1.TabIndex = 2;
            // 
            // nH1
            // 
            nH1.Location = new Point(66, 34);
            nH1.Name = "nH1";
            nH1.Size = new Size(100, 31);
            nH1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(583, 275);
            label9.Name = "label9";
            label9.Size = new Size(20, 25);
            label9.TabIndex = 19;
            label9.Text = "s";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(278, 347);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 275);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 17;
            label7.Text = "m";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(171, 275);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 15;
            label8.Text = "h";
            // 
            // txtSResult
            // 
            txtSResult.Location = new Point(483, 272);
            txtSResult.Name = "txtSResult";
            txtSResult.ReadOnly = true;
            txtSResult.Size = new Size(100, 31);
            txtSResult.TabIndex = 18;
            // 
            // txtMResult
            // 
            txtMResult.Location = new Point(277, 272);
            txtMResult.Name = "txtMResult";
            txtMResult.ReadOnly = true;
            txtMResult.Size = new Size(100, 31);
            txtMResult.TabIndex = 16;
            // 
            // txtHResult
            // 
            txtHResult.Location = new Point(71, 272);
            txtHResult.Name = "txtHResult";
            txtHResult.ReadOnly = true;
            txtHResult.Size = new Size(100, 31);
            txtHResult.TabIndex = 14;
            // 
            // btnResetar
            // 
            btnResetar.Location = new Point(359, 197);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(112, 34);
            btnResetar.TabIndex = 13;
            btnResetar.Text = "Limpar";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += btnResetar_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(198, 197);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(112, 34);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 113);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 11;
            label6.Text = "s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 34);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 5;
            label5.Text = "s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 113);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 9;
            label4.Text = "m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 34);
            label3.Name = "label3";
            label3.Size = new Size(28, 25);
            label3.TabIndex = 3;
            label3.Text = "m";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 113);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 7;
            label2.Text = "h";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 34);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 1;
            label1.Text = "h";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 416);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculadora do Arlson";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nS2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nM2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nH2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nS1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nM1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nH1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnResetar;
        private Button btnSomar;
        private Label label9;
        private Button btnGuardar;
        private Label label7;
        private Label label8;
        private TextBox txtSResult;
        private TextBox txtMResult;
        private TextBox txtHResult;
        private NumericUpDown nS2;
        private NumericUpDown nM2;
        private NumericUpDown nH2;
        private NumericUpDown nS1;
        private NumericUpDown nM1;
        private NumericUpDown nH1;
    }
}
