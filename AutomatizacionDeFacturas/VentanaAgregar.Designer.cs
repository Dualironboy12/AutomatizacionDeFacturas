namespace AutomatizacionDeFacturas
{
    partial class VentanaAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutAgregar = new FlowLayoutPanel();
            labelPaciente = new Label();
            textBoxPaciente = new TextBox();
            labelRazonSocial = new Label();
            textBoxRazonSocial = new TextBox();
            labelRFC = new Label();
            textBoxRFC = new TextBox();
            labelRegimen = new Label();
            comboBoxRegimen = new ComboBox();
            labelCFDI = new Label();
            comboBoxCFDI = new ComboBox();
            labelCorreo = new Label();
            textBoxCorreo = new TextBox();
            labelCP = new Label();
            textBoxCP = new TextBox();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            labelFormaDePago = new Label();
            comboBoxFormaDePago = new ComboBox();
            labelConcepto = new Label();
            textBoxConcepto = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            buttonAgregar = new Button();
            flowLayoutAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutAgregar
            // 
            flowLayoutAgregar.Controls.Add(labelPaciente);
            flowLayoutAgregar.Controls.Add(textBoxPaciente);
            flowLayoutAgregar.Controls.Add(labelRazonSocial);
            flowLayoutAgregar.Controls.Add(textBoxRazonSocial);
            flowLayoutAgregar.Controls.Add(labelRFC);
            flowLayoutAgregar.Controls.Add(textBoxRFC);
            flowLayoutAgregar.Controls.Add(labelRegimen);
            flowLayoutAgregar.Controls.Add(comboBoxRegimen);
            flowLayoutAgregar.Controls.Add(labelCFDI);
            flowLayoutAgregar.Controls.Add(comboBoxCFDI);
            flowLayoutAgregar.Controls.Add(labelCorreo);
            flowLayoutAgregar.Controls.Add(textBoxCorreo);
            flowLayoutAgregar.Controls.Add(labelCP);
            flowLayoutAgregar.Controls.Add(textBoxCP);
            flowLayoutAgregar.Controls.Add(labelMonto);
            flowLayoutAgregar.Controls.Add(textBoxMonto);
            flowLayoutAgregar.Controls.Add(labelFormaDePago);
            flowLayoutAgregar.Controls.Add(comboBoxFormaDePago);
            flowLayoutAgregar.Controls.Add(labelConcepto);
            flowLayoutAgregar.Controls.Add(textBoxConcepto);
            flowLayoutAgregar.Controls.Add(labelTelefono);
            flowLayoutAgregar.Controls.Add(textBoxTelefono);
            flowLayoutAgregar.Controls.Add(buttonAgregar);
            flowLayoutAgregar.Dock = DockStyle.Fill;
            flowLayoutAgregar.Location = new Point(0, 0);
            flowLayoutAgregar.Name = "flowLayoutAgregar";
            flowLayoutAgregar.Padding = new Padding(20);
            flowLayoutAgregar.Size = new Size(631, 158);
            flowLayoutAgregar.TabIndex = 0;
            // 
            // labelPaciente
            // 
            labelPaciente.AutoSize = true;
            labelPaciente.Location = new Point(23, 25);
            labelPaciente.Margin = new Padding(3, 5, 3, 0);
            labelPaciente.Name = "labelPaciente";
            labelPaciente.Size = new Size(55, 15);
            labelPaciente.TabIndex = 0;
            labelPaciente.Text = "Paciente:";
            labelPaciente.Click += label1_Click;
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Location = new Point(84, 23);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.PlaceholderText = "Paciente";
            textBoxPaciente.Size = new Size(145, 23);
            textBoxPaciente.TabIndex = 1;
            // 
            // labelRazonSocial
            // 
            labelRazonSocial.AutoSize = true;
            labelRazonSocial.Location = new Point(235, 25);
            labelRazonSocial.Margin = new Padding(3, 5, 3, 0);
            labelRazonSocial.Name = "labelRazonSocial";
            labelRazonSocial.Size = new Size(76, 15);
            labelRazonSocial.TabIndex = 2;
            labelRazonSocial.Text = "Razon Social:";
            // 
            // textBoxRazonSocial
            // 
            textBoxRazonSocial.Location = new Point(317, 23);
            textBoxRazonSocial.Name = "textBoxRazonSocial";
            textBoxRazonSocial.PlaceholderText = "Razon Social";
            textBoxRazonSocial.Size = new Size(145, 23);
            textBoxRazonSocial.TabIndex = 3;
            // 
            // labelRFC
            // 
            labelRFC.AutoSize = true;
            labelRFC.Location = new Point(468, 25);
            labelRFC.Margin = new Padding(3, 5, 3, 0);
            labelRFC.Name = "labelRFC";
            labelRFC.Size = new Size(31, 15);
            labelRFC.TabIndex = 4;
            labelRFC.Text = "RFC:";
            // 
            // textBoxRFC
            // 
            textBoxRFC.Location = new Point(505, 23);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.PlaceholderText = "RFC";
            textBoxRFC.Size = new Size(103, 23);
            textBoxRFC.TabIndex = 5;
            // 
            // labelRegimen
            // 
            labelRegimen.AutoSize = true;
            labelRegimen.Location = new Point(23, 54);
            labelRegimen.Margin = new Padding(3, 5, 3, 0);
            labelRegimen.Name = "labelRegimen";
            labelRegimen.Size = new Size(89, 15);
            labelRegimen.TabIndex = 6;
            labelRegimen.Text = "Regimen Fiscal:";
            // 
            // comboBoxRegimen
            // 
            comboBoxRegimen.FormattingEnabled = true;
            comboBoxRegimen.Location = new Point(118, 52);
            comboBoxRegimen.Name = "comboBoxRegimen";
            comboBoxRegimen.Size = new Size(100, 23);
            comboBoxRegimen.TabIndex = 7;
            comboBoxRegimen.Text = "Regimen";
            // 
            // labelCFDI
            // 
            labelCFDI.AutoSize = true;
            labelCFDI.Location = new Point(224, 54);
            labelCFDI.Margin = new Padding(3, 5, 3, 0);
            labelCFDI.Name = "labelCFDI";
            labelCFDI.Size = new Size(74, 15);
            labelCFDI.TabIndex = 8;
            labelCFDI.Text = "Uso de CFDI:";
            // 
            // comboBoxCFDI
            // 
            comboBoxCFDI.FormattingEnabled = true;
            comboBoxCFDI.Location = new Point(304, 52);
            comboBoxCFDI.Name = "comboBoxCFDI";
            comboBoxCFDI.Size = new Size(100, 23);
            comboBoxCFDI.TabIndex = 9;
            comboBoxCFDI.Text = "CFDI";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(410, 54);
            labelCorreo.Margin = new Padding(3, 5, 3, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 10;
            labelCorreo.Text = "Correo:";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(462, 52);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Correo";
            textBoxCorreo.Size = new Size(146, 23);
            textBoxCorreo.TabIndex = 11;
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.Location = new Point(23, 83);
            labelCP.Margin = new Padding(3, 5, 3, 0);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(84, 15);
            labelCP.TabIndex = 12;
            labelCP.Text = "Codigo Postal:";
            // 
            // textBoxCP
            // 
            textBoxCP.Location = new Point(113, 81);
            textBoxCP.Name = "textBoxCP";
            textBoxCP.PlaceholderText = "Codigo Postal";
            textBoxCP.Size = new Size(105, 23);
            textBoxCP.TabIndex = 13;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(224, 83);
            labelMonto.Margin = new Padding(3, 5, 3, 0);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(46, 15);
            labelMonto.TabIndex = 14;
            labelMonto.Text = "Monto:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(276, 81);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.PlaceholderText = "Monto";
            textBoxMonto.Size = new Size(105, 23);
            textBoxMonto.TabIndex = 15;
            // 
            // labelFormaDePago
            // 
            labelFormaDePago.AutoSize = true;
            labelFormaDePago.Location = new Point(387, 83);
            labelFormaDePago.Margin = new Padding(3, 5, 3, 0);
            labelFormaDePago.Name = "labelFormaDePago";
            labelFormaDePago.Size = new Size(90, 15);
            labelFormaDePago.TabIndex = 16;
            labelFormaDePago.Text = "Forma de Pago:";
            // 
            // comboBoxFormaDePago
            // 
            comboBoxFormaDePago.FormattingEnabled = true;
            comboBoxFormaDePago.Items.AddRange(new object[] { "Efectivo", "Credito", "Debito", "Transferencia" });
            comboBoxFormaDePago.Location = new Point(483, 81);
            comboBoxFormaDePago.Name = "comboBoxFormaDePago";
            comboBoxFormaDePago.Size = new Size(125, 23);
            comboBoxFormaDePago.TabIndex = 17;
            comboBoxFormaDePago.Text = "Froma de Pago";
            // 
            // labelConcepto
            // 
            labelConcepto.AutoSize = true;
            labelConcepto.Location = new Point(23, 112);
            labelConcepto.Margin = new Padding(3, 5, 3, 0);
            labelConcepto.Name = "labelConcepto";
            labelConcepto.Size = new Size(62, 15);
            labelConcepto.TabIndex = 18;
            labelConcepto.Text = "Concepto:";
            // 
            // textBoxConcepto
            // 
            textBoxConcepto.Location = new Point(91, 110);
            textBoxConcepto.Name = "textBoxConcepto";
            textBoxConcepto.PlaceholderText = "Concepto";
            textBoxConcepto.Size = new Size(269, 23);
            textBoxConcepto.TabIndex = 19;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(366, 112);
            labelTelefono.Margin = new Padding(3, 5, 3, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 20;
            labelTelefono.Text = "Telefono:";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(427, 110);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(100, 23);
            textBoxTelefono.TabIndex = 21;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(533, 110);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 22;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // VentanaAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 158);
            Controls.Add(flowLayoutAgregar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "VentanaAgregar";
            Text = "Agregar Nueva Solicitud";
            FormClosed += VentanaAgregar_FormClosed;
            Load += VentanaAgregar_Load;
            flowLayoutAgregar.ResumeLayout(false);
            flowLayoutAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutAgregar;
        private Label labelPaciente;
        private TextBox textBoxPaciente;
        private Label labelRazonSocial;
        private TextBox textBoxRazonSocial;
        private Label labelRFC;
        private TextBox textBoxRFC;
        private Label labelRegimen;
        private ComboBox comboBoxRegimen;
        private Label labelCFDI;
        private ComboBox comboBoxCFDI;
        private Label labelCorreo;
        private TextBox textBoxCorreo;
        private Label labelCP;
        private TextBox textBoxCP;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private Label labelFormaDePago;
        private ComboBox comboBoxFormaDePago;
        private Label labelConcepto;
        private TextBox textBoxConcepto;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Button buttonAgregar;
    }
}