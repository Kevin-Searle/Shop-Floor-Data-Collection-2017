using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop_Floor_Data_Collection_2017
{
    public partial class SFDCMain : Form
    {
        public SFDCMain()
        {
            InitializeComponent();
        }

        private void SFDCMain_Load(object sender, EventArgs e)
        {
            LoadDemoData();
        }

        //Demo Data only
        private class SFDCEntry
        {
            public string OrderNo { get; set; }
            public string LineNo { get; set; }
            public string OpNo { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal TimeHours { get; set; }
            public int QtyAcc { get; set; }

            public SFDCEntry(string ord, string lin, string op, DateTime startdate, DateTime enddate, decimal timehours, int qtyacc)
            {
                OrderNo = ord;
                LineNo = lin;
                OpNo = op;
                StartDate = startdate;
                EndDate = enddate;
                TimeHours = timehours;
                QtyAcc = qtyacc;
            }
        }

        public void LoadDemoData()
        {
            List<SFDCEntry> sampleData = new List<SFDCEntry>();
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddHours(6);
            sampleData.Add(new SFDCEntry("1011004", "10000", "10", startDate, endDate, 6.0M, 10));
            sampleData.Add(new SFDCEntry("1011004", "10000", "20", startDate.AddDays(1), endDate.AddDays(1), 6.0M, 10));

            var sd = new BindingList<SFDCEntry>(sampleData);
            dgvTimeReview.DataSource = sd;
        }
    }
}
