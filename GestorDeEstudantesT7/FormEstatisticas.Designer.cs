namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelTotalDeEstudantes.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeEstudantes
            // 
            this.panelTotalDeEstudantes.BackColor = System.Drawing.Color.HotPink;
            this.panelTotalDeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.panelTotalDeEstudantes.Location = new System.Drawing.Point(12, 3);
            this.panelTotalDeEstudantes.Name = "panelTotalDeEstudantes";
            this.panelTotalDeEstudantes.Size = new System.Drawing.Size(776, 184);
            this.panelTotalDeEstudantes.TabIndex = 0;
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.AutoSize = true;
            this.labelTotalDeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(259, 77);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(313, 31);
            this.labelTotalDeEstudantes.TabIndex = 0;
            this.labelTotalDeEstudantes.Text = "Total de estudantes: 999";
            this.labelTotalDeEstudantes.Click += new System.EventHandler(this.labelTotalDeEstudantes_Click);
            this.labelTotalDeEstudantes.MouseEnter += new System.EventHandler(this.labelTotalDeEstudantes_MouseEnter);
            this.labelTotalDeEstudantes.MouseLeave += new System.EventHandler(this.labelTotalDeEstudantes_MouseLeave);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.Cyan;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(416, 193);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(372, 223);
            this.panelMeninas.TabIndex = 1;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(107, 101);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(185, 31);
            this.labelMeninas.TabIndex = 1;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.Click += new System.EventHandler(this.labelMeninas_Click);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.GreenYellow;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(12, 193);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(382, 223);
            this.panelMeninos.TabIndex = 1;
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(92, 101);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(185, 31);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.Click += new System.EventHandler(this.labelMeninos_Click);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelTotalDeEstudantes);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotalDeEstudantes.ResumeLayout(false);
            this.panelTotalDeEstudantes.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalDeEstudantes;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
    }
}