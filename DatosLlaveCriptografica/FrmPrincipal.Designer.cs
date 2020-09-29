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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInfoLlaveCriptografica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.PicProcesando = new System.Windows.Forms.PictureBox();
            this.LblPinConsultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDragAndDrop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).BeginInit();
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
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(283, 8);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(139, 23);
            this.BtnSeleccionarArchivo.TabIndex = 1;
            this.BtnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // BtnObtenerInfo
            // 
            this.BtnObtenerInfo.Location = new System.Drawing.Point(285, 227);
            this.BtnObtenerInfo.Name = "BtnObtenerInfo";
            this.BtnObtenerInfo.Size = new System.Drawing.Size(137, 23);
            this.BtnObtenerInfo.TabIndex = 2;
            this.BtnObtenerInfo.Text = "Obtener Info";
            this.BtnObtenerInfo.UseVisualStyleBackColor = true;
            this.BtnObtenerInfo.Click += new System.EventHandler(this.BtnObtenerInfo_Click);
            // 
            // BtnAveriguarPIN
            // 
            this.BtnAveriguarPIN.Location = new System.Drawing.Point(286, 269);
            this.BtnAveriguarPIN.Name = "BtnAveriguarPIN";
            this.BtnAveriguarPIN.Size = new System.Drawing.Size(137, 23);
            this.BtnAveriguarPIN.TabIndex = 3;
            this.BtnAveriguarPIN.Text = "Averiguar PIN";
            this.BtnAveriguarPIN.UseVisualStyleBackColor = true;
            this.BtnAveriguarPIN.Click += new System.EventHandler(this.BtnAveriguarPIN_Click);
            // 
            // BtnLimpiarPantalla
            // 
            this.BtnLimpiarPantalla.Location = new System.Drawing.Point(16, 335);
            this.BtnLimpiarPantalla.Name = "BtnLimpiarPantalla";
            this.BtnLimpiarPantalla.Size = new System.Drawing.Size(136, 23);
            this.BtnLimpiarPantalla.TabIndex = 4;
            this.BtnLimpiarPantalla.Text = "Limpiar";
            this.BtnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.BtnLimpiarPantalla.Click += new System.EventHandler(this.BtnLimpiarPantalla_Click);
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.Location = new System.Drawing.Point(286, 335);
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(136, 23);
            this.BtnAcercaDe.TabIndex = 5;
            this.BtnAcercaDe.Text = "Acerca De";
            this.BtnAcercaDe.UseVisualStyleBackColor = true;
            this.BtnAcercaDe.Click += new System.EventHandler(this.BtnAcercaDe_Click);
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(105, 229);
            this.TxtPin.MaxLength = 4;
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(60, 20);
            this.TxtPin.TabIndex = 6;
            this.TxtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPin_KeyDown);
            this.TxtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click para buscar el PIN si no sabe cual es ";
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
            this.label2.Location = new System.Drawing.Point(11, 232);
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
            this.PicProcesando.Location = new System.Drawing.Point(130, 64);
            this.PicProcesando.Name = "PicProcesando";
            this.PicProcesando.Size = new System.Drawing.Size(168, 151);
            this.PicProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProcesando.TabIndex = 10;
            this.PicProcesando.TabStop = false;
            this.PicProcesando.Visible = false;
            // 
            // LblPinConsultado
            // 
            this.LblPinConsultado.AutoSize = true;
            this.LblPinConsultado.Location = new System.Drawing.Point(222, 304);
            this.LblPinConsultado.Name = "LblPinConsultado";
            this.LblPinConsultado.Size = new System.Drawing.Size(13, 13);
            this.LblPinConsultado.TabIndex = 11;
            this.LblPinConsultado.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 304);
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 379);
            this.Controls.Add(this.BtnObtenerInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDragAndDrop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPinConsultado);
            this.Controls.Add(this.PicProcesando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.BtnAcercaDe);
            this.Controls.Add(this.BtnLimpiarPantalla);
            this.Controls.Add(this.BtnAveriguarPIN);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtInfoLlaveCriptografica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener info llave criptográfica";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInfoLlaveCriptografica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.PictureBox PicProcesando;
        private System.Windows.Forms.Label LblPinConsultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDragAndDrop;
        private System.Windows.Forms.Label label4;
    }
}

