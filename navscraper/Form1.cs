using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace navscraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string datez; bool firstline = true; DataTable dt; string req; int rowscount; string url;
        private void button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable("NAV");
            progressBar1.Visible = true;
            button2.Visible = true;
            try
            {
                datez = dateTimePicker1.Value.Date.ToString("dd/MMM/yyyy");
                if (comboBox1.Text.Length>6)
                {
                    string [] aaz=comboBox1.Text.ToString().Split('-');

                    url = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=" + aaz[1] + "&frmdt=";
                }
                else
                {
                    url = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?frmdt=";

                }
                 req = url+datez+"&todt=" + datez;
                 if (backgroundWorker1.IsBusy)
                     backgroundWorker1.CancelAsync();
                 backgroundWorker1.RunWorkerAsync();
                
            }
            catch(Exception ex)
            {
                
            }
            firstline = true;
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void refresh()
        {
            
        }



        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //dateTimePicker1.Enabled = false;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //try
            //{
            //    dateTimePicker1.Enabled = true;
            //    string s = webBrowser1.Document.Body.InnerHtml;
            //    int a = s.IndexOf("/spages/NAVAll.txt");
            //    hash = s.Substring(a, 35).ToString();
            //    string[] dsz = hash.Split('=');
            //    hash = dsz[1].ToString();
            //    hash = hash.Substring(hash.Length - 6, 6);
                
                
            //}
            //catch(Exception xx)
            //{
            //    MessageBox.Show(xx.Message.ToString());
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker1.ReportProgress(10);
                HttpWebRequest request = WebRequest.Create(req) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);


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
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message.ToString());
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.DataSource = dt;
            rowscount = dt.Rows.Count;
            label1.Text = rowscount.ToString()+" Rows Found..";
            progressBar1.Visible = false;
            button2.Visible = false;
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Step = e.ProgressPercentage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                progressBar1.Visible = false;
                button2.Visible = false;
            }
        }

      

    }
}