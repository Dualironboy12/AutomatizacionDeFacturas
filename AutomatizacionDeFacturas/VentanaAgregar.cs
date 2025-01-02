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
    public partial class VentanaAgregar : Form
    {
        PaginaPrincipal principal;
        public VentanaAgregar(PaginaPrincipal p)
        {
            InitializeComponent();
            principal = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using var readerRegimenes = new StreamReader("regimenesFiscales.csv");
            using var csvRegimenes = new CsvReader(readerRegimenes, CultureInfo.InvariantCulture);
            var regimenes = csvRegimenes.GetRecords<dynamic>();

            using var readerCFDI = new StreamReader("usoDeCFDI.csv");
            using var csvCFDI = new CsvReader(readerCFDI, CultureInfo.InvariantCulture);
            var usosCFDI = csvCFDI.GetRecords<dynamic>();

            var solicitudNueva = new Solicitud();
            solicitudNueva.Paciente = textBoxPaciente.Text;
            solicitudNueva.RazonSocial = textBoxRazonSocial.Text;
            solicitudNueva.RFC = textBoxRFC.Text;
            foreach (var regimen in regimenes)
            {
                if (comboBoxRegimen.Text.Equals(regimen.Clave))
                {
                    solicitudNueva.Regimen = Convert.ToInt16(regimen.Clave);
                }
            }
            foreach (var uso in usosCFDI)
            {
                if (comboBoxCFDI.Text.Equals(uso.Clave))
                {
                    solicitudNueva.CFDI = uso.Clave;
                }
            }
            solicitudNueva.Correo = textBoxCorreo.Text;
            solicitudNueva.CP = Convert.ToInt32(textBoxCP.Text);
            solicitudNueva.Fecha = DateOnly.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy");
            solicitudNueva.Monto = Convert.ToInt32(textBoxMonto.Text);
            solicitudNueva.FormaDePago = comboBoxFormaDePago.Text;
            solicitudNueva.Concepto = textBoxConcepto.Text;
            solicitudNueva.Telefono = Convert.ToInt64(textBoxTelefono.Text);
            solicitudNueva.Estado = "Pendiente";

            using (var writer = new StreamWriter("solicitudes.csv", true))
            {
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecord(solicitudNueva);
                }
            }

            readerRegimenes.Close();
            readerCFDI.Close();
            principal.PopulateListFromCSV("solicitudes.csv");
            this.Close();
        }

        private void VentanaAgregar_Load(object sender, EventArgs e)
        {
            using var reader = new StreamReader("regimenesFiscales.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var regimenes = csv.GetRecords<dynamic>();
            foreach (dynamic regimen in regimenes)
            {
                comboBoxRegimen.Items.Add(regimen.Clave);
            }
            reader.Close();
            using var reader2 = new StreamReader("usoDeCFDI.csv");
            using var csv2 = new CsvReader(reader2, CultureInfo.InvariantCulture);
            var usosCFDI = csv2.GetRecords<dynamic>();
            foreach (dynamic uso in usosCFDI)
            {
                comboBoxCFDI.Items.Add(uso.Clave);
            }
            reader2.Close();
        }

        private void VentanaAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
