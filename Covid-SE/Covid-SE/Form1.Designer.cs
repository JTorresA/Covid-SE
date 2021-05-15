
namespace Covid_SE
{
    partial class Covid_SE
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ckbxFactorial = new System.Windows.Forms.CheckBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ckbxMCD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(46, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conexion Prolog con C#";
            // 
            // ckbxFactorial
            // 
            this.ckbxFactorial.AutoSize = true;
            this.ckbxFactorial.Location = new System.Drawing.Point(12, 60);
            this.ckbxFactorial.Name = "ckbxFactorial";
            this.ckbxFactorial.Size = new System.Drawing.Size(66, 17);
            this.ckbxFactorial.TabIndex = 1;
            this.ckbxFactorial.Text = "Factorial";
            this.ckbxFactorial.UseVisualStyleBackColor = true;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(12, 144);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(303, 108);
            this.lbxOutput.TabIndex = 2;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(12, 104);
            this.tbxInput.MaxLength = 20;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(303, 20);
            this.tbxInput.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 271);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(303, 35);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ckbxMCD
            // 
            this.ckbxMCD.AutoSize = true;
            this.ckbxMCD.Location = new System.Drawing.Point(182, 60);
            this.ckbxMCD.Name = "ckbxMCD";
            this.ckbxMCD.Size = new System.Drawing.Size(133, 17);
            this.ckbxMCD.TabIndex = 5;
            this.ckbxMCD.Text = "Maximo Comun Divisor";
            this.ckbxMCD.UseVisualStyleBackColor = true;
            // 
            // Covid_SE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 320);
            this.Controls.Add(this.ckbxMCD);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.ckbxFactorial);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Covid_SE";
            this.Text = "Covid Sistema Experto";
            this.Load += new System.EventHandler(this.Covid_SE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox ckbxFactorial;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox ckbxMCD;
    }
}

