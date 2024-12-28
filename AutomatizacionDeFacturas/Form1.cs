using CsvHelper;
using System.Globalization;

namespace AutomatizacionDeFacturas
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var streamReader = new StreamReader("solicitudes.csv"))
                {
                    using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        var solicitudes = csvReader.GetRecords<Solicitud>();
                        foreach (var solicitud in solicitudes)
                        {
                            ListViewItem solicitudItem = new ListViewItem(solicitud.Paciente);
                            solicitudItem.SubItems.Add(solicitud.RazonSocial.ToString());
                            solicitudItem.SubItems.Add(solicitud.RFC.ToString());
                            solicitudItem.SubItems.Add(solicitud.Regimen.ToString());
                            solicitudItem.SubItems.Add(solicitud.CFDI.ToString());
                            solicitudItem.SubItems.Add(solicitud.Correo.ToString());
                            solicitudItem.SubItems.Add(solicitud.CP.ToString());
                            solicitudItem.SubItems.Add(solicitud.Fecha.ToString());
                            solicitudItem.SubItems.Add(solicitud.Monto.ToString());
                            solicitudItem.SubItems.Add(solicitud.FormaDePago.ToString());
                            solicitudItem.SubItems.Add(solicitud.Concepto.ToString());
                            solicitudItem.SubItems.Add(solicitud.Telefono.ToString());
                            solicitudItem.SubItems.Add(solicitud.Estado.ToString());
                            listViewSolicitudes.Items.Add(solicitudItem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPor favor seleccione la ubicacion de la base de datos.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listViewSolicitudes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPaciente_TextChanged(object sender, EventArgs e)
        {
            textBoxRazonSocial.Clear();
            textBoxRFC.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            listViewSolicitudes.Items.Clear();
            try
            {
                using (var reader = new StreamReader("solicitudes.csv"))
                {
                    using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var solicitudes = csvReader.GetRecords<Solicitud>();
                        foreach (var solicitud in solicitudes)
                        {
                            if (solicitud.Paciente.Contains(textBoxPaciente.Text))
                            {
                                ListViewItem solicitudItem = new ListViewItem(solicitud.Paciente);
                                solicitudItem.SubItems.Add(solicitud.RazonSocial.ToString());
                                solicitudItem.SubItems.Add(solicitud.RFC.ToString());
                                solicitudItem.SubItems.Add(solicitud.Regimen.ToString());
                                solicitudItem.SubItems.Add(solicitud.CFDI.ToString());
                                solicitudItem.SubItems.Add(solicitud.Correo.ToString());
                                solicitudItem.SubItems.Add(solicitud.CP.ToString());
                                solicitudItem.SubItems.Add(solicitud.Fecha.ToString());
                                solicitudItem.SubItems.Add(solicitud.Monto.ToString());
                                solicitudItem.SubItems.Add(solicitud.FormaDePago.ToString());
                                solicitudItem.SubItems.Add(solicitud.Concepto.ToString());
                                solicitudItem.SubItems.Add(solicitud.Telefono.ToString());
                                solicitudItem.SubItems.Add(solicitud.Estado.ToString());
                                listViewSolicitudes.Items.Add(solicitudItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPor favor seleccione la ubicacion de la base de datos.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxRazonSocial_TextChanged(object sender, EventArgs e)
        {
            textBoxPaciente.Clear();
            textBoxRFC.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            listViewSolicitudes.Items.Clear();
            try
            {
                using (var reader = new StreamReader("solicitudes.csv"))
                {
                    using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var solicitudes = csvReader.GetRecords<Solicitud>();
                        foreach (var solicitud in solicitudes)
                        {
                            if (solicitud.Paciente.Contains(textBoxRazonSocial.Text))
                            {
                                ListViewItem solicitudItem = new ListViewItem(solicitud.Paciente);
                                solicitudItem.SubItems.Add(solicitud.RazonSocial.ToString());
                                solicitudItem.SubItems.Add(solicitud.RFC.ToString());
                                solicitudItem.SubItems.Add(solicitud.Regimen.ToString());
                                solicitudItem.SubItems.Add(solicitud.CFDI.ToString());
                                solicitudItem.SubItems.Add(solicitud.Correo.ToString());
                                solicitudItem.SubItems.Add(solicitud.CP.ToString());
                                solicitudItem.SubItems.Add(solicitud.Fecha.ToString());
                                solicitudItem.SubItems.Add(solicitud.Monto.ToString());
                                solicitudItem.SubItems.Add(solicitud.FormaDePago.ToString());
                                solicitudItem.SubItems.Add(solicitud.Concepto.ToString());
                                solicitudItem.SubItems.Add(solicitud.Telefono.ToString());
                                solicitudItem.SubItems.Add(solicitud.Estado.ToString());
                                listViewSolicitudes.Items.Add(solicitudItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPor favor seleccione la ubicacion de la base de datos.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
