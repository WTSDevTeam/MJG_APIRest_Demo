using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJG_APIRest_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string mEndpoint = "http://mjcd-vbrapp01/VistaAPIRest/api/vistaapi/";

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtResult_code.Text = "";
            this.txtResult_Msg.Text = "";
            this.pmLoad_Session();
        }

        private void btnSessionSeatMap_Click(object sender, EventArgs e)
        {
            this.txtResult_code.Text = "";
            this.txtResult_Msg.Text = "";
            this.pmLoad_SessionSeatMapEx();
        }


        private void btnListTicketStd_Click(object sender, EventArgs e)
        {
            this.txtResult_code.Text = "";
            this.txtResult_Msg.Text = "";
            this.pmLoad_ListTicketStandard();
        }

        private void pmLoad_Session()
        {
            string uri = this.mEndpoint + "listsession";
            string strResMessage = "";
            var values = new Dictionary<string, string>
                            {
                                { "ClientName" , this.txtClient1.Text},
                                { "AuthorizeCode" , this.txtAuth1.Text },
                                { "BranchID" , this.txtBr1.Text },
                                { "SessionDate" , this.txtDate1.Text },
                                { "OrderBy" , "" }
                            };

            string strResMsg = "";
            DateTime dttStart = DateTime.Now;
            HttpStatusCode oResCode = Helper.APIAgents.HttpPost(uri, values, ref strResMessage);
            DateTime dttFinish = DateTime.Now;
            TimeSpan ts = dttFinish - dttStart;
            double procTime = ts.TotalMilliseconds;
            this.txtProcTime.Text = procTime.ToString("n0");

            if (oResCode == HttpStatusCode.OK)
            {
                Models.result_listsession oResult = JsonConvert.DeserializeObject<Models.result_listsession>(strResMessage);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AllowUserToAddRows = false;
                this.dataGridView1.ReadOnly = true;

                this.dataGridView1.DataSource = oResult.result_data;

                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }
            else
            {
                Models.result_listsession oResult = JsonConvert.DeserializeObject<Models.result_listsession>(strResMessage);
                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }

        }


        private void pmLoad_SessionSeatMapEx()
        {
            string uri = this.mEndpoint + "sessionseatmapEx";
            string strResMessage = "";
            var values = new Dictionary<string, string>
                            {
                                { "ClientName" , this.txtClient2.Text},
                                { "AuthorizeCode" , this.txtAuth2.Text },
                                { "BranchID" , this.txtBr2.Text },
                                { "SessionId" , this.txtSID2.Text },
                                { "CardNo" , this.txtCard2.Text }
                            };

            string strResMsg = "";
            DateTime dttStart = DateTime.Now;
            HttpStatusCode oResCode = Helper.APIAgents.HttpPost(uri, values, ref strResMessage);
            DateTime dttFinish = DateTime.Now;
            TimeSpan ts = dttFinish - dttStart;
            double procTime = ts.TotalMilliseconds;
            this.txtProcTime.Text = procTime.ToString("n0");

            if (oResCode == HttpStatusCode.OK)
            {
                Models.result_SessionSeatMap oResult = JsonConvert.DeserializeObject<Models.result_SessionSeatMap>(strResMessage);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AllowUserToAddRows = false;
                this.dataGridView1.ReadOnly = true;

                this.dataGridView2.DataSource = oResult.result_data;

                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }
            else
            {
                Models.result_SessionSeatMap oResult = JsonConvert.DeserializeObject<Models.result_SessionSeatMap>(strResMessage);
                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }

        }

        private void pmLoad_ListTicketStandard()
        {
            string uri = this.mEndpoint + "ListTicketStandard";
            string strResMessage = "";
            var values = new Dictionary<string, string>
                            {
                                { "ClientName" , this.txtClient3.Text},
                                { "AuthorizeCode" , this.txtAuth3.Text },
                                { "BranchID" , this.txtBr3.Text },
                                { "SessionId" , this.txtSID3.Text },
                                { "CardNo" , this.txtCard3.Text }
                            };

            string strResMsg = "";
            DateTime dttStart = DateTime.Now;
            HttpStatusCode oResCode = Helper.APIAgents.HttpPost(uri, values, ref strResMessage);
            DateTime dttFinish = DateTime.Now;
            TimeSpan ts = dttFinish - dttStart;
            double procTime = ts.TotalMilliseconds;
            this.txtProcTime.Text = procTime.ToString("n0");

            if (oResCode == HttpStatusCode.OK)
            {
                Models.result_ListTickettype oResult = JsonConvert.DeserializeObject<Models.result_ListTickettype>(strResMessage);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AllowUserToAddRows = false;
                this.dataGridView1.ReadOnly = true;

                this.dataGridView3.DataSource = oResult.result_tickettype;

                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }
            else
            {
                Models.result_SessionSeatMap oResult = JsonConvert.DeserializeObject<Models.result_SessionSeatMap>(strResMessage);
                this.txtResult_code.Text = oResult.result_code.result_code;
                this.txtResult_Msg.Text = oResult.result_code.result_message;
            }

        }

    }
}
