namespace GestiónModelo
{
    partial class PantallaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delegaciones = new System.Windows.Forms.ListView();
            this.Delegacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_tempo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel_crono = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_del_Estrado = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Delegaciones);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 768);
            this.panel1.TabIndex = 0;
            // 
            // Delegaciones
            // 
            this.Delegaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Delegacion});
            this.Delegaciones.HideSelection = false;
            this.Delegaciones.Location = new System.Drawing.Point(4, 53);
            this.Delegaciones.Name = "Delegaciones";
            this.Delegaciones.Size = new System.Drawing.Size(206, 686);
            this.Delegaciones.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Delegaciones.TabIndex = 1;
            this.Delegaciones.UseCompatibleStateImageBehavior = false;
            this.Delegaciones.View = System.Windows.Forms.View.SmallIcon;
            this.Delegaciones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Delegaciones_MouseClick);
            // 
            // Delegacion
            // 
            this.Delegacion.Text = "Delegaciones";
            this.Delegacion.Width = 200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_principal.Location = new System.Drawing.Point(231, 64);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(695, 673);
            this.panel_principal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Votar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Incicar etapa de enmiendas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_tempo
            // 
            this.panel_tempo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_tempo.Location = new System.Drawing.Point(932, 138);
            this.panel_tempo.Name = "panel_tempo";
            this.panel_tempo.Size = new System.Drawing.Size(225, 270);
            this.panel_tempo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " INFO ESTRADO";
            // 
            // panel_crono
            // 
            this.panel_crono.Location = new System.Drawing.Point(932, 414);
            this.panel_crono.Name = "panel_crono";
            this.panel_crono.Size = new System.Drawing.Size(225, 323);
            this.panel_crono.TabIndex = 5;
            // 
            // panel_del_Estrado
            // 
            this.panel_del_Estrado.Location = new System.Drawing.Point(932, 28);
            this.panel_del_Estrado.Name = "panel_del_Estrado";
            this.panel_del_Estrado.Size = new System.Drawing.Size(225, 59);
            this.panel_del_Estrado.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(968, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hacer Interpelación";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 749);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel_del_Estrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_crono);
            this.Controls.Add(this.panel_tempo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_principal);
            this.Name = "PantallaPrincipal";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.terminarPrograma);
            this.Load += new System.EventHandler(this.Sesión_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_tempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel_crono;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView Delegaciones;
        private System.Windows.Forms.ColumnHeader Delegacion;
        private System.Windows.Forms.Panel panel_del_Estrado;
        private System.Windows.Forms.Button button4;
    }
}