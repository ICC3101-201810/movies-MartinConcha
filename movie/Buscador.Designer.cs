namespace movie
{
    partial class Buscador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.peliculas = new System.Windows.Forms.Button();
            this.actores = new System.Windows.Forms.Button();
            this.directores = new System.Windows.Forms.Button();
            this.productores = new System.Windows.Forms.Button();
            this.estudios = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 20);
            this.textBox1.TabIndex = 0;
            // 
            // peliculas
            // 
            this.peliculas.Location = new System.Drawing.Point(13, 79);
            this.peliculas.Name = "peliculas";
            this.peliculas.Size = new System.Drawing.Size(75, 23);
            this.peliculas.TabIndex = 2;
            this.peliculas.Text = "Peliculas";
            this.peliculas.UseVisualStyleBackColor = true;
            this.peliculas.Click += new System.EventHandler(this.peliculas_Click);
            // 
            // actores
            // 
            this.actores.Location = new System.Drawing.Point(94, 79);
            this.actores.Name = "actores";
            this.actores.Size = new System.Drawing.Size(75, 23);
            this.actores.TabIndex = 3;
            this.actores.Text = "Actores";
            this.actores.UseVisualStyleBackColor = true;
            this.actores.Click += new System.EventHandler(this.actores_Click);
            // 
            // directores
            // 
            this.directores.Location = new System.Drawing.Point(175, 79);
            this.directores.Name = "directores";
            this.directores.Size = new System.Drawing.Size(75, 23);
            this.directores.TabIndex = 4;
            this.directores.Text = "Directores";
            this.directores.UseVisualStyleBackColor = true;
            this.directores.Click += new System.EventHandler(this.directores_Click);
            // 
            // productores
            // 
            this.productores.Location = new System.Drawing.Point(256, 79);
            this.productores.Name = "productores";
            this.productores.Size = new System.Drawing.Size(75, 23);
            this.productores.TabIndex = 5;
            this.productores.Text = "Productores";
            this.productores.UseVisualStyleBackColor = true;
            this.productores.Click += new System.EventHandler(this.productores_Click);
            // 
            // estudios
            // 
            this.estudios.Location = new System.Drawing.Point(337, 79);
            this.estudios.Name = "estudios";
            this.estudios.Size = new System.Drawing.Size(75, 23);
            this.estudios.TabIndex = 6;
            this.estudios.Text = "Estudios";
            this.estudios.UseVisualStyleBackColor = true;
            this.estudios.Click += new System.EventHandler(this.estudios_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(371, 35);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(459, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(70, 23);
            this.Cerrar.TabIndex = 8;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 116);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.estudios);
            this.Controls.Add(this.productores);
            this.Controls.Add(this.directores);
            this.Controls.Add(this.actores);
            this.Controls.Add(this.peliculas);
            this.Controls.Add(this.textBox1);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button peliculas;
        private System.Windows.Forms.Button actores;
        private System.Windows.Forms.Button directores;
        private System.Windows.Forms.Button productores;
        private System.Windows.Forms.Button estudios;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button Cerrar;
    }
}