namespace GestiónModelo
{
    partial class Cronometro
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
            this.components = new System.ComponentModel.Container();
            this.titulo = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Label();
            this.comenzar = new System.Windows.Forms.Button();
            this.pausar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetear = new System.Windows.Forms.Button();
            this.panel_prom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(6, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(214, 25);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Tiempo en el estrado";
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(12, 48);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(200, 76);
            this.reloj.TabIndex = 1;
            this.reloj.Text = "00:00";
            // 
            // comenzar
            // 
            this.comenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenzar.Location = new System.Drawing.Point(12, 133);
            this.comenzar.Name = "comenzar";
            this.comenzar.Size = new System.Drawing.Size(63, 37);
            this.comenzar.TabIndex = 2;
            this.comenzar.Text = "Start";
            this.comenzar.UseVisualStyleBackColor = true;
            this.comenzar.Click += new System.EventHandler(this.comenzar_Click);
            // 
            // pausar
            // 
            this.pausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausar.Location = new System.Drawing.Point(81, 133);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(63, 37);
            this.pausar.TabIndex = 3;
            this.pausar.Text = "Pause";
            this.pausar.UseVisualStyleBackColor = true;
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetear
            // 
            this.resetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetear.Location = new System.Drawing.Point(149, 133);
            this.resetear.Name = "resetear";
            this.resetear.Size = new System.Drawing.Size(63, 37);
            this.resetear.TabIndex = 4;
            this.resetear.Text = "Reset";
            this.resetear.UseVisualStyleBackColor = true;
            this.resetear.Click += new System.EventHandler(this.resetear_Click);
            // 
            // panel_prom
            // 
            this.panel_prom.Location = new System.Drawing.Point(1, 176);
            this.panel_prom.Name = "panel_prom";
            this.panel_prom.Size = new System.Drawing.Size(225, 129);
            this.panel_prom.TabIndex = 5;
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 317);
            this.Controls.Add(this.panel_prom);
            this.Controls.Add(this.resetear);
            this.Controls.Add(this.pausar);
            this.Controls.Add(this.comenzar);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cronometro";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Button comenzar;
        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetear;
        private System.Windows.Forms.Panel panel_prom;
    }
}