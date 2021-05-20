
namespace Covid_SE
{
    partial class formRes
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.pboxResultado = new System.Windows.Forms.PictureBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(96, 20);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Resultado:";
            // 
            // pboxResultado
            // 
            this.pboxResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxResultado.Location = new System.Drawing.Point(0, 40);
            this.pboxResultado.Name = "pboxResultado";
            this.pboxResultado.Size = new System.Drawing.Size(540, 337);
            this.pboxResultado.TabIndex = 1;
            this.pboxResultado.TabStop = false;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRes.Location = new System.Drawing.Point(114, 9);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 20);
            this.lbRes.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(187, 398);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "SALIR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // formRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.pboxResultado);
            this.Controls.Add(this.lbResultado);
            this.Name = "formRes";
            this.Text = "RESULTADO";
            this.Load += new System.EventHandler(this.formRes_Load);
            this.Shown += new System.EventHandler(this.formRes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.PictureBox pboxResultado;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Button btnCerrar;
    }
}