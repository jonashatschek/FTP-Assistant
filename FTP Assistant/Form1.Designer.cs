namespace FTP_Assistant
{
    partial class FTPassistant
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
            this.CalendarForDateSelect_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.getDataFromFTP_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.displayEmployeeData = new System.Windows.Forms.DataGridView();
            this.GCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.exportToExcel_btn = new System.Windows.Forms.Button();
            this.detailsGroupbox = new System.Windows.Forms.GroupBox();
            this.nameAndCgidTextbox = new System.Windows.Forms.TextBox();
            this.copyLinkToClipboardButton = new System.Windows.Forms.Button();
            this.linkToFileTextbox = new System.Windows.Forms.TextBox();
            this.trainerAmbitionTextbox = new System.Windows.Forms.TextBox();
            this.requiredApprovalTextbox = new System.Windows.Forms.TextBox();
            this.roleIdTextbox = new System.Windows.Forms.TextBox();
            this.organisationIdTextbox = new System.Windows.Forms.TextBox();
            this.locationIdTextbox = new System.Windows.Forms.TextBox();
            this.leganEntityIdTextbox = new System.Windows.Forms.TextBox();
            this.lastHireDateTextbox = new System.Windows.Forms.TextBox();
            this.originalHireDateTextbox = new System.Windows.Forms.TextBox();
            this.employmentStatusTextbox = new System.Windows.Forms.TextBox();
            this.employmentEndedTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.countryCodeTextbox = new System.Windows.Forms.TextBox();
            this.managerIdTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.productionEnvironmentRadioBtn = new System.Windows.Forms.RadioButton();
            this.stageEnviromentRadioBtn = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayEmployeeData)).BeginInit();
            this.detailsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarForDateSelect_monthCalendar
            // 
            this.CalendarForDateSelect_monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.CalendarForDateSelect_monthCalendar.Location = new System.Drawing.Point(17, 57);
            this.CalendarForDateSelect_monthCalendar.MaxSelectionCount = 100;
            this.CalendarForDateSelect_monthCalendar.Name = "CalendarForDateSelect_monthCalendar";
            this.CalendarForDateSelect_monthCalendar.ShowWeekNumbers = true;
            this.CalendarForDateSelect_monthCalendar.TabIndex = 0;
            // 
            // getDataFromFTP_btn
            // 
            this.getDataFromFTP_btn.Location = new System.Drawing.Point(12, 414);
            this.getDataFromFTP_btn.Name = "getDataFromFTP_btn";
            this.getDataFromFTP_btn.Size = new System.Drawing.Size(242, 46);
            this.getDataFromFTP_btn.TabIndex = 1;
            this.getDataFromFTP_btn.Text = "Get data from selected dates";
            this.getDataFromFTP_btn.UseVisualStyleBackColor = true;
            this.getDataFromFTP_btn.Click += new System.EventHandler(this.getDataFromFTP_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.search_textbox.Location = new System.Drawing.Point(276, 28);
            this.search_textbox.Multiline = true;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(242, 36);
            this.search_textbox.TabIndex = 3;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // displayEmployeeData
            // 
            this.displayEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayEmployeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GCID,
            this.activeColumn,
            this.firstNameColumn,
            this.lastNameColumn});
            this.displayEmployeeData.Location = new System.Drawing.Point(276, 79);
            this.displayEmployeeData.MultiSelect = false;
            this.displayEmployeeData.Name = "displayEmployeeData";
            this.displayEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayEmployeeData.Size = new System.Drawing.Size(443, 479);
            this.displayEmployeeData.TabIndex = 4;
            this.displayEmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayEmployeeData_CellContentClick);
            // 
            // GCID
            // 
            this.GCID.HeaderText = "GCID";
            this.GCID.MaxInputLength = 6;
            this.GCID.Name = "GCID";
            this.GCID.ReadOnly = true;
            // 
            // activeColumn
            // 
            this.activeColumn.HeaderText = "Active";
            this.activeColumn.Name = "activeColumn";
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First name";
            this.firstNameColumn.Name = "firstNameColumn";
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.HeaderText = "Last name";
            this.lastNameColumn.Name = "lastNameColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search for ID";
            // 
            // exportToExcel_btn
            // 
            this.exportToExcel_btn.Location = new System.Drawing.Point(12, 467);
            this.exportToExcel_btn.Name = "exportToExcel_btn";
            this.exportToExcel_btn.Size = new System.Drawing.Size(242, 46);
            this.exportToExcel_btn.TabIndex = 6;
            this.exportToExcel_btn.Text = "Export current data set to Excel";
            this.exportToExcel_btn.UseVisualStyleBackColor = true;
            this.exportToExcel_btn.Click += new System.EventHandler(this.exportToExcel_btn_Click);
            // 
            // detailsGroupbox
            // 
            this.detailsGroupbox.Controls.Add(this.nameAndCgidTextbox);
            this.detailsGroupbox.Controls.Add(this.copyLinkToClipboardButton);
            this.detailsGroupbox.Controls.Add(this.linkToFileTextbox);
            this.detailsGroupbox.Controls.Add(this.trainerAmbitionTextbox);
            this.detailsGroupbox.Controls.Add(this.requiredApprovalTextbox);
            this.detailsGroupbox.Controls.Add(this.roleIdTextbox);
            this.detailsGroupbox.Controls.Add(this.organisationIdTextbox);
            this.detailsGroupbox.Controls.Add(this.locationIdTextbox);
            this.detailsGroupbox.Controls.Add(this.leganEntityIdTextbox);
            this.detailsGroupbox.Controls.Add(this.lastHireDateTextbox);
            this.detailsGroupbox.Controls.Add(this.originalHireDateTextbox);
            this.detailsGroupbox.Controls.Add(this.employmentStatusTextbox);
            this.detailsGroupbox.Controls.Add(this.employmentEndedTextbox);
            this.detailsGroupbox.Controls.Add(this.emailTextbox);
            this.detailsGroupbox.Controls.Add(this.countryCodeTextbox);
            this.detailsGroupbox.Controls.Add(this.managerIdTextbox);
            this.detailsGroupbox.Controls.Add(this.label15);
            this.detailsGroupbox.Controls.Add(this.label14);
            this.detailsGroupbox.Controls.Add(this.label13);
            this.detailsGroupbox.Controls.Add(this.label12);
            this.detailsGroupbox.Controls.Add(this.label11);
            this.detailsGroupbox.Controls.Add(this.label10);
            this.detailsGroupbox.Controls.Add(this.label9);
            this.detailsGroupbox.Controls.Add(this.label8);
            this.detailsGroupbox.Controls.Add(this.label7);
            this.detailsGroupbox.Controls.Add(this.label6);
            this.detailsGroupbox.Controls.Add(this.label5);
            this.detailsGroupbox.Controls.Add(this.label4);
            this.detailsGroupbox.Controls.Add(this.label3);
            this.detailsGroupbox.Controls.Add(this.label2);
            this.detailsGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGroupbox.Location = new System.Drawing.Point(760, 12);
            this.detailsGroupbox.Name = "detailsGroupbox";
            this.detailsGroupbox.Size = new System.Drawing.Size(526, 546);
            this.detailsGroupbox.TabIndex = 7;
            this.detailsGroupbox.TabStop = false;
            this.detailsGroupbox.Text = "Details";
            // 
            // nameAndCgidTextbox
            // 
            this.nameAndCgidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAndCgidTextbox.Location = new System.Drawing.Point(9, 24);
            this.nameAndCgidTextbox.Multiline = true;
            this.nameAndCgidTextbox.Name = "nameAndCgidTextbox";
            this.nameAndCgidTextbox.Size = new System.Drawing.Size(378, 41);
            this.nameAndCgidTextbox.TabIndex = 31;
            // 
            // copyLinkToClipboardButton
            // 
            this.copyLinkToClipboardButton.Location = new System.Drawing.Point(155, 492);
            this.copyLinkToClipboardButton.Name = "copyLinkToClipboardButton";
            this.copyLinkToClipboardButton.Size = new System.Drawing.Size(194, 42);
            this.copyLinkToClipboardButton.TabIndex = 30;
            this.copyLinkToClipboardButton.Text = "Copy file link to clipboard";
            this.copyLinkToClipboardButton.UseVisualStyleBackColor = true;
            this.copyLinkToClipboardButton.Click += new System.EventHandler(this.copyLinkToClipboardButton_Click);
            // 
            // linkToFileTextbox
            // 
            this.linkToFileTextbox.Location = new System.Drawing.Point(155, 462);
            this.linkToFileTextbox.Name = "linkToFileTextbox";
            this.linkToFileTextbox.ReadOnly = true;
            this.linkToFileTextbox.Size = new System.Drawing.Size(365, 24);
            this.linkToFileTextbox.TabIndex = 28;
            // 
            // trainerAmbitionTextbox
            // 
            this.trainerAmbitionTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.trainerAmbitionTextbox.Location = new System.Drawing.Point(155, 432);
            this.trainerAmbitionTextbox.Name = "trainerAmbitionTextbox";
            this.trainerAmbitionTextbox.ReadOnly = true;
            this.trainerAmbitionTextbox.Size = new System.Drawing.Size(365, 24);
            this.trainerAmbitionTextbox.TabIndex = 27;
            // 
            // requiredApprovalTextbox
            // 
            this.requiredApprovalTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.requiredApprovalTextbox.Location = new System.Drawing.Point(155, 402);
            this.requiredApprovalTextbox.Name = "requiredApprovalTextbox";
            this.requiredApprovalTextbox.ReadOnly = true;
            this.requiredApprovalTextbox.Size = new System.Drawing.Size(365, 24);
            this.requiredApprovalTextbox.TabIndex = 26;
            // 
            // roleIdTextbox
            // 
            this.roleIdTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.roleIdTextbox.Location = new System.Drawing.Point(155, 372);
            this.roleIdTextbox.Name = "roleIdTextbox";
            this.roleIdTextbox.ReadOnly = true;
            this.roleIdTextbox.Size = new System.Drawing.Size(365, 24);
            this.roleIdTextbox.TabIndex = 25;
            // 
            // organisationIdTextbox
            // 
            this.organisationIdTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.organisationIdTextbox.Location = new System.Drawing.Point(155, 342);
            this.organisationIdTextbox.Name = "organisationIdTextbox";
            this.organisationIdTextbox.ReadOnly = true;
            this.organisationIdTextbox.Size = new System.Drawing.Size(365, 24);
            this.organisationIdTextbox.TabIndex = 24;
            // 
            // locationIdTextbox
            // 
            this.locationIdTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.locationIdTextbox.Location = new System.Drawing.Point(155, 312);
            this.locationIdTextbox.Name = "locationIdTextbox";
            this.locationIdTextbox.ReadOnly = true;
            this.locationIdTextbox.Size = new System.Drawing.Size(365, 24);
            this.locationIdTextbox.TabIndex = 23;
            // 
            // leganEntityIdTextbox
            // 
            this.leganEntityIdTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.leganEntityIdTextbox.Location = new System.Drawing.Point(155, 282);
            this.leganEntityIdTextbox.Name = "leganEntityIdTextbox";
            this.leganEntityIdTextbox.ReadOnly = true;
            this.leganEntityIdTextbox.Size = new System.Drawing.Size(365, 24);
            this.leganEntityIdTextbox.TabIndex = 22;
            // 
            // lastHireDateTextbox
            // 
            this.lastHireDateTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lastHireDateTextbox.Location = new System.Drawing.Point(155, 252);
            this.lastHireDateTextbox.Name = "lastHireDateTextbox";
            this.lastHireDateTextbox.ReadOnly = true;
            this.lastHireDateTextbox.Size = new System.Drawing.Size(365, 24);
            this.lastHireDateTextbox.TabIndex = 21;
            // 
            // originalHireDateTextbox
            // 
            this.originalHireDateTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.originalHireDateTextbox.Location = new System.Drawing.Point(155, 220);
            this.originalHireDateTextbox.Name = "originalHireDateTextbox";
            this.originalHireDateTextbox.ReadOnly = true;
            this.originalHireDateTextbox.Size = new System.Drawing.Size(365, 24);
            this.originalHireDateTextbox.TabIndex = 20;
            // 
            // employmentStatusTextbox
            // 
            this.employmentStatusTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.employmentStatusTextbox.Location = new System.Drawing.Point(155, 190);
            this.employmentStatusTextbox.Name = "employmentStatusTextbox";
            this.employmentStatusTextbox.ReadOnly = true;
            this.employmentStatusTextbox.Size = new System.Drawing.Size(365, 24);
            this.employmentStatusTextbox.TabIndex = 19;
            // 
            // employmentEndedTextbox
            // 
            this.employmentEndedTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.employmentEndedTextbox.Location = new System.Drawing.Point(155, 160);
            this.employmentEndedTextbox.Name = "employmentEndedTextbox";
            this.employmentEndedTextbox.ReadOnly = true;
            this.employmentEndedTextbox.Size = new System.Drawing.Size(365, 24);
            this.employmentEndedTextbox.TabIndex = 18;
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.emailTextbox.Location = new System.Drawing.Point(155, 130);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.ReadOnly = true;
            this.emailTextbox.Size = new System.Drawing.Size(365, 24);
            this.emailTextbox.TabIndex = 17;
            // 
            // countryCodeTextbox
            // 
            this.countryCodeTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.countryCodeTextbox.Location = new System.Drawing.Point(155, 101);
            this.countryCodeTextbox.Name = "countryCodeTextbox";
            this.countryCodeTextbox.ReadOnly = true;
            this.countryCodeTextbox.Size = new System.Drawing.Size(365, 24);
            this.countryCodeTextbox.TabIndex = 16;
            // 
            // managerIdTextbox
            // 
            this.managerIdTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.managerIdTextbox.Location = new System.Drawing.Point(155, 71);
            this.managerIdTextbox.Name = "managerIdTextbox";
            this.managerIdTextbox.ReadOnly = true;
            this.managerIdTextbox.Size = new System.Drawing.Size(365, 24);
            this.managerIdTextbox.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 468);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "Link to file";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 438);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "Trainer ambition";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Role ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Required Approval";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Organisation ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Location ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Legal endity ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Last hire date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Original hire date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Employment Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employment ended?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Country Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manager ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Pick dates";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Pick environment";
            // 
            // productionEnvironmentRadioBtn
            // 
            this.productionEnvironmentRadioBtn.AutoSize = true;
            this.productionEnvironmentRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productionEnvironmentRadioBtn.Location = new System.Drawing.Point(22, 272);
            this.productionEnvironmentRadioBtn.Name = "productionEnvironmentRadioBtn";
            this.productionEnvironmentRadioBtn.Size = new System.Drawing.Size(98, 22);
            this.productionEnvironmentRadioBtn.TabIndex = 10;
            this.productionEnvironmentRadioBtn.TabStop = true;
            this.productionEnvironmentRadioBtn.Text = "Production";
            this.productionEnvironmentRadioBtn.UseVisualStyleBackColor = true;
            this.productionEnvironmentRadioBtn.CheckedChanged += new System.EventHandler(this.productionEnvironmentRadioBtn_CheckedChanged);
            // 
            // stageEnviromentRadioBtn
            // 
            this.stageEnviromentRadioBtn.AutoSize = true;
            this.stageEnviromentRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.stageEnviromentRadioBtn.Location = new System.Drawing.Point(138, 272);
            this.stageEnviromentRadioBtn.Name = "stageEnviromentRadioBtn";
            this.stageEnviromentRadioBtn.Size = new System.Drawing.Size(64, 22);
            this.stageEnviromentRadioBtn.TabIndex = 11;
            this.stageEnviromentRadioBtn.TabStop = true;
            this.stageEnviromentRadioBtn.Text = "Stage";
            this.stageEnviromentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 390);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Handle dates";
            // 
            // FTPassistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 577);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.stageEnviromentRadioBtn);
            this.Controls.Add(this.productionEnvironmentRadioBtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.detailsGroupbox);
            this.Controls.Add(this.exportToExcel_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayEmployeeData);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.getDataFromFTP_btn);
            this.Controls.Add(this.CalendarForDateSelect_monthCalendar);
            this.Name = "FTPassistant";
            this.Text = "FTPassistant";
            ((System.ComponentModel.ISupportInitialize)(this.displayEmployeeData)).EndInit();
            this.detailsGroupbox.ResumeLayout(false);
            this.detailsGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarForDateSelect_monthCalendar;
        private System.Windows.Forms.Button getDataFromFTP_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.DataGridView displayEmployeeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportToExcel_btn;
        private System.Windows.Forms.GroupBox detailsGroupbox;
        private System.Windows.Forms.TextBox linkToFileTextbox;
        private System.Windows.Forms.TextBox trainerAmbitionTextbox;
        private System.Windows.Forms.TextBox requiredApprovalTextbox;
        private System.Windows.Forms.TextBox roleIdTextbox;
        private System.Windows.Forms.TextBox organisationIdTextbox;
        private System.Windows.Forms.TextBox locationIdTextbox;
        private System.Windows.Forms.TextBox leganEntityIdTextbox;
        private System.Windows.Forms.TextBox lastHireDateTextbox;
        private System.Windows.Forms.TextBox originalHireDateTextbox;
        private System.Windows.Forms.TextBox employmentStatusTextbox;
        private System.Windows.Forms.TextBox employmentEndedTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox countryCodeTextbox;
        private System.Windows.Forms.TextBox managerIdTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.Button copyLinkToClipboardButton;
        private System.Windows.Forms.TextBox nameAndCgidTextbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton productionEnvironmentRadioBtn;
        private System.Windows.Forms.RadioButton stageEnviromentRadioBtn;
        private System.Windows.Forms.Label label18;
    }
}

