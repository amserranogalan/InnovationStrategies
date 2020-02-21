namespace InnovationStrategies
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPoints = new System.Windows.Forms.NumericUpDown();
            this.txtInfringement = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOkDriver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurnames = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbNumberInfringement = new System.Windows.Forms.ComboBox();
            this.btnOkInfringement = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOkVehicles = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniConductorHabitual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVehicleRegistration = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchDni = new System.Windows.Forms.TextBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvHabitualInfractions = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.btnSearchTopDrivers = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTopDrivers = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDniDriver = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVehicleDriver = new System.Windows.Forms.TextBox();
            this.btnVehicleDriver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitualInfractions)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopDrivers)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 239);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOk);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudPoints);
            this.tabPage1.Controls.Add(this.txtInfringement);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipo Infracción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(336, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puntos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Infracción";
            // 
            // nudPoints
            // 
            this.nudPoints.Location = new System.Drawing.Point(77, 44);
            this.nudPoints.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPoints.Name = "nudPoints";
            this.nudPoints.Size = new System.Drawing.Size(120, 20);
            this.nudPoints.TabIndex = 1;
            this.nudPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtInfringement
            // 
            this.txtInfringement.Location = new System.Drawing.Point(77, 18);
            this.txtInfringement.Name = "txtInfringement";
            this.txtInfringement.Size = new System.Drawing.Size(334, 20);
            this.txtInfringement.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOkDriver);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSurnames);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDni);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conductor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOkDriver
            // 
            this.btnOkDriver.Location = new System.Drawing.Point(373, 118);
            this.btnOkDriver.Name = "btnOkDriver";
            this.btnOkDriver.Size = new System.Drawing.Size(75, 23);
            this.btnOkDriver.TabIndex = 9;
            this.btnOkDriver.Text = "OK";
            this.btnOkDriver.UseVisualStyleBackColor = true;
            this.btnOkDriver.Click += new System.EventHandler(this.btnOkDriver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellidos";
            // 
            // txtSurnames
            // 
            this.txtSurnames.Location = new System.Drawing.Point(84, 72);
            this.txtSurnames.Name = "txtSurnames";
            this.txtSurnames.Size = new System.Drawing.Size(364, 20);
            this.txtSurnames.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(84, 20);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(108, 20);
            this.txtDni.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbNumberInfringement);
            this.tabPage3.Controls.Add(this.btnOkInfringement);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtVehicle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(720, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Infracción";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbNumberInfringement
            // 
            this.cmbNumberInfringement.FormattingEnabled = true;
            this.cmbNumberInfringement.Location = new System.Drawing.Point(125, 40);
            this.cmbNumberInfringement.Name = "cmbNumberInfringement";
            this.cmbNumberInfringement.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberInfringement.TabIndex = 11;
            // 
            // btnOkInfringement
            // 
            this.btnOkInfringement.Location = new System.Drawing.Point(171, 67);
            this.btnOkInfringement.Name = "btnOkInfringement";
            this.btnOkInfringement.Size = new System.Drawing.Size(75, 23);
            this.btnOkInfringement.TabIndex = 10;
            this.btnOkInfringement.Text = "OK";
            this.btnOkInfringement.UseVisualStyleBackColor = true;
            this.btnOkInfringement.Click += new System.EventHandler(this.btnOkInfringement_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo Infracción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vehículo";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(125, 15);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(121, 20);
            this.txtVehicle.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnOkVehicles);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtDniConductorHabitual);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtModel);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtBrand);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtVehicleRegistration);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(817, 213);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vehículos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOkVehicles
            // 
            this.btnOkVehicles.Location = new System.Drawing.Point(187, 133);
            this.btnOkVehicles.Name = "btnOkVehicles";
            this.btnOkVehicles.Size = new System.Drawing.Size(75, 23);
            this.btnOkVehicles.TabIndex = 15;
            this.btnOkVehicles.Text = "OK";
            this.btnOkVehicles.UseVisualStyleBackColor = true;
            this.btnOkVehicles.Click += new System.EventHandler(this.btnOkVehicles_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "DNI Conductor Habitual";
            // 
            // txtDniConductorHabitual
            // 
            this.txtDniConductorHabitual.Location = new System.Drawing.Point(141, 96);
            this.txtDniConductorHabitual.Name = "txtDniConductorHabitual";
            this.txtDniConductorHabitual.Size = new System.Drawing.Size(121, 20);
            this.txtDniConductorHabitual.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Modelo";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(141, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Marca";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(141, 44);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 20);
            this.txtBrand.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Matrícula";
            // 
            // txtVehicleRegistration
            // 
            this.txtVehicleRegistration.Location = new System.Drawing.Point(141, 18);
            this.txtVehicleRegistration.Name = "txtVehicleRegistration";
            this.txtVehicleRegistration.Size = new System.Drawing.Size(121, 20);
            this.txtVehicleRegistration.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnBuscar);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txtSearchDni);
            this.tabPage5.Controls.Add(this.dgvHistory);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(817, 213);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historial Infracciones";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(194, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "DNI";
            // 
            // txtSearchDni
            // 
            this.txtSearchDni.Location = new System.Drawing.Point(80, 6);
            this.txtSearchDni.Name = "txtSearchDni";
            this.txtSearchDni.Size = new System.Drawing.Size(108, 20);
            this.txtSearchDni.TabIndex = 5;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(6, 32);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.Size = new System.Drawing.Size(488, 175);
            this.dgvHistory.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvHabitualInfractions);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(817, 213);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Infracciones Habituales";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvHabitualInfractions
            // 
            this.dgvHabitualInfractions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHabitualInfractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitualInfractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHabitualInfractions.Location = new System.Drawing.Point(3, 3);
            this.dgvHabitualInfractions.MultiSelect = false;
            this.dgvHabitualInfractions.Name = "dgvHabitualInfractions";
            this.dgvHabitualInfractions.RowHeadersVisible = false;
            this.dgvHabitualInfractions.Size = new System.Drawing.Size(811, 207);
            this.dgvHabitualInfractions.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.nudTop);
            this.tabPage7.Controls.Add(this.btnSearchTopDrivers);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.dgvTopDrivers);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(817, 213);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Top Conductores";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // nudTop
            // 
            this.nudTop.Location = new System.Drawing.Point(147, 7);
            this.nudTop.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(58, 20);
            this.nudTop.TabIndex = 21;
            this.nudTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSearchTopDrivers
            // 
            this.btnSearchTopDrivers.Location = new System.Drawing.Point(211, 6);
            this.btnSearchTopDrivers.Name = "btnSearchTopDrivers";
            this.btnSearchTopDrivers.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTopDrivers.TabIndex = 20;
            this.btnSearchTopDrivers.Text = "Buscar";
            this.btnSearchTopDrivers.UseVisualStyleBackColor = true;
            this.btnSearchTopDrivers.Click += new System.EventHandler(this.btnSearchTopDrivers_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Seleccionar TOP a buscar";
            // 
            // dgvTopDrivers
            // 
            this.dgvTopDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTopDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopDrivers.Location = new System.Drawing.Point(6, 32);
            this.dgvTopDrivers.MultiSelect = false;
            this.dgvTopDrivers.Name = "dgvTopDrivers";
            this.dgvTopDrivers.RowHeadersVisible = false;
            this.dgvTopDrivers.Size = new System.Drawing.Size(488, 175);
            this.dgvTopDrivers.TabIndex = 17;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btnVehicleDriver);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.txtDniDriver);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.txtVehicleDriver);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(817, 213);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Añadir conductor a vehículo";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "DNI";
            // 
            // txtDniDriver
            // 
            this.txtDniDriver.Location = new System.Drawing.Point(234, 6);
            this.txtDniDriver.Name = "txtDniDriver";
            this.txtDniDriver.Size = new System.Drawing.Size(121, 20);
            this.txtDniDriver.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Matrícula";
            // 
            // txtVehicleDriver
            // 
            this.txtVehicleDriver.Location = new System.Drawing.Point(75, 6);
            this.txtVehicleDriver.Name = "txtVehicleDriver";
            this.txtVehicleDriver.Size = new System.Drawing.Size(121, 20);
            this.txtVehicleDriver.TabIndex = 15;
            // 
            // btnVehicleDriver
            // 
            this.btnVehicleDriver.Location = new System.Drawing.Point(361, 4);
            this.btnVehicleDriver.Name = "btnVehicleDriver";
            this.btnVehicleDriver.Size = new System.Drawing.Size(75, 23);
            this.btnVehicleDriver.TabIndex = 21;
            this.btnVehicleDriver.Text = "Agregar";
            this.btnVehicleDriver.UseVisualStyleBackColor = true;
            this.btnVehicleDriver.Click += new System.EventHandler(this.btnVehicleDriver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 263);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitualInfractions)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopDrivers)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPoints;
        private System.Windows.Forms.TextBox txtInfringement;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnOkDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurnames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbNumberInfringement;
        private System.Windows.Forms.Button btnOkInfringement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVehicleRegistration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnOkVehicles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDniConductorHabitual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchDni;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvHabitualInfractions;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.Button btnSearchTopDrivers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTopDrivers;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button btnVehicleDriver;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDniDriver;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVehicleDriver;
    }
}

