namespace GestiónModelo
{
    partial class Temporizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.mintxt = new System.Windows.Forms.Label();
            this.segtxt = new System.Windows.Forms.Label();
            this.minbox = new System.Windows.Forms.TextBox();
            this.segbox = new System.Windows.Forms.TextBox();
            this.reloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(12, 183);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(80, 50);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(127, 183);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(80, 50);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Stop_Click_1);
            // 
            // mintxt
            // 
            this.mintxt.AutoSize = true;
            this.mintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintxt.Location = new System.Drawing.Point(12, 9);
            this.mintxt.Name = "mintxt";
            this.mintxt.Size = new System.Drawing.Size(94, 25);
            this.mintxt.TabIndex = 2;
            this.mintxt.Text = "Minutos:";
            // 
            // segtxt
            // 
            this.segtxt.AutoSize = true;
            this.segtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segtxt.Location = new System.Drawing.Point(112, 9);
            this.segtxt.Name = "segtxt";
            this.segtxt.Size = new System.Drawing.Size(115, 25);
            this.segtxt.TabIndex = 3;
            this.segtxt.Text = "Segundos:";
            // 
            // minbox
            // 
            this.minbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbox.Location = new System.Drawing.Point(12, 43);
            this.minbox.Name = "minbox";
            this.minbox.Size = new System.Drawing.Size(80, 31);
            this.minbox.TabIndex = 4;
            // 
            // segbox
            // 
            this.segbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segbox.Location = new System.Drawing.Point(132, 43);
            this.segbox.Name = "segbox";
            this.segbox.Size = new System.Drawing.Size(80, 31);
            this.segbox.TabIndex = 5;
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(13, 92);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(200, 76);
            this.reloj.TabIndex = 6;
            this.reloj.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Temporizador
            // 
            this.ClientSize = new System.Drawing.Size(225, 245);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.segbox);
            this.Controls.Add(this.minbox);
            this.Controls.Add(this.segtxt);
            this.Controls.Add(this.mintxt);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label mintxt;
        private System.Windows.Forms.Label segtxt;
        private System.Windows.Forms.TextBox minbox;
        private System.Windows.Forms.TextBox segbox;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Timer timer1;
    }
}

