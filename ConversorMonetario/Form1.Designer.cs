namespace ConversorMonetario
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
            btnConverter = new Button();
            txtValor = new TextBox();
            label1 = new Label();
            txtDolar = new TextBox();
            txtLibras = new TextBox();
            txtEuro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(315, 46);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += button1_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(195, 47);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 50);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor a ser convertido:";
            label1.Click += label1_Click;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(195, 87);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 3;
            // 
            // txtLibras
            // 
            txtLibras.Location = new Point(195, 128);
            txtLibras.Name = "txtLibras";
            txtLibras.Size = new Size(100, 23);
            txtLibras.TabIndex = 4;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(195, 166);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 90);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor em Dólar";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 131);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor em Libras Esterlinas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 166);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor em Euro";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(315, 90);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 229);
            Controls.Add(btnLimpar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEuro);
            Controls.Add(txtLibras);
            Controls.Add(txtDolar);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(btnConverter);
            Name = "Form1";
            ShowIcon = false;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private TextBox txtValor;
        private Label label1;
        private TextBox txtDolar;
        private TextBox txtLibras;
        private TextBox txtEuro;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLimpar;
    }
}