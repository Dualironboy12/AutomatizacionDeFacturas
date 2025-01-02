using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace AutomatizacionDeFacturas
{
    public partial class PaginaPrincipal : Form
    {
        IEnumerable<Solicitud> solicitudes;
        public Solicitud ListViewItemToSolicitudClass(ListViewItem item) {
            Solicitud solicitud = new Solicitud();
            DateOnly fecha = DateOnly.ParseExact(item.SubItems[7].Text, "dd/MM/yyyy");
            solicitud.Paciente = item.SubItems[0].Text;
            solicitud.RazonSocial = item.SubItems[1].Text;
            solicitud.RFC = item.SubItems[2].Text;
            solicitud.Regimen = Convert.ToInt32(item.SubItems[3].Text);
            solicitud.CFDI = item.SubItems[4].Text;
            solicitud.Correo = item.SubItems[5].Text;
            solicitud.CP = Convert.ToInt32(item.SubItems[6].Text);
            solicitud.Fecha = fecha;
            solicitud.Monto = Convert.ToInt32(item.SubItems[8].Text);
            solicitud.FormaDePago = item.SubItems[9].Text;
            solicitud.Concepto = item.SubItems[10].Text;
            solicitud.Telefono = Convert.ToInt64(item.SubItems[11].Text);
            solicitud.Estado = item.SubItems[12].Text;
            return solicitud;
        }
        public void PopulateListFromCSV(string path)
        {
            this.listViewSolicitudes.Items.Clear();
            using (var streamReader = new StreamReader(path)) {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    solicitudes = csvReader.GetRecords<Solicitud>();
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
        public void GuardarListaEnCSV(string path) {
            List<Solicitud> solicitudesAGuardar = new List<Solicitud>();
            foreach (ListViewItem item in this.listViewSolicitudes.Items)
            {
                var solicitudAGuardar = ListViewItemToSolicitudClass(item);
                solicitudesAGuardar.Add(solicitudAGuardar);
            }
            using (var writer = new StreamWriter(path))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(solicitudesAGuardar);
                }
            }
        }
        public ListViewItem GetSelectedSolicitud()
        {
            return this.listViewSolicitudes.SelectedItems[0];
        }
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListFromCSV("solicitudes.csv");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listViewSolicitudes.SelectedItems.Count.Equals(0))
            {
                MessageBox.Show("Por favor seleccione un item para editar","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ventanaEditar = new VentanaEditar(this);
                ventanaEditar.ShowDialog();
            }
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
            GuardarListaEnCSV("solicitudes.csv");
        }

        private void buttonMarcarEnviada_Click(object sender, EventArgs e)
        {
            listViewSolicitudes.SelectedItems[0].SubItems[12].Text = "Enviada";
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var ventanaAgregar = new VentanaAgregar(this);
            ventanaAgregar.Show();
        }
    }
}
