﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosLlaveCriptografica
{
    public partial class FrmPrincipal : Form
    {
        int cont = 1;
        string ruta;
        string rutayArchivo;
        string certificadoP12;
        string fechaTemp;
        string pinCertificado;
        string pinBuscado;
        string fechaCertificado;
        bool certificadoEncontrado;
        StreamReader sr;
        X509Certificate2 cert;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pinBuscado = string.Empty;
        }

        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            Ofd1.Filter = "Cert|*.p12";
            if (Ofd1.ShowDialog() == DialogResult.OK)
            {
                rutayArchivo = Ofd1.FileName;
                ruta = rutayArchivo.Substring(0, rutayArchivo.LastIndexOf('\\'));
                certificadoP12 = Ofd1.SafeFileName;
                TxtPath.Text = rutayArchivo;
                LblDragAndDrop.Visible = false;
            }
        }

        private void BtnObtenerInfo_Click(object sender, EventArgs e)
        {
            ObtenerInfo();
        }

        private void TxtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ObtenerInfo();
            }
        }

        private void TxtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void TxtInfoLlaveCriptografica_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TxtInfoLlaveCriptografica_DragEnter(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            TxtPath.Text = archivos[0];
            rutayArchivo = TxtPath.Text;
            FileInfo file = new FileInfo(rutayArchivo);
            certificadoP12 = file.Name;

            // string certTemp = certificadoP12;
            // if (!certTemp.EndsWith(".p12"))
            if(file.Extension != ".p12")
            {
                MessageBox.Show("El archivo seleccionado no es una llave criptográfica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LblDragAndDrop.Visible = false;
        }

        private void BtnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }
        #endregion Eventos

        #region Métodos
        private void ObtenerInfo()
        {
            if (certificadoP12 == null)
            {
                MessageBox.Show("Debe de seleccionar una llave criptográfica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TxtPin.Focus();
            }

            string certTemp = certificadoP12;
            if (!certTemp.EndsWith(".p12"))
            {
                MessageBox.Show("El archivo seleccionado no es una llave criptográfica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(TxtPin.Text))
            {
                try
                {
                    pinCertificado = TxtPin.Text;
                    cert = new X509Certificate2(rutayArchivo, pinCertificado);
                    MostrarDatosCertificado();
                }
                catch (Exception)
                {
                    MessageBox.Show("El PIN ingresado es incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un PIN numérico de 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void BtnAveriguarPIN_Click(object sender, EventArgs e)
        private async void BtnAveriguarPIN_Click(object sender, EventArgs e)
        {
            PicProcesando.Visible = true;
            DateTime tiempoInicio = DateTime.Now;

            // ObtenerPIN();                    // Esta llamada se usa con el metodo sincronico ObtenerPin
            pinBuscado = await ObtenerPIN();    // Esta llamada se usa con el metodo asincronico ObtenerPin

            DateTime tiempoFin = DateTime.Now;
            TimeSpan span = tiempoFin - tiempoInicio;
            double segundosTranscurridos = (double)span.TotalMilliseconds / 1000;
            LblPinConsultado.Text = segundosTranscurridos.ToString();
            TxtPin.Text = pinBuscado;

            if (pinBuscado != string.Empty)
            {
                MostrarDatosCertificado();
                PicProcesando.Visible = false;
            }
            else
            {
                PicProcesando.Visible = false;
                // MessageBox.Show("No se encontró el PIN para este certificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region No usados
        // Metodo sincronico que bloquea la GUI y devuelve un valor (string)
        //private string ObtenerPIN()
        //{
        //    {
        //        for (int i = 9020; i < 9030; i++)
        //        {
        //            pinBuscado = i.ToString();
        //            try
        //            {
        //                cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //                //PicProcesando.Visible = false;
        //                //return pinBuscado;

        //                fechaCertificado = certificadoP12.Substring(0, 12);
        //                fechaTemp = fechaCertificado;

        //                string certificadoVenta = cert.NotAfter.ToString("dd-MMMM-yyyy ,  HH:mm");
        //                TxtInfoLlaveCriptografica.Text = $"Fecha de Vencimiento =   {certificadoVenta}";
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText(cert.IssuerName.Name.ToString());
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText(cert.Subject.ToString());
        //            }
        //            catch (Exception) { }
        //        }
        //        return pinBuscado;
        //    }
        //}

        // Metodo Asyncronico que no bloquea la GUI y no devuelve ningun dato(void)
        //private async void ObtenerPIN()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 9023; i < 9030; i++)
        //        {
        //            pinBuscado = i.ToString();
        //            try
        //            {
        //                cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //                // MostrarDatosCertificado();

        //                fechaCertificado = certificadoP12.Substring(0, 12);
        //                fechaTemp = fechaCertificado;

        //                string certificadoVenta = cert.NotAfter.ToString("dd-MMMM-yyyy ,  HH:mm");
        //                TxtInfoLlaveCriptografica.Text = $"Fecha de Vencimiento =   {certificadoVenta}";
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText(cert.IssuerName.Name.ToString());
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText("\r\n");
        //                TxtInfoLlaveCriptografica.AppendText(cert.Subject.ToString());

        //            }
        //            catch (Exception ex) { }
        //        }
        //    });
        //}
        #endregion

        // Metodo Asyncrónico que no bloquea la GUI y que devuelve un valor(string)
        private async Task<string> ObtenerPIN()
        {
            return await Task<string>.Run(() =>
            {
                for (int i = 1; i < 9999; i++)
                {
                    pinBuscado = i.ToString();
                    try
                    {
                        cert = new X509Certificate2(rutayArchivo, pinBuscado);
                        if (cert != null)
                        {
                            return pinBuscado;
                        }
                    }
                    catch (Exception) { }
                }
                pinBuscado = string.Empty;
                return pinBuscado;
            });
        }

        private void MostrarDatosCertificado()
        {
            fechaCertificado = certificadoP12.Substring(0, 12);
            fechaTemp = fechaCertificado;

            string certificadoVenta = cert.NotAfter.ToString("dd-MMMM-yyyy ,  HH:mm");
            TxtInfoLlaveCriptografica.Text = $"Fecha de Vencimiento =   {certificadoVenta}";
            TxtInfoLlaveCriptografica.AppendText("\r\n");
            TxtInfoLlaveCriptografica.AppendText("\r\n");
            TxtInfoLlaveCriptografica.AppendText(cert.IssuerName.Name.ToString());
            TxtInfoLlaveCriptografica.AppendText("\r\n");
            TxtInfoLlaveCriptografica.AppendText("\r\n");
            TxtInfoLlaveCriptografica.AppendText(cert.Subject.ToString());
        }
        private void LimpiarDatos()
        {
            TxtPath.Clear();
            TxtPin.Clear();
            TxtInfoLlaveCriptografica.Clear();
            LblDragAndDrop.Visible = true;
        }

        private async Task<string> ObtenerPIN2()
        {
            return await Task<string>.Run(() =>
            {
                for (int i = 5000; i < 9999; i++)
                {
                    pinBuscado = i.ToString();
                    try
                    {
                        cert = new X509Certificate2(rutayArchivo, pinBuscado);
                        if (cert != null)
                        {
                            return pinBuscado;
                        }
                    }
                    catch (Exception) { }
                }
                pinBuscado = string.Empty;
                return pinBuscado;
            });
        }

        #endregion Metodos

        #region Parallel For
        //var options = new ParallelOptions()
        //{
        //    MaxDegreeOfParallelism = 2
        //};

        //int temp = 1016;
        //int limit = 9999;

        //Parallel.For(temp, limit, new ParallelOptions { MaxDegreeOfParallelism = 10 }, i =>
        //Parallel.For(temp, limit, options, i =>
        //{
        //    // pinBuscado = temp.ToString();
        //    pinBuscado = i.ToString();
        //    try
        //    {
        //        cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //        if(cert.ToString() != null)
        //        {
        //            string pin = pinBuscado;
        //            DateTime tiempoFin = DateTime.Now;
        //            TimeSpan span = tiempoFin - tiempoInicio;
        //            int segundosTranscurridos = (int)span.TotalSeconds;
        //        }
        //       // return pinBuscado;
        //    }
        //    catch (Exception) { }
        //});


        //int[] nums = Enumerable.Range(0, 9999).ToArray();
        //long total = 0;

        // Use type parameter to make subtotal a long, not an int
        //Parallel.For<long>(temp, limit, () => 0, (j, loop, subtotal) =>
        //{
        //    pinBuscado = j.ToString();

        //    try
        //    {
        //        cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //        if (cert.ToString() != null)
        //        {
        //            string pin = pinBuscado;
        //            DateTime tiempoFin = DateTime.Now;
        //            TimeSpan span = tiempoFin - tiempoInicio;
        //            int segundosTranscurridos = (int)span.TotalSeconds;
        //        }
        //        // return pinBuscado;
        //    }
        //    catch (Exception) { }

        //    //return subtotal;
        //    return long.Parse(pinBuscado);
        //},
        //    (x) => Interlocked.Add(ref total, x)
        //);
        #endregion Parallel For

        private async void button1_Click(object sender, EventArgs e)
        {
            PicProcesando.Visible = true;
            DateTime tiempoInicio = DateTime.Now;

            // ObtenerPIN();                    // Esta llamada se usa con el metodo sincronico ObtenerPin
            pinBuscado = await ObtenerPIN2();    // Esta llamada se usa con el metodo asincronico ObtenerPin

            DateTime tiempoFin = DateTime.Now;
            TimeSpan span = tiempoFin - tiempoInicio;
            double segundosTranscurridos = (double)span.TotalMilliseconds / 1000;
            LblPinConsultado.Text = segundosTranscurridos.ToString();
            TxtPin.Text = pinBuscado;

            if (pinBuscado != string.Empty)
            {
                MostrarDatosCertificado();
                PicProcesando.Visible = false;
            }
            else
            {
                PicProcesando.Visible = false;
                // MessageBox.Show("No se encontró el PIN para este certificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
