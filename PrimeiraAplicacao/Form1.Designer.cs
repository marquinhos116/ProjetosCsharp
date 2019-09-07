namespace PrimeiraAplicacao
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
            this.Btn_Executar = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Executar
            // 
            this.Btn_Executar.Location = new System.Drawing.Point(394, 280);
            this.Btn_Executar.Name = "Btn_Executar";
            this.Btn_Executar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Executar.TabIndex = 0;
            this.Btn_Executar.Text = "Executar";
            this.Btn_Executar.UseVisualStyleBackColor = true;
            this.Btn_Executar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.Location = new System.Drawing.Point(29, 69);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(484, 23);
            this.caixa_texto.TabIndex = 1;
            this.caixa_texto.Text = "Texto de Exemplo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 321);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.Btn_Executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Executar;
        private System.Windows.Forms.Label caixa_texto;
    }
}

