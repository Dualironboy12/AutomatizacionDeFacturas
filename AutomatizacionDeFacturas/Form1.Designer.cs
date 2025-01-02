namespace AutomatizacionDeFacturas
{
    partial class PaginaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelBotones = new FlowLayoutPanel();
            buttonAgregar = new Button();
            buttonEditar = new Button();
            buttonMarcarEnviada = new Button();
            buttonGenerarCorreos = new Button();
            buttonGuardar = new Button();
            panelBusqueda = new Panel();
            tableLayoutPanelBusqueda = new TableLayoutPanel();
            labelBuscar = new Label();
            textBoxPaciente = new TextBox();
            textBoxRazonSocial = new TextBox();
            textBoxRFC = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            panelLista = new Panel();
            listViewSolicitudes = new ListView();
            columnPaciente = new ColumnHeader();
            columnRazonSocial = new ColumnHeader();
            columnRFC = new ColumnHeader();
            columnRegimen = new ColumnHeader();
            columnCFDI = new ColumnHeader();
            columnCorreo = new ColumnHeader();
            columnCP = new ColumnHeader();
            columnFecha = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnFormaDePago = new ColumnHeader();
            columnConcepto = new ColumnHeader();
            columnTelefono = new ColumnHeader();
            columnEstado = new ColumnHeader();
            flowLayoutPanelBotones.SuspendLayout();
            panelBusqueda.SuspendLayout();
            tableLayoutPanelBusqueda.SuspendLayout();
            panelLista.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBotones
            // 
            flowLayoutPanelBotones.AutoSize = true;
            flowLayoutPanelBotones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelBotones.Controls.Add(buttonAgregar);
            flowLayoutPanelBotones.Controls.Add(buttonEditar);
            flowLayoutPanelBotones.Controls.Add(buttonMarcarEnviada);
            flowLayoutPanelBotones.Controls.Add(buttonGenerarCorreos);
            flowLayoutPanelBotones.Controls.Add(buttonGuardar);
            flowLayoutPanelBotones.Dock = DockStyle.Bottom;
            flowLayoutPanelBotones.Location = new Point(0, 480);
            flowLayoutPanelBotones.Name = "flowLayoutPanelBotones";
            flowLayoutPanelBotones.Padding = new Padding(10);
            flowLayoutPanelBotones.Size = new Size(1146, 51);
            flowLayoutPanelBotones.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            buttonAgregar.AutoSize = true;
            buttonAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAgregar.Location = new Point(13, 13);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(59, 25);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.AutoSize = true;
            buttonEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditar.Location = new Point(78, 13);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(47, 25);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonMarcarEnviada
            // 
            buttonMarcarEnviada.AutoSize = true;
            buttonMarcarEnviada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonMarcarEnviada.Location = new Point(131, 13);
            buttonMarcarEnviada.Name = "buttonMarcarEnviada";
            buttonMarcarEnviada.Size = new Size(134, 25);
            buttonMarcarEnviada.TabIndex = 2;
            buttonMarcarEnviada.Text = "Marcar Como Enviada";
            buttonMarcarEnviada.UseVisualStyleBackColor = true;
            buttonMarcarEnviada.Click += buttonMarcarEnviada_Click;
            // 
            // buttonGenerarCorreos
            // 
            buttonGenerarCorreos.AutoSize = true;
            buttonGenerarCorreos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonGenerarCorreos.Location = new Point(271, 13);
            buttonGenerarCorreos.Name = "buttonGenerarCorreos";
            buttonGenerarCorreos.Size = new Size(163, 25);
            buttonGenerarCorreos.TabIndex = 3;
            buttonGenerarCorreos.Text = "Generar Correos Pendientes";
            buttonGenerarCorreos.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(440, 13);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(tableLayoutPanelBusqueda);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Padding = new Padding(5);
            panelBusqueda.Size = new Size(1146, 100);
            panelBusqueda.TabIndex = 1;
            // 
            // tableLayoutPanelBusqueda
            // 
            tableLayoutPanelBusqueda.AutoSize = true;
            tableLayoutPanelBusqueda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelBusqueda.ColumnCount = 3;
            tableLayoutPanelBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.Controls.Add(labelBuscar, 0, 0);
            tableLayoutPanelBusqueda.Controls.Add(textBoxPaciente, 0, 1);
            tableLayoutPanelBusqueda.Controls.Add(textBoxRazonSocial, 1, 1);
            tableLayoutPanelBusqueda.Controls.Add(textBoxRFC, 2, 1);
            tableLayoutPanelBusqueda.Controls.Add(textBoxTelefono, 0, 2);
            tableLayoutPanelBusqueda.Controls.Add(textBoxCorreo, 1, 2);
            tableLayoutPanelBusqueda.Dock = DockStyle.Fill;
            tableLayoutPanelBusqueda.Location = new Point(5, 5);
            tableLayoutPanelBusqueda.Name = "tableLayoutPanelBusqueda";
            tableLayoutPanelBusqueda.Padding = new Padding(5);
            tableLayoutPanelBusqueda.RowCount = 3;
            tableLayoutPanelBusqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelBusqueda.Size = new Size(1136, 90);
            tableLayoutPanelBusqueda.TabIndex = 2;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Dock = DockStyle.Fill;
            labelBuscar.Location = new Point(8, 5);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(369, 26);
            labelBuscar.TabIndex = 0;
            labelBuscar.Text = "Buscar:";
            labelBuscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Dock = DockStyle.Fill;
            textBoxPaciente.Location = new Point(8, 34);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.PlaceholderText = "Paciente";
            textBoxPaciente.Size = new Size(369, 23);
            textBoxPaciente.TabIndex = 1;
            textBoxPaciente.TextChanged += textBoxPaciente_TextChanged;
            // 
            // textBoxRazonSocial
            // 
            textBoxRazonSocial.Dock = DockStyle.Fill;
            textBoxRazonSocial.Location = new Point(383, 34);
            textBoxRazonSocial.Name = "textBoxRazonSocial";
            textBoxRazonSocial.PlaceholderText = "Razon Social";
            textBoxRazonSocial.Size = new Size(369, 23);
            textBoxRazonSocial.TabIndex = 2;
            textBoxRazonSocial.TextChanged += textBoxRazonSocial_TextChanged;
            // 
            // textBoxRFC
            // 
            textBoxRFC.Dock = DockStyle.Fill;
            textBoxRFC.Location = new Point(758, 34);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.PlaceholderText = "RFC";
            textBoxRFC.Size = new Size(370, 23);
            textBoxRFC.TabIndex = 3;
            textBoxRFC.TextChanged += textBoxRFC_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Dock = DockStyle.Fill;
            textBoxTelefono.Location = new Point(8, 60);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(369, 23);
            textBoxTelefono.TabIndex = 4;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Dock = DockStyle.Fill;
            textBoxCorreo.Location = new Point(383, 60);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Correo";
            textBoxCorreo.Size = new Size(369, 23);
            textBoxCorreo.TabIndex = 5;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // panelLista
            // 
            panelLista.Controls.Add(listViewSolicitudes);
            panelLista.Dock = DockStyle.Fill;
            panelLista.Location = new Point(0, 100);
            panelLista.Name = "panelLista";
            panelLista.Padding = new Padding(10, 10, 10, 0);
            panelLista.Size = new Size(1146, 380);
            panelLista.TabIndex = 2;
            // 
            // listViewSolicitudes
            // 
            listViewSolicitudes.Columns.AddRange(new ColumnHeader[] { columnPaciente, columnRazonSocial, columnRFC, columnRegimen, columnCFDI, columnCorreo, columnCP, columnFecha, columnMonto, columnFormaDePago, columnConcepto, columnTelefono, columnEstado });
            listViewSolicitudes.Dock = DockStyle.Fill;
            listViewSolicitudes.GridLines = true;
            listViewSolicitudes.Location = new Point(10, 10);
            listViewSolicitudes.MultiSelect = false;
            listViewSolicitudes.Name = "listViewSolicitudes";
            listViewSolicitudes.Size = new Size(1126, 370);
            listViewSolicitudes.TabIndex = 0;
            listViewSolicitudes.UseCompatibleStateImageBehavior = false;
            listViewSolicitudes.View = View.Details;
            listViewSolicitudes.SelectedIndexChanged += listViewSolicitudes_SelectedIndexChanged;
            // 
            // columnPaciente
            // 
            columnPaciente.Text = "Paciente";
            // 
            // columnRazonSocial
            // 
            columnRazonSocial.Text = "Razon Social";
            // 
            // columnRFC
            // 
            columnRFC.Text = "RFC";
            // 
            // columnRegimen
            // 
            columnRegimen.Text = "Regimen";
            // 
            // columnCFDI
            // 
            columnCFDI.Text = "CFDI";
            // 
            // columnCorreo
            // 
            columnCorreo.Text = "Correo";
            // 
            // columnCP
            // 
            columnCP.Text = "CP";
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha de solicitud";
            // 
            // columnMonto
            // 
            columnMonto.Text = "Monto";
            // 
            // columnFormaDePago
            // 
            columnFormaDePago.Text = "Forma de Pago";
            // 
            // columnConcepto
            // 
            columnConcepto.Text = "Concepto";
            // 
            // columnTelefono
            // 
            columnTelefono.Text = "Telefono";
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 531);
            Controls.Add(panelLista);
            Controls.Add(panelBusqueda);
            Controls.Add(flowLayoutPanelBotones);
            Name = "PaginaPrincipal";
            Text = "Generador de Facturas";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            flowLayoutPanelBotones.ResumeLayout(false);
            flowLayoutPanelBotones.PerformLayout();
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            tableLayoutPanelBusqueda.ResumeLayout(false);
            tableLayoutPanelBusqueda.PerformLayout();
            panelLista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBotones;
        private Panel panelBusqueda;
        private TableLayoutPanel tableLayoutPanelBusqueda;
        private Button buttonAgregar;
        private Button buttonEditar;
        private Button buttonMarcarEnviada;
        private Button buttonGenerarCorreos;
        private Panel panelLista;
        private ListView listViewSolicitudes;
        private Label labelBuscar;
        private TextBox textBoxPaciente;
        private TextBox textBoxRazonSocial;
        private TextBox textBoxRFC;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private ColumnHeader columnPaciente;
        private ColumnHeader columnRazonSocial;
        private ColumnHeader columnRFC;
        private ColumnHeader columnRegimen;
        private ColumnHeader columnCFDI;
        private ColumnHeader columnCorreo;
        private ColumnHeader columnCP;
        private ColumnHeader columnFecha;
        private ColumnHeader columnMonto;
        private ColumnHeader columnFormaDePago;
        private ColumnHeader columnConcepto;
        private ColumnHeader columnTelefono;
        private ColumnHeader columnEstado;
        private Button buttonGuardar;
    }
}
