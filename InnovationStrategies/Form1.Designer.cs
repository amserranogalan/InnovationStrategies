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
            this.label6 = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOkInfringement = new System.Windows.Forms.Button();
            this.cmbNumberInfringement = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVehicleRegistration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniConductorHabitual = new System.Windows.Forms.TextBox();
            this.btnOkVehicles = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 239);
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
            this.tabPage1.Size = new System.Drawing.Size(500, 213);
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
            this.tabPage2.Size = new System.Drawing.Size(500, 213);
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
            this.tabPage3.Size = new System.Drawing.Size(500, 213);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Infracción";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tipo Infracción";
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
            // cmbNumberInfringement
            // 
            this.cmbNumberInfringement.FormattingEnabled = true;
            this.cmbNumberInfringement.Location = new System.Drawing.Point(125, 40);
            this.cmbNumberInfringement.Name = "cmbNumberInfringement";
            this.cmbNumberInfringement.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberInfringement.TabIndex = 11;
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
            this.tabPage4.Size = new System.Drawing.Size(500, 213);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vehículos";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 263);
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
    }
}

