using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.Office.Interop.Excel;


namespace navscraper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool firstline = true; System.Data.DataTable dt; string req;

        public double getnav(string code, DateTime date)
        {
             double ret = 0;
                 trxndate = date;
            while (ret==0.0)
            {

                dt = new System.Data.DataTable();
                try
                {
                    string url = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?frmdt=";
                    req = url + trxndate.ToString("dd/MMM/yyyy") + "&todt=" + trxndate.ToString("dd/MMM/yyyy");
                    HttpWebRequest request = WebRequest.Create(req) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        if (s.Contains("</title>"))
                            break;
                        if (s.Contains(";"))
                        {
                            string[] d = s.Split(';');
                            if (firstline)
                            {
                                foreach (string a in d)
                                {
                                    dt.Columns.Add(a);

                                }
                                firstline = false;
                            }
                            else
                            {
                                dt.Rows.Add(d);
                            }
                        }
                    }
                    reader.Dispose(); stream.Dispose();
                    firstline = true;
                }
                catch(Exception z)
                {
                   
                    //MessageBox.Show(z.Message.ToString());
                    
                }
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == code)
                    {
                        ret = Convert.ToDouble(dr[2]);
                        break;
                    }

                }
                if (ret == 0.0)
                    trxndate = trxndate.AddDays(-1);
            }
            return ret;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = new System.Data.DataTable();
            try
            {

                    HttpWebRequest request = WebRequest.Create(req) as HttpWebRequest;
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);

                    dt.Clear();
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        if (s.Contains(";"))
                        {
                            string[] d = s.Split(';');
                            if (firstline)
                            {
                                foreach (string a in d)
                                {
                                    dt.Columns.Add(a);

                                }
                                firstline = false;
                            }
                            else
                            {

                                dt.Rows.Add(d);

                            }

                        }
                        backgroundWorker1.ReportProgress(100);
                    }
                    
                    firstline = true;
                    
                }
            
            catch (Exception z)
                {
                    firstline = true;
                backgroundWorker1.CancelAsync();
                
            }
        }

        public void fillschemes(string keyword)
        {
            try
            {
                lstbx_schemes.Items.Clear();
                foreach(DataRow dr in dt.Rows)
                {
                    if(dr[1].ToString().ToLower().Contains(keyword.ToLower()))
                    lstbx_schemes.Items.Add(dr[1].ToString() + "~" + dr[0].ToString()+"~" + dr[2].ToString());
                }
            }
            catch
            { }
        }
         

        private void Form2_Load(object sender, EventArgs e)
        {
            //getnav("128ISGP", DateTime.Now.AddDays(-13));
            fillschemes("");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (dt.Rows.Count > 10)
            {
                fillschemes("");
                dtpick_trxndate.Enabled = true;
                comboBox1.Enabled = true;
                button1.Text = "Fetch";
            }
            else
                dtpick_trxndate.Value = dtpick_trxndate.Value.AddDays(-1);
            
        }
        string schemecode = ""; double nav = 0; int amount = 0; string schemename = ""; DateTime trxndate;
        private void lstbx_schemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatesummary();
        }
        public void updatesummary()
        {
            try
            {

                string[] split = lstbx_schemes.Text.ToString().Split('~');
                schemename = split[0];
                schemecode = split[1];
                nav = Convert.ToDouble(split[2]);
                txtbx_nav.Text = nav.ToString();
                label4.Text = "Scheme Name: " + schemename + "\n Price: :" + nav.ToString() + "\nAmount: " + amount.ToString() + "\nUnits: " + (amount / nav).ToString();
            }
            catch
            { }
        }
        private void txtbx_amt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToInt32(txtbx_amt.Text);
                updatesummary();
            }
            catch
            { }
        }


        string url = ""; 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Fetch")
                {
                    
                    trxndate = dtpick_trxndate.Value;
                    dtpick_trxndate.Enabled = false;
                    comboBox1.Enabled = false;
                    button1.Text = "Cancel";
                    if (comboBox1.Text.Length > 6)
                    {
                        string[] aaz = comboBox1.Text.ToString().Split('-');

                        url = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=" + aaz[1] + "&frmdt=";
                    }
                    else
                    {
                        url = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?frmdt=";

                    }
                    req = url + trxndate.ToString("dd/MMM/yyyy") + "&todt=" + trxndate.ToString("dd/MMM/yyyy");
                    if (backgroundWorker1.IsBusy)
                        backgroundWorker1.CancelAsync();
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    backgroundWorker1.CancelAsync();
                    dtpick_trxndate.Enabled = true;
                    comboBox1.Enabled = true;
                    button1.Text = "Fetch";
                    if (backgroundWorker1.IsBusy)
                        backgroundWorker1.CancelAsync();
                }
            }
            catch
            { }
        }
        bool issip = false;
        private void button2_Click(object sender, EventArgs e)
        {
            double units = amount / nav;int day=0;
            if (cmbx_days.SelectedItem == null)
                day = 0;
            else
                day = Convert.ToInt32(cmbx_days.SelectedItem);
            Properties.Settings.Default.pfdetails.Add(trxndate + "^" + issip + "^" + day + "^" +schemecode+ "^" + schemename + "^" + nav + "^" + units.ToString() + "^" + amount.ToString());
            Properties.Settings.Default.Save();
            MessageBox.Show("Added Sucessfully");
        }

        public void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                btn_refresh.Text = "Generating..";
                btn_refresh.Enabled = false;
                System.Data.DataTable dt = new System.Data.DataTable("Portfolio");
                dt.Columns.Add("Transaction Date");
                dt.Columns.Add("IsSIP");
                dt.Columns.Add("SIP Day");
                dt.Columns.Add("SchemeCode");
                dt.Columns.Add("SchemeName");
                dt.Columns.Add("Purchase Price");
                dt.Columns.Add("Purchase Units");
                dt.Columns.Add("Purchase Value");
                dt.Columns.Add("Current Price");
                dt.Columns.Add("Current Value");
                dt.Columns.Add("Gain / Loss");
                dt.Columns.Add("Abs Return");
                dt.Columns.Add("Sim. Ann Return");
                //dt.Columns.Add("XIRR");
                dt.Columns.Add("As on Date");
                string[] rows=null; ; int a = 0;
                foreach (string s in Properties.Settings.Default.pfdetails)
                {
                    if (s.Length > 4)
                    {
                        string ss = s;
                        string[] split = ss.Split('^');
                        if (split[1].ToLower() == "false")
                        {
                            double nav = Convert.ToDouble(getnav(split[3], dtpcker_asondate.Value));
                            ss += "^" + nav;
                            double cv = Convert.ToDouble(nav * (Convert.ToDouble(split[split.Length - 2])));
                            ss += "^" + cv;
                            split = ss.Split('^');
                            double pl = Convert.ToDouble(Convert.ToDouble(split[split.Length - 1]) - Convert.ToDouble(split[split.Length - 3]));
                            if (pl < 0)
                                pl = 0;
                            ss += "^" + pl.ToString();
                            ss += "^" + (pl / Convert.ToDouble(split[split.Length - 3])) * 100;
                            TimeSpan ts = trxndate - Convert.ToDateTime(split[0]);
                            ss += "^" + (((pl / Convert.ToDouble(split[split.Length - 3])) * 100) * 365) / ts.Days;

                            ss += "^" + trxndate.ToShortDateString();
                            dt.Rows.Add(ss.Split('^'));
                        }
                        else
                        {
                            List<DateTime> trxndates = getsipdates(Convert.ToDateTime(split[0]),dtpcker_asondate.Value,Convert.ToInt32(split[2]));
                            ss = split[0] + "^" + split[1] + "^" + split[2] + "^" + split[3] + "^" + split[4] + "^" + split[5] + "^" + split[6]+ "^" + split[7]; ; ;
                            double units = Convert.ToDouble(split[6]);double nav =0;
                            foreach (DateTime dat in trxndates)
                            {
                                nav=getnav(split[3], dat);
                                units += Convert.ToDouble(split[7]) / nav;
                            }

                            double cv = units * nav;
                            ss += "^" + nav;
                            
                            ss += "^" + cv;
                            double pl = 90;
                            if (pl < 0)
                                pl = 0;
                            ss += "^" + pl.ToString();
                            ss += "^" + 50;
                            TimeSpan ts = trxndate - Convert.ToDateTime(split[0]);
                            ss += "^" + (((pl / Convert.ToDouble(split[split.Length - 3])) * 100) * 365) / ts.Days;

                            ss += "^" + trxndate.ToShortDateString();
                            dt.Rows.Add(ss.Split('^'));

                        }

                        //rows[a++] = ss;
                        dgvw_pf.DataSource = dt;
                    }
                }
              
                btn_refresh.Enabled = true;
                btn_refresh.Text = "Show Report";
                
            }
            catch(Exception){
                btn_refresh.Enabled = true;
                btn_refresh.Text = "Show Report";
            };
        }

        //xirr
        //List<DateTime> _dates = new List<DateTime>();
        //List<object> _cash = new List<object>();
        //_dates.Add(Convert.ToDateTime(split[0])); _dates.Add(trxndate);
        //_cash.Add(Convert.ToInt32(Convert.ToDouble(split[5])));
        //_cash.Add(0 - Convert.ToInt32(Convert.ToDouble(split[7])));
        //ss += "^" + calculatexirr(_cash, _dates);
        //double tgl = 0;  double tcv = 0; double tpv = 0;
        //foreach (DataRow dr in dgvw_pf.tab)
        //{
        //    tpv = tpv + Convert.ToDouble(dr[5]);
        //    tcv = tcv + Convert.ToDouble(dr[7]);
        //    tgl = tgl + Convert.ToDouble(dr[8]);

        //}
        //string z="Total^-^-^-^-^"+tpv+"^-^"+tpv+"^"+tgl+"^-^-";
        //dgvw_pf.Rows.Add(z.Split('^'));
//xirr

        public List<DateTime> getsipdates(DateTime trxndate, DateTime asondate,int sipday)
        {
            List<DateTime> sipdates = new List<DateTime>();
            bool check = true;
            while (check)
            {
                trxndate = trxndate.AddMonths(1);
                sipdates.Add(trxndate);
                TimeSpan ts = DateTime.Now - trxndate;
                if (ts.Days < 2)
                    check = false;
            }
            return sipdates;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.pfdetails.Clear();
            Properties.Settings.Default.Save();
            btn_refresh.PerformClick();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillschemes(textBox1.Text.ToString());
        }

        // value to store the results
        double xirrValue;
        // create the new excel interop object 

        public double calculatexirr(List<object> _cash, List<DateTime> _dates)
        {
            try
            {
                ApplicationClass xlApp = new ApplicationClass();
                
                if (Decimal.Parse(xlApp.Version) > 11)
                {
                    xirrValue = xlApp.WorksheetFunction.Xirr(_cash.ToArray(), _dates.ToArray(), 0.1);
                }
                else
                {
                    xlApp.RegisterXLL(xlApp.Path + @"\Library\Analysis\ANALYS32.XLL");
                    xirrValue = (double)xlApp.Run("XIRR", _cash.ToArray(), _dates.ToArray(), 1,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return xirrValue;

        }

        private void rdbtn_sip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_sip.Checked)
                cmbx_days.Visible = true;
            else
                cmbx_days.Visible = false;

            issip=rdbtn_sip.Checked;
        }
            


//        double LOW_RATE=0.01;
//        double HIGH_RATE = 0.5;
//double MAX_ITERATION=1000;
//double PRECISION_REQ=0.00000001;

//        public double computeIRR(double[] cf, int numOfFlows)
//        {
//            int i = 0, j = 0;
//            double m = 0.0;
//            double old = 0.00;
//            double nzew = 0.00;
//            double oldguessRate = LOW_RATE;
//            double newguessRate = LOW_RATE;
//            double guessRate = LOW_RATE;
//            double lowGuessRate = LOW_RATE;
//            double highGuessRate = HIGH_RATE;
//            double npv = 0.0;
//            double denom = 0.0;
//            for (i = 0; i < MAX_ITERATION; i++)
//            {
//                npv = 0.00;
//                for (j = 0; j < numOfFlows; j++)
//                {
//                    denom = pow((1 + guessRate), j);
//                    npv = npv + (cf[j] / denom);
//                }
//                /* Stop checking once the required precision is achieved */
//                if ((npv > 0) && (npv < PRECISION_REQ))
//                    break;
//                if (old == 0)
//                    old = npv;
//                else
//                    old = nzew;
//                nzew = npv;
//                if (i > 0)
//                {
//                    if (old < nzew)
//                    {
//                        if (old < 0 && nzew < 0)
//                            highGuessRate = newguessRate;
//                        else
//                            lowGuessRate = newguessRate;
//                    }
//                    else
//                    {
//                        if (old > 0 && nzew > 0)
//                            lowGuessRate = newguessRate;
//                        else
//                            highGuessRate = newguessRate;
//                    }
//                }
//                oldguessRate = guessRate;
//                guessRate = (lowGuessRate + highGuessRate) / 2;
//                newguessRate = guessRate;
//            }
//            return guessRate;
//        }

    }
}