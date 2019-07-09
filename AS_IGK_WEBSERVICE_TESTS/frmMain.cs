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
                Username = "bizpark",
                Password = "6420435c-ed9b-4002-bd16-e85e70238c94"
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
                TRANSACTIONS = new SalesTransaction()
                {
                    items = new SalesItem[1]
                    {
                        new SalesItem()
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

        private void btnGetBankCardList_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.GetBankCardList(_authentication);

            if (result?.Length > 0)
            {
                ShowDataOntoDatagridview(result);
            }

            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        private void btnGetBankAccountCardsByCARDTYPE_Click(object sender, EventArgs e)
        {
            var result = _serviceReferenceLogo.GetBankAccountCardsByCARDTYPE(_authentication, "5");

            if (result?.Length > 0)
            {
                ShowDataOntoDatagridview(result);
            }

            ShowXMLStatusOntoTextBox(result.Serialize());
        }

        private void btnSaveArpOrder_Click(object sender, EventArgs e)
        {
            /* Cari hesap fişi -- KREDİ KARTI TÜRÜNDE */

            var resultClientCard = _serviceReferenceLogo.GetClientCardListByTCKN(_authentication, "123456");
            var resultBankAccountCard = _serviceReferenceLogo.GetBankAccountCardsByCARDTYPE(_authentication, "5");

            if (resultClientCard != null && resultBankAccountCard?.Length > 0)
            {

                ArpOrder arpOrder = new ArpOrder()
                {
                    LOGICALREF = "0",
                    TYPE = "70", //Kredi kartı,
                    ARP_CODE = resultClientCard.CODE,
                    BANKACC_CODE = resultBankAccountCard[0].CODE,

                    DEPARTMENT = "0",
                    DIVISION = "0",
                    NUMBER = "~",
                    RC_TOTAL_CREDIT = "0",
                    RC_TOTAL_DEBIT = "0",
                    TOTAL_CREDIT = "50",
                    TOTAL_DEBIT = "0",
                    DATE = DateTime.Now.ToString("yyyy-MM-dd"),
                    TRANSACTIONS = new ArpTransaction()
                    {
                        items = new ArpItem[1]
                        {
                            new ArpItem()
                            {
                                 LOGICALREF = "0",
                                 ARP_CODE = resultClientCard.CODE,
                                 TRCODE = "70",
                                 DATE = DateTime.Now.ToString("yyyy-MM-dd"),
                                 DEPARTMENT = "0",
                                 DIVISION = "0",
                                 AMOUNT = "50",
                                 VAT_RATE = "0",
                                 BANKACC_CODE = resultBankAccountCard[0].CODE,
                                 RC_XRATE = "0",
                                 BNLN_TC_AMOUNT = "50",
                                 BNLN_TC_CURR = "0",
                                 BNLN_TC_XRATE = "1",
                                 CREDIT = "50",
                                 CURRSEL_TRANS = "0",
                                 CURR_TRANS = "0",
                                 DEBIT = "0",
                                 DISCACCREF = "0",
                                 DISCCENREF = "0",
                                 DISCOUNTED = "0",
                                 DISCOUNTED_AMOUNT = "0",
                                 DISCOUNT_RATE = "0",
                                 GL_POSTED = "0",
                                 PAYMENT_LIST = new PaymentList(),
                                 RC_AMOUNT = "0",
                                 SIGN = "1",
                                 TC_AMOUNT = "50",
                                 TC_XRATE = "1",
                                 VATRACCREF = "0",
                                 
                            }
                        }
                    }
                };



                var result = _serviceReferenceLogo.SaveArpOrder(_authentication, arpOrder);

                ShowXMLStatusOntoTextBox(result.Serialize());
            }
        }
    }
}
