namespace navscraper
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpcker_asondate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvw_pf = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstbx_schemes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_nav = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_amt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpick_trxndate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbtn_lmsm = new System.Windows.Forms.RadioButton();
            this.rdbtn_sip = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbx_days = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_pf)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpcker_asondate);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dgvw_pf);
            this.tabPage1.Controls.Add(this.btn_refresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Portfolio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpcker_asondate
            // 
            this.dtpcker_asondate.Location = new System.Drawing.Point(86, 6);
            this.dtpcker_asondate.Name = "dtpcker_asondate";
            this.dtpcker_asondate.Size = new System.Drawing.Size(200, 20);
            this.dtpcker_asondate.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvw_pf
            // 
            this.dgvw_pf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvw_pf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvw_pf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvw_pf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_pf.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_pf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvw_pf.Location = new System.Drawing.Point(3, 179);
            this.dgvw_pf.Name = "dgvw_pf";
            this.dgvw_pf.ReadOnly = true;
            this.dgvw_pf.Size = new System.Drawing.Size(670, 273);
            this.dgvw_pf.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(292, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(107, 23);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Show Report";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Entry";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstbx_schemes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtbx_nav, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtbx_amt, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_export, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Date : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbx_schemes
            // 
            this.lstbx_schemes.FormattingEnabled = true;
            this.lstbx_schemes.Location = new System.Drawing.Point(136, 120);
            this.lstbx_schemes.Name = "lstbx_schemes";
            this.lstbx_schemes.Size = new System.Drawing.Size(463, 134);
            this.lstbx_schemes.TabIndex = 0;
            this.lstbx_schemes.SelectedIndexChanged += new System.EventHandler(this.lstbx_schemes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // txtbx_nav
            // 
            this.txtbx_nav.Location = new System.Drawing.Point(136, 260);
            this.txtbx_nav.Name = "txtbx_nav";
            this.txtbx_nav.ReadOnly = true;
            this.txtbx_nav.Size = new System.Drawing.Size(251, 20);
            this.txtbx_nav.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // txtbx_amt
            // 
            this.txtbx_amt.Location = new System.Drawing.Point(136, 286);
            this.txtbx_amt.Name = "txtbx_amt";
            this.txtbx_amt.Size = new System.Drawing.Size(251, 20);
            this.txtbx_amt.TabIndex = 5;
            this.txtbx_amt.TextChanged += new System.EventHandler(this.txtbx_amt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(136, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(32, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "- -";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtpick_trxndate, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 26);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // dtpick_trxndate
            // 
            this.dtpick_trxndate.Location = new System.Drawing.Point(3, 3);
            this.dtpick_trxndate.Name = "dtpick_trxndate";
            this.dtpick_trxndate.Size = new System.Drawing.Size(200, 20);
            this.dtpick_trxndate.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(136, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Fund : ";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Select",
            "ABN AMRO Mutual Fund-39",
            "AEGON Mutual Fund-50",
            "Alliance Capital Mutual Fund-1",
            "Axis Mutual Fund-53",
            "Baroda Pioneer Mutual Fund-4",
            "Benchmark Mutual Fund-36",
            "Birla Sun Life Mutual Fund-3",
            "BNP Paribas Mutual Fund-59",
            "BOI AXA Mutual Fund-46",
            "Canara Robeco Mutual Fund-32",
            "Daiwa Mutual Fund-60",
            "DBS Chola Mutual Fund-31",
            "Deutsche Mutual Fund-38",
            "DHFL Pramerica Mutual Fund-58",
            "DSP BlackRock Mutual Fund-6",
            "Edelweiss Mutual Fund-47",
            "Escorts Mutual Fund-13",
            "Fidelity Mutual Fund-40",
            "Fortis Mutual Fund-51",
            "Franklin Templeton Mutual Fund-27",
            "GIC Mutual Fund-8",
            "Goldman Sachs Mutual Fund-49",
            "HDFC Mutual Fund-9",
            "HSBC Mutual Fund-37",
            "ICICI Prudential Mutual Fund-20",
            "IDBI Mutual Fund-57",
            "IDFC Mutual Fund-48",
            "IIFCL Mutual Fund IDF)-68",
            "IIFL Mutual Fund-62",
            "IL&amp F S Mutual Fund-11",
            "IL&amp FS Mutual Fund IDF)-65",
            "Indiabulls Mutual Fund-63",
            "ING Mutual Fund-14",
            "Invesco Mutual Fund-42",
            "JM Financial Mutual Fund-16",
            "JPMorgan Mutual Fund-43",
            "Kotak Mahindra Mutual Fund-17",
            "selected selected L&amp T Mutual Fund-selected",
            "LIC Mutual Fund-18",
            "Mahindra Mutual Fund-69",
            "Mirae Asset Mutual Fund-45",
            "Morgan Stanley Mutual Fund-19",
            "Motilal Oswal Mutual Fund-55",
            "Peerless Mutual Fund-54",
            "PineBridge Mutual Fund-44",
            "PNB Mutual Fund-34",
            "PPFAS Mutual Fund-64",
            "PRINCIPAL Mutual Fund-10",
            "Quantum Mutual Fund-41",
            "Reliance Mutual Fund-21",
            "Sahara Mutual Fund-35",
            "SBI Mutual Fund-22",
            "Shinsei Mutual Fund-52",
            "Shriram Mutual Fund-67",
            "SREI Mutual Fund IDF)-66",
            "Standard Chartered Mutual Fund-2",
            "SUN F&amp C Mutual Fund-24",
            "Sundaram Mutual Fund-33",
            "Tata Mutual Fund-25",
            "Taurus Mutual Fund-26",
            "Union Mutual Fund-61",
            "UTI Mutual Fund-28",
            "Zurich India Mutual Fund-29"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select",
            "ABN AMRO Mutual Fund-39",
            "AEGON Mutual Fund-50",
            "Alliance Capital Mutual Fund-1",
            "Axis Mutual Fund-53",
            "Baroda Pioneer Mutual Fund-4",
            "Benchmark Mutual Fund-36",
            "Birla Sun Life Mutual Fund-3",
            "BNP Paribas Mutual Fund-59",
            "BOI AXA Mutual Fund-46",
            "Canara Robeco Mutual Fund-32",
            "Daiwa Mutual Fund-60",
            "DBS Chola Mutual Fund-31",
            "Deutsche Mutual Fund-38",
            "DHFL Pramerica Mutual Fund-58",
            "DSP BlackRock Mutual Fund-6",
            "Edelweiss Mutual Fund-47",
            "Escorts Mutual Fund-13",
            "Fidelity Mutual Fund-40",
            "Fortis Mutual Fund-51",
            "Franklin Templeton Mutual Fund-27",
            "GIC Mutual Fund-8",
            "Goldman Sachs Mutual Fund-49",
            "HDFC Mutual Fund-9",
            "HSBC Mutual Fund-37",
            "ICICI Prudential Mutual Fund-20",
            "IDBI Mutual Fund-57",
            "IDFC Mutual Fund-48",
            "IIFCL Mutual Fund IDF)-68",
            "IIFL Mutual Fund-62",
            "IL&amp F S Mutual Fund-11",
            "IL&amp FS Mutual Fund IDF)-65",
            "Indiabulls Mutual Fund-63",
            "ING Mutual Fund-14",
            "Invesco Mutual Fund-42",
            "JM Financial Mutual Fund-16",
            "JPMorgan Mutual Fund-43",
            "Kotak Mahindra Mutual Fund-17",
            "selected selected L&amp T Mutual Fund-selected",
            "LIC Mutual Fund-18",
            "Mahindra Mutual Fund-69",
            "Mirae Asset Mutual Fund-45",
            "Morgan Stanley Mutual Fund-19",
            "Motilal Oswal Mutual Fund-55",
            "Peerless Mutual Fund-54",
            "PineBridge Mutual Fund-44",
            "PNB Mutual Fund-34",
            "PPFAS Mutual Fund-64",
            "PRINCIPAL Mutual Fund-10",
            "Quantum Mutual Fund-41",
            "Reliance Mutual Fund-21",
            "Sahara Mutual Fund-35",
            "SBI Mutual Fund-22",
            "Shinsei Mutual Fund-52",
            "Shriram Mutual Fund-67",
            "SREI Mutual Fund IDF)-66",
            "Standard Chartered Mutual Fund-2",
            "SUN F&amp C Mutual Fund-24",
            "Sundaram Mutual Fund-33",
            "Tata Mutual Fund-25",
            "Taurus Mutual Fund-26",
            "Union Mutual Fund-61",
            "UTI Mutual Fund-28",
            "Zurich India Mutual Fund-29"});
            this.comboBox1.Location = new System.Drawing.Point(136, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_export.AutoSize = true;
            this.btn_export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_export.Location = new System.Drawing.Point(83, 416);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(47, 23);
            this.btn_export.TabIndex = 13;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rdbtn_lmsm
            // 
            this.rdbtn_lmsm.AutoSize = true;
            this.rdbtn_lmsm.Checked = true;
            this.rdbtn_lmsm.Location = new System.Drawing.Point(3, 3);
            this.rdbtn_lmsm.Name = "rdbtn_lmsm";
            this.rdbtn_lmsm.Size = new System.Drawing.Size(66, 17);
            this.rdbtn_lmsm.TabIndex = 1;
            this.rdbtn_lmsm.TabStop = true;
            this.rdbtn_lmsm.Text = "LumSum";
            this.rdbtn_lmsm.UseVisualStyleBackColor = true;
            // 
            // rdbtn_sip
            // 
            this.rdbtn_sip.AutoSize = true;
            this.rdbtn_sip.Location = new System.Drawing.Point(75, 3);
            this.rdbtn_sip.Name = "rdbtn_sip";
            this.rdbtn_sip.Size = new System.Drawing.Size(40, 17);
            this.rdbtn_sip.TabIndex = 2;
            this.rdbtn_sip.Text = "Sip";
            this.rdbtn_sip.UseVisualStyleBackColor = true;
            this.rdbtn_sip.CheckedChanged += new System.EventHandler(this.rdbtn_sip_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.Controls.Add(this.rdbtn_sip, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdbtn_lmsm, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbx_days, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(136, 383);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(238, 27);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cmbx_days
            // 
            this.cmbx_days.FormattingEnabled = true;
            this.cmbx_days.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbx_days.Location = new System.Drawing.Point(147, 3);
            this.cmbx_days.Name = "cmbx_days";
            this.cmbx_days.Size = new System.Drawing.Size(88, 21);
            this.cmbx_days.TabIndex = 3;
            this.cmbx_days.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trxn Type";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Virtual Portfolio - rk";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_pf)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lstbx_schemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_nav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_amt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpick_trxndate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dgvw_pf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DateTimePicker dtpcker_asondate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbtn_sip;
        private System.Windows.Forms.RadioButton rdbtn_lmsm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cmbx_days;
    }
}