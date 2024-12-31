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
                            if (solicitud.RazonSocial.Contains(textBoxRazonSocial.Text))
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

        private void textBoxRFC_TextChanged(object sender, EventArgs e)
        {
            textBoxRazonSocial.Clear();
            textBoxPaciente.Clear();
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
                            if (solicitud.RFC.Contains(textBoxRFC.Text))
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

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            textBoxRazonSocial.Clear();
            textBoxRFC.Clear();
            textBoxPaciente.Clear();
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
                            if (solicitud.Telefono.ToString().Contains(textBoxTelefono.Text))
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

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            textBoxRazonSocial.Clear();
            textBoxRFC.Clear();
            textBoxTelefono.Clear();
            textBoxPaciente.Clear();
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
                            if (solicitud.Correo.Contains(textBoxCorreo.Text))
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<Solicitud> solicitudesAGuardar = new List<Solicitud>();
            foreach (ListViewItem item in listViewSolicitudes.Items) {
                var solicitudAGuardar = new Solicitud();
                DateOnly fecha = DateOnly.ParseExact(item.SubItems[7].Text, "dd/MM/yyyy");
                solicitudAGuardar.Paciente = item.SubItems[0].Text;
                solicitudAGuardar.RazonSocial = item.SubItems[1].Text;
                solicitudAGuardar.RFC = item.SubItems[2].Text;
                solicitudAGuardar.Regimen = Convert.ToInt32(item.SubItems[3].Text);
                solicitudAGuardar.CFDI = item.SubItems[4].Text;
                solicitudAGuardar.Correo = item.SubItems[5].Text;
                solicitudAGuardar.CP = Convert.ToInt32(item.SubItems[6].Text);
                solicitudAGuardar.Fecha = fecha;
                solicitudAGuardar.Monto = Convert.ToInt32(item.SubItems[8].Text);
                solicitudAGuardar.FormaDePago = item.SubItems[9].Text;
                solicitudAGuardar.Concepto = item.SubItems[10].Text;
                solicitudAGuardar.Telefono = Convert.ToInt64(item.SubItems[11].Text);
                solicitudAGuardar.Estado = item.SubItems[12].Text;
                solicitudesAGuardar.Add(solicitudAGuardar);
            }
            using (var writer = new StreamWriter("solicitudes.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(solicitudesAGuardar);
            }
        }

        private void buttonMarcarEnviada_Click(object sender, EventArgs e)
        {
            listViewSolicitudes.SelectedItems[0].SubItems[12].Text = "Enviada";
        }
    }
}
