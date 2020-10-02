namespace DatosLlaveCriptografica
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.BtnObtenerInfo = new System.Windows.Forms.Button();
            this.BtnAveriguarPIN = new System.Windows.Forms.Button();
            this.BtnLimpiarPantalla = new System.Windows.Forms.Button();
            this.BtnAcercaDe = new System.Windows.Forms.Button();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.TxtInfoLlaveCriptografica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.PicProcesando = new System.Windows.Forms.PictureBox();
            this.LblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDragAndDrop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelarBusqueda = new System.Windows.Forms.Button();
            this.TxtValorInicial = new System.Windows.Forms.TextBox();
            this.TxtValorFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(15, 36);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(407, 20);
            this.TxtPath.TabIndex = 0;
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSeleccionarArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSeleccionarArchivo.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnSeleccionarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSeleccionarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(274, 7);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(142, 23);
            this.BtnSeleccionarArchivo.TabIndex = 1;
            this.BtnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = false;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // BtnObtenerInfo
            // 
            this.BtnObtenerInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnObtenerInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnObtenerInfo.FlatAppearance.BorderSize = 0;
            this.BtnObtenerInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnObtenerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnObtenerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObtenerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObtenerInfo.ForeColor = System.Drawing.Color.White;
            this.BtnObtenerInfo.Location = new System.Drawing.Point(274, 229);
            this.BtnObtenerInfo.Name = "BtnObtenerInfo";
            this.BtnObtenerInfo.Size = new System.Drawing.Size(142, 23);
            this.BtnObtenerInfo.TabIndex = 2;
            this.BtnObtenerInfo.Text = "Obtener Info";
            this.BtnObtenerInfo.UseVisualStyleBackColor = false;
            this.BtnObtenerInfo.Click += new System.EventHandler(this.BtnObtenerInfo_Click);
            // 
            // BtnAveriguarPIN
            // 
            this.BtnAveriguarPIN.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAveriguarPIN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAveriguarPIN.FlatAppearance.BorderSize = 0;
            this.BtnAveriguarPIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnAveriguarPIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAveriguarPIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAveriguarPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAveriguarPIN.ForeColor = System.Drawing.Color.White;
            this.BtnAveriguarPIN.Location = new System.Drawing.Point(261, 24);
            this.BtnAveriguarPIN.Name = "BtnAveriguarPIN";
            this.BtnAveriguarPIN.Size = new System.Drawing.Size(142, 23);
            this.BtnAveriguarPIN.TabIndex = 3;
            this.BtnAveriguarPIN.Text = "Averiguar PIN";
            this.BtnAveriguarPIN.UseVisualStyleBackColor = false;
            this.BtnAveriguarPIN.Click += new System.EventHandler(this.BtnAveriguarPIN_Click);
            // 
            // BtnLimpiarPantalla
            // 
            this.BtnLimpiarPantalla.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnLimpiarPantalla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLimpiarPantalla.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarPantalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnLimpiarPantalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiarPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarPantalla.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarPantalla.Location = new System.Drawing.Point(27, 402);
            this.BtnLimpiarPantalla.Name = "BtnLimpiarPantalla";
            this.BtnLimpiarPantalla.Size = new System.Drawing.Size(142, 23);
            this.BtnLimpiarPantalla.TabIndex = 4;
            this.BtnLimpiarPantalla.Text = "Limpiar";
            this.BtnLimpiarPantalla.UseVisualStyleBackColor = false;
            this.BtnLimpiarPantalla.Click += new System.EventHandler(this.BtnLimpiarPantalla_Click);
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAcercaDe.FlatAppearance.BorderSize = 0;
            this.BtnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.BtnAcercaDe.Location = new System.Drawing.Point(274, 402);
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(142, 23);
            this.BtnAcercaDe.TabIndex = 5;
            this.BtnAcercaDe.Text = "Acerca De";
            this.BtnAcercaDe.UseVisualStyleBackColor = false;
            this.BtnAcercaDe.Click += new System.EventHandler(this.BtnAcercaDe_Click);
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(92, 231);
            this.TxtPin.MaxLength = 4;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(43, 20);
            this.TxtPin.TabIndex = 6;
            this.TxtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPin_KeyDown);
            this.TxtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPin_KeyPress);
            // 
            // TxtInfoLlaveCriptografica
            // 
            this.TxtInfoLlaveCriptografica.AllowDrop = true;
            this.TxtInfoLlaveCriptografica.Location = new System.Drawing.Point(16, 65);
            this.TxtInfoLlaveCriptografica.Multiline = true;
            this.TxtInfoLlaveCriptografica.Name = "TxtInfoLlaveCriptografica";
            this.TxtInfoLlaveCriptografica.Size = new System.Drawing.Size(407, 151);
            this.TxtInfoLlaveCriptografica.TabIndex = 8;
            this.TxtInfoLlaveCriptografica.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtInfoLlaveCriptografica_DragDrop);
            this.TxtInfoLlaveCriptografica.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtInfoLlaveCriptografica_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese el PIN";
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "openFileDialog1";
            // 
            // PicProcesando
            // 
            this.PicProcesando.Image = ((System.Drawing.Image)(resources.GetObject("PicProcesando.Image")));
            this.PicProcesando.Location = new System.Drawing.Point(141, 70);
            this.PicProcesando.Name = "PicProcesando";
            this.PicProcesando.Size = new System.Drawing.Size(152, 140);
            this.PicProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProcesando.TabIndex = 10;
            this.PicProcesando.TabStop = false;
            this.PicProcesando.Visible = false;
            // 
            // LblTiempoTranscurrido
            // 
            this.LblTiempoTranscurrido.AutoSize = true;
            this.LblTiempoTranscurrido.Location = new System.Drawing.Point(203, 93);
            this.LblTiempoTranscurrido.Name = "LblTiempoTranscurrido";
            this.LblTiempoTranscurrido.Size = new System.Drawing.Size(13, 13);
            this.LblTiempoTranscurrido.TabIndex = 11;
            this.LblTiempoTranscurrido.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tiempo transcurrido (segundos) : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Averiguar PIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDragAndDrop
            // 
            this.LblDragAndDrop.AutoSize = true;
            this.LblDragAndDrop.BackColor = System.Drawing.Color.White;
            this.LblDragAndDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDragAndDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblDragAndDrop.Location = new System.Drawing.Point(28, 130);
            this.LblDragAndDrop.Name = "LblDragAndDrop";
            this.LblDragAndDrop.Size = new System.Drawing.Size(382, 15);
            this.LblDragAndDrop.TabIndex = 14;
            this.LblDragAndDrop.Text = "Use el botón Seleccionar Archivo o arrastre el archivo aquí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ruta del archivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = " Desarrollado por Roberto Reyes García - 02-Oct-2020";
            // 
            // BtnCancelarBusqueda
            // 
            this.BtnCancelarBusqueda.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelarBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnCancelarBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.BtnCancelarBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCancelarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarBusqueda.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarBusqueda.Location = new System.Drawing.Point(261, 60);
            this.BtnCancelarBusqueda.Name = "BtnCancelarBusqueda";
            this.BtnCancelarBusqueda.Size = new System.Drawing.Size(141, 23);
            this.BtnCancelarBusqueda.TabIndex = 17;
            this.BtnCancelarBusqueda.Text = "Cancelar";
            this.BtnCancelarBusqueda.UseVisualStyleBackColor = false;
            this.BtnCancelarBusqueda.Click += new System.EventHandler(this.BtnCancelarBusqueda_Click);
            // 
            // TxtValorInicial
            // 
            this.TxtValorInicial.Location = new System.Drawing.Point(191, 27);
            this.TxtValorInicial.MaxLength = 4;
            this.TxtValorInicial.Name = "TxtValorInicial";
            this.TxtValorInicial.Size = new System.Drawing.Size(43, 20);
            this.TxtValorInicial.TabIndex = 18;
            this.TxtValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorInicial_KeyPress);
            // 
            // TxtValorFinal
            // 
            this.TxtValorFinal.Location = new System.Drawing.Point(191, 62);
            this.TxtValorFinal.MaxLength = 4;
            this.TxtValorFinal.Name = "TxtValorFinal";
            this.TxtValorFinal.Size = new System.Drawing.Size(43, 20);
            this.TxtValorFinal.TabIndex = 19;
            this.TxtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorFinal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Valor Inicial para la búsqueda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Valor Final para la búsqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCancelarBusqueda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtValorFinal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtValorInicial);
            this.groupBox1.Controls.Add(this.BtnAveriguarPIN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTiempoTranscurrido);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 118);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Averiguar PIN ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnObtenerInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDragAndDrop);
            this.Controls.Add(this.PicProcesando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.BtnAcercaDe);
            this.Controls.Add(this.BtnLimpiarPantalla);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtInfoLlaveCriptografica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener info llave criptográfica";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnSeleccionarArchivo;
        private System.Windows.Forms.Button BtnObtenerInfo;
        private System.Windows.Forms.Button BtnAveriguarPIN;
        private System.Windows.Forms.Button BtnLimpiarPantalla;
        private System.Windows.Forms.Button BtnAcercaDe;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.TextBox TxtInfoLlaveCriptografica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.PictureBox PicProcesando;
        private System.Windows.Forms.Label LblTiempoTranscurrido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDragAndDrop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelarBusqueda;
        private System.Windows.Forms.TextBox TxtValorInicial;
        private System.Windows.Forms.TextBox TxtValorFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

