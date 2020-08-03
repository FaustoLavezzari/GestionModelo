namespace GestiónModelo
{
    partial class Interpelacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmar_interpelacion = new System.Windows.Forms.Button();
            this.del_interpeladora = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Delegación que \r realiza la interpelacion";
            // 
            // confirmar_interpelacion
            // 
            this.confirmar_interpelacion.Location = new System.Drawing.Point(54, 96);
            this.confirmar_interpelacion.Name = "confirmar_interpelacion";
            this.confirmar_interpelacion.Size = new System.Drawing.Size(75, 23);
            this.confirmar_interpelacion.TabIndex = 2;
            this.confirmar_interpelacion.Text = "Ok";
            this.confirmar_interpelacion.UseVisualStyleBackColor = true;
            this.confirmar_interpelacion.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // del_interpeladora
            // 
            this.del_interpeladora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.del_interpeladora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.del_interpeladora.FormattingEnabled = true;
            this.del_interpeladora.Location = new System.Drawing.Point(12, 48);
            this.del_interpeladora.Name = "del_interpeladora";
            this.del_interpeladora.Size = new System.Drawing.Size(160, 21);
            this.del_interpeladora.Sorted = true;
            this.del_interpeladora.TabIndex = 3;
            // 
            // Interpelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 131);
            this.Controls.Add(this.del_interpeladora);
            this.Controls.Add(this.confirmar_interpelacion);
            this.Controls.Add(this.label1);
            this.Name = "Interpelacion";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar_interpelacion;
        private System.Windows.Forms.ComboBox del_interpeladora;
    }
}