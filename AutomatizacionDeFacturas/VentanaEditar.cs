using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace AutomatizacionDeFacturas
{
    public partial class VentanaEditar : Form
    {
        PaginaPrincipal principal;
        public void PopulateEditForm(Solicitud solicitud)
        {
            this.textBoxPaciente.Text = solicitud.Paciente;
            this.textBoxRazonSocial.Text = solicitud.RazonSocial;
            this.textBoxRFC.Text = solicitud.RFC;
            this.comboBoxRegimen.Text = solicitud.Regimen.ToString();
            this.comboBoxCFDI.Text = solicitud.CFDI;
            this.textBoxCorreo.Text = solicitud.Correo;
            this.textBoxCodigoPostal.Text = solicitud.CP.ToString();
            this.textBoxMonto.Text = solicitud.Monto.ToString();
            this.comboBoxFormaDePago.Text = solicitud.FormaDePago;
            this.textBoxConcepto.Text = solicitud.Concepto;
            this.textBoxTelefono.Text = solicitud.Telefono.ToString();
        }
        public VentanaEditar(PaginaPrincipal p)
        {
            InitializeComponent();
            principal = p;
        }

        private void VentanaEditar_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("regimenesFiscales.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var regimenes = csv.GetRecords<dynamic>();
                    foreach (dynamic regimen in regimenes)
                    {
                        comboBoxRegimen.Items.Add(regimen.Clave);
                    }
                }
            }
            using (var reader2 = new StreamReader("usoDeCFDI.csv"))
            {
                using (var csv2 = new CsvReader(reader2, CultureInfo.InvariantCulture))
                {
                    var usosCFDI = csv2.GetRecords<dynamic>();
                    foreach (dynamic uso in usosCFDI)
                    {
                        comboBoxCFDI.Items.Add(uso.Clave);
                    }
                }
            }

            ListViewItem solicitudDeLista = principal.GetSelectedSolicitud();
            var solicitud = principal.ListViewItemToSolicitudClass(solicitudDeLista);
            this.PopulateEditForm(solicitud);
        }
    }
}
