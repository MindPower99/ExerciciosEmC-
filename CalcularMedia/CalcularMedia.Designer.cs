namespace CalculoDeMedia
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(135, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular média";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite as respectivas notas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1º Bimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2º Bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3º Bimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "4º Bimestre";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(130, 49);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(44, 20);
            this.txtn1.TabIndex = 6;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(130, 112);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(44, 20);
            this.txtn2.TabIndex = 7;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(246, 49);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(44, 20);
            this.txtn3.TabIndex = 8;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(246, 112);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(44, 20);
            this.txtn4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sua média anual é: ";
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(198, 260);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(63, 20);
            this.txtmedia.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(135, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 307);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Cálculo de Média Anual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Button btnLimpar;
    }
}

