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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mintxt = new System.Windows.Forms.Label();
            this.segtxt = new System.Windows.Forms.Label();
            this.minbox = new System.Windows.Forms.TextBox();
            this.segbox = new System.Windows.Forms.TextBox();
            this.reloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(157, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mintxt
            // 
            this.mintxt.AutoSize = true;
            this.mintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintxt.Location = new System.Drawing.Point(33, 9);
            this.mintxt.Name = "mintxt";
            this.mintxt.Size = new System.Drawing.Size(94, 25);
            this.mintxt.TabIndex = 2;
            this.mintxt.Text = "Minutos:";
            // 
            // segtxt
            // 
            this.segtxt.AutoSize = true;
            this.segtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segtxt.Location = new System.Drawing.Point(152, 9);
            this.segtxt.Name = "segtxt";
            this.segtxt.Size = new System.Drawing.Size(115, 25);
            this.segtxt.TabIndex = 3;
            this.segtxt.Text = "Segundos:";
            // 
            // minbox
            // 
            this.minbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbox.Location = new System.Drawing.Point(47, 43);
            this.minbox.Name = "minbox";
            this.minbox.Size = new System.Drawing.Size(80, 31);
            this.minbox.TabIndex = 4;
            // 
            // segbox
            // 
            this.segbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segbox.Location = new System.Drawing.Point(160, 43);
            this.segbox.Name = "segbox";
            this.segbox.Size = new System.Drawing.Size(80, 31);
            this.segbox.TabIndex = 5;
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(40, 98);
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
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.segbox);
            this.Controls.Add(this.minbox);
            this.Controls.Add(this.segtxt);
            this.Controls.Add(this.mintxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label mintxt;
        private System.Windows.Forms.Label segtxt;
        private System.Windows.Forms.TextBox minbox;
        private System.Windows.Forms.TextBox segbox;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Timer timer1;
    }
}

