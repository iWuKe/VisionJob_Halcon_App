using System;
using System.Collections.Generic;
using System.ComponentModel;
 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shikii.VisionJob
{
    public partial class RetriveLogForm : Form
    {
        public RetriveLogForm()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            bool isSearchDay = false;
            if(dateTimePicker1.Text.Equals(dateTimePicker2.Text))
            {
                isSearchDay = true;
            }
            if(dateTimePicker2.Value <dateTimePicker2.Value)
            {
                dotNetLab.Tipper.Error = "第二个日期控件的日期必须大于或者等于前一个日期控件的日期。";
                return;
            }
            if (isSearchDay)
            {
                String searchTime = dateTimePicker1.Value.ToString("yyyy-MM-dd");

               this.dataGridView1.DataSource =  dotNetLab.Common.R.LogDB.ProvideTable(String.Format("SELECT Fire_Time,Message FROM LogTable where Fire_Time='{0}';", searchTime), dotNetLab.Data.DBOperator.OPERATOR_QUERY_TABLE);
             }
            else
            {
                String searchTime1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String searchTime2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                this.dataGridView1.DataSource = dotNetLab.Common.R.LogDB.ProvideTable(String.Format("SELECT Fire_Time,Message FROM LogTable where Fire_Time >='{0}' and Fire_Time <='{1}';", searchTime1,searchTime2), dotNetLab.Data.DBOperator.OPERATOR_QUERY_TABLE);
            }
        }
    }
}
