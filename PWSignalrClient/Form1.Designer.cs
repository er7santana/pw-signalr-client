namespace PWSignalrClient
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
            this.conectar_button = new System.Windows.Forms.Button();
            this.server_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado_text = new System.Windows.Forms.TextBox();
            this.limpar_button = new System.Windows.Forms.Button();
            this.desconectar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conectar_button
            // 
            this.conectar_button.Location = new System.Drawing.Point(357, 23);
            this.conectar_button.Name = "conectar_button";
            this.conectar_button.Size = new System.Drawing.Size(131, 49);
            this.conectar_button.TabIndex = 0;
            this.conectar_button.Text = "Conectar";
            this.conectar_button.UseVisualStyleBackColor = true;
            this.conectar_button.Click += new System.EventHandler(this.OnConectarButtonClicked);
            // 
            // server_text
            // 
            this.server_text.Location = new System.Drawing.Point(28, 50);
            this.server_text.Name = "server_text";
            this.server_text.Size = new System.Drawing.Size(304, 22);
            this.server_text.TabIndex = 1;
            this.server_text.Text = "https://localhost:44334";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // resultado_text
            // 
            this.resultado_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultado_text.Location = new System.Drawing.Point(28, 90);
            this.resultado_text.Multiline = true;
            this.resultado_text.Name = "resultado_text";
            this.resultado_text.Size = new System.Drawing.Size(304, 349);
            this.resultado_text.TabIndex = 3;
            // 
            // limpar_button
            // 
            this.limpar_button.Location = new System.Drawing.Point(357, 90);
            this.limpar_button.Name = "limpar_button";
            this.limpar_button.Size = new System.Drawing.Size(131, 50);
            this.limpar_button.TabIndex = 4;
            this.limpar_button.Text = "Limpar";
            this.limpar_button.UseVisualStyleBackColor = true;
            this.limpar_button.Click += new System.EventHandler(this.OnLimparClicked);
            // 
            // desconectar_button
            // 
            this.desconectar_button.Location = new System.Drawing.Point(505, 23);
            this.desconectar_button.Name = "desconectar_button";
            this.desconectar_button.Size = new System.Drawing.Size(131, 49);
            this.desconectar_button.TabIndex = 5;
            this.desconectar_button.Text = "Desconectar";
            this.desconectar_button.UseVisualStyleBackColor = true;
            this.desconectar_button.Click += new System.EventHandler(this.desconectar_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 468);
            this.Controls.Add(this.desconectar_button);
            this.Controls.Add(this.limpar_button);
            this.Controls.Add(this.resultado_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server_text);
            this.Controls.Add(this.conectar_button);
            this.Name = "Form1";
            this.Text = "PW SignalR Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conectar_button;
        private System.Windows.Forms.TextBox server_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultado_text;
        private System.Windows.Forms.Button limpar_button;
        private System.Windows.Forms.Button desconectar_button;
    }
}

