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
            this.filtro = new System.Windows.Forms.ComboBox();
            this.control = new System.Windows.Forms.ListView();
            this.Delegacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Respuestas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buscador = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.filtro);
            this.panel1.Controls.Add(this.control);
            this.panel1.Controls.Add(this.buscador);
            this.panel1.Location = new System.Drawing.Point(12, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 768);
            this.panel1.TabIndex = 0;
            // 
            // filtro
            // 
            this.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtro.FormattingEnabled = true;
            this.filtro.Items.AddRange(new object[] {
            "Todos",
            "Presentes",
            "Sin leer Discurso"});
            this.filtro.Location = new System.Drawing.Point(171, 25);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(105, 21);
            this.filtro.TabIndex = 9;
            this.filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // control
            // 
            this.control.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Delegacion,
            this.Discurso,
            this.Respuestas,
            this.Puntos});
            this.control.HideSelection = false;
            this.control.Location = new System.Drawing.Point(3, 52);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(273, 687);
            this.control.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.control.TabIndex = 1;
            this.control.UseCompatibleStateImageBehavior = false;
            this.control.View = System.Windows.Forms.View.Details;
            this.control.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.control_ColumnClick);
            this.control.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Delegaciones_MouseClick);
            // 
            // Delegacion
            // 
            this.Delegacion.Text = "Delegaciones";
            this.Delegacion.Width = 105;
            // 
            // Discurso
            // 
            this.Discurso.Text = "Discurso";
            this.Discurso.Width = 53;
            // 
            // Respuestas
            // 
            this.Respuestas.Text = "Respuestas";
            this.Respuestas.Width = 69;
            // 
            // Puntos
            // 
            this.Puntos.Text = "Puntos";
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(3, 26);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(162, 20);
            this.buscador.TabIndex = 0;
            this.buscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_principal.Location = new System.Drawing.Point(298, 64);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(628, 673);
            this.panel_principal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Votar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(691, 12);
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
            this.button4.Location = new System.Drawing.Point(967, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "Hacer Interpelación";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.interpelacion_Click);
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
        private System.Windows.Forms.TextBox buscador;
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
        private System.Windows.Forms.ListView control;
        private System.Windows.Forms.ColumnHeader Delegacion;
        private System.Windows.Forms.Panel panel_del_Estrado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox filtro;
        private System.Windows.Forms.ColumnHeader Discurso;
        private System.Windows.Forms.ColumnHeader Respuestas;
        private System.Windows.Forms.ColumnHeader Puntos;
    }
}