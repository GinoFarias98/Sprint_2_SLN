namespace Sprint_2
{
    partial class CalculoBeneficio
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuotasPagadas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNSuscripto = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbNSuscripto = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btBuscarCalcular = new System.Windows.Forms.Button();
            this.txtBeneficio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorCompradoPlan = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantCuotasPagadas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNsuctiproBenef = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMontoCuotaB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCuotasPagadasB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNSuscriptoB = new System.Windows.Forms.TextBox();
            this.txtDNIB = new System.Windows.Forms.TextBox();
            this.txtTelefonoB = new System.Windows.Forms.TextBox();
            this.txtApellidoB = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btMostrarGrid = new System.Windows.Forms.Button();
            this.btLimpiarGrid = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(154, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 396);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btLimpiarGrid);
            this.tabPage1.Controls.Add(this.btMostrarGrid);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMontoCuota);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtCuotasPagadas);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNSuscripto);
            this.tabPage1.Controls.Add(this.txtDNI);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Suscrito";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Monto cuota";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.Location = new System.Drawing.Point(106, 183);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.Size = new System.Drawing.Size(116, 20);
            this.txtMontoCuota.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cuotas pagadas";
            // 
            // txtCuotasPagadas
            // 
            this.txtCuotasPagadas.Location = new System.Drawing.Point(106, 157);
            this.txtCuotasPagadas.Name = "txtCuotasPagadas";
            this.txtCuotasPagadas.Size = new System.Drawing.Size(116, 20);
            this.txtCuotasPagadas.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "N° Suscrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // txtNSuscripto
            // 
            this.txtNSuscripto.Location = new System.Drawing.Point(106, 131);
            this.txtNSuscripto.Name = "txtNSuscripto";
            this.txtNSuscripto.Size = new System.Drawing.Size(116, 20);
            this.txtNSuscripto.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(106, 105);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(116, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(106, 79);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btLimpiar);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtMontoCuotaB);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtCuotasPagadasB);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtNSuscriptoB);
            this.tabPage2.Controls.Add(this.txtDNIB);
            this.tabPage2.Controls.Add(this.txtTelefonoB);
            this.tabPage2.Controls.Add(this.txtApellidoB);
            this.tabPage2.Controls.Add(this.txtNombreB);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAbuscar);
            this.tabPage2.Controls.Add(this.btBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Suscrito";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbDNI);
            this.flowLayoutPanel1.Controls.Add(this.rbNSuscripto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(190, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(117, 53);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(3, 3);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Tag = "DNI";
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbNSuscripto
            // 
            this.rbNSuscripto.AutoSize = true;
            this.rbNSuscripto.Location = new System.Drawing.Point(3, 26);
            this.rbNSuscripto.Name = "rbNSuscripto";
            this.rbNSuscripto.Size = new System.Drawing.Size(109, 17);
            this.rbNSuscripto.TabIndex = 1;
            this.rbNSuscripto.TabStop = true;
            this.rbNSuscripto.Tag = "aNSuscripto";
            this.rbNSuscripto.Text = "Numero Suscripto";
            this.rbNSuscripto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Elemento a buscar";
            // 
            // txtAbuscar
            // 
            this.txtAbuscar.Location = new System.Drawing.Point(6, 39);
            this.txtAbuscar.Name = "txtAbuscar";
            this.txtAbuscar.Size = new System.Drawing.Size(178, 20);
            this.txtAbuscar.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(9, 75);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btCalcular);
            this.tabPage3.Controls.Add(this.btBuscarCalcular);
            this.tabPage3.Controls.Add(this.txtBeneficio);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtValorCompradoPlan);
            this.tabPage3.Controls.Add(this.txtMontoTotal);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtCantCuotasPagadas);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtNsuctiproBenef);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(476, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calcular Beneficio Del Plan";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(248, 240);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 15;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btBuscarCalcular
            // 
            this.btBuscarCalcular.Location = new System.Drawing.Point(3, 67);
            this.btBuscarCalcular.Name = "btBuscarCalcular";
            this.btBuscarCalcular.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCalcular.TabIndex = 14;
            this.btBuscarCalcular.Text = "Buscar";
            this.btBuscarCalcular.UseVisualStyleBackColor = true;
            this.btBuscarCalcular.Click += new System.EventHandler(this.btBuscarCalcular_Click);
            // 
            // txtBeneficio
            // 
            this.txtBeneficio.Location = new System.Drawing.Point(248, 214);
            this.txtBeneficio.Name = "txtBeneficio";
            this.txtBeneficio.Size = new System.Drawing.Size(178, 20);
            this.txtBeneficio.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Beneficio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Valor al que se compro el plan";
            // 
            // txtValorCompradoPlan
            // 
            this.txtValorCompradoPlan.Location = new System.Drawing.Point(248, 156);
            this.txtValorCompradoPlan.Name = "txtValorCompradoPlan";
            this.txtValorCompradoPlan.Size = new System.Drawing.Size(178, 20);
            this.txtValorCompradoPlan.TabIndex = 10;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(3, 214);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(178, 20);
            this.txtMontoTotal.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Monto de cuotas abonadas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cantidad de cuotas pagadas ";
            // 
            // txtCantCuotasPagadas
            // 
            this.txtCantCuotasPagadas.Location = new System.Drawing.Point(3, 156);
            this.txtCantCuotasPagadas.Name = "txtCantCuotasPagadas";
            this.txtCantCuotasPagadas.Size = new System.Drawing.Size(178, 20);
            this.txtCantCuotasPagadas.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Numero suscripto";
            // 
            // txtNsuctiproBenef
            // 
            this.txtNsuctiproBenef.Location = new System.Drawing.Point(3, 41);
            this.txtNsuctiproBenef.Name = "txtNsuctiproBenef";
            this.txtNsuctiproBenef.Size = new System.Drawing.Size(178, 20);
            this.txtNsuctiproBenef.TabIndex = 3;
            this.txtNsuctiproBenef.Tag = "aNSuscripto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Monto cuota";
            // 
            // txtMontoCuotaB
            // 
            this.txtMontoCuotaB.Location = new System.Drawing.Point(121, 286);
            this.txtMontoCuotaB.Name = "txtMontoCuotaB";
            this.txtMontoCuotaB.Size = new System.Drawing.Size(116, 20);
            this.txtMontoCuotaB.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Cuotas pagadas";
            // 
            // txtCuotasPagadasB
            // 
            this.txtCuotasPagadasB.Location = new System.Drawing.Point(121, 260);
            this.txtCuotasPagadasB.Name = "txtCuotasPagadasB";
            this.txtCuotasPagadasB.Size = new System.Drawing.Size(116, 20);
            this.txtCuotasPagadasB.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "N° Suscrito";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "DNI";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Telefono";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Apellido";
            // 
            // txtNSuscriptoB
            // 
            this.txtNSuscriptoB.Location = new System.Drawing.Point(121, 234);
            this.txtNSuscriptoB.Name = "txtNSuscriptoB";
            this.txtNSuscriptoB.Size = new System.Drawing.Size(116, 20);
            this.txtNSuscriptoB.TabIndex = 21;
            // 
            // txtDNIB
            // 
            this.txtDNIB.Location = new System.Drawing.Point(121, 208);
            this.txtDNIB.Name = "txtDNIB";
            this.txtDNIB.Size = new System.Drawing.Size(116, 20);
            this.txtDNIB.TabIndex = 20;
            // 
            // txtTelefonoB
            // 
            this.txtTelefonoB.Location = new System.Drawing.Point(121, 182);
            this.txtTelefonoB.Name = "txtTelefonoB";
            this.txtTelefonoB.Size = new System.Drawing.Size(116, 20);
            this.txtTelefonoB.TabIndex = 19;
            // 
            // txtApellidoB
            // 
            this.txtApellidoB.Location = new System.Drawing.Point(121, 156);
            this.txtApellidoB.Name = "txtApellidoB";
            this.txtApellidoB.Size = new System.Drawing.Size(116, 20);
            this.txtApellidoB.TabIndex = 18;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(121, 130);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(116, 20);
            this.txtNombreB.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Nombre";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(24, 341);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 30;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 127);
            this.dataGridView1.TabIndex = 16;
            // 
            // btMostrarGrid
            // 
            this.btMostrarGrid.Location = new System.Drawing.Point(268, 205);
            this.btMostrarGrid.Name = "btMostrarGrid";
            this.btMostrarGrid.Size = new System.Drawing.Size(98, 26);
            this.btMostrarGrid.TabIndex = 17;
            this.btMostrarGrid.Text = "Mostrar datos";
            this.btMostrarGrid.UseVisualStyleBackColor = true;
            this.btMostrarGrid.Click += new System.EventHandler(this.btMostrarGrid_Click);
            // 
            // btLimpiarGrid
            // 
            this.btLimpiarGrid.Location = new System.Drawing.Point(372, 205);
            this.btLimpiarGrid.Name = "btLimpiarGrid";
            this.btLimpiarGrid.Size = new System.Drawing.Size(98, 26);
            this.btLimpiarGrid.TabIndex = 18;
            this.btLimpiarGrid.Text = "Limpiar";
            this.btLimpiarGrid.UseVisualStyleBackColor = true;
            this.btLimpiarGrid.Click += new System.EventHandler(this.btLimpiarGrid_Click);
            // 
            // CalculoBeneficio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalculoBeneficio";
            this.Text = "CalculoBeneficio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNSuscripto;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuotasPagadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbNSuscripto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantCuotasPagadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNsuctiproBenef;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtBeneficio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtValorCompradoPlan;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btBuscarCalcular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoCuotaB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCuotasPagadasB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNSuscriptoB;
        private System.Windows.Forms.TextBox txtDNIB;
        private System.Windows.Forms.TextBox txtTelefonoB;
        private System.Windows.Forms.TextBox txtApellidoB;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btLimpiarGrid;
        private System.Windows.Forms.Button btMostrarGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}