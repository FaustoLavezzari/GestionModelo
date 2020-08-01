namespace GestiónModelo
{
    partial class CreadorDeSesion
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
            this.clean = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.TextBox();
            this.SeleccionarTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionadorDePaises = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AñadirDelegacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DelegacionesAñadidas = new System.Windows.Forms.ListBox();
            this.NombreDelegacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AñadirTopico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TopicosAñadidos = new System.Windows.Forms.ListBox();
            this.NombreTopico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearSesion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.clean);
            this.panel1.Controls.Add(this.buscador);
            this.panel1.Controls.Add(this.SeleccionarTodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.seleccionadorDePaises);
            this.panel1.Location = new System.Drawing.Point(25, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 454);
            this.panel1.TabIndex = 0;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(213, 34);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(104, 23);
            this.clean.TabIndex = 7;
            this.clean.Text = "Borrar todo";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Visible = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // buscador
            // 
            this.buscador.AutoCompleteCustomSource.AddRange(new string[] {
            "Afganistan",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyan",
            "Bahamas",
            "Bahrein",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgica",
            "Belice",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botswana",
            "Brasil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Camboya",
            "Camerun",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "Congo",
            "Costa Rica",
            "Costa de Marfil",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Djibouti",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Arabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos de America",
            "Estonia",
            "Eswatini",
            "Etiopia",
            "Rusia",
            "Fiji",
            "Filipinas",
            "Finlandia",
            "Francia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guinea Ecuatorial",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungria",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomon",
            "Israel",
            "Italia",
            "Jamaica",
            "Japon",
            "Jordania",
            "Kazajstan",
            "Kenya",
            "Kirguistan",
            "Kiribati",
            "Kuwait",
            "Lesotho",
            "Letonia",
            "Libano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malawi",
            "Maldivas",
            "Mali",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mexico",
            "Micronesia",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Noruega",
            "Nueva Zelandia",
            "Oman",
            "Paises Bajos",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua Nueva Guinea",
            "Paraguay",
            "Peru",
            "Polonia",
            "Portugal",
            "Qatar",
            "Reino Unido de Gran Bretaña e Irlanda del Norte",
            "Siria",
            "Republica Centroafricana",
            "Republica Checa",
            "Republica de Corea",
            "Republica de Moldova",
            "República Democratica del Congo",
            "República Democratica Popular Lao",
            "Republica Dominicana",
            "Republica Popular Democratica de Corea",
            "Republica Unida de Tanzania",
            "Rumania",
            "Rwanda",
            "Saint Kitts y Nevis",
            "Samoa",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucia",
            "Santo Tome y Principe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Somalia",
            "Sri Lanka",
            "Sudafrica",
            "Sudan",
            "Sudan del Sur",
            "Suecia",
            "Suiza",
            "Suriname",
            "Tailandia",
            "Tayikistan",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Tunez",
            "Turkmenistan",
            "Turquia",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.buscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.buscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.buscador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buscador.Location = new System.Drawing.Point(38, 34);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(169, 20);
            this.buscador.TabIndex = 4;
            this.buscador.TextChanged += new System.EventHandler(this.buscador_TextChanged);
            // 
            // SeleccionarTodo
            // 
            this.SeleccionarTodo.Location = new System.Drawing.Point(213, 34);
            this.SeleccionarTodo.Name = "SeleccionarTodo";
            this.SeleccionarTodo.Size = new System.Drawing.Size(104, 23);
            this.SeleccionarTodo.TabIndex = 3;
            this.SeleccionarTodo.Text = "seleccionar todo";
            this.SeleccionarTodo.UseVisualStyleBackColor = true;
            this.SeleccionarTodo.Click += new System.EventHandler(this.SeleccionarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delegaciones";
            // 
            // seleccionadorDePaises
            // 
            this.seleccionadorDePaises.CheckOnClick = true;
            this.seleccionadorDePaises.FormattingEnabled = true;
            this.seleccionadorDePaises.Location = new System.Drawing.Point(16, 59);
            this.seleccionadorDePaises.Name = "seleccionadorDePaises";
            this.seleccionadorDePaises.Size = new System.Drawing.Size(301, 379);
            this.seleccionadorDePaises.Sorted = true;
            this.seleccionadorDePaises.TabIndex = 1;
            this.seleccionadorDePaises.SelectedIndexChanged += new System.EventHandler(this.seleccionadorDePaises_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AñadirDelegacion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DelegacionesAñadidas);
            this.panel2.Controls.Add(this.NombreDelegacion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(414, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 114);
            this.panel2.TabIndex = 1;
            // 
            // AñadirDelegacion
            // 
            this.AñadirDelegacion.Location = new System.Drawing.Point(216, 33);
            this.AñadirDelegacion.Name = "AñadirDelegacion";
            this.AñadirDelegacion.Size = new System.Drawing.Size(65, 23);
            this.AñadirDelegacion.TabIndex = 4;
            this.AñadirDelegacion.Text = "Añadir";
            this.AñadirDelegacion.UseVisualStyleBackColor = true;
            this.AñadirDelegacion.Click += new System.EventHandler(this.AñadirNuevaDelegacion);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // DelegacionesAñadidas
            // 
            this.DelegacionesAñadidas.FormattingEnabled = true;
            this.DelegacionesAñadidas.Location = new System.Drawing.Point(21, 59);
            this.DelegacionesAñadidas.Name = "DelegacionesAñadidas";
            this.DelegacionesAñadidas.Size = new System.Drawing.Size(260, 43);
            this.DelegacionesAñadidas.TabIndex = 2;
            // 
            // NombreDelegacion
            // 
            this.NombreDelegacion.Location = new System.Drawing.Point(71, 33);
            this.NombreDelegacion.Name = "NombreDelegacion";
            this.NombreDelegacion.Size = new System.Drawing.Size(139, 20);
            this.NombreDelegacion.TabIndex = 1;
            this.NombreDelegacion.TextChanged += new System.EventHandler(this.ChequeoTexto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Añadir Delegacion";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AñadirTopico);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TopicosAñadidos);
            this.panel3.Controls.Add(this.NombreTopico);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(414, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 114);
            this.panel3.TabIndex = 2;
            // 
            // AñadirTopico
            // 
            this.AñadirTopico.Location = new System.Drawing.Point(216, 30);
            this.AñadirTopico.Name = "AñadirTopico";
            this.AñadirTopico.Size = new System.Drawing.Size(65, 23);
            this.AñadirTopico.TabIndex = 5;
            this.AñadirTopico.Text = "Añadir";
            this.AñadirTopico.UseVisualStyleBackColor = true;
            this.AñadirTopico.Click += new System.EventHandler(this.AñadirNuevoTopico);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // TopicosAñadidos
            // 
            this.TopicosAñadidos.FormattingEnabled = true;
            this.TopicosAñadidos.Location = new System.Drawing.Point(21, 59);
            this.TopicosAñadidos.Name = "TopicosAñadidos";
            this.TopicosAñadidos.Size = new System.Drawing.Size(260, 43);
            this.TopicosAñadidos.TabIndex = 2;
            // 
            // NombreTopico
            // 
            this.NombreTopico.Location = new System.Drawing.Point(71, 33);
            this.NombreTopico.Name = "NombreTopico";
            this.NombreTopico.Size = new System.Drawing.Size(139, 20);
            this.NombreTopico.TabIndex = 1;
            this.NombreTopico.TextChanged += new System.EventHandler(this.ChequeoTexto);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Añadir Tópico";
            // 
            // CrearSesion
            // 
            this.CrearSesion.Location = new System.Drawing.Point(473, 351);
            this.CrearSesion.Name = "CrearSesion";
            this.CrearSesion.Size = new System.Drawing.Size(172, 70);
            this.CrearSesion.TabIndex = 3;
            this.CrearSesion.Text = "Crear Sesión";
            this.CrearSesion.UseVisualStyleBackColor = true;
            this.CrearSesion.Click += new System.EventHandler(this.CrearNuevaSesion);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "☐",
            "☑",
            "☒"});
            this.comboBox1.Location = new System.Drawing.Point(15, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(17, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreadorDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 494);
            this.Controls.Add(this.CrearSesion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreadorDeSesion";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CreadorDeSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox seleccionadorDePaises;
        private System.Windows.Forms.TextBox NombreDelegacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DelegacionesAñadidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox TopicosAñadidos;
        private System.Windows.Forms.TextBox NombreTopico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CrearSesion;
        private System.Windows.Forms.Button AñadirDelegacion;
        private System.Windows.Forms.Button AñadirTopico;
        private System.Windows.Forms.Button SeleccionarTodo;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}