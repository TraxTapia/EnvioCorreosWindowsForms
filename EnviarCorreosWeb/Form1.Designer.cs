
namespace EnviarCorreosWeb
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
            System.Windows.Forms.Button btnEnviar;
            this.lblPara = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnEnviar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnEnviar.Location = new System.Drawing.Point(156, 315);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new System.Drawing.Size(377, 50);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPara.Location = new System.Drawing.Point(57, 31);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(48, 21);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(57, 69);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 21);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Asunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensaje";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(156, 28);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(377, 23);
            this.txtPara.TabIndex = 3;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(156, 67);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(377, 23);
            this.txtAsunto.TabIndex = 5;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(156, 101);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(377, 208);
            this.txtMensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblPara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
    }
}

