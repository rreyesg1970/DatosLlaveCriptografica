using System;
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

        private void Form1_Load(object sender, EventArgs e)
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
            }
        }

        private void BtnObtenerInfo_Click(object sender, EventArgs e)
        {
            ObtenerInfo();
        }

        private void TxtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ObtenerInfo();
            }
        }

        private void BtnObtenerInfo_KeyDown(object sender, KeyEventArgs e)
        {
            ObtenerInfo();
        }
        private void BtnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void ObtenerInfo()
        {
            certificadoEncontrado = VerificaCertificadoSeleccionado();
            if (!certificadoEncontrado)
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
                return;
            }

            if (!string.IsNullOrEmpty(TxtPin.Text))
            {
                try
                {
                    pinCertificado = TxtPin.Text;
                    cert = new X509Certificate2(rutayArchivo, pinCertificado);
                    fechaCertificado = certificadoP12.Substring(0, 12);
                    fechaTemp = fechaCertificado;

                    string certificadoVenta = cert.NotAfter.ToString("dd-MMMM-yyyy");
                    TxtInfoLlaveCriptografica.Text = $"Fecha de Vencimiento =   {certificadoVenta}";
                    TxtInfoLlaveCriptografica.AppendText("\r\n");
                    TxtInfoLlaveCriptografica.AppendText("\r\n");
                    TxtInfoLlaveCriptografica.AppendText(cert.IssuerName.Name.ToString());
                    TxtInfoLlaveCriptografica.AppendText("\r\n");
                    TxtInfoLlaveCriptografica.AppendText("\r\n");
                    TxtInfoLlaveCriptografica.AppendText(cert.Subject.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("El PIN ingresado es incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool VerificaCertificadoSeleccionado()
        {
            string certTemp = certificadoP12;

            if (certTemp != null)
            {
                return certificadoEncontrado = true;
            }

            return certificadoEncontrado = false;
        }

        private async void BtnAveriguarPIN_Click(object sender, EventArgs e)
        {
            PicProcesando.Visible = true;
            DateTime tiempoInicio = DateTime.Now;

            pinBuscado = await ObtenerPIN();

            DateTime tiempoFin = DateTime.Now;
            TimeSpan span = tiempoFin - tiempoInicio;
            double segundosTranscurridos = (double)span.TotalMilliseconds / 1000;
            LblPinConsultado.Text = segundosTranscurridos.ToString();

            TxtPin.Text = pinBuscado;

            ObtenerInfo();
            PicProcesando.Visible = false;
        }

        // Metodo sincronico que bloquea la GUI y devuelve un valor (string)
        //private string ObtenerPIN()
        //{
        //    {
        //        for (int i = 9000; i < 9999; i++)
        //        {
        //            pinBuscado = i.ToString();
        //            try
        //            {
        //                cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //                PicProcesando.Visible = false;
        //                return pinBuscado;
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
        //        for (int i = 1016; i < 1020; i++)
        //        {
        //            pinBuscado = i.ToString();
        //            try
        //            {
        //                cert = new X509Certificate2(rutayArchivo, pinBuscado);
        //                PicProcesando.Visible = false;

        //                //return pinBuscado;
        //            }
        //            catch (Exception) { }
        //        }
        //        // return pinBuscado;
        //    });
        //}

        // Metodo Asyncronico que no bloquea la GUI y que devuelve un valor (string)

        private async Task<string> ObtenerPIN()
        {
            return await Task<string>.Run(() =>
            {
                for (int i = 1000; i < 9999; i++)
                {
                    pinBuscado = i.ToString();
                    try
                    {
                        cert = new X509Certificate2(rutayArchivo, pinBuscado);
                        return pinBuscado;
                    }
                    catch (Exception) { }
                }

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

                return pinBuscado;
            });
        }


        private void LimpiarDatos()
        {
            TxtPath.Clear();
            TxtPin.Clear();
            TxtInfoLlaveCriptografica.Clear();
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        
    }
}
