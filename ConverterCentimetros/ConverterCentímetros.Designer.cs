namespace ConverterCent
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtCent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMili = new System.Windows.Forms.Label();
            this.lblDeci = new System.Windows.Forms.Label();
            this.txtMili = new System.Windows.Forms.TextBox();
            this.txtDeci = new System.Windows.Forms.TextBox();
            this.lblMetros = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(84, 103);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter..";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtCent
            // 
            this.txtCent.Location = new System.Drawing.Point(165, 43);
            this.txtCent.Name = "txtCent";
            this.txtCent.Size = new System.Drawing.Size(100, 20);
            this.txtCent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Valor em Centímetros";
            // 
            // lblMili
            // 
            this.lblMili.AutoSize = true;
            this.lblMili.Location = new System.Drawing.Point(101, 162);
            this.lblMili.Name = "lblMili";
            this.lblMili.Size = new System.Drawing.Size(58, 13);
            this.lblMili.TabIndex = 3;
            this.lblMili.Text = "Milímetros:";
            // 
            // lblDeci
            // 
            this.lblDeci.AutoSize = true;
            this.lblDeci.Location = new System.Drawing.Point(94, 200);
            this.lblDeci.Name = "lblDeci";
            this.lblDeci.Size = new System.Drawing.Size(65, 13);
            this.lblDeci.TabIndex = 4;
            this.lblDeci.Text = "Decímetros:";
            // 
            // txtMili
            // 
            this.txtMili.Location = new System.Drawing.Point(165, 159);
            this.txtMili.Name = "txtMili";
            this.txtMili.Size = new System.Drawing.Size(100, 20);
            this.txtMili.TabIndex = 5;
            // 
            // txtDeci
            // 
            this.txtDeci.Location = new System.Drawing.Point(165, 197);
            this.txtDeci.Name = "txtDeci";
            this.txtDeci.Size = new System.Drawing.Size(100, 20);
            this.txtDeci.TabIndex = 6;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(117, 240);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(42, 13);
            this.lblMetros.TabIndex = 7;
            this.lblMetros.Text = "Metros:";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(165, 237);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 20);
            this.txtMetros.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(179, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.txtDeci);
            this.Controls.Add(this.txtMili);
            this.Controls.Add(this.lblDeci);
            this.Controls.Add(this.lblMili);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCent);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Converter Centímetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtCent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Label lblDeci;
        private System.Windows.Forms.TextBox txtMili;
        private System.Windows.Forms.TextBox txtDeci;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Button btnLimpar;
    }
}

