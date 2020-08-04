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
            this.btn_discurso = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button5 = new System.Windows.Forms.Button();
            this.subir_est = new System.Windows.Forms.Button();
            this.Bandera = new System.Windows.Forms.PictureBox();
            this.InterpelacionesRespondidas = new System.Windows.Forms.Label();
            this.InterpelacionesRealizadas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LeyoDiscurso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Asistencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.fefefe = new System.Windows.Forms.Label();
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
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bandera)).BeginInit();
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
            this.panel_principal.Controls.Add(this.btn_discurso);
            this.panel_principal.Controls.Add(this.listView1);
            this.panel_principal.Controls.Add(this.button5);
            this.panel_principal.Controls.Add(this.subir_est);
            this.panel_principal.Controls.Add(this.Bandera);
            this.panel_principal.Controls.Add(this.InterpelacionesRespondidas);
            this.panel_principal.Controls.Add(this.InterpelacionesRealizadas);
            this.panel_principal.Controls.Add(this.label5);
            this.panel_principal.Controls.Add(this.label6);
            this.panel_principal.Controls.Add(this.label7);
            this.panel_principal.Controls.Add(this.LeyoDiscurso);
            this.panel_principal.Controls.Add(this.label4);
            this.panel_principal.Controls.Add(this.Asistencia);
            this.panel_principal.Controls.Add(this.label2);
            this.panel_principal.Controls.Add(this.Nombre);
            this.panel_principal.Controls.Add(this.fefefe);
            this.panel_principal.Location = new System.Drawing.Point(298, 64);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(628, 673);
            this.panel_principal.TabIndex = 1;
            // 
            // btn_discurso
            // 
            this.btn_discurso.BackColor = System.Drawing.SystemColors.Control;
            this.btn_discurso.Location = new System.Drawing.Point(312, 334);
            this.btn_discurso.Name = "btn_discurso";
            this.btn_discurso.Size = new System.Drawing.Size(75, 41);
            this.btn_discurso.TabIndex = 21;
            this.btn_discurso.Text = "Marcar Discurso";
            this.btn_discurso.UseVisualStyleBackColor = false;
            this.btn_discurso.Click += new System.EventHandler(this.MarcarDiscurso);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 381);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 250);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(406, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 41);
            this.button5.TabIndex = 19;
            this.button5.Text = "Valorar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // subir_est
            // 
            this.subir_est.Location = new System.Drawing.Point(406, 161);
            this.subir_est.Name = "subir_est";
            this.subir_est.Size = new System.Drawing.Size(187, 42);
            this.subir_est.TabIndex = 18;
            this.subir_est.Text = "Subir Al Estrado";
            this.subir_est.UseVisualStyleBackColor = true;
            this.subir_est.Click += new System.EventHandler(this.SubirAlEstrado);
            // 
            // Bandera
            // 
            this.Bandera.Location = new System.Drawing.Point(406, 25);
            this.Bandera.Name = "Bandera";
            this.Bandera.Size = new System.Drawing.Size(187, 126);
            this.Bandera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bandera.TabIndex = 17;
            this.Bandera.TabStop = false;
            // 
            // InterpelacionesRespondidas
            // 
            this.InterpelacionesRespondidas.AutoSize = true;
            this.InterpelacionesRespondidas.Location = new System.Drawing.Point(170, 232);
            this.InterpelacionesRespondidas.Name = "InterpelacionesRespondidas";
            this.InterpelacionesRespondidas.Size = new System.Drawing.Size(49, 13);
            this.InterpelacionesRespondidas.TabIndex = 16;
            this.InterpelacionesRespondidas.Text = "Cantidad";
            // 
            // InterpelacionesRealizadas
            // 
            this.InterpelacionesRealizadas.AutoSize = true;
            this.InterpelacionesRealizadas.Location = new System.Drawing.Point(157, 203);
            this.InterpelacionesRealizadas.Name = "InterpelacionesRealizadas";
            this.InterpelacionesRealizadas.Size = new System.Drawing.Size(49, 13);
            this.InterpelacionesRealizadas.TabIndex = 15;
            this.InterpelacionesRealizadas.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Respondidas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Realizadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interpelaciones:";
            // 
            // LeyoDiscurso
            // 
            this.LeyoDiscurso.AutoSize = true;
            this.LeyoDiscurso.Location = new System.Drawing.Point(88, 137);
            this.LeyoDiscurso.Name = "LeyoDiscurso";
            this.LeyoDiscurso.Size = new System.Drawing.Size(71, 13);
            this.LeyoDiscurso.TabIndex = 10;
            this.LeyoDiscurso.Text = "Leido/sin leer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discurso:";
            // 
            // Asistencia
            // 
            this.Asistencia.AutoSize = true;
            this.Asistencia.Location = new System.Drawing.Point(102, 95);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Size = new System.Drawing.Size(93, 13);
            this.Asistencia.TabIndex = 8;
            this.Asistencia.Text = "Presente/Ausente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asistencia:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(88, 57);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(119, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Aca se carga el nombre";
            // 
            // fefefe
            // 
            this.fefefe.AutoSize = true;
            this.fefefe.Location = new System.Drawing.Point(35, 57);
            this.fefefe.Name = "fefefe";
            this.fefefe.Size = new System.Drawing.Size(47, 13);
            this.fefefe.TabIndex = 2;
            this.fefefe.Text = "Nombre:";
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
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bandera)).EndInit();
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
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label fefefe;
        private System.Windows.Forms.Label Asistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LeyoDiscurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label InterpelacionesRespondidas;
        private System.Windows.Forms.Label InterpelacionesRealizadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Bandera;
        private System.Windows.Forms.Button subir_est;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_discurso;
    }
}