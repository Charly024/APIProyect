namespace proyect44CPT
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cbDataLastesTemperatureUnit = new System.Windows.Forms.ComboBox();
            this.dgvDataStops = new System.Windows.Forms.DataGridView();
            this.numDataHoursOfService = new System.Windows.Forms.NumericUpDown();
            this.numDataLatestTemperature = new System.Windows.Forms.NumericUpDown();
            this.cboDataEvenType = new System.Windows.Forms.ComboBox();
            this.dtpDataUtcTimestamp = new System.Windows.Forms.DateTimePicker();
            this.numDataLongitude = new System.Windows.Forms.NumericUpDown();
            this.numDataLatitude = new System.Windows.Forms.NumericUpDown();
            this.txtDataCustomerId = new System.Windows.Forms.TextBox();
            this.txtDataShippmentId = new System.Windows.Forms.TextBox();
            this.gbStops = new System.Windows.Forms.GroupBox();
            this.dtpDataDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDataArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtDataStopName = new System.Windows.Forms.TextBox();
            this.txtDataStopNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtDataCompanyName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.btnAddStop = new System.Windows.Forms.Button();
            this.cboDataCountry = new System.Windows.Forms.ComboBox();
            this.cboDataState = new System.Windows.Forms.ComboBox();
            this.txtDataCity = new System.Windows.Forms.TextBox();
            this.txtDataAddressLines = new System.Windows.Forms.TextBox();
            this.txtDataPostalCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDataStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPeticion = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataHoursOfService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLatestTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLatitude)).BeginInit();
            this.gbStops.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitude*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longitude*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "utcTimestamp*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EventType";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "stopNumber";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnPeticion);
            this.gbData.Controls.Add(this.cbDataLastesTemperatureUnit);
            this.gbData.Controls.Add(this.dgvDataStops);
            this.gbData.Controls.Add(this.numDataHoursOfService);
            this.gbData.Controls.Add(this.numDataLatestTemperature);
            this.gbData.Controls.Add(this.cboDataEvenType);
            this.gbData.Controls.Add(this.dtpDataUtcTimestamp);
            this.gbData.Controls.Add(this.numDataLongitude);
            this.gbData.Controls.Add(this.numDataLatitude);
            this.gbData.Controls.Add(this.txtDataCustomerId);
            this.gbData.Controls.Add(this.txtDataShippmentId);
            this.gbData.Controls.Add(this.gbStops);
            this.gbData.Controls.Add(this.label22);
            this.gbData.Controls.Add(this.label21);
            this.gbData.Controls.Add(this.label20);
            this.gbData.Controls.Add(this.label19);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(984, 426);
            this.gbData.TabIndex = 5;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // cbDataLastesTemperatureUnit
            // 
            this.cbDataLastesTemperatureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataLastesTemperatureUnit.FormattingEnabled = true;
            this.cbDataLastesTemperatureUnit.Items.AddRange(new object[] {
            "F",
            "C"});
            this.cbDataLastesTemperatureUnit.Location = new System.Drawing.Point(244, 202);
            this.cbDataLastesTemperatureUnit.Name = "cbDataLastesTemperatureUnit";
            this.cbDataLastesTemperatureUnit.Size = new System.Drawing.Size(121, 21);
            this.cbDataLastesTemperatureUnit.TabIndex = 19;
            // 
            // dgvDataStops
            // 
            this.dgvDataStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataStops.Location = new System.Drawing.Point(25, 238);
            this.dgvDataStops.Name = "dgvDataStops";
            this.dgvDataStops.Size = new System.Drawing.Size(418, 161);
            this.dgvDataStops.TabIndex = 18;
            // 
            // numDataHoursOfService
            // 
            this.numDataHoursOfService.Location = new System.Drawing.Point(245, 97);
            this.numDataHoursOfService.Name = "numDataHoursOfService";
            this.numDataHoursOfService.Size = new System.Drawing.Size(120, 20);
            this.numDataHoursOfService.TabIndex = 17;
            // 
            // numDataLatestTemperature
            // 
            this.numDataLatestTemperature.DecimalPlaces = 1;
            this.numDataLatestTemperature.Location = new System.Drawing.Point(108, 94);
            this.numDataLatestTemperature.Name = "numDataLatestTemperature";
            this.numDataLatestTemperature.Size = new System.Drawing.Size(120, 20);
            this.numDataLatestTemperature.TabIndex = 15;
            // 
            // cboDataEvenType
            // 
            this.cboDataEvenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataEvenType.FormattingEnabled = true;
            this.cboDataEvenType.Items.AddRange(new object[] {
            "DELIVERED",
            "CANCELLED",
            "DEPARTED",
            "ARRIVED",
            "DISPATCHED",
            "LOADING",
            "UNLOADING"});
            this.cboDataEvenType.Location = new System.Drawing.Point(322, 41);
            this.cboDataEvenType.Name = "cboDataEvenType";
            this.cboDataEvenType.Size = new System.Drawing.Size(121, 21);
            this.cboDataEvenType.TabIndex = 14;
            // 
            // dtpDataUtcTimestamp
            // 
            this.dtpDataUtcTimestamp.Location = new System.Drawing.Point(25, 199);
            this.dtpDataUtcTimestamp.Name = "dtpDataUtcTimestamp";
            this.dtpDataUtcTimestamp.Size = new System.Drawing.Size(200, 20);
            this.dtpDataUtcTimestamp.TabIndex = 13;
            // 
            // numDataLongitude
            // 
            this.numDataLongitude.DecimalPlaces = 6;
            this.numDataLongitude.Location = new System.Drawing.Point(245, 145);
            this.numDataLongitude.Name = "numDataLongitude";
            this.numDataLongitude.Size = new System.Drawing.Size(120, 20);
            this.numDataLongitude.TabIndex = 12;
            // 
            // numDataLatitude
            // 
            this.numDataLatitude.DecimalPlaces = 6;
            this.numDataLatitude.Location = new System.Drawing.Point(108, 145);
            this.numDataLatitude.Name = "numDataLatitude";
            this.numDataLatitude.Size = new System.Drawing.Size(120, 20);
            this.numDataLatitude.TabIndex = 11;
            // 
            // txtDataCustomerId
            // 
            this.txtDataCustomerId.Location = new System.Drawing.Point(165, 43);
            this.txtDataCustomerId.Name = "txtDataCustomerId";
            this.txtDataCustomerId.Size = new System.Drawing.Size(111, 20);
            this.txtDataCustomerId.TabIndex = 10;
            // 
            // txtDataShippmentId
            // 
            this.txtDataShippmentId.Location = new System.Drawing.Point(25, 39);
            this.txtDataShippmentId.Name = "txtDataShippmentId";
            this.txtDataShippmentId.Size = new System.Drawing.Size(111, 20);
            this.txtDataShippmentId.TabIndex = 9;
            // 
            // gbStops
            // 
            this.gbStops.Controls.Add(this.dtpDataDepartureDateTime);
            this.gbStops.Controls.Add(this.dtpDataArrivalDateTime);
            this.gbStops.Controls.Add(this.txtDataStopName);
            this.gbStops.Controls.Add(this.txtDataStopNumber);
            this.gbStops.Controls.Add(this.label17);
            this.gbStops.Controls.Add(this.label16);
            this.gbStops.Controls.Add(this.label15);
            this.gbStops.Controls.Add(this.label14);
            this.gbStops.Controls.Add(this.gbContact);
            this.gbStops.Controls.Add(this.gbAddress);
            this.gbStops.Controls.Add(this.groupBox1);
            this.gbStops.Controls.Add(this.label6);
            this.gbStops.Location = new System.Drawing.Point(472, 23);
            this.gbStops.Name = "gbStops";
            this.gbStops.Size = new System.Drawing.Size(483, 376);
            this.gbStops.TabIndex = 6;
            this.gbStops.TabStop = false;
            this.gbStops.Text = "Stops";
            // 
            // dtpDataDepartureDateTime
            // 
            this.dtpDataDepartureDateTime.Location = new System.Drawing.Point(25, 154);
            this.dtpDataDepartureDateTime.Name = "dtpDataDepartureDateTime";
            this.dtpDataDepartureDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDataDepartureDateTime.TabIndex = 17;
            // 
            // dtpDataArrivalDateTime
            // 
            this.dtpDataArrivalDateTime.Location = new System.Drawing.Point(25, 106);
            this.dtpDataArrivalDateTime.Name = "dtpDataArrivalDateTime";
            this.dtpDataArrivalDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDataArrivalDateTime.TabIndex = 16;
            // 
            // txtDataStopName
            // 
            this.txtDataStopName.Location = new System.Drawing.Point(133, 55);
            this.txtDataStopName.Name = "txtDataStopName";
            this.txtDataStopName.Size = new System.Drawing.Size(111, 20);
            this.txtDataStopName.TabIndex = 15;
            // 
            // txtDataStopNumber
            // 
            this.txtDataStopNumber.Location = new System.Drawing.Point(16, 55);
            this.txtDataStopNumber.Name = "txtDataStopNumber";
            this.txtDataStopNumber.Size = new System.Drawing.Size(111, 20);
            this.txtDataStopNumber.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "carrierSuppliedEta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "departureDateTime";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "arrivalDateTime";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "stopName";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtDataCompanyName);
            this.gbContact.Controls.Add(this.label18);
            this.gbContact.Location = new System.Drawing.Point(25, 174);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(437, 47);
            this.gbContact.TabIndex = 9;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact";
            // 
            // txtDataCompanyName
            // 
            this.txtDataCompanyName.Location = new System.Drawing.Point(106, 15);
            this.txtDataCompanyName.Name = "txtDataCompanyName";
            this.txtDataCompanyName.Size = new System.Drawing.Size(315, 20);
            this.txtDataCompanyName.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "companyName";
            // 
            // gbAddress
            // 
            this.gbAddress.Controls.Add(this.btnAddStop);
            this.gbAddress.Controls.Add(this.cboDataCountry);
            this.gbAddress.Controls.Add(this.cboDataState);
            this.gbAddress.Controls.Add(this.txtDataCity);
            this.gbAddress.Controls.Add(this.txtDataAddressLines);
            this.gbAddress.Controls.Add(this.txtDataPostalCode);
            this.gbAddress.Controls.Add(this.label13);
            this.gbAddress.Controls.Add(this.label12);
            this.gbAddress.Controls.Add(this.label11);
            this.gbAddress.Controls.Add(this.label9);
            this.gbAddress.Controls.Add(this.label10);
            this.gbAddress.Location = new System.Drawing.Point(16, 227);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(446, 125);
            this.gbAddress.TabIndex = 8;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // btnAddStop
            // 
            this.btnAddStop.Location = new System.Drawing.Point(215, 79);
            this.btnAddStop.Name = "btnAddStop";
            this.btnAddStop.Size = new System.Drawing.Size(75, 23);
            this.btnAddStop.TabIndex = 22;
            this.btnAddStop.Text = "ADD STOP";
            this.btnAddStop.UseVisualStyleBackColor = true;
            // 
            // cboDataCountry
            // 
            this.cboDataCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataCountry.FormattingEnabled = true;
            this.cboDataCountry.Location = new System.Drawing.Point(138, 81);
            this.cboDataCountry.Name = "cboDataCountry";
            this.cboDataCountry.Size = new System.Drawing.Size(56, 21);
            this.cboDataCountry.TabIndex = 21;
            // 
            // cboDataState
            // 
            this.cboDataState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataState.FormattingEnabled = true;
            this.cboDataState.Location = new System.Drawing.Point(21, 81);
            this.cboDataState.Name = "cboDataState";
            this.cboDataState.Size = new System.Drawing.Size(56, 21);
            this.cboDataState.TabIndex = 18;
            // 
            // txtDataCity
            // 
            this.txtDataCity.Location = new System.Drawing.Point(314, 34);
            this.txtDataCity.Name = "txtDataCity";
            this.txtDataCity.Size = new System.Drawing.Size(116, 20);
            this.txtDataCity.TabIndex = 20;
            // 
            // txtDataAddressLines
            // 
            this.txtDataAddressLines.Location = new System.Drawing.Point(131, 34);
            this.txtDataAddressLines.Name = "txtDataAddressLines";
            this.txtDataAddressLines.Size = new System.Drawing.Size(159, 20);
            this.txtDataAddressLines.TabIndex = 19;
            // 
            // txtDataPostalCode
            // 
            this.txtDataPostalCode.Location = new System.Drawing.Point(20, 34);
            this.txtDataPostalCode.Name = "txtDataPostalCode";
            this.txtDataPostalCode.Size = new System.Drawing.Size(79, 20);
            this.txtDataPostalCode.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "state";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "city";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "addressLines";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "postalCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataEndDate);
            this.groupBox1.Controls.Add(this.dtpDataStartDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(250, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // dtpDataEndDate
            // 
            this.dtpDataEndDate.Location = new System.Drawing.Point(6, 88);
            this.dtpDataEndDate.Name = "dtpDataEndDate";
            this.dtpDataEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDataEndDate.TabIndex = 15;
            // 
            // dtpDataStartDate
            // 
            this.dtpDataStartDate.Location = new System.Drawing.Point(6, 40);
            this.dtpDataStartDate.Name = "dtpDataStartDate";
            this.dtpDataStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDataStartDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "endDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "startDate";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(162, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "customerId*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(242, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "hoursOfServiceRemaining";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(242, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "latestTemeratureUnit";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(105, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "latestTemperature";
            // 
            // btnPeticion
            // 
            this.btnPeticion.Location = new System.Drawing.Point(405, 190);
            this.btnPeticion.Name = "btnPeticion";
            this.btnPeticion.Size = new System.Drawing.Size(75, 23);
            this.btnPeticion.TabIndex = 20;
            this.btnPeticion.Text = "button1";
            this.btnPeticion.UseVisualStyleBackColor = true;
            this.btnPeticion.Click += new System.EventHandler(this.btnPeticion_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.gbData);
            this.Name = "frmMain";
            this.Text = "project44 Carrier Push Tracking API";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataHoursOfService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLatestTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDataLatitude)).EndInit();
            this.gbStops.ResumeLayout(false);
            this.gbStops.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbStops;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvDataStops;
        private System.Windows.Forms.NumericUpDown numDataHoursOfService;
        private System.Windows.Forms.NumericUpDown numDataLatestTemperature;
        private System.Windows.Forms.ComboBox cboDataEvenType;
        private System.Windows.Forms.DateTimePicker dtpDataUtcTimestamp;
        private System.Windows.Forms.NumericUpDown numDataLongitude;
        private System.Windows.Forms.NumericUpDown numDataLatitude;
        private System.Windows.Forms.TextBox txtDataCustomerId;
        private System.Windows.Forms.TextBox txtDataShippmentId;
        private System.Windows.Forms.DateTimePicker dtpDataDepartureDateTime;
        private System.Windows.Forms.DateTimePicker dtpDataArrivalDateTime;
        private System.Windows.Forms.TextBox txtDataStopName;
        private System.Windows.Forms.TextBox txtDataStopNumber;
        private System.Windows.Forms.TextBox txtDataCompanyName;
        private System.Windows.Forms.ComboBox cboDataCountry;
        private System.Windows.Forms.ComboBox cboDataState;
        private System.Windows.Forms.TextBox txtDataCity;
        private System.Windows.Forms.TextBox txtDataAddressLines;
        private System.Windows.Forms.TextBox txtDataPostalCode;
        private System.Windows.Forms.DateTimePicker dtpDataEndDate;
        private System.Windows.Forms.DateTimePicker dtpDataStartDate;
        private System.Windows.Forms.Button btnAddStop;
        private System.Windows.Forms.ComboBox cbDataLastesTemperatureUnit;
        private System.Windows.Forms.Button btnPeticion;
    }
}

