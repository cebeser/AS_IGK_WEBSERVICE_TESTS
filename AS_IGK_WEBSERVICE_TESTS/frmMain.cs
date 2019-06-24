using AS_IGK_WEBSERVICE_TESTS.ServiceReferenceLOGO;
using System;
using System.Windows.Forms;
using AS_IGK_WEBSERVICE_TESTS.Helpers;

namespace AS_IGK_WEBSERVICE_TESTS
{
    public partial class frmMain : Form
    {
        ServiceReferenceLOGO.LogoSoapClient _serviceReferenceLogo = new LogoSoapClient();
        ServiceReferenceLOGO.Authentication _authentication = new Authentication();

        public frmMain()
        {
            InitializeComponent();
            _authentication = new Authentication()
            {
                FirmNR = "111",
                Username = "YOUR_AUTH_USERNAME",
                Password = "YOUR_AUTH_PASSWORD"
            };
        }

        private void btnUserCheck_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.UserCheck(_authentication);

            ShowXMLStatusOntoTextBox(result);
        }

        private void btnSaveClientCardByTCKN_Click(object sender, EventArgs e)
        {
            ClientCard clientCard = new ClientCard()
            {
                CODE = "~", // LOGO Tarafında otomatik yaratılsın.
                TCKNO = "123456",
                ISPERSCOMP = "0",
                CARDTYPE = "3",
                NAME = "Cari Adı",
                SURNAME = "Cari Soyadı",
                DEFINITION_ = "Cari Ünvanı",
                ACCEPTEINV = "1",
                ADDR1 = "Adres 1",
                FINBRWS = "1",
                SALESBRWS = "1",
                IMPBRWS = "1",
                EXPBRWS = "1",
                PURCHBRWS = "1",
                LOGICALREF = "0",
            };

            var result = _serviceReferenceLogo.SaveClientCardByTCKN(_authentication, clientCard);

            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        private void btnGetPayPlanList_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.GetPayPlanList(_authentication);

            if (result?.Length > 0)
            {
                ShowDataOntoDatagridview(result);
            }

            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        private void btnGetClientCardListByTCKN_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.GetClientCardListByTCKN(_authentication, "123456");


            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        private void btnSaveSalesOrder_Click(object sender, EventArgs e)
        {
            var resultClientCard = _serviceReferenceLogo.GetClientCardListByTCKN(_authentication, "123456");
            var resultServiceCard = _serviceReferenceLogo.GetServiceCardList(_authentication, 2);



            SalesOrder salesOrder = new SalesOrder()
            {
                LOGICALREF = "0",
                TYPE = "1",
                NUMBER = "~",
                DATE = DateTime.Now.ToString("yyyy-MM-dd"),
                ARP_CODE = resultClientCard.CODE,
                PAYMENT_CODE = "6TAKSIT", //PayPlan içerisindeki özel kod alınmalı.
                NOTES1 = "Üyelik bedeli",
                WITH_PAYMENT = "1",
                ORDER_STATUS = "1",
                CURRSEL_TOTAL = "1",
                TOTAL_NET = "5000", //5,000 TL 
                TRANSACTIONS = new TRANSACTIONS()
                {
                    items = new Item[1]
                    {
                        new Item()
                        {
                            TYPE = "4",
                            MASTER_CODE = resultServiceCard[0].CODE,
                            QUANTITY = "1",
                            PRICE = "5000",
                            TOTAL = "5000",
                            UNIT_CODE = "ADET",
                            TRANS_DESCRIPTION = "Satır Açıklama_ÖNEMSİZ",
                            UNIT_CONV1 = "1",
                            UNIT_CONV2 = "1",
                            DUE_DATE =  DateTime.Now.ToString("yyyy-MM-dd"),
                            TOTAL_NET = "5000",
                            EDT_CURR = "1",
                            DEPARTMENT = "",
                            DIVISION = "",
                            ORG_DUE_DATE =  DateTime.Now.ToString("yyyy-MM-dd"),
                            ORG_QUANTITY = "1",
                            ORG_PRICE = "5000",
                            RC_XRATE = "0",
                            SOURCE_COST_GRP = "",
                            SOURCE_WH = "",
                            VAT_AMOUNT = "0",
                            VAT_BASE = "5000",
                            VAT_INCLUDED = "",
                            VAT_RATE = "0",
                        }
                    }
                }
            };

            var result = _serviceReferenceLogo.SaveSalesOrder(_authentication, salesOrder);

            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        void ShowXMLStatusOntoTextBox(string value)
        {
            txtStatus.Text = value;
        }

        void ShowDataOntoDatagridview(object obj)
        {

            dataGridView1.DataSource = obj;

        }


        private void btnGetInstallmentsListByTCKNForIGKProject_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.GetInstallmentsListByTCKNForIGKProject(_authentication, "123456", 24.00m);


            if (result?.Length > 0)
            {
                ShowDataOntoDatagridview(result);
            }

            ShowXMLStatusOntoTextBox(result.Serialize());
        }
    }
}
