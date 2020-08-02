namespace GestiónModelo
{
    partial class Del_Estrado
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
            this.delegacion_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bajar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delegacion_name
            // 
            this.delegacion_name.AutoSize = true;
            this.delegacion_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delegacion_name.Location = new System.Drawing.Point(57, 5);
            this.delegacion_name.Name = "delegacion_name";
            this.delegacion_name.Size = new System.Drawing.Size(60, 24);
            this.delegacion_name.TabIndex = 0;
            this.delegacion_name.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bajar
            // 
            this.bajar.Location = new System.Drawing.Point(61, 32);
            this.bajar.Name = "bajar";
            this.bajar.Size = new System.Drawing.Size(123, 23);
            this.bajar.TabIndex = 2;
            this.bajar.Text = "Bajar Del Estrado";
            this.bajar.UseVisualStyleBackColor = true;
            this.bajar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_Estrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 59);
            this.Controls.Add(this.bajar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delegacion_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Del_Estrado";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label delegacion_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bajar;
    }
}