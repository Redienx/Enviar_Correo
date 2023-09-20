namespace EnvioCorreo
{
    partial class fmrEnvioCorreo
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblEnviarPara = new System.Windows.Forms.Label();
            this.lblArchivos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtEmailPara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(24, 129);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(62, 16);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(24, 76);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(51, 16);
            this.lblAsunto.TabIndex = 18;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblEnviarPara
            // 
            this.lblEnviarPara.AutoSize = true;
            this.lblEnviarPara.Location = new System.Drawing.Point(24, 26);
            this.lblEnviarPara.Name = "lblEnviarPara";
            this.lblEnviarPara.Size = new System.Drawing.Size(59, 16);
            this.lblEnviarPara.TabIndex = 17;
            this.lblEnviarPara.Text = "Enviar a:";
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.Location = new System.Drawing.Point(122, 344);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(16, 16);
            this.lblArchivos.TabIndex = 16;
            this.lblArchivos.Text = "...";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(122, 317);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(116, 16);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Archivos adjuntos:";
            // 
            // btnArchivos
            // 
            this.btnArchivos.Location = new System.Drawing.Point(125, 458);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(164, 25);
            this.btnArchivos.TabIndex = 14;
            this.btnArchivos.Text = "Adjuntar archivos";
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(443, 458);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(125, 126);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(393, 177);
            this.txtMensaje.TabIndex = 12;
            this.txtMensaje.Text = "";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(125, 76);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(393, 22);
            this.txtAsunto.TabIndex = 11;
            // 
            // txtEmailPara
            // 
            this.txtEmailPara.Location = new System.Drawing.Point(125, 26);
            this.txtEmailPara.Name = "txtEmailPara";
            this.txtEmailPara.Size = new System.Drawing.Size(393, 22);
            this.txtEmailPara.TabIndex = 10;
            // 
            // fmrEnvioCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 509);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblEnviarPara);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnArchivos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtEmailPara);
            this.Name = "fmrEnvioCorreo";
            this.Text = "Envio de Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblEnviarPara;
        private System.Windows.Forms.Label lblArchivos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtEmailPara;
    }
}

