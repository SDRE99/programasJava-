namespace Tragaperras
{
    partial class f_Tragaperras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Tragaperras));
            this.gbPremios = new System.Windows.Forms.GroupBox();
            this.lblPremioConseguido = new System.Windows.Forms.Label();
            this.btConvertir = new System.Windows.Forms.Button();
            this.btDeter = new System.Windows.Forms.Button();
            this.btXogar = new System.Windows.Forms.Button();
            this.btAcumular = new System.Windows.Forms.Button();
            this.btCobrarAcumulado = new System.Windows.Forms.Button();
            this.btCobrarPremio = new System.Windows.Forms.Button();
            this.lblAcumulado = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            this.gbFrutas = new System.Windows.Forms.GroupBox();
            this.pbFruta2 = new System.Windows.Forms.PictureBox();
            this.pbFruta3 = new System.Windows.Forms.PictureBox();
            this.pbFruta1 = new System.Windows.Forms.PictureBox();
            this.bt20cent = new System.Windows.Forms.Button();
            this.bt50cent = new System.Windows.Forms.Button();
            this.bt1euro = new System.Windows.Forms.Button();
            this.bt2euros = new System.Windows.Forms.Button();
            this.lblXogadasRestantes = new System.Windows.Forms.Label();
            this.lblCuadroNegro = new System.Windows.Forms.Label();
            this.lblseparadora = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.gbPremios.SuspendLayout();
            this.gbFrutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPremios
            // 
            this.gbPremios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbPremios.Controls.Add(this.lblPremioConseguido);
            this.gbPremios.Controls.Add(this.btConvertir);
            this.gbPremios.Controls.Add(this.btDeter);
            this.gbPremios.Controls.Add(this.btXogar);
            this.gbPremios.Controls.Add(this.btAcumular);
            this.gbPremios.Controls.Add(this.btCobrarAcumulado);
            this.gbPremios.Controls.Add(this.btCobrarPremio);
            this.gbPremios.Controls.Add(this.lblAcumulado);
            this.gbPremios.Controls.Add(this.lblPremio);
            this.gbPremios.Location = new System.Drawing.Point(12, 284);
            this.gbPremios.Name = "gbPremios";
            this.gbPremios.Size = new System.Drawing.Size(760, 152);
            this.gbPremios.TabIndex = 14;
            this.gbPremios.TabStop = false;
            // 
            // lblPremioConseguido
            // 
            this.lblPremioConseguido.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.lblPremioConseguido.Location = new System.Drawing.Point(-36, 19);
            this.lblPremioConseguido.Name = "lblPremioConseguido";
            this.lblPremioConseguido.Size = new System.Drawing.Size(845, 117);
            this.lblPremioConseguido.TabIndex = 22;
            this.lblPremioConseguido.Text = "Dinero cobrado";
            this.lblPremioConseguido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPremioConseguido.Click += new System.EventHandler(this.lblPremioConseguido_Click);
            // 
            // btConvertir
            // 
            this.btConvertir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btConvertir.Enabled = false;
            this.btConvertir.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConvertir.ForeColor = System.Drawing.Color.Red;
            this.btConvertir.Location = new System.Drawing.Point(264, 88);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(97, 48);
            this.btConvertir.TabIndex = 12;
            this.btConvertir.Text = "Convertir en Xogadas";
            this.btConvertir.UseVisualStyleBackColor = false;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // btDeter
            // 
            this.btDeter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDeter.Enabled = false;
            this.btDeter.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeter.ForeColor = System.Drawing.Color.Red;
            this.btDeter.Location = new System.Drawing.Point(472, 24);
            this.btDeter.Name = "btDeter";
            this.btDeter.Size = new System.Drawing.Size(120, 104);
            this.btDeter.TabIndex = 11;
            this.btDeter.Text = "DETER";
            this.btDeter.UseVisualStyleBackColor = false;
            this.btDeter.Click += new System.EventHandler(this.btDeter_Click);
            // 
            // btXogar
            // 
            this.btXogar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btXogar.Enabled = false;
            this.btXogar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXogar.ForeColor = System.Drawing.Color.Red;
            this.btXogar.Location = new System.Drawing.Point(624, 24);
            this.btXogar.Name = "btXogar";
            this.btXogar.Size = new System.Drawing.Size(120, 104);
            this.btXogar.TabIndex = 10;
            this.btXogar.Text = "XOGAR";
            this.btXogar.UseVisualStyleBackColor = false;
            this.btXogar.Click += new System.EventHandler(this.btXogar_Click);
            // 
            // btAcumular
            // 
            this.btAcumular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAcumular.Enabled = false;
            this.btAcumular.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcumular.ForeColor = System.Drawing.Color.Red;
            this.btAcumular.Location = new System.Drawing.Point(264, 24);
            this.btAcumular.Name = "btAcumular";
            this.btAcumular.Size = new System.Drawing.Size(97, 48);
            this.btAcumular.TabIndex = 9;
            this.btAcumular.Text = "Acumular";
            this.btAcumular.UseVisualStyleBackColor = false;
            this.btAcumular.Click += new System.EventHandler(this.btAcumular_Click);
            // 
            // btCobrarAcumulado
            // 
            this.btCobrarAcumulado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCobrarAcumulado.Enabled = false;
            this.btCobrarAcumulado.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrarAcumulado.ForeColor = System.Drawing.Color.Red;
            this.btCobrarAcumulado.Location = new System.Drawing.Point(16, 88);
            this.btCobrarAcumulado.Name = "btCobrarAcumulado";
            this.btCobrarAcumulado.Size = new System.Drawing.Size(88, 48);
            this.btCobrarAcumulado.TabIndex = 8;
            this.btCobrarAcumulado.Text = "Cobrar Acumulado";
            this.btCobrarAcumulado.UseVisualStyleBackColor = false;
            this.btCobrarAcumulado.Click += new System.EventHandler(this.btCobrarAcumulado_Click);
            // 
            // btCobrarPremio
            // 
            this.btCobrarPremio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCobrarPremio.Enabled = false;
            this.btCobrarPremio.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrarPremio.ForeColor = System.Drawing.Color.Red;
            this.btCobrarPremio.Location = new System.Drawing.Point(16, 24);
            this.btCobrarPremio.Name = "btCobrarPremio";
            this.btCobrarPremio.Size = new System.Drawing.Size(88, 48);
            this.btCobrarPremio.TabIndex = 7;
            this.btCobrarPremio.Text = "Cobrar Premio";
            this.btCobrarPremio.UseVisualStyleBackColor = false;
            this.btCobrarPremio.Click += new System.EventHandler(this.btCobrarPremio_Click);
            // 
            // lblAcumulado
            // 
            this.lblAcumulado.BackColor = System.Drawing.Color.Black;
            this.lblAcumulado.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumulado.ForeColor = System.Drawing.Color.Lime;
            this.lblAcumulado.Location = new System.Drawing.Point(112, 88);
            this.lblAcumulado.Name = "lblAcumulado";
            this.lblAcumulado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAcumulado.Size = new System.Drawing.Size(144, 48);
            this.lblAcumulado.TabIndex = 6;
            this.lblAcumulado.Text = "0";
            this.lblAcumulado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPremio
            // 
            this.lblPremio.BackColor = System.Drawing.Color.Black;
            this.lblPremio.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.ForeColor = System.Drawing.Color.Lime;
            this.lblPremio.Location = new System.Drawing.Point(112, 24);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPremio.Size = new System.Drawing.Size(144, 48);
            this.lblPremio.TabIndex = 5;
            this.lblPremio.Text = "0";
            this.lblPremio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFrutas
            // 
            this.gbFrutas.BackColor = System.Drawing.Color.DarkGray;
            this.gbFrutas.Controls.Add(this.pbFruta2);
            this.gbFrutas.Controls.Add(this.pbFruta3);
            this.gbFrutas.Controls.Add(this.pbFruta1);
            this.gbFrutas.Enabled = false;
            this.gbFrutas.Location = new System.Drawing.Point(12, 12);
            this.gbFrutas.Name = "gbFrutas";
            this.gbFrutas.Size = new System.Drawing.Size(552, 256);
            this.gbFrutas.TabIndex = 12;
            this.gbFrutas.TabStop = false;
            // 
            // pbFruta2
            // 
            this.pbFruta2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta2.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta2.Image")));
            this.pbFruta2.Location = new System.Drawing.Point(208, 24);
            this.pbFruta2.Name = "pbFruta2";
            this.pbFruta2.Size = new System.Drawing.Size(136, 200);
            this.pbFruta2.TabIndex = 1;
            this.pbFruta2.TabStop = false;
            // 
            // pbFruta3
            // 
            this.pbFruta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta3.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta3.Image")));
            this.pbFruta3.Location = new System.Drawing.Point(384, 24);
            this.pbFruta3.Name = "pbFruta3";
            this.pbFruta3.Size = new System.Drawing.Size(136, 200);
            this.pbFruta3.TabIndex = 2;
            this.pbFruta3.TabStop = false;
            // 
            // pbFruta1
            // 
            this.pbFruta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFruta1.Image = ((System.Drawing.Image)(resources.GetObject("pbFruta1.Image")));
            this.pbFruta1.Location = new System.Drawing.Point(32, 24);
            this.pbFruta1.Name = "pbFruta1";
            this.pbFruta1.Size = new System.Drawing.Size(136, 200);
            this.pbFruta1.TabIndex = 0;
            this.pbFruta1.TabStop = false;
            // 
            // bt20cent
            // 
            this.bt20cent.Image = ((System.Drawing.Image)(resources.GetObject("bt20cent.Image")));
            this.bt20cent.Location = new System.Drawing.Point(593, 16);
            this.bt20cent.Name = "bt20cent";
            this.bt20cent.Size = new System.Drawing.Size(72, 72);
            this.bt20cent.TabIndex = 15;
            this.bt20cent.UseVisualStyleBackColor = true;
            this.bt20cent.Click += new System.EventHandler(this.bt20cent_Click);
            // 
            // bt50cent
            // 
            this.bt50cent.Image = ((System.Drawing.Image)(resources.GetObject("bt50cent.Image")));
            this.bt50cent.Location = new System.Drawing.Point(687, 16);
            this.bt50cent.Name = "bt50cent";
            this.bt50cent.Size = new System.Drawing.Size(72, 72);
            this.bt50cent.TabIndex = 16;
            this.bt50cent.UseVisualStyleBackColor = true;
            this.bt50cent.Click += new System.EventHandler(this.bt50cent_Click);
            // 
            // bt1euro
            // 
            this.bt1euro.Image = ((System.Drawing.Image)(resources.GetObject("bt1euro.Image")));
            this.bt1euro.Location = new System.Drawing.Point(593, 103);
            this.bt1euro.Name = "bt1euro";
            this.bt1euro.Size = new System.Drawing.Size(72, 72);
            this.bt1euro.TabIndex = 17;
            this.bt1euro.UseVisualStyleBackColor = true;
            this.bt1euro.Click += new System.EventHandler(this.bt1euro_Click);
            // 
            // bt2euros
            // 
            this.bt2euros.Image = ((System.Drawing.Image)(resources.GetObject("bt2euros.Image")));
            this.bt2euros.Location = new System.Drawing.Point(687, 103);
            this.bt2euros.Name = "bt2euros";
            this.bt2euros.Size = new System.Drawing.Size(72, 72);
            this.bt2euros.TabIndex = 18;
            this.bt2euros.UseVisualStyleBackColor = true;
            this.bt2euros.Click += new System.EventHandler(this.bt2euros_Click);
            // 
            // lblXogadasRestantes
            // 
            this.lblXogadasRestantes.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXogadasRestantes.Location = new System.Drawing.Point(593, 196);
            this.lblXogadasRestantes.Name = "lblXogadasRestantes";
            this.lblXogadasRestantes.Size = new System.Drawing.Size(166, 28);
            this.lblXogadasRestantes.TabIndex = 19;
            this.lblXogadasRestantes.Text = "XOGADAS RESTANTES";
            this.lblXogadasRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuadroNegro
            // 
            this.lblCuadroNegro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCuadroNegro.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadroNegro.ForeColor = System.Drawing.Color.Red;
            this.lblCuadroNegro.Location = new System.Drawing.Point(593, 230);
            this.lblCuadroNegro.Name = "lblCuadroNegro";
            this.lblCuadroNegro.Size = new System.Drawing.Size(166, 38);
            this.lblCuadroNegro.TabIndex = 20;
            this.lblCuadroNegro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblseparadora
            // 
            this.lblseparadora.Location = new System.Drawing.Point(593, 178);
            this.lblseparadora.Name = "lblseparadora";
            this.lblseparadora.Size = new System.Drawing.Size(166, 18);
            this.lblseparadora.TabIndex = 21;
            this.lblseparadora.Text = "___________________________";
            this.lblseparadora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 150;
            this.Temporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // f_Tragaperras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 460);
            this.Controls.Add(this.lblseparadora);
            this.Controls.Add(this.lblCuadroNegro);
            this.Controls.Add(this.lblXogadasRestantes);
            this.Controls.Add(this.bt2euros);
            this.Controls.Add(this.bt1euro);
            this.Controls.Add(this.bt50cent);
            this.Controls.Add(this.bt20cent);
            this.Controls.Add(this.gbPremios);
            this.Controls.Add(this.gbFrutas);
            this.Name = "f_Tragaperras";
            this.Text = "Tragaperras";
            this.gbPremios.ResumeLayout(false);
            this.gbFrutas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbPremios;
        internal System.Windows.Forms.Button btConvertir;
        internal System.Windows.Forms.Button btDeter;
        internal System.Windows.Forms.Button btXogar;
        internal System.Windows.Forms.Button btAcumular;
        internal System.Windows.Forms.Button btCobrarAcumulado;
        internal System.Windows.Forms.Button btCobrarPremio;
        internal System.Windows.Forms.Label lblAcumulado;
        internal System.Windows.Forms.Label lblPremio;
        internal System.Windows.Forms.GroupBox gbFrutas;
        internal System.Windows.Forms.PictureBox pbFruta2;
        internal System.Windows.Forms.PictureBox pbFruta3;
        internal System.Windows.Forms.PictureBox pbFruta1;
        private System.Windows.Forms.Button bt20cent;
        private System.Windows.Forms.Button bt50cent;
        private System.Windows.Forms.Button bt1euro;
        private System.Windows.Forms.Button bt2euros;
        private System.Windows.Forms.Label lblXogadasRestantes;
        private System.Windows.Forms.Label lblCuadroNegro;
        private System.Windows.Forms.Label lblseparadora;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label lblPremioConseguido;
    }
}

