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
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(13, 13);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(287, 20);
            this.TxtPath.TabIndex = 0;
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(306, 12);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(119, 23);
            this.BtnSeleccionarArchivo.TabIndex = 1;
            this.BtnSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // BtnObtenerInfo
            // 
            this.BtnObtenerInfo.Location = new System.Drawing.Point(306, 41);
            this.BtnObtenerInfo.Name = "BtnObtenerInfo";
            this.BtnObtenerInfo.Size = new System.Drawing.Size(119, 23);
            this.BtnObtenerInfo.TabIndex = 2;
            this.BtnObtenerInfo.Text = "Obtener Info";
            this.BtnObtenerInfo.UseVisualStyleBackColor = true;
            this.BtnObtenerInfo.Click += new System.EventHandler(this.BtnObtenerInfo_Click);
            this.BtnObtenerInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnObtenerInfo_KeyDown);
            // 
            // BtnAveriguarPIN
            // 
            this.BtnAveriguarPIN.Location = new System.Drawing.Point(306, 70);
            this.BtnAveriguarPIN.Name = "BtnAveriguarPIN";
            this.BtnAveriguarPIN.Size = new System.Drawing.Size(119, 23);
            this.BtnAveriguarPIN.TabIndex = 3;
            this.BtnAveriguarPIN.Text = "Averiguar PIN";
            this.BtnAveriguarPIN.UseVisualStyleBackColor = true;
            this.BtnAveriguarPIN.Click += new System.EventHandler(this.BtnAveriguarPIN_Click);
            // 
            // BtnLimpiarPantalla
            // 
            this.BtnLimpiarPantalla.Location = new System.Drawing.Point(13, 380);
            this.BtnLimpiarPantalla.Name = "BtnLimpiarPantalla";
            this.BtnLimpiarPantalla.Size = new System.Drawing.Size(108, 23);
            this.BtnLimpiarPantalla.TabIndex = 4;
            this.BtnLimpiarPantalla.Text = "Limpiar";
            this.BtnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.BtnLimpiarPantalla.Click += new System.EventHandler(this.BtnLimpiarPantalla_Click);
            // 
            // BtnAcercaDe
            // 
            this.BtnAcercaDe.Location = new System.Drawing.Point(317, 379);
            this.BtnAcercaDe.Name = "BtnAcercaDe";
            this.BtnAcercaDe.Size = new System.Drawing.Size(108, 23);
            this.BtnAcercaDe.TabIndex = 5;
            this.BtnAcercaDe.Text = "Acerca De";
            this.BtnAcercaDe.UseVisualStyleBackColor = true;
            this.BtnAcercaDe.Click += new System.EventHandler(this.BtnAcercaDe_Click);
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(240, 43);
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(60, 20);
            this.TxtPin.TabIndex = 6;
            this.TxtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click para buscar el PIN ";
            // 
            // TxtInfoLlaveCriptografica
            // 
            this.TxtInfoLlaveCriptografica.Location = new System.Drawing.Point(13, 114);
            this.TxtInfoLlaveCriptografica.Multiline = true;
            this.TxtInfoLlaveCriptografica.Name = "TxtInfoLlaveCriptografica";
            this.TxtInfoLlaveCriptografica.Size = new System.Drawing.Size(412, 217);
            this.TxtInfoLlaveCriptografica.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PIN";
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "openFileDialog1";
            // 
            // PicProcesando
            // 
            this.PicProcesando.Image = ((System.Drawing.Image)(resources.GetObject("PicProcesando.Image")));
            this.PicProcesando.Location = new System.Drawing.Point(112, 122);
            this.PicProcesando.Name = "PicProcesando";
            this.PicProcesando.Size = new System.Drawing.Size(214, 200);
            this.PicProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProcesando.TabIndex = 10;
            this.PicProcesando.TabStop = false;
            this.PicProcesando.Visible = false;
            // 
            // LblPinConsultado
            // 
            this.LblPinConsultado.AutoSize = true;
            this.LblPinConsultado.Location = new System.Drawing.Point(221, 337);
            this.LblPinConsultado.Name = "LblPinConsultado";
            this.LblPinConsultado.Size = new System.Drawing.Size(13, 13);
            this.LblPinConsultado.TabIndex = 11;
            this.LblPinConsultado.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tiempo transcurrido (segundos) : ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPinConsultado);
            this.Controls.Add(this.PicProcesando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtInfoLlaveCriptografica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.BtnAcercaDe);
            this.Controls.Add(this.BtnLimpiarPantalla);
            this.Controls.Add(this.BtnAveriguarPIN);
            this.Controls.Add(this.BtnObtenerInfo);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.Controls.Add(this.TxtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener info llave criptográfica";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

