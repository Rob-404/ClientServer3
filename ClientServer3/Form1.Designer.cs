
namespace ClientServer3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.da_so_master_hdr = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ds_so_master_hdr1 = new ClientServer3.ds_so_master_hdr();
            this.colSO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_PREFIX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUOTE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATOR_SAVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_SAVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATOR_LAST_MODIFIED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_LAST_MODIFIED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPLETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_HOLD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATOR_HOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_HOLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATOR_RELEASED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_RELEASED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAX_EXEMPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAX_EXEMPT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILLING_ADDR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_ADD_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_ADD_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_ADD_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_CITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_ZIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_COUNTRY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_COUNTRY_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACT_INFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTERMS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_USER_DEF1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_USER_DEF2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMO_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_CANCEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERATOR_CANCEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCANCEL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_INTERNAL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGST_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIN_PCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOUT_PCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_PCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_COMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_COMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_PROD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_TAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_GST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNEXT_PO_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAY_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDISC_PCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXP_SHIP_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPREPARE_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpri_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASH_UPDATED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHSE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIP_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUTURE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURRENCY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_DISCOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_QUOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_QUOTE_REF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCKED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCKED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBR_CUSTOMER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CNTL_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMM_CNTL_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYMENT_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHANGE_GIVEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPLIT_COMM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREV_SHIP_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXTRACT_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXP_COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCALL_BACK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_APPROVED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTHORIZED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTHORIZED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAUTHORIZED_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCHEDULED_QUOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYMENT_APPLIED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOSIT_APPLIED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOSIT_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOSIT_UPDATED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDELIVERY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRETURN_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_TRN_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDELIVERY_CHARGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTOCKING_CHARGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTOCKING_PCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_DIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAR_SETUP_GL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRICE_CODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINT_CNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREDIT_REF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMENT_INT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFOOTER_COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWMS_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWMS_MESSAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMTR_REQUIRED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMETRIC_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWMS_ORDER_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_WEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXT_REFERENCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLSD_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDERED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFOB_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinstaller_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD_CODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILE_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINT_PRICES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUY_RCVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAS_PIPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREVIEWED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQUIRED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXCEPTION_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGGING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPO_RELEASE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMTR_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarsallingOrdType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWMS_STATUS_PIPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWMS_MESSAGE_PIPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRE_APPROVAL_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOST_APPROVAL_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPPROVAL_REQ_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirectShip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPONO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_RFQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconvert_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_GMStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_GM_RequestID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICK_SLIP_PRINT_COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttentionRequired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB2B_Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBUY_RCVD_PIPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB2B_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipInProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuildReference_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuildReferenceCompany_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditRemaining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashSalePaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLS_ID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOUT_PCT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOUT_PCT3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOE_Priority_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcons_method_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcons_frequency_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSOLIDATE_INVOICES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommissionsPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompletionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickSlipPrinted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickSlipPrinted_pipe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_RoutedApproval_Req_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_RoutedForTraining = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_RoutedForCreditDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKC_RoutedForCreditDays_Req_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManualQuote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRM_Opportunity_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProbablityPct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLY_AND_INSTALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuoteValidityID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuoteRoutingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuoteRoutingStatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseFolder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndConsumer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREV_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReleaseToDrafting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_REF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_TELEPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILL_TO_FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRE_APPROVED_AMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReleaseShipHold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndConsumer_Customer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndConsumer_ContactID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencedSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuoteSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfirmationSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_Class_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_so_master_hdr1)).BeginInit();
            this.SuspendLayout();
            // 
            // da_so_master_hdr
            // 
            this.da_so_master_hdr.DeleteCommand = this.sqlDeleteCommand;
            this.da_so_master_hdr.InsertCommand = this.sqlInsertCommand;
            this.da_so_master_hdr.SelectCommand = this.sqlSelectCommand1;
            this.da_so_master_hdr.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SO_MASTER_HDR", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SO_NO", "SO_NO"),
                        new System.Data.Common.DataColumnMapping("SO_ID", "SO_ID"),
                        new System.Data.Common.DataColumnMapping("SO_PREFIX", "SO_PREFIX"),
                        new System.Data.Common.DataColumnMapping("SO_TYPE", "SO_TYPE"),
                        new System.Data.Common.DataColumnMapping("QUOTE_ID", "QUOTE_ID"),
                        new System.Data.Common.DataColumnMapping("CUSTOMER_ID", "CUSTOMER_ID"),
                        new System.Data.Common.DataColumnMapping("PONO", "PONO"),
                        new System.Data.Common.DataColumnMapping("ORDER_DATE", "ORDER_DATE"),
                        new System.Data.Common.DataColumnMapping("OPERATOR_SAVED", "OPERATOR_SAVED"),
                        new System.Data.Common.DataColumnMapping("DATE_SAVED", "DATE_SAVED"),
                        new System.Data.Common.DataColumnMapping("OPERATOR_LAST_MODIFIED", "OPERATOR_LAST_MODIFIED"),
                        new System.Data.Common.DataColumnMapping("DATE_LAST_MODIFIED", "DATE_LAST_MODIFIED"),
                        new System.Data.Common.DataColumnMapping("STATUS", "STATUS"),
                        new System.Data.Common.DataColumnMapping("HOLD", "HOLD"),
                        new System.Data.Common.DataColumnMapping("COMPLETE", "COMPLETE"),
                        new System.Data.Common.DataColumnMapping("SO_HOLD_ID", "SO_HOLD_ID"),
                        new System.Data.Common.DataColumnMapping("OPERATOR_HOLD", "OPERATOR_HOLD"),
                        new System.Data.Common.DataColumnMapping("DATE_HOLD", "DATE_HOLD"),
                        new System.Data.Common.DataColumnMapping("OPERATOR_RELEASED", "OPERATOR_RELEASED"),
                        new System.Data.Common.DataColumnMapping("DATE_RELEASED", "DATE_RELEASED"),
                        new System.Data.Common.DataColumnMapping("TAX_EXEMPT", "TAX_EXEMPT"),
                        new System.Data.Common.DataColumnMapping("TAX_EXEMPT_ID", "TAX_EXEMPT_ID"),
                        new System.Data.Common.DataColumnMapping("BILLING_ADDR_ID", "BILLING_ADDR_ID"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_NAME", "BILL_TO_NAME"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_ADD_1", "BILL_TO_ADD_1"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_ADD_2", "BILL_TO_ADD_2"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_ADD_3", "BILL_TO_ADD_3"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_CITY", "BILL_TO_CITY"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_STATE", "BILL_TO_STATE"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_ZIP", "BILL_TO_ZIP"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_COUNTRY_ID", "BILL_TO_COUNTRY_ID"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_COUNTRY_CODE", "BILL_TO_COUNTRY_CODE"),
                        new System.Data.Common.DataColumnMapping("CONTACT_ID", "CONTACT_ID"),
                        new System.Data.Common.DataColumnMapping("CONTACT_INFO", "CONTACT_INFO"),
                        new System.Data.Common.DataColumnMapping("COMM_METHOD", "COMM_METHOD"),
                        new System.Data.Common.DataColumnMapping("TERMS_ID", "TERMS_ID"),
                        new System.Data.Common.DataColumnMapping("SO_USER_DEF1_ID", "SO_USER_DEF1_ID"),
                        new System.Data.Common.DataColumnMapping("SO_USER_DEF2", "SO_USER_DEF2"),
                        new System.Data.Common.DataColumnMapping("COD", "COD"),
                        new System.Data.Common.DataColumnMapping("MEMO_CODE", "MEMO_CODE"),
                        new System.Data.Common.DataColumnMapping("DATE_CANCEL", "DATE_CANCEL"),
                        new System.Data.Common.DataColumnMapping("OPERATOR_CANCEL", "OPERATOR_CANCEL"),
                        new System.Data.Common.DataColumnMapping("CANCEL_ID", "CANCEL_ID"),
                        new System.Data.Common.DataColumnMapping("SLS_INTERNAL_ID", "SLS_INTERNAL_ID"),
                        new System.Data.Common.DataColumnMapping("GST_FLAG", "GST_FLAG"),
                        new System.Data.Common.DataColumnMapping("IN_PCT", "IN_PCT"),
                        new System.Data.Common.DataColumnMapping("OUT_PCT", "OUT_PCT"),
                        new System.Data.Common.DataColumnMapping("COMM_PCT", "COMM_PCT"),
                        new System.Data.Common.DataColumnMapping("SLS_COMM", "SLS_COMM"),
                        new System.Data.Common.DataColumnMapping("TOTAL_COMM", "TOTAL_COMM"),
                        new System.Data.Common.DataColumnMapping("TOTAL_PROD", "TOTAL_PROD"),
                        new System.Data.Common.DataColumnMapping("TOTAL_TAX", "TOTAL_TAX"),
                        new System.Data.Common.DataColumnMapping("TOTAL_GST", "TOTAL_GST"),
                        new System.Data.Common.DataColumnMapping("NEXT_PO_SEQ", "NEXT_PO_SEQ"),
                        new System.Data.Common.DataColumnMapping("CASH", "CASH"),
                        new System.Data.Common.DataColumnMapping("PAY_METHOD", "PAY_METHOD"),
                        new System.Data.Common.DataColumnMapping("DISC_PCT", "DISC_PCT"),
                        new System.Data.Common.DataColumnMapping("EXP_SHIP_DATE", "EXP_SHIP_DATE"),
                        new System.Data.Common.DataColumnMapping("PREPARE_BY", "PREPARE_BY"),
                        new System.Data.Common.DataColumnMapping("pri_num", "pri_num"),
                        new System.Data.Common.DataColumnMapping("INVOICE_NO", "INVOICE_NO"),
                        new System.Data.Common.DataColumnMapping("MOP_ID", "MOP_ID"),
                        new System.Data.Common.DataColumnMapping("LOCATION", "LOCATION"),
                        new System.Data.Common.DataColumnMapping("CASH_UPDATED", "CASH_UPDATED"),
                        new System.Data.Common.DataColumnMapping("WHSE_ID", "WHSE_ID"),
                        new System.Data.Common.DataColumnMapping("SHIP_TYPE", "SHIP_TYPE"),
                        new System.Data.Common.DataColumnMapping("FUTURE_DATE", "FUTURE_DATE"),
                        new System.Data.Common.DataColumnMapping("CURRENCY_ID", "CURRENCY_ID"),
                        new System.Data.Common.DataColumnMapping("SIC_ID", "SIC_ID"),
                        new System.Data.Common.DataColumnMapping("TOTAL_DISCOUNT", "TOTAL_DISCOUNT"),
                        new System.Data.Common.DataColumnMapping("SO_QUOTE", "SO_QUOTE"),
                        new System.Data.Common.DataColumnMapping("SO_QUOTE_REF", "SO_QUOTE_REF"),
                        new System.Data.Common.DataColumnMapping("LOCKED", "LOCKED"),
                        new System.Data.Common.DataColumnMapping("LOCKED_BY", "LOCKED_BY"),
                        new System.Data.Common.DataColumnMapping("SLS_ID", "SLS_ID"),
                        new System.Data.Common.DataColumnMapping("SLS_ID2", "SLS_ID2"),
                        new System.Data.Common.DataColumnMapping("BR_CUSTOMER_ID", "BR_CUSTOMER_ID"),
                        new System.Data.Common.DataColumnMapping("COMM_CNTL_ID1", "COMM_CNTL_ID1"),
                        new System.Data.Common.DataColumnMapping("COMM_CNTL_ID2", "COMM_CNTL_ID2"),
                        new System.Data.Common.DataColumnMapping("PAYMENT_AMOUNT", "PAYMENT_AMOUNT"),
                        new System.Data.Common.DataColumnMapping("CHANGE_GIVEN", "CHANGE_GIVEN"),
                        new System.Data.Common.DataColumnMapping("SPLIT_COMM", "SPLIT_COMM"),
                        new System.Data.Common.DataColumnMapping("PRINTED", "PRINTED"),
                        new System.Data.Common.DataColumnMapping("REV_SHIP_DATE", "REV_SHIP_DATE"),
                        new System.Data.Common.DataColumnMapping("EXTRACT_FLAG", "EXTRACT_FLAG"),
                        new System.Data.Common.DataColumnMapping("EXP_COMMENT", "EXP_COMMENT"),
                        new System.Data.Common.DataColumnMapping("CALL_BACK", "CALL_BACK"),
                        new System.Data.Common.DataColumnMapping("SO_TYPE_ID", "SO_TYPE_ID"),
                        new System.Data.Common.DataColumnMapping("ORDER_APPROVED", "ORDER_APPROVED"),
                        new System.Data.Common.DataColumnMapping("AUTHORIZED_BY", "AUTHORIZED_BY"),
                        new System.Data.Common.DataColumnMapping("AUTHORIZED_DATE", "AUTHORIZED_DATE"),
                        new System.Data.Common.DataColumnMapping("AUTHORIZED_AMOUNT", "AUTHORIZED_AMOUNT"),
                        new System.Data.Common.DataColumnMapping("SCHEDULED_QUOTE", "SCHEDULED_QUOTE"),
                        new System.Data.Common.DataColumnMapping("PAYMENT_APPLIED", "PAYMENT_APPLIED"),
                        new System.Data.Common.DataColumnMapping("DEPOSIT_APPLIED", "DEPOSIT_APPLIED"),
                        new System.Data.Common.DataColumnMapping("DEPOSIT_AMOUNT", "DEPOSIT_AMOUNT"),
                        new System.Data.Common.DataColumnMapping("DEPOSIT_UPDATED", "DEPOSIT_UPDATED"),
                        new System.Data.Common.DataColumnMapping("DELIVERY", "DELIVERY"),
                        new System.Data.Common.DataColumnMapping("RETURN_FLAG", "RETURN_FLAG"),
                        new System.Data.Common.DataColumnMapping("SO_TRN_ID", "SO_TRN_ID"),
                        new System.Data.Common.DataColumnMapping("DELIVERY_CHARGE", "DELIVERY_CHARGE"),
                        new System.Data.Common.DataColumnMapping("RESTOCKING_CHARGE", "RESTOCKING_CHARGE"),
                        new System.Data.Common.DataColumnMapping("RESTOCKING_PCT", "RESTOCKING_PCT"),
                        new System.Data.Common.DataColumnMapping("SO_DIV", "SO_DIV"),
                        new System.Data.Common.DataColumnMapping("AR_SETUP_GL_ID", "AR_SETUP_GL_ID"),
                        new System.Data.Common.DataColumnMapping("PRICE_CODE_ID", "PRICE_CODE_ID"),
                        new System.Data.Common.DataColumnMapping("PRINT_CNT", "PRINT_CNT"),
                        new System.Data.Common.DataColumnMapping("CREDIT_REF", "CREDIT_REF"),
                        new System.Data.Common.DataColumnMapping("COMMENT", "COMMENT"),
                        new System.Data.Common.DataColumnMapping("COMMENT_INT", "COMMENT_INT"),
                        new System.Data.Common.DataColumnMapping("MEMO", "MEMO"),
                        new System.Data.Common.DataColumnMapping("FOOTER_COMMENT", "FOOTER_COMMENT"),
                        new System.Data.Common.DataColumnMapping("WMS_STATUS", "WMS_STATUS"),
                        new System.Data.Common.DataColumnMapping("WMS_MESSAGE", "WMS_MESSAGE"),
                        new System.Data.Common.DataColumnMapping("MTR_REQUIRED", "MTR_REQUIRED"),
                        new System.Data.Common.DataColumnMapping("METRIC_ORDER", "METRIC_ORDER"),
                        new System.Data.Common.DataColumnMapping("WMS_ORDER_SEQ", "WMS_ORDER_SEQ"),
                        new System.Data.Common.DataColumnMapping("SHIP_NO", "SHIP_NO"),
                        new System.Data.Common.DataColumnMapping("TOTAL_WEIGHT", "TOTAL_WEIGHT"),
                        new System.Data.Common.DataColumnMapping("EXT_REFERENCE", "EXT_REFERENCE"),
                        new System.Data.Common.DataColumnMapping("LSD_NUMBER", "LSD_NUMBER"),
                        new System.Data.Common.DataColumnMapping("ORDERED_BY", "ORDERED_BY"),
                        new System.Data.Common.DataColumnMapping("FOB_DESC", "FOB_DESC"),
                        new System.Data.Common.DataColumnMapping("installer_id", "installer_id"),
                        new System.Data.Common.DataColumnMapping("AD_CODE_ID", "AD_CODE_ID"),
                        new System.Data.Common.DataColumnMapping("MOBILE_ADDRESS", "MOBILE_ADDRESS"),
                        new System.Data.Common.DataColumnMapping("PRINT_PRICES", "PRINT_PRICES"),
                        new System.Data.Common.DataColumnMapping("BUY_RCVD", "BUY_RCVD"),
                        new System.Data.Common.DataColumnMapping("HAS_PIPE", "HAS_PIPE"),
                        new System.Data.Common.DataColumnMapping("REVIEWED", "REVIEWED"),
                        new System.Data.Common.DataColumnMapping("REQUIRED_BY", "REQUIRED_BY"),
                        new System.Data.Common.DataColumnMapping("EXCEPTION_ORDER", "EXCEPTION_ORDER"),
                        new System.Data.Common.DataColumnMapping("TAGGING", "TAGGING"),
                        new System.Data.Common.DataColumnMapping("PO_RELEASE_NO", "PO_RELEASE_NO"),
                        new System.Data.Common.DataColumnMapping("MTR_STATUS", "MTR_STATUS"),
                        new System.Data.Common.DataColumnMapping("marsallingOrdType", "marsallingOrdType"),
                        new System.Data.Common.DataColumnMapping("WMS_STATUS_PIPE", "WMS_STATUS_PIPE"),
                        new System.Data.Common.DataColumnMapping("WMS_MESSAGE_PIPE", "WMS_MESSAGE_PIPE"),
                        new System.Data.Common.DataColumnMapping("PRE_APPROVAL_AMT", "PRE_APPROVAL_AMT"),
                        new System.Data.Common.DataColumnMapping("POST_APPROVAL_AMT", "POST_APPROVAL_AMT"),
                        new System.Data.Common.DataColumnMapping("KC_STATUS", "KC_STATUS"),
                        new System.Data.Common.DataColumnMapping("APPROVAL_REQ_ID", "APPROVAL_REQ_ID"),
                        new System.Data.Common.DataColumnMapping("DirectShip", "DirectShip"),
                        new System.Data.Common.DataColumnMapping("PONO2", "PONO2"),
                        new System.Data.Common.DataColumnMapping("CUST_RFQ", "CUST_RFQ"),
                        new System.Data.Common.DataColumnMapping("convert_count", "convert_count"),
                        new System.Data.Common.DataColumnMapping("KC_GMStatus", "KC_GMStatus"),
                        new System.Data.Common.DataColumnMapping("KC_GM_RequestID", "KC_GM_RequestID"),
                        new System.Data.Common.DataColumnMapping("PICK_SLIP_PRINT_COUNT", "PICK_SLIP_PRINT_COUNT"),
                        new System.Data.Common.DataColumnMapping("AttentionRequired", "AttentionRequired"),
                        new System.Data.Common.DataColumnMapping("B2B_Notes", "B2B_Notes"),
                        new System.Data.Common.DataColumnMapping("BUY_RCVD_PIPE", "BUY_RCVD_PIPE"),
                        new System.Data.Common.DataColumnMapping("SubStatus", "SubStatus"),
                        new System.Data.Common.DataColumnMapping("B2B_ID", "B2B_ID"),
                        new System.Data.Common.DataColumnMapping("ShipInProcess", "ShipInProcess"),
                        new System.Data.Common.DataColumnMapping("LinkDescription", "LinkDescription"),
                        new System.Data.Common.DataColumnMapping("BuildReference_ID", "BuildReference_ID"),
                        new System.Data.Common.DataColumnMapping("BuildReferenceCompany_ID", "BuildReferenceCompany_ID"),
                        new System.Data.Common.DataColumnMapping("CreditRemaining", "CreditRemaining"),
                        new System.Data.Common.DataColumnMapping("CreditUsed", "CreditUsed"),
                        new System.Data.Common.DataColumnMapping("CreditLimit", "CreditLimit"),
                        new System.Data.Common.DataColumnMapping("CashSalePaid", "CashSalePaid"),
                        new System.Data.Common.DataColumnMapping("SLS_ID3", "SLS_ID3"),
                        new System.Data.Common.DataColumnMapping("SLS_ID4", "SLS_ID4"),
                        new System.Data.Common.DataColumnMapping("OUT_PCT2", "OUT_PCT2"),
                        new System.Data.Common.DataColumnMapping("OUT_PCT3", "OUT_PCT3"),
                        new System.Data.Common.DataColumnMapping("OE_Priority_ID", "OE_Priority_ID"),
                        new System.Data.Common.DataColumnMapping("cons_method_id", "cons_method_id"),
                        new System.Data.Common.DataColumnMapping("cons_frequency_id", "cons_frequency_id"),
                        new System.Data.Common.DataColumnMapping("CONSOLIDATE_INVOICES", "CONSOLIDATE_INVOICES"),
                        new System.Data.Common.DataColumnMapping("CommissionsPaid", "CommissionsPaid"),
                        new System.Data.Common.DataColumnMapping("CompletionDate", "CompletionDate"),
                        new System.Data.Common.DataColumnMapping("PickSlipPrinted", "PickSlipPrinted"),
                        new System.Data.Common.DataColumnMapping("PickSlipPrinted_pipe", "PickSlipPrinted_pipe"),
                        new System.Data.Common.DataColumnMapping("KC_RoutedApproval_Req_ID", "KC_RoutedApproval_Req_ID"),
                        new System.Data.Common.DataColumnMapping("KC_RoutedForTraining", "KC_RoutedForTraining"),
                        new System.Data.Common.DataColumnMapping("KC_RoutedForCreditDays", "KC_RoutedForCreditDays"),
                        new System.Data.Common.DataColumnMapping("KC_RoutedForCreditDays_Req_ID", "KC_RoutedForCreditDays_Req_ID"),
                        new System.Data.Common.DataColumnMapping("ManualQuote", "ManualQuote"),
                        new System.Data.Common.DataColumnMapping("RM_Opportunity_ID", "RM_Opportunity_ID"),
                        new System.Data.Common.DataColumnMapping("ProbablityPct", "ProbablityPct"),
                        new System.Data.Common.DataColumnMapping("SUPPLY_AND_INSTALL", "SUPPLY_AND_INSTALL"),
                        new System.Data.Common.DataColumnMapping("QuoteValidityID", "QuoteValidityID"),
                        new System.Data.Common.DataColumnMapping("QuoteRoutingStatus", "QuoteRoutingStatus"),
                        new System.Data.Common.DataColumnMapping("QuoteRoutingStatusID", "QuoteRoutingStatusID"),
                        new System.Data.Common.DataColumnMapping("BaseFolder", "BaseFolder"),
                        new System.Data.Common.DataColumnMapping("EndConsumer", "EndConsumer"),
                        new System.Data.Common.DataColumnMapping("REV_NO", "REV_NO"),
                        new System.Data.Common.DataColumnMapping("ReleaseToDrafting", "ReleaseToDrafting"),
                        new System.Data.Common.DataColumnMapping("CUST_REF", "CUST_REF"),
                        new System.Data.Common.DataColumnMapping("BillingType", "BillingType"),
                        new System.Data.Common.DataColumnMapping("BillingComplete", "BillingComplete"),
                        new System.Data.Common.DataColumnMapping("LockID", "LockID"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_TELEPHONE", "BILL_TO_TELEPHONE"),
                        new System.Data.Common.DataColumnMapping("BILL_TO_FAX", "BILL_TO_FAX"),
                        new System.Data.Common.DataColumnMapping("PRE_APPROVED_AMT", "PRE_APPROVED_AMT"),
                        new System.Data.Common.DataColumnMapping("ReleaseShipHold", "ReleaseShipHold"),
                        new System.Data.Common.DataColumnMapping("EndConsumer_Customer_ID", "EndConsumer_Customer_ID"),
                        new System.Data.Common.DataColumnMapping("EndConsumer_ContactID", "EndConsumer_ContactID"),
                        new System.Data.Common.DataColumnMapping("ReferencedSO", "ReferencedSO"),
                        new System.Data.Common.DataColumnMapping("QuoteSent", "QuoteSent"),
                        new System.Data.Common.DataColumnMapping("ConfirmationSent", "ConfirmationSent"),
                        new System.Data.Common.DataColumnMapping("SO_Class_ID", "SO_Class_ID")})});
            this.da_so_master_hdr.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select top 200 * from so_master_hdr";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=WIN2019\\SQL2019;Initial Catalog=TR_FOLK;Persist Security Info=True;Us" +
    "er ID=hmsqlsa;Password=hmsqlsa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConnection1;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SO_NO", System.Data.SqlDbType.Int, 0, "SO_NO"),
            new System.Data.SqlClient.SqlParameter("@SO_ID", System.Data.SqlDbType.Int, 0, "SO_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_PREFIX", System.Data.SqlDbType.Char, 0, "SO_PREFIX"),
            new System.Data.SqlClient.SqlParameter("@SO_TYPE", System.Data.SqlDbType.Char, 0, "SO_TYPE"),
            new System.Data.SqlClient.SqlParameter("@QUOTE_ID", System.Data.SqlDbType.Int, 0, "QUOTE_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@PONO", System.Data.SqlDbType.VarChar, 0, "PONO"),
            new System.Data.SqlClient.SqlParameter("@ORDER_DATE", System.Data.SqlDbType.DateTime, 0, "ORDER_DATE"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_SAVED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_SAVED"),
            new System.Data.SqlClient.SqlParameter("@DATE_SAVED", System.Data.SqlDbType.DateTime, 0, "DATE_SAVED"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_LAST_MODIFIED"),
            new System.Data.SqlClient.SqlParameter("@DATE_LAST_MODIFIED", System.Data.SqlDbType.DateTime, 0, "DATE_LAST_MODIFIED"),
            new System.Data.SqlClient.SqlParameter("@STATUS", System.Data.SqlDbType.Char, 0, "STATUS"),
            new System.Data.SqlClient.SqlParameter("@HOLD", System.Data.SqlDbType.Char, 0, "HOLD"),
            new System.Data.SqlClient.SqlParameter("@COMPLETE", System.Data.SqlDbType.Char, 0, "COMPLETE"),
            new System.Data.SqlClient.SqlParameter("@SO_HOLD_ID", System.Data.SqlDbType.Int, 0, "SO_HOLD_ID"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_HOLD", System.Data.SqlDbType.VarChar, 0, "OPERATOR_HOLD"),
            new System.Data.SqlClient.SqlParameter("@DATE_HOLD", System.Data.SqlDbType.DateTime, 0, "DATE_HOLD"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_RELEASED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_RELEASED"),
            new System.Data.SqlClient.SqlParameter("@DATE_RELEASED", System.Data.SqlDbType.DateTime, 0, "DATE_RELEASED"),
            new System.Data.SqlClient.SqlParameter("@TAX_EXEMPT", System.Data.SqlDbType.Char, 0, "TAX_EXEMPT"),
            new System.Data.SqlClient.SqlParameter("@TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, "TAX_EXEMPT_ID"),
            new System.Data.SqlClient.SqlParameter("@BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, "BILLING_ADDR_ID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_NAME", System.Data.SqlDbType.VarChar, 0, "BILL_TO_NAME"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_1", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_1"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_2", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_2"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_3", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_3"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_CITY", System.Data.SqlDbType.VarChar, 0, "BILL_TO_CITY"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_STATE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_STATE"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ZIP", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ZIP"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, "BILL_TO_COUNTRY_ID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_COUNTRY_CODE"),
            new System.Data.SqlClient.SqlParameter("@CONTACT_ID", System.Data.SqlDbType.Int, 0, "CONTACT_ID"),
            new System.Data.SqlClient.SqlParameter("@CONTACT_INFO", System.Data.SqlDbType.VarChar, 0, "CONTACT_INFO"),
            new System.Data.SqlClient.SqlParameter("@COMM_METHOD", System.Data.SqlDbType.Char, 0, "COMM_METHOD"),
            new System.Data.SqlClient.SqlParameter("@TERMS_ID", System.Data.SqlDbType.Int, 0, "TERMS_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, "SO_USER_DEF1_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_USER_DEF2", System.Data.SqlDbType.VarChar, 0, "SO_USER_DEF2"),
            new System.Data.SqlClient.SqlParameter("@COD", System.Data.SqlDbType.Char, 0, "COD"),
            new System.Data.SqlClient.SqlParameter("@MEMO_CODE", System.Data.SqlDbType.VarChar, 0, "MEMO_CODE"),
            new System.Data.SqlClient.SqlParameter("@DATE_CANCEL", System.Data.SqlDbType.DateTime, 0, "DATE_CANCEL"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_CANCEL", System.Data.SqlDbType.VarChar, 0, "OPERATOR_CANCEL"),
            new System.Data.SqlClient.SqlParameter("@CANCEL_ID", System.Data.SqlDbType.Int, 0, "CANCEL_ID"),
            new System.Data.SqlClient.SqlParameter("@SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, "SLS_INTERNAL_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_FLAG", System.Data.SqlDbType.Char, 0, "GST_FLAG"),
            new System.Data.SqlClient.SqlParameter("@IN_PCT", System.Data.SqlDbType.Money, 0, "IN_PCT"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT", System.Data.SqlDbType.Money, 0, "OUT_PCT"),
            new System.Data.SqlClient.SqlParameter("@COMM_PCT", System.Data.SqlDbType.Money, 0, "COMM_PCT"),
            new System.Data.SqlClient.SqlParameter("@SLS_COMM", System.Data.SqlDbType.Money, 0, "SLS_COMM"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_COMM", System.Data.SqlDbType.Money, 0, "TOTAL_COMM"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_PROD", System.Data.SqlDbType.Money, 0, "TOTAL_PROD"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_TAX", System.Data.SqlDbType.Money, 0, "TOTAL_TAX"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_GST", System.Data.SqlDbType.Money, 0, "TOTAL_GST"),
            new System.Data.SqlClient.SqlParameter("@NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, "NEXT_PO_SEQ"),
            new System.Data.SqlClient.SqlParameter("@CASH", System.Data.SqlDbType.Char, 0, "CASH"),
            new System.Data.SqlClient.SqlParameter("@PAY_METHOD", System.Data.SqlDbType.Char, 0, "PAY_METHOD"),
            new System.Data.SqlClient.SqlParameter("@DISC_PCT", System.Data.SqlDbType.Money, 0, "DISC_PCT"),
            new System.Data.SqlClient.SqlParameter("@EXP_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, "EXP_SHIP_DATE"),
            new System.Data.SqlClient.SqlParameter("@PREPARE_BY", System.Data.SqlDbType.VarChar, 0, "PREPARE_BY"),
            new System.Data.SqlClient.SqlParameter("@pri_num", System.Data.SqlDbType.Int, 0, "pri_num"),
            new System.Data.SqlClient.SqlParameter("@INVOICE_NO", System.Data.SqlDbType.Int, 0, "INVOICE_NO"),
            new System.Data.SqlClient.SqlParameter("@MOP_ID", System.Data.SqlDbType.Int, 0, "MOP_ID"),
            new System.Data.SqlClient.SqlParameter("@LOCATION", System.Data.SqlDbType.VarChar, 0, "LOCATION"),
            new System.Data.SqlClient.SqlParameter("@CASH_UPDATED", System.Data.SqlDbType.Char, 0, "CASH_UPDATED"),
            new System.Data.SqlClient.SqlParameter("@WHSE_ID", System.Data.SqlDbType.Int, 0, "WHSE_ID"),
            new System.Data.SqlClient.SqlParameter("@SHIP_TYPE", System.Data.SqlDbType.Char, 0, "SHIP_TYPE"),
            new System.Data.SqlClient.SqlParameter("@FUTURE_DATE", System.Data.SqlDbType.DateTime, 0, "FUTURE_DATE"),
            new System.Data.SqlClient.SqlParameter("@CURRENCY_ID", System.Data.SqlDbType.Int, 0, "CURRENCY_ID"),
            new System.Data.SqlClient.SqlParameter("@SIC_ID", System.Data.SqlDbType.Int, 0, "SIC_ID"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_DISCOUNT", System.Data.SqlDbType.Money, 0, "TOTAL_DISCOUNT"),
            new System.Data.SqlClient.SqlParameter("@SO_QUOTE", System.Data.SqlDbType.Char, 0, "SO_QUOTE"),
            new System.Data.SqlClient.SqlParameter("@SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, "SO_QUOTE_REF"),
            new System.Data.SqlClient.SqlParameter("@LOCKED", System.Data.SqlDbType.Char, 0, "LOCKED"),
            new System.Data.SqlClient.SqlParameter("@LOCKED_BY", System.Data.SqlDbType.Char, 0, "LOCKED_BY"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID", System.Data.SqlDbType.Int, 0, "SLS_ID"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID2", System.Data.SqlDbType.Int, 0, "SLS_ID2"),
            new System.Data.SqlClient.SqlParameter("@BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "BR_CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, "COMM_CNTL_ID1"),
            new System.Data.SqlClient.SqlParameter("@COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, "COMM_CNTL_ID2"),
            new System.Data.SqlClient.SqlParameter("@PAYMENT_AMOUNT", System.Data.SqlDbType.Money, 0, "PAYMENT_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@CHANGE_GIVEN", System.Data.SqlDbType.Money, 0, "CHANGE_GIVEN"),
            new System.Data.SqlClient.SqlParameter("@SPLIT_COMM", System.Data.SqlDbType.Char, 0, "SPLIT_COMM"),
            new System.Data.SqlClient.SqlParameter("@PRINTED", System.Data.SqlDbType.Char, 0, "PRINTED"),
            new System.Data.SqlClient.SqlParameter("@REV_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, "REV_SHIP_DATE"),
            new System.Data.SqlClient.SqlParameter("@EXTRACT_FLAG", System.Data.SqlDbType.Char, 0, "EXTRACT_FLAG"),
            new System.Data.SqlClient.SqlParameter("@EXP_COMMENT", System.Data.SqlDbType.Text, 0, "EXP_COMMENT"),
            new System.Data.SqlClient.SqlParameter("@CALL_BACK", System.Data.SqlDbType.Char, 0, "CALL_BACK"),
            new System.Data.SqlClient.SqlParameter("@SO_TYPE_ID", System.Data.SqlDbType.Int, 0, "SO_TYPE_ID"),
            new System.Data.SqlClient.SqlParameter("@ORDER_APPROVED", System.Data.SqlDbType.Char, 0, "ORDER_APPROVED"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_BY", System.Data.SqlDbType.VarChar, 0, "AUTHORIZED_BY"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_DATE", System.Data.SqlDbType.DateTime, 0, "AUTHORIZED_DATE"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_AMOUNT", System.Data.SqlDbType.Float, 0, "AUTHORIZED_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@SCHEDULED_QUOTE", System.Data.SqlDbType.Char, 0, "SCHEDULED_QUOTE"),
            new System.Data.SqlClient.SqlParameter("@PAYMENT_APPLIED", System.Data.SqlDbType.Char, 0, "PAYMENT_APPLIED"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_APPLIED", System.Data.SqlDbType.Char, 0, "DEPOSIT_APPLIED"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_AMOUNT", System.Data.SqlDbType.Money, 0, "DEPOSIT_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_UPDATED", System.Data.SqlDbType.Money, 0, "DEPOSIT_UPDATED"),
            new System.Data.SqlClient.SqlParameter("@DELIVERY", System.Data.SqlDbType.Char, 0, "DELIVERY"),
            new System.Data.SqlClient.SqlParameter("@RETURN_FLAG", System.Data.SqlDbType.Char, 0, "RETURN_FLAG"),
            new System.Data.SqlClient.SqlParameter("@SO_TRN_ID", System.Data.SqlDbType.Int, 0, "SO_TRN_ID"),
            new System.Data.SqlClient.SqlParameter("@DELIVERY_CHARGE", System.Data.SqlDbType.Float, 0, "DELIVERY_CHARGE"),
            new System.Data.SqlClient.SqlParameter("@RESTOCKING_CHARGE", System.Data.SqlDbType.Float, 0, "RESTOCKING_CHARGE"),
            new System.Data.SqlClient.SqlParameter("@RESTOCKING_PCT", System.Data.SqlDbType.Float, 0, "RESTOCKING_PCT"),
            new System.Data.SqlClient.SqlParameter("@SO_DIV", System.Data.SqlDbType.VarChar, 0, "SO_DIV"),
            new System.Data.SqlClient.SqlParameter("@AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, "AR_SETUP_GL_ID"),
            new System.Data.SqlClient.SqlParameter("@PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, "PRICE_CODE_ID"),
            new System.Data.SqlClient.SqlParameter("@PRINT_CNT", System.Data.SqlDbType.Int, 0, "PRINT_CNT"),
            new System.Data.SqlClient.SqlParameter("@CREDIT_REF", System.Data.SqlDbType.VarChar, 0, "CREDIT_REF"),
            new System.Data.SqlClient.SqlParameter("@COMMENT", System.Data.SqlDbType.Text, 0, "COMMENT"),
            new System.Data.SqlClient.SqlParameter("@COMMENT_INT", System.Data.SqlDbType.Text, 0, "COMMENT_INT"),
            new System.Data.SqlClient.SqlParameter("@MEMO", System.Data.SqlDbType.Text, 0, "MEMO"),
            new System.Data.SqlClient.SqlParameter("@FOOTER_COMMENT", System.Data.SqlDbType.Text, 0, "FOOTER_COMMENT"),
            new System.Data.SqlClient.SqlParameter("@WMS_STATUS", System.Data.SqlDbType.VarChar, 0, "WMS_STATUS"),
            new System.Data.SqlClient.SqlParameter("@WMS_MESSAGE", System.Data.SqlDbType.Text, 0, "WMS_MESSAGE"),
            new System.Data.SqlClient.SqlParameter("@MTR_REQUIRED", System.Data.SqlDbType.VarChar, 0, "MTR_REQUIRED"),
            new System.Data.SqlClient.SqlParameter("@METRIC_ORDER", System.Data.SqlDbType.VarChar, 0, "METRIC_ORDER"),
            new System.Data.SqlClient.SqlParameter("@WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, "WMS_ORDER_SEQ"),
            new System.Data.SqlClient.SqlParameter("@SHIP_NO", System.Data.SqlDbType.Int, 0, "SHIP_NO"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_WEIGHT", System.Data.SqlDbType.Money, 0, "TOTAL_WEIGHT"),
            new System.Data.SqlClient.SqlParameter("@EXT_REFERENCE", System.Data.SqlDbType.VarChar, 0, "EXT_REFERENCE"),
            new System.Data.SqlClient.SqlParameter("@LSD_NUMBER", System.Data.SqlDbType.VarChar, 0, "LSD_NUMBER"),
            new System.Data.SqlClient.SqlParameter("@ORDERED_BY", System.Data.SqlDbType.VarChar, 0, "ORDERED_BY"),
            new System.Data.SqlClient.SqlParameter("@FOB_DESC", System.Data.SqlDbType.VarChar, 0, "FOB_DESC"),
            new System.Data.SqlClient.SqlParameter("@installer_id", System.Data.SqlDbType.Int, 0, "installer_id"),
            new System.Data.SqlClient.SqlParameter("@AD_CODE_ID", System.Data.SqlDbType.Int, 0, "AD_CODE_ID"),
            new System.Data.SqlClient.SqlParameter("@MOBILE_ADDRESS", System.Data.SqlDbType.VarChar, 0, "MOBILE_ADDRESS"),
            new System.Data.SqlClient.SqlParameter("@PRINT_PRICES", System.Data.SqlDbType.VarChar, 0, "PRINT_PRICES"),
            new System.Data.SqlClient.SqlParameter("@BUY_RCVD", System.Data.SqlDbType.VarChar, 0, "BUY_RCVD"),
            new System.Data.SqlClient.SqlParameter("@HAS_PIPE", System.Data.SqlDbType.VarChar, 0, "HAS_PIPE"),
            new System.Data.SqlClient.SqlParameter("@REVIEWED", System.Data.SqlDbType.VarChar, 0, "REVIEWED"),
            new System.Data.SqlClient.SqlParameter("@REQUIRED_BY", System.Data.SqlDbType.DateTime, 0, "REQUIRED_BY"),
            new System.Data.SqlClient.SqlParameter("@EXCEPTION_ORDER", System.Data.SqlDbType.VarChar, 0, "EXCEPTION_ORDER"),
            new System.Data.SqlClient.SqlParameter("@TAGGING", System.Data.SqlDbType.VarChar, 0, "TAGGING"),
            new System.Data.SqlClient.SqlParameter("@PO_RELEASE_NO", System.Data.SqlDbType.VarChar, 0, "PO_RELEASE_NO"),
            new System.Data.SqlClient.SqlParameter("@MTR_STATUS", System.Data.SqlDbType.VarChar, 0, "MTR_STATUS"),
            new System.Data.SqlClient.SqlParameter("@marsallingOrdType", System.Data.SqlDbType.VarChar, 0, "marsallingOrdType"),
            new System.Data.SqlClient.SqlParameter("@WMS_STATUS_PIPE", System.Data.SqlDbType.VarChar, 0, "WMS_STATUS_PIPE"),
            new System.Data.SqlClient.SqlParameter("@WMS_MESSAGE_PIPE", System.Data.SqlDbType.Text, 0, "WMS_MESSAGE_PIPE"),
            new System.Data.SqlClient.SqlParameter("@PRE_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, "PRE_APPROVAL_AMT"),
            new System.Data.SqlClient.SqlParameter("@POST_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, "POST_APPROVAL_AMT"),
            new System.Data.SqlClient.SqlParameter("@KC_STATUS", System.Data.SqlDbType.VarChar, 0, "KC_STATUS"),
            new System.Data.SqlClient.SqlParameter("@APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, "APPROVAL_REQ_ID"),
            new System.Data.SqlClient.SqlParameter("@DirectShip", System.Data.SqlDbType.Bit, 0, "DirectShip"),
            new System.Data.SqlClient.SqlParameter("@PONO2", System.Data.SqlDbType.VarChar, 0, "PONO2"),
            new System.Data.SqlClient.SqlParameter("@CUST_RFQ", System.Data.SqlDbType.VarChar, 0, "CUST_RFQ"),
            new System.Data.SqlClient.SqlParameter("@convert_count", System.Data.SqlDbType.Int, 0, "convert_count"),
            new System.Data.SqlClient.SqlParameter("@KC_GMStatus", System.Data.SqlDbType.VarChar, 0, "KC_GMStatus"),
            new System.Data.SqlClient.SqlParameter("@KC_GM_RequestID", System.Data.SqlDbType.Int, 0, "KC_GM_RequestID"),
            new System.Data.SqlClient.SqlParameter("@PICK_SLIP_PRINT_COUNT", System.Data.SqlDbType.Int, 0, "PICK_SLIP_PRINT_COUNT"),
            new System.Data.SqlClient.SqlParameter("@AttentionRequired", System.Data.SqlDbType.Bit, 0, "AttentionRequired"),
            new System.Data.SqlClient.SqlParameter("@B2B_Notes", System.Data.SqlDbType.Text, 0, "B2B_Notes"),
            new System.Data.SqlClient.SqlParameter("@BUY_RCVD_PIPE", System.Data.SqlDbType.Char, 0, "BUY_RCVD_PIPE"),
            new System.Data.SqlClient.SqlParameter("@SubStatus", System.Data.SqlDbType.VarChar, 0, "SubStatus"),
            new System.Data.SqlClient.SqlParameter("@B2B_ID", System.Data.SqlDbType.Int, 0, "B2B_ID"),
            new System.Data.SqlClient.SqlParameter("@ShipInProcess", System.Data.SqlDbType.Bit, 0, "ShipInProcess"),
            new System.Data.SqlClient.SqlParameter("@LinkDescription", System.Data.SqlDbType.VarChar, 0, "LinkDescription"),
            new System.Data.SqlClient.SqlParameter("@BuildReference_ID", System.Data.SqlDbType.Int, 0, "BuildReference_ID"),
            new System.Data.SqlClient.SqlParameter("@BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, "BuildReferenceCompany_ID"),
            new System.Data.SqlClient.SqlParameter("@CreditRemaining", System.Data.SqlDbType.Money, 0, "CreditRemaining"),
            new System.Data.SqlClient.SqlParameter("@CreditUsed", System.Data.SqlDbType.Money, 0, "CreditUsed"),
            new System.Data.SqlClient.SqlParameter("@CreditLimit", System.Data.SqlDbType.Money, 0, "CreditLimit"),
            new System.Data.SqlClient.SqlParameter("@CashSalePaid", System.Data.SqlDbType.Char, 0, "CashSalePaid"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID3", System.Data.SqlDbType.Int, 0, "SLS_ID3"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID4", System.Data.SqlDbType.Int, 0, "SLS_ID4"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT2", System.Data.SqlDbType.Money, 0, "OUT_PCT2"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT3", System.Data.SqlDbType.Money, 0, "OUT_PCT3"),
            new System.Data.SqlClient.SqlParameter("@OE_Priority_ID", System.Data.SqlDbType.Int, 0, "OE_Priority_ID"),
            new System.Data.SqlClient.SqlParameter("@cons_method_id", System.Data.SqlDbType.Int, 0, "cons_method_id"),
            new System.Data.SqlClient.SqlParameter("@cons_frequency_id", System.Data.SqlDbType.Int, 0, "cons_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@CONSOLIDATE_INVOICES", System.Data.SqlDbType.VarChar, 0, "CONSOLIDATE_INVOICES"),
            new System.Data.SqlClient.SqlParameter("@CommissionsPaid", System.Data.SqlDbType.Char, 0, "CommissionsPaid"),
            new System.Data.SqlClient.SqlParameter("@CompletionDate", System.Data.SqlDbType.DateTime, 0, "CompletionDate"),
            new System.Data.SqlClient.SqlParameter("@PickSlipPrinted", System.Data.SqlDbType.Bit, 0, "PickSlipPrinted"),
            new System.Data.SqlClient.SqlParameter("@PickSlipPrinted_pipe", System.Data.SqlDbType.Bit, 0, "PickSlipPrinted_pipe"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, "KC_RoutedApproval_Req_ID"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForTraining", System.Data.SqlDbType.Char, 0, "KC_RoutedForTraining"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForCreditDays", System.Data.SqlDbType.Char, 0, "KC_RoutedForCreditDays"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, "KC_RoutedForCreditDays_Req_ID"),
            new System.Data.SqlClient.SqlParameter("@ManualQuote", System.Data.SqlDbType.Bit, 0, "ManualQuote"),
            new System.Data.SqlClient.SqlParameter("@RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, "RM_Opportunity_ID"),
            new System.Data.SqlClient.SqlParameter("@ProbablityPct", System.Data.SqlDbType.Int, 0, "ProbablityPct"),
            new System.Data.SqlClient.SqlParameter("@SUPPLY_AND_INSTALL", System.Data.SqlDbType.VarChar, 0, "SUPPLY_AND_INSTALL"),
            new System.Data.SqlClient.SqlParameter("@QuoteValidityID", System.Data.SqlDbType.Int, 0, "QuoteValidityID"),
            new System.Data.SqlClient.SqlParameter("@QuoteRoutingStatus", System.Data.SqlDbType.Char, 0, "QuoteRoutingStatus"),
            new System.Data.SqlClient.SqlParameter("@QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, "QuoteRoutingStatusID"),
            new System.Data.SqlClient.SqlParameter("@BaseFolder", System.Data.SqlDbType.VarChar, 0, "BaseFolder"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer", System.Data.SqlDbType.VarChar, 0, "EndConsumer"),
            new System.Data.SqlClient.SqlParameter("@REV_NO", System.Data.SqlDbType.Int, 0, "REV_NO"),
            new System.Data.SqlClient.SqlParameter("@ReleaseToDrafting", System.Data.SqlDbType.Bit, 0, "ReleaseToDrafting"),
            new System.Data.SqlClient.SqlParameter("@CUST_REF", System.Data.SqlDbType.VarChar, 0, "CUST_REF"),
            new System.Data.SqlClient.SqlParameter("@BillingType", System.Data.SqlDbType.VarChar, 0, "BillingType"),
            new System.Data.SqlClient.SqlParameter("@BillingComplete", System.Data.SqlDbType.Bit, 0, "BillingComplete"),
            new System.Data.SqlClient.SqlParameter("@LockID", System.Data.SqlDbType.Int, 0, "LockID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_TELEPHONE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_TELEPHONE"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_FAX", System.Data.SqlDbType.VarChar, 0, "BILL_TO_FAX"),
            new System.Data.SqlClient.SqlParameter("@PRE_APPROVED_AMT", System.Data.SqlDbType.Money, 0, "PRE_APPROVED_AMT"),
            new System.Data.SqlClient.SqlParameter("@ReleaseShipHold", System.Data.SqlDbType.Bit, 0, "ReleaseShipHold"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, "EndConsumer_Customer_ID"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, "EndConsumer_ContactID"),
            new System.Data.SqlClient.SqlParameter("@ReferencedSO", System.Data.SqlDbType.Int, 0, "ReferencedSO"),
            new System.Data.SqlClient.SqlParameter("@QuoteSent", System.Data.SqlDbType.Bit, 0, "QuoteSent"),
            new System.Data.SqlClient.SqlParameter("@ConfirmationSent", System.Data.SqlDbType.Bit, 0, "ConfirmationSent"),
            new System.Data.SqlClient.SqlParameter("@SO_Class_ID", System.Data.SqlDbType.Int, 0, "SO_Class_ID")});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConnection1;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@SO_NO", System.Data.SqlDbType.Int, 0, "SO_NO"),
            new System.Data.SqlClient.SqlParameter("@SO_ID", System.Data.SqlDbType.Int, 0, "SO_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_PREFIX", System.Data.SqlDbType.Char, 0, "SO_PREFIX"),
            new System.Data.SqlClient.SqlParameter("@SO_TYPE", System.Data.SqlDbType.Char, 0, "SO_TYPE"),
            new System.Data.SqlClient.SqlParameter("@QUOTE_ID", System.Data.SqlDbType.Int, 0, "QUOTE_ID"),
            new System.Data.SqlClient.SqlParameter("@CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@PONO", System.Data.SqlDbType.VarChar, 0, "PONO"),
            new System.Data.SqlClient.SqlParameter("@ORDER_DATE", System.Data.SqlDbType.DateTime, 0, "ORDER_DATE"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_SAVED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_SAVED"),
            new System.Data.SqlClient.SqlParameter("@DATE_SAVED", System.Data.SqlDbType.DateTime, 0, "DATE_SAVED"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_LAST_MODIFIED"),
            new System.Data.SqlClient.SqlParameter("@DATE_LAST_MODIFIED", System.Data.SqlDbType.DateTime, 0, "DATE_LAST_MODIFIED"),
            new System.Data.SqlClient.SqlParameter("@STATUS", System.Data.SqlDbType.Char, 0, "STATUS"),
            new System.Data.SqlClient.SqlParameter("@HOLD", System.Data.SqlDbType.Char, 0, "HOLD"),
            new System.Data.SqlClient.SqlParameter("@COMPLETE", System.Data.SqlDbType.Char, 0, "COMPLETE"),
            new System.Data.SqlClient.SqlParameter("@SO_HOLD_ID", System.Data.SqlDbType.Int, 0, "SO_HOLD_ID"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_HOLD", System.Data.SqlDbType.VarChar, 0, "OPERATOR_HOLD"),
            new System.Data.SqlClient.SqlParameter("@DATE_HOLD", System.Data.SqlDbType.DateTime, 0, "DATE_HOLD"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_RELEASED", System.Data.SqlDbType.VarChar, 0, "OPERATOR_RELEASED"),
            new System.Data.SqlClient.SqlParameter("@DATE_RELEASED", System.Data.SqlDbType.DateTime, 0, "DATE_RELEASED"),
            new System.Data.SqlClient.SqlParameter("@TAX_EXEMPT", System.Data.SqlDbType.Char, 0, "TAX_EXEMPT"),
            new System.Data.SqlClient.SqlParameter("@TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, "TAX_EXEMPT_ID"),
            new System.Data.SqlClient.SqlParameter("@BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, "BILLING_ADDR_ID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_NAME", System.Data.SqlDbType.VarChar, 0, "BILL_TO_NAME"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_1", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_1"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_2", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_2"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ADD_3", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ADD_3"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_CITY", System.Data.SqlDbType.VarChar, 0, "BILL_TO_CITY"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_STATE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_STATE"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_ZIP", System.Data.SqlDbType.VarChar, 0, "BILL_TO_ZIP"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, "BILL_TO_COUNTRY_ID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_COUNTRY_CODE"),
            new System.Data.SqlClient.SqlParameter("@CONTACT_ID", System.Data.SqlDbType.Int, 0, "CONTACT_ID"),
            new System.Data.SqlClient.SqlParameter("@CONTACT_INFO", System.Data.SqlDbType.VarChar, 0, "CONTACT_INFO"),
            new System.Data.SqlClient.SqlParameter("@COMM_METHOD", System.Data.SqlDbType.Char, 0, "COMM_METHOD"),
            new System.Data.SqlClient.SqlParameter("@TERMS_ID", System.Data.SqlDbType.Int, 0, "TERMS_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, "SO_USER_DEF1_ID"),
            new System.Data.SqlClient.SqlParameter("@SO_USER_DEF2", System.Data.SqlDbType.VarChar, 0, "SO_USER_DEF2"),
            new System.Data.SqlClient.SqlParameter("@COD", System.Data.SqlDbType.Char, 0, "COD"),
            new System.Data.SqlClient.SqlParameter("@MEMO_CODE", System.Data.SqlDbType.VarChar, 0, "MEMO_CODE"),
            new System.Data.SqlClient.SqlParameter("@DATE_CANCEL", System.Data.SqlDbType.DateTime, 0, "DATE_CANCEL"),
            new System.Data.SqlClient.SqlParameter("@OPERATOR_CANCEL", System.Data.SqlDbType.VarChar, 0, "OPERATOR_CANCEL"),
            new System.Data.SqlClient.SqlParameter("@CANCEL_ID", System.Data.SqlDbType.Int, 0, "CANCEL_ID"),
            new System.Data.SqlClient.SqlParameter("@SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, "SLS_INTERNAL_ID"),
            new System.Data.SqlClient.SqlParameter("@GST_FLAG", System.Data.SqlDbType.Char, 0, "GST_FLAG"),
            new System.Data.SqlClient.SqlParameter("@IN_PCT", System.Data.SqlDbType.Money, 0, "IN_PCT"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT", System.Data.SqlDbType.Money, 0, "OUT_PCT"),
            new System.Data.SqlClient.SqlParameter("@COMM_PCT", System.Data.SqlDbType.Money, 0, "COMM_PCT"),
            new System.Data.SqlClient.SqlParameter("@SLS_COMM", System.Data.SqlDbType.Money, 0, "SLS_COMM"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_COMM", System.Data.SqlDbType.Money, 0, "TOTAL_COMM"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_PROD", System.Data.SqlDbType.Money, 0, "TOTAL_PROD"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_TAX", System.Data.SqlDbType.Money, 0, "TOTAL_TAX"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_GST", System.Data.SqlDbType.Money, 0, "TOTAL_GST"),
            new System.Data.SqlClient.SqlParameter("@NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, "NEXT_PO_SEQ"),
            new System.Data.SqlClient.SqlParameter("@CASH", System.Data.SqlDbType.Char, 0, "CASH"),
            new System.Data.SqlClient.SqlParameter("@PAY_METHOD", System.Data.SqlDbType.Char, 0, "PAY_METHOD"),
            new System.Data.SqlClient.SqlParameter("@DISC_PCT", System.Data.SqlDbType.Money, 0, "DISC_PCT"),
            new System.Data.SqlClient.SqlParameter("@EXP_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, "EXP_SHIP_DATE"),
            new System.Data.SqlClient.SqlParameter("@PREPARE_BY", System.Data.SqlDbType.VarChar, 0, "PREPARE_BY"),
            new System.Data.SqlClient.SqlParameter("@pri_num", System.Data.SqlDbType.Int, 0, "pri_num"),
            new System.Data.SqlClient.SqlParameter("@INVOICE_NO", System.Data.SqlDbType.Int, 0, "INVOICE_NO"),
            new System.Data.SqlClient.SqlParameter("@MOP_ID", System.Data.SqlDbType.Int, 0, "MOP_ID"),
            new System.Data.SqlClient.SqlParameter("@LOCATION", System.Data.SqlDbType.VarChar, 0, "LOCATION"),
            new System.Data.SqlClient.SqlParameter("@CASH_UPDATED", System.Data.SqlDbType.Char, 0, "CASH_UPDATED"),
            new System.Data.SqlClient.SqlParameter("@WHSE_ID", System.Data.SqlDbType.Int, 0, "WHSE_ID"),
            new System.Data.SqlClient.SqlParameter("@SHIP_TYPE", System.Data.SqlDbType.Char, 0, "SHIP_TYPE"),
            new System.Data.SqlClient.SqlParameter("@FUTURE_DATE", System.Data.SqlDbType.DateTime, 0, "FUTURE_DATE"),
            new System.Data.SqlClient.SqlParameter("@CURRENCY_ID", System.Data.SqlDbType.Int, 0, "CURRENCY_ID"),
            new System.Data.SqlClient.SqlParameter("@SIC_ID", System.Data.SqlDbType.Int, 0, "SIC_ID"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_DISCOUNT", System.Data.SqlDbType.Money, 0, "TOTAL_DISCOUNT"),
            new System.Data.SqlClient.SqlParameter("@SO_QUOTE", System.Data.SqlDbType.Char, 0, "SO_QUOTE"),
            new System.Data.SqlClient.SqlParameter("@SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, "SO_QUOTE_REF"),
            new System.Data.SqlClient.SqlParameter("@LOCKED", System.Data.SqlDbType.Char, 0, "LOCKED"),
            new System.Data.SqlClient.SqlParameter("@LOCKED_BY", System.Data.SqlDbType.Char, 0, "LOCKED_BY"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID", System.Data.SqlDbType.Int, 0, "SLS_ID"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID2", System.Data.SqlDbType.Int, 0, "SLS_ID2"),
            new System.Data.SqlClient.SqlParameter("@BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, "BR_CUSTOMER_ID"),
            new System.Data.SqlClient.SqlParameter("@COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, "COMM_CNTL_ID1"),
            new System.Data.SqlClient.SqlParameter("@COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, "COMM_CNTL_ID2"),
            new System.Data.SqlClient.SqlParameter("@PAYMENT_AMOUNT", System.Data.SqlDbType.Money, 0, "PAYMENT_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@CHANGE_GIVEN", System.Data.SqlDbType.Money, 0, "CHANGE_GIVEN"),
            new System.Data.SqlClient.SqlParameter("@SPLIT_COMM", System.Data.SqlDbType.Char, 0, "SPLIT_COMM"),
            new System.Data.SqlClient.SqlParameter("@PRINTED", System.Data.SqlDbType.Char, 0, "PRINTED"),
            new System.Data.SqlClient.SqlParameter("@REV_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, "REV_SHIP_DATE"),
            new System.Data.SqlClient.SqlParameter("@EXTRACT_FLAG", System.Data.SqlDbType.Char, 0, "EXTRACT_FLAG"),
            new System.Data.SqlClient.SqlParameter("@EXP_COMMENT", System.Data.SqlDbType.Text, 0, "EXP_COMMENT"),
            new System.Data.SqlClient.SqlParameter("@CALL_BACK", System.Data.SqlDbType.Char, 0, "CALL_BACK"),
            new System.Data.SqlClient.SqlParameter("@SO_TYPE_ID", System.Data.SqlDbType.Int, 0, "SO_TYPE_ID"),
            new System.Data.SqlClient.SqlParameter("@ORDER_APPROVED", System.Data.SqlDbType.Char, 0, "ORDER_APPROVED"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_BY", System.Data.SqlDbType.VarChar, 0, "AUTHORIZED_BY"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_DATE", System.Data.SqlDbType.DateTime, 0, "AUTHORIZED_DATE"),
            new System.Data.SqlClient.SqlParameter("@AUTHORIZED_AMOUNT", System.Data.SqlDbType.Float, 0, "AUTHORIZED_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@SCHEDULED_QUOTE", System.Data.SqlDbType.Char, 0, "SCHEDULED_QUOTE"),
            new System.Data.SqlClient.SqlParameter("@PAYMENT_APPLIED", System.Data.SqlDbType.Char, 0, "PAYMENT_APPLIED"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_APPLIED", System.Data.SqlDbType.Char, 0, "DEPOSIT_APPLIED"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_AMOUNT", System.Data.SqlDbType.Money, 0, "DEPOSIT_AMOUNT"),
            new System.Data.SqlClient.SqlParameter("@DEPOSIT_UPDATED", System.Data.SqlDbType.Money, 0, "DEPOSIT_UPDATED"),
            new System.Data.SqlClient.SqlParameter("@DELIVERY", System.Data.SqlDbType.Char, 0, "DELIVERY"),
            new System.Data.SqlClient.SqlParameter("@RETURN_FLAG", System.Data.SqlDbType.Char, 0, "RETURN_FLAG"),
            new System.Data.SqlClient.SqlParameter("@SO_TRN_ID", System.Data.SqlDbType.Int, 0, "SO_TRN_ID"),
            new System.Data.SqlClient.SqlParameter("@DELIVERY_CHARGE", System.Data.SqlDbType.Float, 0, "DELIVERY_CHARGE"),
            new System.Data.SqlClient.SqlParameter("@RESTOCKING_CHARGE", System.Data.SqlDbType.Float, 0, "RESTOCKING_CHARGE"),
            new System.Data.SqlClient.SqlParameter("@RESTOCKING_PCT", System.Data.SqlDbType.Float, 0, "RESTOCKING_PCT"),
            new System.Data.SqlClient.SqlParameter("@SO_DIV", System.Data.SqlDbType.VarChar, 0, "SO_DIV"),
            new System.Data.SqlClient.SqlParameter("@AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, "AR_SETUP_GL_ID"),
            new System.Data.SqlClient.SqlParameter("@PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, "PRICE_CODE_ID"),
            new System.Data.SqlClient.SqlParameter("@PRINT_CNT", System.Data.SqlDbType.Int, 0, "PRINT_CNT"),
            new System.Data.SqlClient.SqlParameter("@CREDIT_REF", System.Data.SqlDbType.VarChar, 0, "CREDIT_REF"),
            new System.Data.SqlClient.SqlParameter("@COMMENT", System.Data.SqlDbType.Text, 0, "COMMENT"),
            new System.Data.SqlClient.SqlParameter("@COMMENT_INT", System.Data.SqlDbType.Text, 0, "COMMENT_INT"),
            new System.Data.SqlClient.SqlParameter("@MEMO", System.Data.SqlDbType.Text, 0, "MEMO"),
            new System.Data.SqlClient.SqlParameter("@FOOTER_COMMENT", System.Data.SqlDbType.Text, 0, "FOOTER_COMMENT"),
            new System.Data.SqlClient.SqlParameter("@WMS_STATUS", System.Data.SqlDbType.VarChar, 0, "WMS_STATUS"),
            new System.Data.SqlClient.SqlParameter("@WMS_MESSAGE", System.Data.SqlDbType.Text, 0, "WMS_MESSAGE"),
            new System.Data.SqlClient.SqlParameter("@MTR_REQUIRED", System.Data.SqlDbType.VarChar, 0, "MTR_REQUIRED"),
            new System.Data.SqlClient.SqlParameter("@METRIC_ORDER", System.Data.SqlDbType.VarChar, 0, "METRIC_ORDER"),
            new System.Data.SqlClient.SqlParameter("@WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, "WMS_ORDER_SEQ"),
            new System.Data.SqlClient.SqlParameter("@SHIP_NO", System.Data.SqlDbType.Int, 0, "SHIP_NO"),
            new System.Data.SqlClient.SqlParameter("@TOTAL_WEIGHT", System.Data.SqlDbType.Money, 0, "TOTAL_WEIGHT"),
            new System.Data.SqlClient.SqlParameter("@EXT_REFERENCE", System.Data.SqlDbType.VarChar, 0, "EXT_REFERENCE"),
            new System.Data.SqlClient.SqlParameter("@LSD_NUMBER", System.Data.SqlDbType.VarChar, 0, "LSD_NUMBER"),
            new System.Data.SqlClient.SqlParameter("@ORDERED_BY", System.Data.SqlDbType.VarChar, 0, "ORDERED_BY"),
            new System.Data.SqlClient.SqlParameter("@FOB_DESC", System.Data.SqlDbType.VarChar, 0, "FOB_DESC"),
            new System.Data.SqlClient.SqlParameter("@installer_id", System.Data.SqlDbType.Int, 0, "installer_id"),
            new System.Data.SqlClient.SqlParameter("@AD_CODE_ID", System.Data.SqlDbType.Int, 0, "AD_CODE_ID"),
            new System.Data.SqlClient.SqlParameter("@MOBILE_ADDRESS", System.Data.SqlDbType.VarChar, 0, "MOBILE_ADDRESS"),
            new System.Data.SqlClient.SqlParameter("@PRINT_PRICES", System.Data.SqlDbType.VarChar, 0, "PRINT_PRICES"),
            new System.Data.SqlClient.SqlParameter("@BUY_RCVD", System.Data.SqlDbType.VarChar, 0, "BUY_RCVD"),
            new System.Data.SqlClient.SqlParameter("@HAS_PIPE", System.Data.SqlDbType.VarChar, 0, "HAS_PIPE"),
            new System.Data.SqlClient.SqlParameter("@REVIEWED", System.Data.SqlDbType.VarChar, 0, "REVIEWED"),
            new System.Data.SqlClient.SqlParameter("@REQUIRED_BY", System.Data.SqlDbType.DateTime, 0, "REQUIRED_BY"),
            new System.Data.SqlClient.SqlParameter("@EXCEPTION_ORDER", System.Data.SqlDbType.VarChar, 0, "EXCEPTION_ORDER"),
            new System.Data.SqlClient.SqlParameter("@TAGGING", System.Data.SqlDbType.VarChar, 0, "TAGGING"),
            new System.Data.SqlClient.SqlParameter("@PO_RELEASE_NO", System.Data.SqlDbType.VarChar, 0, "PO_RELEASE_NO"),
            new System.Data.SqlClient.SqlParameter("@MTR_STATUS", System.Data.SqlDbType.VarChar, 0, "MTR_STATUS"),
            new System.Data.SqlClient.SqlParameter("@marsallingOrdType", System.Data.SqlDbType.VarChar, 0, "marsallingOrdType"),
            new System.Data.SqlClient.SqlParameter("@WMS_STATUS_PIPE", System.Data.SqlDbType.VarChar, 0, "WMS_STATUS_PIPE"),
            new System.Data.SqlClient.SqlParameter("@WMS_MESSAGE_PIPE", System.Data.SqlDbType.Text, 0, "WMS_MESSAGE_PIPE"),
            new System.Data.SqlClient.SqlParameter("@PRE_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, "PRE_APPROVAL_AMT"),
            new System.Data.SqlClient.SqlParameter("@POST_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, "POST_APPROVAL_AMT"),
            new System.Data.SqlClient.SqlParameter("@KC_STATUS", System.Data.SqlDbType.VarChar, 0, "KC_STATUS"),
            new System.Data.SqlClient.SqlParameter("@APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, "APPROVAL_REQ_ID"),
            new System.Data.SqlClient.SqlParameter("@DirectShip", System.Data.SqlDbType.Bit, 0, "DirectShip"),
            new System.Data.SqlClient.SqlParameter("@PONO2", System.Data.SqlDbType.VarChar, 0, "PONO2"),
            new System.Data.SqlClient.SqlParameter("@CUST_RFQ", System.Data.SqlDbType.VarChar, 0, "CUST_RFQ"),
            new System.Data.SqlClient.SqlParameter("@convert_count", System.Data.SqlDbType.Int, 0, "convert_count"),
            new System.Data.SqlClient.SqlParameter("@KC_GMStatus", System.Data.SqlDbType.VarChar, 0, "KC_GMStatus"),
            new System.Data.SqlClient.SqlParameter("@KC_GM_RequestID", System.Data.SqlDbType.Int, 0, "KC_GM_RequestID"),
            new System.Data.SqlClient.SqlParameter("@PICK_SLIP_PRINT_COUNT", System.Data.SqlDbType.Int, 0, "PICK_SLIP_PRINT_COUNT"),
            new System.Data.SqlClient.SqlParameter("@AttentionRequired", System.Data.SqlDbType.Bit, 0, "AttentionRequired"),
            new System.Data.SqlClient.SqlParameter("@B2B_Notes", System.Data.SqlDbType.Text, 0, "B2B_Notes"),
            new System.Data.SqlClient.SqlParameter("@BUY_RCVD_PIPE", System.Data.SqlDbType.Char, 0, "BUY_RCVD_PIPE"),
            new System.Data.SqlClient.SqlParameter("@SubStatus", System.Data.SqlDbType.VarChar, 0, "SubStatus"),
            new System.Data.SqlClient.SqlParameter("@B2B_ID", System.Data.SqlDbType.Int, 0, "B2B_ID"),
            new System.Data.SqlClient.SqlParameter("@ShipInProcess", System.Data.SqlDbType.Bit, 0, "ShipInProcess"),
            new System.Data.SqlClient.SqlParameter("@LinkDescription", System.Data.SqlDbType.VarChar, 0, "LinkDescription"),
            new System.Data.SqlClient.SqlParameter("@BuildReference_ID", System.Data.SqlDbType.Int, 0, "BuildReference_ID"),
            new System.Data.SqlClient.SqlParameter("@BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, "BuildReferenceCompany_ID"),
            new System.Data.SqlClient.SqlParameter("@CreditRemaining", System.Data.SqlDbType.Money, 0, "CreditRemaining"),
            new System.Data.SqlClient.SqlParameter("@CreditUsed", System.Data.SqlDbType.Money, 0, "CreditUsed"),
            new System.Data.SqlClient.SqlParameter("@CreditLimit", System.Data.SqlDbType.Money, 0, "CreditLimit"),
            new System.Data.SqlClient.SqlParameter("@CashSalePaid", System.Data.SqlDbType.Char, 0, "CashSalePaid"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID3", System.Data.SqlDbType.Int, 0, "SLS_ID3"),
            new System.Data.SqlClient.SqlParameter("@SLS_ID4", System.Data.SqlDbType.Int, 0, "SLS_ID4"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT2", System.Data.SqlDbType.Money, 0, "OUT_PCT2"),
            new System.Data.SqlClient.SqlParameter("@OUT_PCT3", System.Data.SqlDbType.Money, 0, "OUT_PCT3"),
            new System.Data.SqlClient.SqlParameter("@OE_Priority_ID", System.Data.SqlDbType.Int, 0, "OE_Priority_ID"),
            new System.Data.SqlClient.SqlParameter("@cons_method_id", System.Data.SqlDbType.Int, 0, "cons_method_id"),
            new System.Data.SqlClient.SqlParameter("@cons_frequency_id", System.Data.SqlDbType.Int, 0, "cons_frequency_id"),
            new System.Data.SqlClient.SqlParameter("@CONSOLIDATE_INVOICES", System.Data.SqlDbType.VarChar, 0, "CONSOLIDATE_INVOICES"),
            new System.Data.SqlClient.SqlParameter("@CommissionsPaid", System.Data.SqlDbType.Char, 0, "CommissionsPaid"),
            new System.Data.SqlClient.SqlParameter("@CompletionDate", System.Data.SqlDbType.DateTime, 0, "CompletionDate"),
            new System.Data.SqlClient.SqlParameter("@PickSlipPrinted", System.Data.SqlDbType.Bit, 0, "PickSlipPrinted"),
            new System.Data.SqlClient.SqlParameter("@PickSlipPrinted_pipe", System.Data.SqlDbType.Bit, 0, "PickSlipPrinted_pipe"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, "KC_RoutedApproval_Req_ID"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForTraining", System.Data.SqlDbType.Char, 0, "KC_RoutedForTraining"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForCreditDays", System.Data.SqlDbType.Char, 0, "KC_RoutedForCreditDays"),
            new System.Data.SqlClient.SqlParameter("@KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, "KC_RoutedForCreditDays_Req_ID"),
            new System.Data.SqlClient.SqlParameter("@ManualQuote", System.Data.SqlDbType.Bit, 0, "ManualQuote"),
            new System.Data.SqlClient.SqlParameter("@RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, "RM_Opportunity_ID"),
            new System.Data.SqlClient.SqlParameter("@ProbablityPct", System.Data.SqlDbType.Int, 0, "ProbablityPct"),
            new System.Data.SqlClient.SqlParameter("@SUPPLY_AND_INSTALL", System.Data.SqlDbType.VarChar, 0, "SUPPLY_AND_INSTALL"),
            new System.Data.SqlClient.SqlParameter("@QuoteValidityID", System.Data.SqlDbType.Int, 0, "QuoteValidityID"),
            new System.Data.SqlClient.SqlParameter("@QuoteRoutingStatus", System.Data.SqlDbType.Char, 0, "QuoteRoutingStatus"),
            new System.Data.SqlClient.SqlParameter("@QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, "QuoteRoutingStatusID"),
            new System.Data.SqlClient.SqlParameter("@BaseFolder", System.Data.SqlDbType.VarChar, 0, "BaseFolder"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer", System.Data.SqlDbType.VarChar, 0, "EndConsumer"),
            new System.Data.SqlClient.SqlParameter("@REV_NO", System.Data.SqlDbType.Int, 0, "REV_NO"),
            new System.Data.SqlClient.SqlParameter("@ReleaseToDrafting", System.Data.SqlDbType.Bit, 0, "ReleaseToDrafting"),
            new System.Data.SqlClient.SqlParameter("@CUST_REF", System.Data.SqlDbType.VarChar, 0, "CUST_REF"),
            new System.Data.SqlClient.SqlParameter("@BillingType", System.Data.SqlDbType.VarChar, 0, "BillingType"),
            new System.Data.SqlClient.SqlParameter("@BillingComplete", System.Data.SqlDbType.Bit, 0, "BillingComplete"),
            new System.Data.SqlClient.SqlParameter("@LockID", System.Data.SqlDbType.Int, 0, "LockID"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_TELEPHONE", System.Data.SqlDbType.VarChar, 0, "BILL_TO_TELEPHONE"),
            new System.Data.SqlClient.SqlParameter("@BILL_TO_FAX", System.Data.SqlDbType.VarChar, 0, "BILL_TO_FAX"),
            new System.Data.SqlClient.SqlParameter("@PRE_APPROVED_AMT", System.Data.SqlDbType.Money, 0, "PRE_APPROVED_AMT"),
            new System.Data.SqlClient.SqlParameter("@ReleaseShipHold", System.Data.SqlDbType.Bit, 0, "ReleaseShipHold"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, "EndConsumer_Customer_ID"),
            new System.Data.SqlClient.SqlParameter("@EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, "EndConsumer_ContactID"),
            new System.Data.SqlClient.SqlParameter("@ReferencedSO", System.Data.SqlDbType.Int, 0, "ReferencedSO"),
            new System.Data.SqlClient.SqlParameter("@QuoteSent", System.Data.SqlDbType.Bit, 0, "QuoteSent"),
            new System.Data.SqlClient.SqlParameter("@ConfirmationSent", System.Data.SqlDbType.Bit, 0, "ConfirmationSent"),
            new System.Data.SqlClient.SqlParameter("@SO_Class_ID", System.Data.SqlDbType.Int, 0, "SO_Class_ID"),
            new System.Data.SqlClient.SqlParameter("@Original_SO_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_PREFIX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_PREFIX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_PREFIX", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_PREFIX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TYPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TYPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TYPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TYPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QUOTE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QUOTE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QUOTE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QUOTE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PONO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PONO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PONO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PONO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDER_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDER_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDER_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDER_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_SAVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_SAVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_SAVED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_SAVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_SAVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_SAVED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_LAST_MODIFIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_LAST_MODIFIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_LAST_MODIFIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_LAST_MODIFIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_LAST_MODIFIED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_LAST_MODIFIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_STATUS", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HOLD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMPLETE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMPLETE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMPLETE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMPLETE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_HOLD_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_HOLD_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_HOLD_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_HOLD_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_HOLD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_HOLD", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_RELEASED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_RELEASED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_RELEASED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_RELEASED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_RELEASED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_RELEASED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_RELEASED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_RELEASED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAX_EXEMPT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAX_EXEMPT", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILLING_ADDR_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILLING_ADDR_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_CITY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_CITY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_CITY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_CITY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_STATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_STATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_STATE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_STATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ZIP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ZIP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ZIP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ZIP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_CODE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONTACT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONTACT_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONTACT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONTACT_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONTACT_INFO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONTACT_INFO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONTACT_INFO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONTACT_INFO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_METHOD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_METHOD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_METHOD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_METHOD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TERMS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TERMS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TERMS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TERMS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_USER_DEF1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_USER_DEF1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_USER_DEF2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_USER_DEF2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_USER_DEF2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_USER_DEF2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MEMO_CODE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MEMO_CODE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MEMO_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MEMO_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_CANCEL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_CANCEL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_CANCEL", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_CANCEL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_CANCEL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_CANCEL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_CANCEL", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_CANCEL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CANCEL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CANCEL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CANCEL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CANCEL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_INTERNAL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_INTERNAL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IN_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IN_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IN_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IN_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_COMM", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_COMM", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_PROD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_PROD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_PROD", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_PROD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_TAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_TAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_TAX", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_TAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_GST", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NEXT_PO_SEQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NEXT_PO_SEQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CASH", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CASH", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CASH", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CASH", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAY_METHOD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAY_METHOD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAY_METHOD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAY_METHOD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DISC_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DISC_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DISC_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DISC_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXP_SHIP_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXP_SHIP_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXP_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXP_SHIP_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PREPARE_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PREPARE_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PREPARE_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PREPARE_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_INVOICE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "INVOICE_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_INVOICE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "INVOICE_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MOP_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MOP_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MOP_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MOP_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCATION", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCATION", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCATION", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCATION", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CASH_UPDATED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CASH_UPDATED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CASH_UPDATED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CASH_UPDATED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WHSE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WHSE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WHSE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WHSE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SHIP_TYPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SHIP_TYPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SHIP_TYPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SHIP_TYPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FUTURE_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FUTURE_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FUTURE_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FUTURE_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CURRENCY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CURRENCY_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CURRENCY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CURRENCY_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SIC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SIC_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SIC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SIC_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_DISCOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_DISCOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_DISCOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_DISCOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_QUOTE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_QUOTE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_QUOTE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_QUOTE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_QUOTE_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_QUOTE_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCKED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCKED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCKED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCKED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCKED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCKED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCKED_BY", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCKED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BR_CUSTOMER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BR_CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAYMENT_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAYMENT_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAYMENT_AMOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAYMENT_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CHANGE_GIVEN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CHANGE_GIVEN", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CHANGE_GIVEN", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CHANGE_GIVEN", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPLIT_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPLIT_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPLIT_COMM", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPLIT_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINTED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINTED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REV_SHIP_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REV_SHIP_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REV_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REV_SHIP_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXTRACT_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXTRACT_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXTRACT_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXTRACT_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CALL_BACK", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CALL_BACK", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CALL_BACK", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CALL_BACK", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TYPE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDER_APPROVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDER_APPROVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDER_APPROVED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDER_APPROVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_AMOUNT", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SCHEDULED_QUOTE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SCHEDULED_QUOTE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SCHEDULED_QUOTE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCHEDULED_QUOTE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAYMENT_APPLIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAYMENT_APPLIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAYMENT_APPLIED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAYMENT_APPLIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_APPLIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_APPLIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_APPLIED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_APPLIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_AMOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_UPDATED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_UPDATED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_UPDATED", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_UPDATED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DELIVERY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DELIVERY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DELIVERY", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DELIVERY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RETURN_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RETURN_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RETURN_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RETURN_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TRN_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TRN_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TRN_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TRN_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DELIVERY_CHARGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DELIVERY_CHARGE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DELIVERY_CHARGE", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DELIVERY_CHARGE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RESTOCKING_CHARGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RESTOCKING_CHARGE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RESTOCKING_CHARGE", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RESTOCKING_CHARGE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RESTOCKING_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RESTOCKING_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RESTOCKING_PCT", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RESTOCKING_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_DIV", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_DIV", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_DIV", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_DIV", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AR_SETUP_GL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AR_SETUP_GL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRICE_CODE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRICE_CODE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINT_CNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINT_CNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINT_CNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINT_CNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CREDIT_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CREDIT_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CREDIT_REF", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CREDIT_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MTR_REQUIRED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MTR_REQUIRED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MTR_REQUIRED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MTR_REQUIRED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_METRIC_ORDER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "METRIC_ORDER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_METRIC_ORDER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "METRIC_ORDER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_ORDER_SEQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_ORDER_SEQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SHIP_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SHIP_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SHIP_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SHIP_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_WEIGHT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_WEIGHT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_WEIGHT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_WEIGHT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXT_REFERENCE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXT_REFERENCE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXT_REFERENCE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXT_REFERENCE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LSD_NUMBER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LSD_NUMBER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LSD_NUMBER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LSD_NUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDERED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDERED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDERED_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDERED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FOB_DESC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FOB_DESC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FOB_DESC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOB_DESC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_installer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "installer_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_installer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "installer_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AD_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AD_CODE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AD_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AD_CODE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MOBILE_ADDRESS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MOBILE_ADDRESS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MOBILE_ADDRESS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MOBILE_ADDRESS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINT_PRICES", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINT_PRICES", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINT_PRICES", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINT_PRICES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BUY_RCVD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BUY_RCVD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BUY_RCVD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BUY_RCVD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HAS_PIPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HAS_PIPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HAS_PIPE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HAS_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REVIEWED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REVIEWED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REVIEWED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REVIEWED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REQUIRED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REQUIRED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REQUIRED_BY", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REQUIRED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXCEPTION_ORDER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXCEPTION_ORDER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXCEPTION_ORDER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXCEPTION_ORDER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAGGING", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAGGING", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAGGING", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAGGING", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PO_RELEASE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PO_RELEASE_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PO_RELEASE_NO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PO_RELEASE_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MTR_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MTR_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MTR_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MTR_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_marsallingOrdType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "marsallingOrdType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_marsallingOrdType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "marsallingOrdType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_STATUS_PIPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_STATUS_PIPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_STATUS_PIPE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_STATUS_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRE_APPROVAL_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRE_APPROVAL_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRE_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRE_APPROVAL_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POST_APPROVAL_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POST_APPROVAL_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POST_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POST_APPROVAL_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "APPROVAL_REQ_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "APPROVAL_REQ_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DirectShip", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DirectShip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PONO2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PONO2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PONO2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PONO2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUST_RFQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUST_RFQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUST_RFQ", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUST_RFQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_convert_count", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "convert_count", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_GMStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_GMStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_GMStatus", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_GMStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_GM_RequestID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_GM_RequestID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_GM_RequestID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_GM_RequestID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PICK_SLIP_PRINT_COUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PICK_SLIP_PRINT_COUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AttentionRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AttentionRequired", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AttentionRequired", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AttentionRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BUY_RCVD_PIPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BUY_RCVD_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SubStatus", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SubStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_B2B_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "B2B_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_B2B_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "B2B_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipInProcess", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipInProcess", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LinkDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LinkDescription", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LinkDescription", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LinkDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BuildReference_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BuildReference_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BuildReference_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BuildReference_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BuildReferenceCompany_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BuildReferenceCompany_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditRemaining", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditRemaining", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditRemaining", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditRemaining", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditUsed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditUsed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditUsed", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditUsed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditLimit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditLimit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditLimit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditLimit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CashSalePaid", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CashSalePaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT3", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OE_Priority_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OE_Priority_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OE_Priority_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OE_Priority_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cons_method_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cons_method_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cons_method_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cons_method_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cons_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cons_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cons_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cons_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONSOLIDATE_INVOICES", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONSOLIDATE_INVOICES", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONSOLIDATE_INVOICES", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONSOLIDATE_INVOICES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CommissionsPaid", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CommissionsPaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CompletionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CompletionDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CompletionDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompletionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PickSlipPrinted", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PickSlipPrinted", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PickSlipPrinted_pipe", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PickSlipPrinted_pipe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedApproval_Req_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedApproval_Req_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForTraining", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForTraining", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForTraining", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForTraining", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForCreditDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForCreditDays", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays_Req_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays_Req_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManualQuote", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManualQuote", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManualQuote", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManualQuote", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RM_Opportunity_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RM_Opportunity_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProbablityPct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProbablityPct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProbablityPct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProbablityPct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SUPPLY_AND_INSTALL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SUPPLY_AND_INSTALL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLY_AND_INSTALL", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLY_AND_INSTALL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteValidityID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteValidityID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteValidityID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteValidityID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteRoutingStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteRoutingStatus", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatusID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatusID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_REV_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REV_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReleaseToDrafting", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReleaseToDrafting", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUST_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUST_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUST_REF", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUST_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BillingType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BillingType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BillingComplete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BillingComplete", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LockID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LockID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LockID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LockID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_TELEPHONE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_TELEPHONE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_TELEPHONE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_TELEPHONE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_FAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_FAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_FAX", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_FAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRE_APPROVED_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRE_APPROVED_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRE_APPROVED_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRE_APPROVED_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReleaseShipHold", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReleaseShipHold", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndConsumer_Customer_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndConsumer_Customer_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndConsumer_ContactID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndConsumer_ContactID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReferencedSO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReferencedSO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReferencedSO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReferencedSO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteSent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteSent", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteSent", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteSent", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConfirmationSent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConfirmationSent", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConfirmationSent", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfirmationSent", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_Class_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_Class_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.sqlConnection1;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SO_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SO_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_PREFIX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_PREFIX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_PREFIX", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_PREFIX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TYPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TYPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TYPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TYPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QUOTE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QUOTE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QUOTE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QUOTE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PONO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PONO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PONO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PONO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDER_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDER_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDER_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDER_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_SAVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_SAVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_SAVED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_SAVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_SAVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_SAVED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_LAST_MODIFIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_LAST_MODIFIED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_LAST_MODIFIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_LAST_MODIFIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_LAST_MODIFIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_LAST_MODIFIED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_LAST_MODIFIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_STATUS", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HOLD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMPLETE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMPLETE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMPLETE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMPLETE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_HOLD_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_HOLD_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_HOLD_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_HOLD_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_HOLD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_HOLD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_HOLD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_HOLD", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_HOLD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_RELEASED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_RELEASED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_RELEASED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_RELEASED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_RELEASED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_RELEASED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_RELEASED", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_RELEASED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAX_EXEMPT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAX_EXEMPT", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAX_EXEMPT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAX_EXEMPT_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILLING_ADDR_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILLING_ADDR_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILLING_ADDR_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_NAME", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_NAME", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_NAME", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_NAME", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ADD_3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ADD_3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ADD_3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_CITY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_CITY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_CITY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_CITY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_STATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_STATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_STATE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_STATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_ZIP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_ZIP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_ZIP", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_ZIP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_COUNTRY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_CODE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_COUNTRY_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_COUNTRY_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONTACT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONTACT_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONTACT_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONTACT_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONTACT_INFO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONTACT_INFO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONTACT_INFO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONTACT_INFO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_METHOD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_METHOD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_METHOD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_METHOD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TERMS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TERMS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TERMS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TERMS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_USER_DEF1_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_USER_DEF1_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_USER_DEF1_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_USER_DEF2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_USER_DEF2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_USER_DEF2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_USER_DEF2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MEMO_CODE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MEMO_CODE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MEMO_CODE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MEMO_CODE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DATE_CANCEL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DATE_CANCEL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DATE_CANCEL", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE_CANCEL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OPERATOR_CANCEL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OPERATOR_CANCEL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OPERATOR_CANCEL", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OPERATOR_CANCEL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CANCEL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CANCEL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CANCEL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CANCEL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_INTERNAL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_INTERNAL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_INTERNAL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GST_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GST_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GST_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "GST_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IN_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IN_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IN_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IN_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_COMM", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_COMM", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_PROD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_PROD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_PROD", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_PROD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_TAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_TAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_TAX", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_TAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_GST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_GST", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_GST", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_GST", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NEXT_PO_SEQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NEXT_PO_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NEXT_PO_SEQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CASH", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CASH", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CASH", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CASH", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAY_METHOD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAY_METHOD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAY_METHOD", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAY_METHOD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DISC_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DISC_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DISC_PCT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DISC_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXP_SHIP_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXP_SHIP_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXP_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXP_SHIP_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PREPARE_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PREPARE_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PREPARE_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PREPARE_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_num", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_num", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_num", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_INVOICE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "INVOICE_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_INVOICE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "INVOICE_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MOP_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MOP_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MOP_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MOP_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCATION", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCATION", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCATION", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCATION", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CASH_UPDATED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CASH_UPDATED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CASH_UPDATED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CASH_UPDATED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WHSE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WHSE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WHSE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WHSE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SHIP_TYPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SHIP_TYPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SHIP_TYPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SHIP_TYPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FUTURE_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FUTURE_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FUTURE_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FUTURE_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CURRENCY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CURRENCY_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CURRENCY_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CURRENCY_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SIC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SIC_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SIC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SIC_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_DISCOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_DISCOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_DISCOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_DISCOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_QUOTE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_QUOTE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_QUOTE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_QUOTE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_QUOTE_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_QUOTE_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_QUOTE_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCKED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCKED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCKED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCKED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOCKED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOCKED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOCKED_BY", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOCKED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BR_CUSTOMER_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BR_CUSTOMER_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BR_CUSTOMER_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_CNTL_ID1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_COMM_CNTL_ID2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COMM_CNTL_ID2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAYMENT_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAYMENT_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAYMENT_AMOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAYMENT_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CHANGE_GIVEN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CHANGE_GIVEN", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CHANGE_GIVEN", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CHANGE_GIVEN", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPLIT_COMM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPLIT_COMM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPLIT_COMM", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPLIT_COMM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINTED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINTED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REV_SHIP_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REV_SHIP_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REV_SHIP_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REV_SHIP_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXTRACT_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXTRACT_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXTRACT_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXTRACT_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CALL_BACK", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CALL_BACK", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CALL_BACK", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CALL_BACK", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TYPE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TYPE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TYPE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDER_APPROVED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDER_APPROVED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDER_APPROVED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDER_APPROVED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_DATE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_DATE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_DATE", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_DATE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AUTHORIZED_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AUTHORIZED_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AUTHORIZED_AMOUNT", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AUTHORIZED_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SCHEDULED_QUOTE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SCHEDULED_QUOTE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SCHEDULED_QUOTE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SCHEDULED_QUOTE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PAYMENT_APPLIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PAYMENT_APPLIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PAYMENT_APPLIED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PAYMENT_APPLIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_APPLIED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_APPLIED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_APPLIED", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_APPLIED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_AMOUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_AMOUNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_AMOUNT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_AMOUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DEPOSIT_UPDATED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DEPOSIT_UPDATED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DEPOSIT_UPDATED", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DEPOSIT_UPDATED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DELIVERY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DELIVERY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DELIVERY", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DELIVERY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RETURN_FLAG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RETURN_FLAG", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RETURN_FLAG", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RETURN_FLAG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_TRN_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_TRN_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_TRN_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_TRN_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DELIVERY_CHARGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DELIVERY_CHARGE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DELIVERY_CHARGE", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DELIVERY_CHARGE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RESTOCKING_CHARGE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RESTOCKING_CHARGE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RESTOCKING_CHARGE", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RESTOCKING_CHARGE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RESTOCKING_PCT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RESTOCKING_PCT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RESTOCKING_PCT", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RESTOCKING_PCT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_DIV", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_DIV", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_DIV", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_DIV", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AR_SETUP_GL_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AR_SETUP_GL_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AR_SETUP_GL_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRICE_CODE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRICE_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRICE_CODE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINT_CNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINT_CNT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINT_CNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINT_CNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CREDIT_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CREDIT_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CREDIT_REF", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CREDIT_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MTR_REQUIRED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MTR_REQUIRED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MTR_REQUIRED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MTR_REQUIRED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_METRIC_ORDER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "METRIC_ORDER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_METRIC_ORDER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "METRIC_ORDER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_ORDER_SEQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_ORDER_SEQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_ORDER_SEQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SHIP_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SHIP_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SHIP_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SHIP_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TOTAL_WEIGHT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TOTAL_WEIGHT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TOTAL_WEIGHT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TOTAL_WEIGHT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXT_REFERENCE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXT_REFERENCE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXT_REFERENCE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXT_REFERENCE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LSD_NUMBER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LSD_NUMBER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LSD_NUMBER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LSD_NUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ORDERED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ORDERED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ORDERED_BY", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ORDERED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FOB_DESC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FOB_DESC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FOB_DESC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOB_DESC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_installer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "installer_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_installer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "installer_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AD_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AD_CODE_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AD_CODE_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AD_CODE_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MOBILE_ADDRESS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MOBILE_ADDRESS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MOBILE_ADDRESS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MOBILE_ADDRESS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRINT_PRICES", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRINT_PRICES", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRINT_PRICES", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRINT_PRICES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BUY_RCVD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BUY_RCVD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BUY_RCVD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BUY_RCVD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HAS_PIPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HAS_PIPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HAS_PIPE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HAS_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REVIEWED", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REVIEWED", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REVIEWED", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REVIEWED", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_REQUIRED_BY", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "REQUIRED_BY", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_REQUIRED_BY", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REQUIRED_BY", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EXCEPTION_ORDER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EXCEPTION_ORDER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EXCEPTION_ORDER", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EXCEPTION_ORDER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAGGING", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAGGING", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAGGING", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAGGING", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PO_RELEASE_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PO_RELEASE_NO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PO_RELEASE_NO", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PO_RELEASE_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MTR_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MTR_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MTR_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MTR_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_marsallingOrdType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "marsallingOrdType", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_marsallingOrdType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "marsallingOrdType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_WMS_STATUS_PIPE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WMS_STATUS_PIPE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_WMS_STATUS_PIPE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WMS_STATUS_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRE_APPROVAL_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRE_APPROVAL_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRE_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRE_APPROVAL_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_POST_APPROVAL_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "POST_APPROVAL_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_POST_APPROVAL_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "POST_APPROVAL_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_STATUS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_STATUS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_STATUS", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_STATUS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "APPROVAL_REQ_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_APPROVAL_REQ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "APPROVAL_REQ_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DirectShip", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DirectShip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PONO2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PONO2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PONO2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PONO2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUST_RFQ", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUST_RFQ", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUST_RFQ", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUST_RFQ", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_convert_count", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "convert_count", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_GMStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_GMStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_GMStatus", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_GMStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_GM_RequestID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_GM_RequestID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_GM_RequestID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_GM_RequestID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PICK_SLIP_PRINT_COUNT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PICK_SLIP_PRINT_COUNT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AttentionRequired", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AttentionRequired", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AttentionRequired", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AttentionRequired", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BUY_RCVD_PIPE", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BUY_RCVD_PIPE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SubStatus", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SubStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_B2B_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "B2B_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_B2B_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "B2B_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ShipInProcess", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipInProcess", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LinkDescription", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LinkDescription", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LinkDescription", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LinkDescription", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BuildReference_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BuildReference_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BuildReference_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BuildReference_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BuildReferenceCompany_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BuildReferenceCompany_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BuildReferenceCompany_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditRemaining", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditRemaining", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditRemaining", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditRemaining", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditUsed", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditUsed", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditUsed", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditUsed", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CreditLimit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditLimit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CreditLimit", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditLimit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CashSalePaid", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CashSalePaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SLS_ID4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SLS_ID4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SLS_ID4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SLS_ID4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT2", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OUT_PCT3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OUT_PCT3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OUT_PCT3", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUT_PCT3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OE_Priority_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OE_Priority_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OE_Priority_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OE_Priority_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cons_method_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cons_method_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cons_method_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cons_method_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cons_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cons_frequency_id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cons_frequency_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cons_frequency_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CONSOLIDATE_INVOICES", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CONSOLIDATE_INVOICES", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CONSOLIDATE_INVOICES", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CONSOLIDATE_INVOICES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CommissionsPaid", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CommissionsPaid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CompletionDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CompletionDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CompletionDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CompletionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PickSlipPrinted", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PickSlipPrinted", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PickSlipPrinted_pipe", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PickSlipPrinted_pipe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedApproval_Req_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedApproval_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedApproval_Req_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForTraining", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForTraining", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForTraining", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForTraining", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForCreditDays", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForCreditDays", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays_Req_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KC_RoutedForCreditDays_Req_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KC_RoutedForCreditDays_Req_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ManualQuote", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ManualQuote", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ManualQuote", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ManualQuote", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RM_Opportunity_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RM_Opportunity_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RM_Opportunity_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProbablityPct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProbablityPct", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProbablityPct", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProbablityPct", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SUPPLY_AND_INSTALL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SUPPLY_AND_INSTALL", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SUPPLY_AND_INSTALL", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SUPPLY_AND_INSTALL", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteValidityID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteValidityID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteValidityID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteValidityID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteRoutingStatus", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatus", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteRoutingStatus", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatus", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatusID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteRoutingStatusID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteRoutingStatusID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_REV_NO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "REV_NO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReleaseToDrafting", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReleaseToDrafting", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CUST_REF", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CUST_REF", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CUST_REF", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CUST_REF", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BillingType", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BillingType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_BillingComplete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BillingComplete", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LockID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LockID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LockID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LockID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_TELEPHONE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_TELEPHONE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_TELEPHONE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_TELEPHONE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BILL_TO_FAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BILL_TO_FAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BILL_TO_FAX", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BILL_TO_FAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PRE_APPROVED_AMT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PRE_APPROVED_AMT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PRE_APPROVED_AMT", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRE_APPROVED_AMT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ReleaseShipHold", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReleaseShipHold", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndConsumer_Customer_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndConsumer_Customer_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndConsumer_Customer_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndConsumer_ContactID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EndConsumer_ContactID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndConsumer_ContactID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReferencedSO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReferencedSO", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReferencedSO", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReferencedSO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_QuoteSent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "QuoteSent", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_QuoteSent", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "QuoteSent", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConfirmationSent", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConfirmationSent", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConfirmationSent", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfirmationSent", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SO_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SO_Class_ID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SO_Class_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SO_Class_ID", System.Data.DataRowVersion.Original, null)});
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "SO_MASTER_HDR";
            this.gridControl1.DataSource = this.ds_so_master_hdr1;
            this.gridControl1.Location = new System.Drawing.Point(26, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(747, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSO_NO,
            this.colSO_ID,
            this.colSO_PREFIX,
            this.colSO_TYPE,
            this.colQUOTE_ID,
            this.colCUSTOMER_ID,
            this.colPONO,
            this.colORDER_DATE,
            this.colOPERATOR_SAVED,
            this.colDATE_SAVED,
            this.colOPERATOR_LAST_MODIFIED,
            this.colDATE_LAST_MODIFIED,
            this.colSTATUS,
            this.colHOLD,
            this.colCOMPLETE,
            this.colSO_HOLD_ID,
            this.colOPERATOR_HOLD,
            this.colDATE_HOLD,
            this.colOPERATOR_RELEASED,
            this.colDATE_RELEASED,
            this.colTAX_EXEMPT,
            this.colTAX_EXEMPT_ID,
            this.colBILLING_ADDR_ID,
            this.colBILL_TO_NAME,
            this.colBILL_TO_ADD_1,
            this.colBILL_TO_ADD_2,
            this.colBILL_TO_ADD_3,
            this.colBILL_TO_CITY,
            this.colBILL_TO_STATE,
            this.colBILL_TO_ZIP,
            this.colBILL_TO_COUNTRY_ID,
            this.colBILL_TO_COUNTRY_CODE,
            this.colCONTACT_ID,
            this.colCONTACT_INFO,
            this.colCOMM_METHOD,
            this.colTERMS_ID,
            this.colSO_USER_DEF1_ID,
            this.colSO_USER_DEF2,
            this.colCOD,
            this.colMEMO_CODE,
            this.colDATE_CANCEL,
            this.colOPERATOR_CANCEL,
            this.colCANCEL_ID,
            this.colSLS_INTERNAL_ID,
            this.colGST_FLAG,
            this.colIN_PCT,
            this.colOUT_PCT,
            this.colCOMM_PCT,
            this.colSLS_COMM,
            this.colTOTAL_COMM,
            this.colTOTAL_PROD,
            this.colTOTAL_TAX,
            this.colTOTAL_GST,
            this.colNEXT_PO_SEQ,
            this.colCASH,
            this.colPAY_METHOD,
            this.colDISC_PCT,
            this.colEXP_SHIP_DATE,
            this.colPREPARE_BY,
            this.colpri_num,
            this.colINVOICE_NO,
            this.colMOP_ID,
            this.colLOCATION,
            this.colCASH_UPDATED,
            this.colWHSE_ID,
            this.colSHIP_TYPE,
            this.colFUTURE_DATE,
            this.colCURRENCY_ID,
            this.colSIC_ID,
            this.colTOTAL_DISCOUNT,
            this.colSO_QUOTE,
            this.colSO_QUOTE_REF,
            this.colLOCKED,
            this.colLOCKED_BY,
            this.colSLS_ID,
            this.colSLS_ID2,
            this.colBR_CUSTOMER_ID,
            this.colCOMM_CNTL_ID1,
            this.colCOMM_CNTL_ID2,
            this.colPAYMENT_AMOUNT,
            this.colCHANGE_GIVEN,
            this.colSPLIT_COMM,
            this.colPRINTED,
            this.colREV_SHIP_DATE,
            this.colEXTRACT_FLAG,
            this.colEXP_COMMENT,
            this.colCALL_BACK,
            this.colSO_TYPE_ID,
            this.colORDER_APPROVED,
            this.colAUTHORIZED_BY,
            this.colAUTHORIZED_DATE,
            this.colAUTHORIZED_AMOUNT,
            this.colSCHEDULED_QUOTE,
            this.colPAYMENT_APPLIED,
            this.colDEPOSIT_APPLIED,
            this.colDEPOSIT_AMOUNT,
            this.colDEPOSIT_UPDATED,
            this.colDELIVERY,
            this.colRETURN_FLAG,
            this.colSO_TRN_ID,
            this.colDELIVERY_CHARGE,
            this.colRESTOCKING_CHARGE,
            this.colRESTOCKING_PCT,
            this.colSO_DIV,
            this.colAR_SETUP_GL_ID,
            this.colPRICE_CODE_ID,
            this.colPRINT_CNT,
            this.colCREDIT_REF,
            this.colCOMMENT,
            this.colCOMMENT_INT,
            this.colMEMO,
            this.colFOOTER_COMMENT,
            this.colWMS_STATUS,
            this.colWMS_MESSAGE,
            this.colMTR_REQUIRED,
            this.colMETRIC_ORDER,
            this.colWMS_ORDER_SEQ,
            this.colSHIP_NO,
            this.colTOTAL_WEIGHT,
            this.colEXT_REFERENCE,
            this.colLSD_NUMBER,
            this.colORDERED_BY,
            this.colFOB_DESC,
            this.colinstaller_id,
            this.colAD_CODE_ID,
            this.colMOBILE_ADDRESS,
            this.colPRINT_PRICES,
            this.colBUY_RCVD,
            this.colHAS_PIPE,
            this.colREVIEWED,
            this.colREQUIRED_BY,
            this.colEXCEPTION_ORDER,
            this.colTAGGING,
            this.colPO_RELEASE_NO,
            this.colMTR_STATUS,
            this.colmarsallingOrdType,
            this.colWMS_STATUS_PIPE,
            this.colWMS_MESSAGE_PIPE,
            this.colPRE_APPROVAL_AMT,
            this.colPOST_APPROVAL_AMT,
            this.colKC_STATUS,
            this.colAPPROVAL_REQ_ID,
            this.colDirectShip,
            this.colPONO2,
            this.colCUST_RFQ,
            this.colconvert_count,
            this.colKC_GMStatus,
            this.colKC_GM_RequestID,
            this.colPICK_SLIP_PRINT_COUNT,
            this.colAttentionRequired,
            this.colB2B_Notes,
            this.colBUY_RCVD_PIPE,
            this.colSubStatus,
            this.colB2B_ID,
            this.colShipInProcess,
            this.colLinkDescription,
            this.colBuildReference_ID,
            this.colBuildReferenceCompany_ID,
            this.colCreditRemaining,
            this.colCreditUsed,
            this.colCreditLimit,
            this.colCashSalePaid,
            this.colSLS_ID3,
            this.colSLS_ID4,
            this.colOUT_PCT2,
            this.colOUT_PCT3,
            this.colOE_Priority_ID,
            this.colcons_method_id,
            this.colcons_frequency_id,
            this.colCONSOLIDATE_INVOICES,
            this.colCommissionsPaid,
            this.colCompletionDate,
            this.colPickSlipPrinted,
            this.colPickSlipPrinted_pipe,
            this.colKC_RoutedApproval_Req_ID,
            this.colKC_RoutedForTraining,
            this.colKC_RoutedForCreditDays,
            this.colKC_RoutedForCreditDays_Req_ID,
            this.colManualQuote,
            this.colRM_Opportunity_ID,
            this.colProbablityPct,
            this.colSUPPLY_AND_INSTALL,
            this.colQuoteValidityID,
            this.colQuoteRoutingStatus,
            this.colQuoteRoutingStatusID,
            this.colBaseFolder,
            this.colEndConsumer,
            this.colREV_NO,
            this.colReleaseToDrafting,
            this.colCUST_REF,
            this.colBillingType,
            this.colBillingComplete,
            this.colLockID,
            this.colBILL_TO_TELEPHONE,
            this.colBILL_TO_FAX,
            this.colPRE_APPROVED_AMT,
            this.colReleaseShipHold,
            this.colEndConsumer_Customer_ID,
            this.colEndConsumer_ContactID,
            this.colReferencedSO,
            this.colQuoteSent,
            this.colConfirmationSent,
            this.colSO_Class_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // ds_so_master_hdr1
            // 
            this.ds_so_master_hdr1.DataSetName = "ds_so_master_hdr";
            this.ds_so_master_hdr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colSO_NO
            // 
            this.colSO_NO.FieldName = "SO_NO";
            this.colSO_NO.Name = "colSO_NO";
            this.colSO_NO.Visible = true;
            this.colSO_NO.VisibleIndex = 0;
            // 
            // colSO_ID
            // 
            this.colSO_ID.FieldName = "SO_ID";
            this.colSO_ID.Name = "colSO_ID";
            this.colSO_ID.Visible = true;
            this.colSO_ID.VisibleIndex = 1;
            // 
            // colSO_PREFIX
            // 
            this.colSO_PREFIX.FieldName = "SO_PREFIX";
            this.colSO_PREFIX.Name = "colSO_PREFIX";
            this.colSO_PREFIX.Visible = true;
            this.colSO_PREFIX.VisibleIndex = 2;
            // 
            // colSO_TYPE
            // 
            this.colSO_TYPE.FieldName = "SO_TYPE";
            this.colSO_TYPE.Name = "colSO_TYPE";
            this.colSO_TYPE.Visible = true;
            this.colSO_TYPE.VisibleIndex = 3;
            // 
            // colQUOTE_ID
            // 
            this.colQUOTE_ID.FieldName = "QUOTE_ID";
            this.colQUOTE_ID.Name = "colQUOTE_ID";
            this.colQUOTE_ID.Visible = true;
            this.colQUOTE_ID.VisibleIndex = 4;
            // 
            // colCUSTOMER_ID
            // 
            this.colCUSTOMER_ID.FieldName = "CUSTOMER_ID";
            this.colCUSTOMER_ID.Name = "colCUSTOMER_ID";
            this.colCUSTOMER_ID.Visible = true;
            this.colCUSTOMER_ID.VisibleIndex = 5;
            // 
            // colPONO
            // 
            this.colPONO.FieldName = "PONO";
            this.colPONO.Name = "colPONO";
            this.colPONO.Visible = true;
            this.colPONO.VisibleIndex = 6;
            // 
            // colORDER_DATE
            // 
            this.colORDER_DATE.FieldName = "ORDER_DATE";
            this.colORDER_DATE.Name = "colORDER_DATE";
            this.colORDER_DATE.Visible = true;
            this.colORDER_DATE.VisibleIndex = 7;
            // 
            // colOPERATOR_SAVED
            // 
            this.colOPERATOR_SAVED.FieldName = "OPERATOR_SAVED";
            this.colOPERATOR_SAVED.Name = "colOPERATOR_SAVED";
            this.colOPERATOR_SAVED.Visible = true;
            this.colOPERATOR_SAVED.VisibleIndex = 8;
            // 
            // colDATE_SAVED
            // 
            this.colDATE_SAVED.FieldName = "DATE_SAVED";
            this.colDATE_SAVED.Name = "colDATE_SAVED";
            this.colDATE_SAVED.Visible = true;
            this.colDATE_SAVED.VisibleIndex = 9;
            // 
            // colOPERATOR_LAST_MODIFIED
            // 
            this.colOPERATOR_LAST_MODIFIED.FieldName = "OPERATOR_LAST_MODIFIED";
            this.colOPERATOR_LAST_MODIFIED.Name = "colOPERATOR_LAST_MODIFIED";
            this.colOPERATOR_LAST_MODIFIED.Visible = true;
            this.colOPERATOR_LAST_MODIFIED.VisibleIndex = 10;
            // 
            // colDATE_LAST_MODIFIED
            // 
            this.colDATE_LAST_MODIFIED.FieldName = "DATE_LAST_MODIFIED";
            this.colDATE_LAST_MODIFIED.Name = "colDATE_LAST_MODIFIED";
            this.colDATE_LAST_MODIFIED.Visible = true;
            this.colDATE_LAST_MODIFIED.VisibleIndex = 11;
            // 
            // colSTATUS
            // 
            this.colSTATUS.FieldName = "STATUS";
            this.colSTATUS.Name = "colSTATUS";
            this.colSTATUS.Visible = true;
            this.colSTATUS.VisibleIndex = 12;
            // 
            // colHOLD
            // 
            this.colHOLD.FieldName = "HOLD";
            this.colHOLD.Name = "colHOLD";
            this.colHOLD.Visible = true;
            this.colHOLD.VisibleIndex = 13;
            // 
            // colCOMPLETE
            // 
            this.colCOMPLETE.FieldName = "COMPLETE";
            this.colCOMPLETE.Name = "colCOMPLETE";
            this.colCOMPLETE.Visible = true;
            this.colCOMPLETE.VisibleIndex = 14;
            // 
            // colSO_HOLD_ID
            // 
            this.colSO_HOLD_ID.FieldName = "SO_HOLD_ID";
            this.colSO_HOLD_ID.Name = "colSO_HOLD_ID";
            this.colSO_HOLD_ID.Visible = true;
            this.colSO_HOLD_ID.VisibleIndex = 15;
            // 
            // colOPERATOR_HOLD
            // 
            this.colOPERATOR_HOLD.FieldName = "OPERATOR_HOLD";
            this.colOPERATOR_HOLD.Name = "colOPERATOR_HOLD";
            this.colOPERATOR_HOLD.Visible = true;
            this.colOPERATOR_HOLD.VisibleIndex = 16;
            // 
            // colDATE_HOLD
            // 
            this.colDATE_HOLD.FieldName = "DATE_HOLD";
            this.colDATE_HOLD.Name = "colDATE_HOLD";
            this.colDATE_HOLD.Visible = true;
            this.colDATE_HOLD.VisibleIndex = 17;
            // 
            // colOPERATOR_RELEASED
            // 
            this.colOPERATOR_RELEASED.FieldName = "OPERATOR_RELEASED";
            this.colOPERATOR_RELEASED.Name = "colOPERATOR_RELEASED";
            this.colOPERATOR_RELEASED.Visible = true;
            this.colOPERATOR_RELEASED.VisibleIndex = 18;
            // 
            // colDATE_RELEASED
            // 
            this.colDATE_RELEASED.FieldName = "DATE_RELEASED";
            this.colDATE_RELEASED.Name = "colDATE_RELEASED";
            this.colDATE_RELEASED.Visible = true;
            this.colDATE_RELEASED.VisibleIndex = 19;
            // 
            // colTAX_EXEMPT
            // 
            this.colTAX_EXEMPT.FieldName = "TAX_EXEMPT";
            this.colTAX_EXEMPT.Name = "colTAX_EXEMPT";
            this.colTAX_EXEMPT.Visible = true;
            this.colTAX_EXEMPT.VisibleIndex = 20;
            // 
            // colTAX_EXEMPT_ID
            // 
            this.colTAX_EXEMPT_ID.FieldName = "TAX_EXEMPT_ID";
            this.colTAX_EXEMPT_ID.Name = "colTAX_EXEMPT_ID";
            this.colTAX_EXEMPT_ID.Visible = true;
            this.colTAX_EXEMPT_ID.VisibleIndex = 21;
            // 
            // colBILLING_ADDR_ID
            // 
            this.colBILLING_ADDR_ID.FieldName = "BILLING_ADDR_ID";
            this.colBILLING_ADDR_ID.Name = "colBILLING_ADDR_ID";
            this.colBILLING_ADDR_ID.Visible = true;
            this.colBILLING_ADDR_ID.VisibleIndex = 22;
            // 
            // colBILL_TO_NAME
            // 
            this.colBILL_TO_NAME.FieldName = "BILL_TO_NAME";
            this.colBILL_TO_NAME.Name = "colBILL_TO_NAME";
            this.colBILL_TO_NAME.Visible = true;
            this.colBILL_TO_NAME.VisibleIndex = 23;
            // 
            // colBILL_TO_ADD_1
            // 
            this.colBILL_TO_ADD_1.FieldName = "BILL_TO_ADD_1";
            this.colBILL_TO_ADD_1.Name = "colBILL_TO_ADD_1";
            this.colBILL_TO_ADD_1.Visible = true;
            this.colBILL_TO_ADD_1.VisibleIndex = 24;
            // 
            // colBILL_TO_ADD_2
            // 
            this.colBILL_TO_ADD_2.FieldName = "BILL_TO_ADD_2";
            this.colBILL_TO_ADD_2.Name = "colBILL_TO_ADD_2";
            this.colBILL_TO_ADD_2.Visible = true;
            this.colBILL_TO_ADD_2.VisibleIndex = 25;
            // 
            // colBILL_TO_ADD_3
            // 
            this.colBILL_TO_ADD_3.FieldName = "BILL_TO_ADD_3";
            this.colBILL_TO_ADD_3.Name = "colBILL_TO_ADD_3";
            this.colBILL_TO_ADD_3.Visible = true;
            this.colBILL_TO_ADD_3.VisibleIndex = 26;
            // 
            // colBILL_TO_CITY
            // 
            this.colBILL_TO_CITY.FieldName = "BILL_TO_CITY";
            this.colBILL_TO_CITY.Name = "colBILL_TO_CITY";
            this.colBILL_TO_CITY.Visible = true;
            this.colBILL_TO_CITY.VisibleIndex = 27;
            // 
            // colBILL_TO_STATE
            // 
            this.colBILL_TO_STATE.FieldName = "BILL_TO_STATE";
            this.colBILL_TO_STATE.Name = "colBILL_TO_STATE";
            this.colBILL_TO_STATE.Visible = true;
            this.colBILL_TO_STATE.VisibleIndex = 28;
            // 
            // colBILL_TO_ZIP
            // 
            this.colBILL_TO_ZIP.FieldName = "BILL_TO_ZIP";
            this.colBILL_TO_ZIP.Name = "colBILL_TO_ZIP";
            this.colBILL_TO_ZIP.Visible = true;
            this.colBILL_TO_ZIP.VisibleIndex = 29;
            // 
            // colBILL_TO_COUNTRY_ID
            // 
            this.colBILL_TO_COUNTRY_ID.FieldName = "BILL_TO_COUNTRY_ID";
            this.colBILL_TO_COUNTRY_ID.Name = "colBILL_TO_COUNTRY_ID";
            this.colBILL_TO_COUNTRY_ID.Visible = true;
            this.colBILL_TO_COUNTRY_ID.VisibleIndex = 30;
            // 
            // colBILL_TO_COUNTRY_CODE
            // 
            this.colBILL_TO_COUNTRY_CODE.FieldName = "BILL_TO_COUNTRY_CODE";
            this.colBILL_TO_COUNTRY_CODE.Name = "colBILL_TO_COUNTRY_CODE";
            this.colBILL_TO_COUNTRY_CODE.Visible = true;
            this.colBILL_TO_COUNTRY_CODE.VisibleIndex = 31;
            // 
            // colCONTACT_ID
            // 
            this.colCONTACT_ID.FieldName = "CONTACT_ID";
            this.colCONTACT_ID.Name = "colCONTACT_ID";
            this.colCONTACT_ID.Visible = true;
            this.colCONTACT_ID.VisibleIndex = 32;
            // 
            // colCONTACT_INFO
            // 
            this.colCONTACT_INFO.FieldName = "CONTACT_INFO";
            this.colCONTACT_INFO.Name = "colCONTACT_INFO";
            this.colCONTACT_INFO.Visible = true;
            this.colCONTACT_INFO.VisibleIndex = 33;
            // 
            // colCOMM_METHOD
            // 
            this.colCOMM_METHOD.FieldName = "COMM_METHOD";
            this.colCOMM_METHOD.Name = "colCOMM_METHOD";
            this.colCOMM_METHOD.Visible = true;
            this.colCOMM_METHOD.VisibleIndex = 34;
            // 
            // colTERMS_ID
            // 
            this.colTERMS_ID.FieldName = "TERMS_ID";
            this.colTERMS_ID.Name = "colTERMS_ID";
            this.colTERMS_ID.Visible = true;
            this.colTERMS_ID.VisibleIndex = 35;
            // 
            // colSO_USER_DEF1_ID
            // 
            this.colSO_USER_DEF1_ID.FieldName = "SO_USER_DEF1_ID";
            this.colSO_USER_DEF1_ID.Name = "colSO_USER_DEF1_ID";
            this.colSO_USER_DEF1_ID.Visible = true;
            this.colSO_USER_DEF1_ID.VisibleIndex = 36;
            // 
            // colSO_USER_DEF2
            // 
            this.colSO_USER_DEF2.FieldName = "SO_USER_DEF2";
            this.colSO_USER_DEF2.Name = "colSO_USER_DEF2";
            this.colSO_USER_DEF2.Visible = true;
            this.colSO_USER_DEF2.VisibleIndex = 37;
            // 
            // colCOD
            // 
            this.colCOD.FieldName = "COD";
            this.colCOD.Name = "colCOD";
            this.colCOD.Visible = true;
            this.colCOD.VisibleIndex = 38;
            // 
            // colMEMO_CODE
            // 
            this.colMEMO_CODE.FieldName = "MEMO_CODE";
            this.colMEMO_CODE.Name = "colMEMO_CODE";
            this.colMEMO_CODE.Visible = true;
            this.colMEMO_CODE.VisibleIndex = 39;
            // 
            // colDATE_CANCEL
            // 
            this.colDATE_CANCEL.FieldName = "DATE_CANCEL";
            this.colDATE_CANCEL.Name = "colDATE_CANCEL";
            this.colDATE_CANCEL.Visible = true;
            this.colDATE_CANCEL.VisibleIndex = 40;
            // 
            // colOPERATOR_CANCEL
            // 
            this.colOPERATOR_CANCEL.FieldName = "OPERATOR_CANCEL";
            this.colOPERATOR_CANCEL.Name = "colOPERATOR_CANCEL";
            this.colOPERATOR_CANCEL.Visible = true;
            this.colOPERATOR_CANCEL.VisibleIndex = 41;
            // 
            // colCANCEL_ID
            // 
            this.colCANCEL_ID.FieldName = "CANCEL_ID";
            this.colCANCEL_ID.Name = "colCANCEL_ID";
            this.colCANCEL_ID.Visible = true;
            this.colCANCEL_ID.VisibleIndex = 42;
            // 
            // colSLS_INTERNAL_ID
            // 
            this.colSLS_INTERNAL_ID.FieldName = "SLS_INTERNAL_ID";
            this.colSLS_INTERNAL_ID.Name = "colSLS_INTERNAL_ID";
            this.colSLS_INTERNAL_ID.Visible = true;
            this.colSLS_INTERNAL_ID.VisibleIndex = 43;
            // 
            // colGST_FLAG
            // 
            this.colGST_FLAG.FieldName = "GST_FLAG";
            this.colGST_FLAG.Name = "colGST_FLAG";
            this.colGST_FLAG.Visible = true;
            this.colGST_FLAG.VisibleIndex = 44;
            // 
            // colIN_PCT
            // 
            this.colIN_PCT.FieldName = "IN_PCT";
            this.colIN_PCT.Name = "colIN_PCT";
            this.colIN_PCT.Visible = true;
            this.colIN_PCT.VisibleIndex = 45;
            // 
            // colOUT_PCT
            // 
            this.colOUT_PCT.FieldName = "OUT_PCT";
            this.colOUT_PCT.Name = "colOUT_PCT";
            this.colOUT_PCT.Visible = true;
            this.colOUT_PCT.VisibleIndex = 46;
            // 
            // colCOMM_PCT
            // 
            this.colCOMM_PCT.FieldName = "COMM_PCT";
            this.colCOMM_PCT.Name = "colCOMM_PCT";
            this.colCOMM_PCT.Visible = true;
            this.colCOMM_PCT.VisibleIndex = 47;
            // 
            // colSLS_COMM
            // 
            this.colSLS_COMM.FieldName = "SLS_COMM";
            this.colSLS_COMM.Name = "colSLS_COMM";
            this.colSLS_COMM.Visible = true;
            this.colSLS_COMM.VisibleIndex = 48;
            // 
            // colTOTAL_COMM
            // 
            this.colTOTAL_COMM.FieldName = "TOTAL_COMM";
            this.colTOTAL_COMM.Name = "colTOTAL_COMM";
            this.colTOTAL_COMM.Visible = true;
            this.colTOTAL_COMM.VisibleIndex = 49;
            // 
            // colTOTAL_PROD
            // 
            this.colTOTAL_PROD.FieldName = "TOTAL_PROD";
            this.colTOTAL_PROD.Name = "colTOTAL_PROD";
            this.colTOTAL_PROD.Visible = true;
            this.colTOTAL_PROD.VisibleIndex = 50;
            // 
            // colTOTAL_TAX
            // 
            this.colTOTAL_TAX.FieldName = "TOTAL_TAX";
            this.colTOTAL_TAX.Name = "colTOTAL_TAX";
            this.colTOTAL_TAX.Visible = true;
            this.colTOTAL_TAX.VisibleIndex = 51;
            // 
            // colTOTAL_GST
            // 
            this.colTOTAL_GST.FieldName = "TOTAL_GST";
            this.colTOTAL_GST.Name = "colTOTAL_GST";
            this.colTOTAL_GST.Visible = true;
            this.colTOTAL_GST.VisibleIndex = 52;
            // 
            // colNEXT_PO_SEQ
            // 
            this.colNEXT_PO_SEQ.FieldName = "NEXT_PO_SEQ";
            this.colNEXT_PO_SEQ.Name = "colNEXT_PO_SEQ";
            this.colNEXT_PO_SEQ.Visible = true;
            this.colNEXT_PO_SEQ.VisibleIndex = 53;
            // 
            // colCASH
            // 
            this.colCASH.FieldName = "CASH";
            this.colCASH.Name = "colCASH";
            this.colCASH.Visible = true;
            this.colCASH.VisibleIndex = 54;
            // 
            // colPAY_METHOD
            // 
            this.colPAY_METHOD.FieldName = "PAY_METHOD";
            this.colPAY_METHOD.Name = "colPAY_METHOD";
            this.colPAY_METHOD.Visible = true;
            this.colPAY_METHOD.VisibleIndex = 55;
            // 
            // colDISC_PCT
            // 
            this.colDISC_PCT.FieldName = "DISC_PCT";
            this.colDISC_PCT.Name = "colDISC_PCT";
            this.colDISC_PCT.Visible = true;
            this.colDISC_PCT.VisibleIndex = 56;
            // 
            // colEXP_SHIP_DATE
            // 
            this.colEXP_SHIP_DATE.FieldName = "EXP_SHIP_DATE";
            this.colEXP_SHIP_DATE.Name = "colEXP_SHIP_DATE";
            this.colEXP_SHIP_DATE.Visible = true;
            this.colEXP_SHIP_DATE.VisibleIndex = 57;
            // 
            // colPREPARE_BY
            // 
            this.colPREPARE_BY.FieldName = "PREPARE_BY";
            this.colPREPARE_BY.Name = "colPREPARE_BY";
            this.colPREPARE_BY.Visible = true;
            this.colPREPARE_BY.VisibleIndex = 58;
            // 
            // colpri_num
            // 
            this.colpri_num.FieldName = "pri_num";
            this.colpri_num.Name = "colpri_num";
            this.colpri_num.Visible = true;
            this.colpri_num.VisibleIndex = 59;
            // 
            // colINVOICE_NO
            // 
            this.colINVOICE_NO.FieldName = "INVOICE_NO";
            this.colINVOICE_NO.Name = "colINVOICE_NO";
            this.colINVOICE_NO.Visible = true;
            this.colINVOICE_NO.VisibleIndex = 60;
            // 
            // colMOP_ID
            // 
            this.colMOP_ID.FieldName = "MOP_ID";
            this.colMOP_ID.Name = "colMOP_ID";
            this.colMOP_ID.Visible = true;
            this.colMOP_ID.VisibleIndex = 61;
            // 
            // colLOCATION
            // 
            this.colLOCATION.FieldName = "LOCATION";
            this.colLOCATION.Name = "colLOCATION";
            this.colLOCATION.Visible = true;
            this.colLOCATION.VisibleIndex = 62;
            // 
            // colCASH_UPDATED
            // 
            this.colCASH_UPDATED.FieldName = "CASH_UPDATED";
            this.colCASH_UPDATED.Name = "colCASH_UPDATED";
            this.colCASH_UPDATED.Visible = true;
            this.colCASH_UPDATED.VisibleIndex = 63;
            // 
            // colWHSE_ID
            // 
            this.colWHSE_ID.FieldName = "WHSE_ID";
            this.colWHSE_ID.Name = "colWHSE_ID";
            this.colWHSE_ID.Visible = true;
            this.colWHSE_ID.VisibleIndex = 64;
            // 
            // colSHIP_TYPE
            // 
            this.colSHIP_TYPE.FieldName = "SHIP_TYPE";
            this.colSHIP_TYPE.Name = "colSHIP_TYPE";
            this.colSHIP_TYPE.Visible = true;
            this.colSHIP_TYPE.VisibleIndex = 65;
            // 
            // colFUTURE_DATE
            // 
            this.colFUTURE_DATE.FieldName = "FUTURE_DATE";
            this.colFUTURE_DATE.Name = "colFUTURE_DATE";
            this.colFUTURE_DATE.Visible = true;
            this.colFUTURE_DATE.VisibleIndex = 66;
            // 
            // colCURRENCY_ID
            // 
            this.colCURRENCY_ID.FieldName = "CURRENCY_ID";
            this.colCURRENCY_ID.Name = "colCURRENCY_ID";
            this.colCURRENCY_ID.Visible = true;
            this.colCURRENCY_ID.VisibleIndex = 67;
            // 
            // colSIC_ID
            // 
            this.colSIC_ID.FieldName = "SIC_ID";
            this.colSIC_ID.Name = "colSIC_ID";
            this.colSIC_ID.Visible = true;
            this.colSIC_ID.VisibleIndex = 68;
            // 
            // colTOTAL_DISCOUNT
            // 
            this.colTOTAL_DISCOUNT.FieldName = "TOTAL_DISCOUNT";
            this.colTOTAL_DISCOUNT.Name = "colTOTAL_DISCOUNT";
            this.colTOTAL_DISCOUNT.Visible = true;
            this.colTOTAL_DISCOUNT.VisibleIndex = 69;
            // 
            // colSO_QUOTE
            // 
            this.colSO_QUOTE.FieldName = "SO_QUOTE";
            this.colSO_QUOTE.Name = "colSO_QUOTE";
            this.colSO_QUOTE.Visible = true;
            this.colSO_QUOTE.VisibleIndex = 70;
            // 
            // colSO_QUOTE_REF
            // 
            this.colSO_QUOTE_REF.FieldName = "SO_QUOTE_REF";
            this.colSO_QUOTE_REF.Name = "colSO_QUOTE_REF";
            this.colSO_QUOTE_REF.Visible = true;
            this.colSO_QUOTE_REF.VisibleIndex = 71;
            // 
            // colLOCKED
            // 
            this.colLOCKED.FieldName = "LOCKED";
            this.colLOCKED.Name = "colLOCKED";
            this.colLOCKED.Visible = true;
            this.colLOCKED.VisibleIndex = 72;
            // 
            // colLOCKED_BY
            // 
            this.colLOCKED_BY.FieldName = "LOCKED_BY";
            this.colLOCKED_BY.Name = "colLOCKED_BY";
            this.colLOCKED_BY.Visible = true;
            this.colLOCKED_BY.VisibleIndex = 73;
            // 
            // colSLS_ID
            // 
            this.colSLS_ID.FieldName = "SLS_ID";
            this.colSLS_ID.Name = "colSLS_ID";
            this.colSLS_ID.Visible = true;
            this.colSLS_ID.VisibleIndex = 74;
            // 
            // colSLS_ID2
            // 
            this.colSLS_ID2.FieldName = "SLS_ID2";
            this.colSLS_ID2.Name = "colSLS_ID2";
            this.colSLS_ID2.Visible = true;
            this.colSLS_ID2.VisibleIndex = 75;
            // 
            // colBR_CUSTOMER_ID
            // 
            this.colBR_CUSTOMER_ID.FieldName = "BR_CUSTOMER_ID";
            this.colBR_CUSTOMER_ID.Name = "colBR_CUSTOMER_ID";
            this.colBR_CUSTOMER_ID.Visible = true;
            this.colBR_CUSTOMER_ID.VisibleIndex = 76;
            // 
            // colCOMM_CNTL_ID1
            // 
            this.colCOMM_CNTL_ID1.FieldName = "COMM_CNTL_ID1";
            this.colCOMM_CNTL_ID1.Name = "colCOMM_CNTL_ID1";
            this.colCOMM_CNTL_ID1.Visible = true;
            this.colCOMM_CNTL_ID1.VisibleIndex = 77;
            // 
            // colCOMM_CNTL_ID2
            // 
            this.colCOMM_CNTL_ID2.FieldName = "COMM_CNTL_ID2";
            this.colCOMM_CNTL_ID2.Name = "colCOMM_CNTL_ID2";
            this.colCOMM_CNTL_ID2.Visible = true;
            this.colCOMM_CNTL_ID2.VisibleIndex = 78;
            // 
            // colPAYMENT_AMOUNT
            // 
            this.colPAYMENT_AMOUNT.FieldName = "PAYMENT_AMOUNT";
            this.colPAYMENT_AMOUNT.Name = "colPAYMENT_AMOUNT";
            this.colPAYMENT_AMOUNT.Visible = true;
            this.colPAYMENT_AMOUNT.VisibleIndex = 79;
            // 
            // colCHANGE_GIVEN
            // 
            this.colCHANGE_GIVEN.FieldName = "CHANGE_GIVEN";
            this.colCHANGE_GIVEN.Name = "colCHANGE_GIVEN";
            this.colCHANGE_GIVEN.Visible = true;
            this.colCHANGE_GIVEN.VisibleIndex = 80;
            // 
            // colSPLIT_COMM
            // 
            this.colSPLIT_COMM.FieldName = "SPLIT_COMM";
            this.colSPLIT_COMM.Name = "colSPLIT_COMM";
            this.colSPLIT_COMM.Visible = true;
            this.colSPLIT_COMM.VisibleIndex = 81;
            // 
            // colPRINTED
            // 
            this.colPRINTED.FieldName = "PRINTED";
            this.colPRINTED.Name = "colPRINTED";
            this.colPRINTED.Visible = true;
            this.colPRINTED.VisibleIndex = 82;
            // 
            // colREV_SHIP_DATE
            // 
            this.colREV_SHIP_DATE.FieldName = "REV_SHIP_DATE";
            this.colREV_SHIP_DATE.Name = "colREV_SHIP_DATE";
            this.colREV_SHIP_DATE.Visible = true;
            this.colREV_SHIP_DATE.VisibleIndex = 83;
            // 
            // colEXTRACT_FLAG
            // 
            this.colEXTRACT_FLAG.FieldName = "EXTRACT_FLAG";
            this.colEXTRACT_FLAG.Name = "colEXTRACT_FLAG";
            this.colEXTRACT_FLAG.Visible = true;
            this.colEXTRACT_FLAG.VisibleIndex = 84;
            // 
            // colEXP_COMMENT
            // 
            this.colEXP_COMMENT.FieldName = "EXP_COMMENT";
            this.colEXP_COMMENT.Name = "colEXP_COMMENT";
            this.colEXP_COMMENT.Visible = true;
            this.colEXP_COMMENT.VisibleIndex = 85;
            // 
            // colCALL_BACK
            // 
            this.colCALL_BACK.FieldName = "CALL_BACK";
            this.colCALL_BACK.Name = "colCALL_BACK";
            this.colCALL_BACK.Visible = true;
            this.colCALL_BACK.VisibleIndex = 86;
            // 
            // colSO_TYPE_ID
            // 
            this.colSO_TYPE_ID.FieldName = "SO_TYPE_ID";
            this.colSO_TYPE_ID.Name = "colSO_TYPE_ID";
            this.colSO_TYPE_ID.Visible = true;
            this.colSO_TYPE_ID.VisibleIndex = 87;
            // 
            // colORDER_APPROVED
            // 
            this.colORDER_APPROVED.FieldName = "ORDER_APPROVED";
            this.colORDER_APPROVED.Name = "colORDER_APPROVED";
            this.colORDER_APPROVED.Visible = true;
            this.colORDER_APPROVED.VisibleIndex = 88;
            // 
            // colAUTHORIZED_BY
            // 
            this.colAUTHORIZED_BY.FieldName = "AUTHORIZED_BY";
            this.colAUTHORIZED_BY.Name = "colAUTHORIZED_BY";
            this.colAUTHORIZED_BY.Visible = true;
            this.colAUTHORIZED_BY.VisibleIndex = 89;
            // 
            // colAUTHORIZED_DATE
            // 
            this.colAUTHORIZED_DATE.FieldName = "AUTHORIZED_DATE";
            this.colAUTHORIZED_DATE.Name = "colAUTHORIZED_DATE";
            this.colAUTHORIZED_DATE.Visible = true;
            this.colAUTHORIZED_DATE.VisibleIndex = 90;
            // 
            // colAUTHORIZED_AMOUNT
            // 
            this.colAUTHORIZED_AMOUNT.FieldName = "AUTHORIZED_AMOUNT";
            this.colAUTHORIZED_AMOUNT.Name = "colAUTHORIZED_AMOUNT";
            this.colAUTHORIZED_AMOUNT.Visible = true;
            this.colAUTHORIZED_AMOUNT.VisibleIndex = 91;
            // 
            // colSCHEDULED_QUOTE
            // 
            this.colSCHEDULED_QUOTE.FieldName = "SCHEDULED_QUOTE";
            this.colSCHEDULED_QUOTE.Name = "colSCHEDULED_QUOTE";
            this.colSCHEDULED_QUOTE.Visible = true;
            this.colSCHEDULED_QUOTE.VisibleIndex = 92;
            // 
            // colPAYMENT_APPLIED
            // 
            this.colPAYMENT_APPLIED.FieldName = "PAYMENT_APPLIED";
            this.colPAYMENT_APPLIED.Name = "colPAYMENT_APPLIED";
            this.colPAYMENT_APPLIED.Visible = true;
            this.colPAYMENT_APPLIED.VisibleIndex = 93;
            // 
            // colDEPOSIT_APPLIED
            // 
            this.colDEPOSIT_APPLIED.FieldName = "DEPOSIT_APPLIED";
            this.colDEPOSIT_APPLIED.Name = "colDEPOSIT_APPLIED";
            this.colDEPOSIT_APPLIED.Visible = true;
            this.colDEPOSIT_APPLIED.VisibleIndex = 94;
            // 
            // colDEPOSIT_AMOUNT
            // 
            this.colDEPOSIT_AMOUNT.FieldName = "DEPOSIT_AMOUNT";
            this.colDEPOSIT_AMOUNT.Name = "colDEPOSIT_AMOUNT";
            this.colDEPOSIT_AMOUNT.Visible = true;
            this.colDEPOSIT_AMOUNT.VisibleIndex = 95;
            // 
            // colDEPOSIT_UPDATED
            // 
            this.colDEPOSIT_UPDATED.FieldName = "DEPOSIT_UPDATED";
            this.colDEPOSIT_UPDATED.Name = "colDEPOSIT_UPDATED";
            this.colDEPOSIT_UPDATED.Visible = true;
            this.colDEPOSIT_UPDATED.VisibleIndex = 96;
            // 
            // colDELIVERY
            // 
            this.colDELIVERY.FieldName = "DELIVERY";
            this.colDELIVERY.Name = "colDELIVERY";
            this.colDELIVERY.Visible = true;
            this.colDELIVERY.VisibleIndex = 97;
            // 
            // colRETURN_FLAG
            // 
            this.colRETURN_FLAG.FieldName = "RETURN_FLAG";
            this.colRETURN_FLAG.Name = "colRETURN_FLAG";
            this.colRETURN_FLAG.Visible = true;
            this.colRETURN_FLAG.VisibleIndex = 98;
            // 
            // colSO_TRN_ID
            // 
            this.colSO_TRN_ID.FieldName = "SO_TRN_ID";
            this.colSO_TRN_ID.Name = "colSO_TRN_ID";
            this.colSO_TRN_ID.Visible = true;
            this.colSO_TRN_ID.VisibleIndex = 99;
            // 
            // colDELIVERY_CHARGE
            // 
            this.colDELIVERY_CHARGE.FieldName = "DELIVERY_CHARGE";
            this.colDELIVERY_CHARGE.Name = "colDELIVERY_CHARGE";
            this.colDELIVERY_CHARGE.Visible = true;
            this.colDELIVERY_CHARGE.VisibleIndex = 100;
            // 
            // colRESTOCKING_CHARGE
            // 
            this.colRESTOCKING_CHARGE.FieldName = "RESTOCKING_CHARGE";
            this.colRESTOCKING_CHARGE.Name = "colRESTOCKING_CHARGE";
            this.colRESTOCKING_CHARGE.Visible = true;
            this.colRESTOCKING_CHARGE.VisibleIndex = 101;
            // 
            // colRESTOCKING_PCT
            // 
            this.colRESTOCKING_PCT.FieldName = "RESTOCKING_PCT";
            this.colRESTOCKING_PCT.Name = "colRESTOCKING_PCT";
            this.colRESTOCKING_PCT.Visible = true;
            this.colRESTOCKING_PCT.VisibleIndex = 102;
            // 
            // colSO_DIV
            // 
            this.colSO_DIV.FieldName = "SO_DIV";
            this.colSO_DIV.Name = "colSO_DIV";
            this.colSO_DIV.Visible = true;
            this.colSO_DIV.VisibleIndex = 103;
            // 
            // colAR_SETUP_GL_ID
            // 
            this.colAR_SETUP_GL_ID.FieldName = "AR_SETUP_GL_ID";
            this.colAR_SETUP_GL_ID.Name = "colAR_SETUP_GL_ID";
            this.colAR_SETUP_GL_ID.Visible = true;
            this.colAR_SETUP_GL_ID.VisibleIndex = 104;
            // 
            // colPRICE_CODE_ID
            // 
            this.colPRICE_CODE_ID.FieldName = "PRICE_CODE_ID";
            this.colPRICE_CODE_ID.Name = "colPRICE_CODE_ID";
            this.colPRICE_CODE_ID.Visible = true;
            this.colPRICE_CODE_ID.VisibleIndex = 105;
            // 
            // colPRINT_CNT
            // 
            this.colPRINT_CNT.FieldName = "PRINT_CNT";
            this.colPRINT_CNT.Name = "colPRINT_CNT";
            this.colPRINT_CNT.Visible = true;
            this.colPRINT_CNT.VisibleIndex = 106;
            // 
            // colCREDIT_REF
            // 
            this.colCREDIT_REF.FieldName = "CREDIT_REF";
            this.colCREDIT_REF.Name = "colCREDIT_REF";
            this.colCREDIT_REF.Visible = true;
            this.colCREDIT_REF.VisibleIndex = 107;
            // 
            // colCOMMENT
            // 
            this.colCOMMENT.FieldName = "COMMENT";
            this.colCOMMENT.Name = "colCOMMENT";
            this.colCOMMENT.Visible = true;
            this.colCOMMENT.VisibleIndex = 108;
            // 
            // colCOMMENT_INT
            // 
            this.colCOMMENT_INT.FieldName = "COMMENT_INT";
            this.colCOMMENT_INT.Name = "colCOMMENT_INT";
            this.colCOMMENT_INT.Visible = true;
            this.colCOMMENT_INT.VisibleIndex = 109;
            // 
            // colMEMO
            // 
            this.colMEMO.FieldName = "MEMO";
            this.colMEMO.Name = "colMEMO";
            this.colMEMO.Visible = true;
            this.colMEMO.VisibleIndex = 110;
            // 
            // colFOOTER_COMMENT
            // 
            this.colFOOTER_COMMENT.FieldName = "FOOTER_COMMENT";
            this.colFOOTER_COMMENT.Name = "colFOOTER_COMMENT";
            this.colFOOTER_COMMENT.Visible = true;
            this.colFOOTER_COMMENT.VisibleIndex = 111;
            // 
            // colWMS_STATUS
            // 
            this.colWMS_STATUS.FieldName = "WMS_STATUS";
            this.colWMS_STATUS.Name = "colWMS_STATUS";
            this.colWMS_STATUS.Visible = true;
            this.colWMS_STATUS.VisibleIndex = 112;
            // 
            // colWMS_MESSAGE
            // 
            this.colWMS_MESSAGE.FieldName = "WMS_MESSAGE";
            this.colWMS_MESSAGE.Name = "colWMS_MESSAGE";
            this.colWMS_MESSAGE.Visible = true;
            this.colWMS_MESSAGE.VisibleIndex = 113;
            // 
            // colMTR_REQUIRED
            // 
            this.colMTR_REQUIRED.FieldName = "MTR_REQUIRED";
            this.colMTR_REQUIRED.Name = "colMTR_REQUIRED";
            this.colMTR_REQUIRED.Visible = true;
            this.colMTR_REQUIRED.VisibleIndex = 114;
            // 
            // colMETRIC_ORDER
            // 
            this.colMETRIC_ORDER.FieldName = "METRIC_ORDER";
            this.colMETRIC_ORDER.Name = "colMETRIC_ORDER";
            this.colMETRIC_ORDER.Visible = true;
            this.colMETRIC_ORDER.VisibleIndex = 115;
            // 
            // colWMS_ORDER_SEQ
            // 
            this.colWMS_ORDER_SEQ.FieldName = "WMS_ORDER_SEQ";
            this.colWMS_ORDER_SEQ.Name = "colWMS_ORDER_SEQ";
            this.colWMS_ORDER_SEQ.Visible = true;
            this.colWMS_ORDER_SEQ.VisibleIndex = 116;
            // 
            // colSHIP_NO
            // 
            this.colSHIP_NO.FieldName = "SHIP_NO";
            this.colSHIP_NO.Name = "colSHIP_NO";
            this.colSHIP_NO.Visible = true;
            this.colSHIP_NO.VisibleIndex = 117;
            // 
            // colTOTAL_WEIGHT
            // 
            this.colTOTAL_WEIGHT.FieldName = "TOTAL_WEIGHT";
            this.colTOTAL_WEIGHT.Name = "colTOTAL_WEIGHT";
            this.colTOTAL_WEIGHT.Visible = true;
            this.colTOTAL_WEIGHT.VisibleIndex = 118;
            // 
            // colEXT_REFERENCE
            // 
            this.colEXT_REFERENCE.FieldName = "EXT_REFERENCE";
            this.colEXT_REFERENCE.Name = "colEXT_REFERENCE";
            this.colEXT_REFERENCE.Visible = true;
            this.colEXT_REFERENCE.VisibleIndex = 119;
            // 
            // colLSD_NUMBER
            // 
            this.colLSD_NUMBER.FieldName = "LSD_NUMBER";
            this.colLSD_NUMBER.Name = "colLSD_NUMBER";
            this.colLSD_NUMBER.Visible = true;
            this.colLSD_NUMBER.VisibleIndex = 120;
            // 
            // colORDERED_BY
            // 
            this.colORDERED_BY.FieldName = "ORDERED_BY";
            this.colORDERED_BY.Name = "colORDERED_BY";
            this.colORDERED_BY.Visible = true;
            this.colORDERED_BY.VisibleIndex = 121;
            // 
            // colFOB_DESC
            // 
            this.colFOB_DESC.FieldName = "FOB_DESC";
            this.colFOB_DESC.Name = "colFOB_DESC";
            this.colFOB_DESC.Visible = true;
            this.colFOB_DESC.VisibleIndex = 122;
            // 
            // colinstaller_id
            // 
            this.colinstaller_id.FieldName = "installer_id";
            this.colinstaller_id.Name = "colinstaller_id";
            this.colinstaller_id.Visible = true;
            this.colinstaller_id.VisibleIndex = 123;
            // 
            // colAD_CODE_ID
            // 
            this.colAD_CODE_ID.FieldName = "AD_CODE_ID";
            this.colAD_CODE_ID.Name = "colAD_CODE_ID";
            this.colAD_CODE_ID.Visible = true;
            this.colAD_CODE_ID.VisibleIndex = 124;
            // 
            // colMOBILE_ADDRESS
            // 
            this.colMOBILE_ADDRESS.FieldName = "MOBILE_ADDRESS";
            this.colMOBILE_ADDRESS.Name = "colMOBILE_ADDRESS";
            this.colMOBILE_ADDRESS.Visible = true;
            this.colMOBILE_ADDRESS.VisibleIndex = 125;
            // 
            // colPRINT_PRICES
            // 
            this.colPRINT_PRICES.FieldName = "PRINT_PRICES";
            this.colPRINT_PRICES.Name = "colPRINT_PRICES";
            this.colPRINT_PRICES.Visible = true;
            this.colPRINT_PRICES.VisibleIndex = 126;
            // 
            // colBUY_RCVD
            // 
            this.colBUY_RCVD.FieldName = "BUY_RCVD";
            this.colBUY_RCVD.Name = "colBUY_RCVD";
            this.colBUY_RCVD.Visible = true;
            this.colBUY_RCVD.VisibleIndex = 127;
            // 
            // colHAS_PIPE
            // 
            this.colHAS_PIPE.FieldName = "HAS_PIPE";
            this.colHAS_PIPE.Name = "colHAS_PIPE";
            this.colHAS_PIPE.Visible = true;
            this.colHAS_PIPE.VisibleIndex = 128;
            // 
            // colREVIEWED
            // 
            this.colREVIEWED.FieldName = "REVIEWED";
            this.colREVIEWED.Name = "colREVIEWED";
            this.colREVIEWED.Visible = true;
            this.colREVIEWED.VisibleIndex = 129;
            // 
            // colREQUIRED_BY
            // 
            this.colREQUIRED_BY.FieldName = "REQUIRED_BY";
            this.colREQUIRED_BY.Name = "colREQUIRED_BY";
            this.colREQUIRED_BY.Visible = true;
            this.colREQUIRED_BY.VisibleIndex = 130;
            // 
            // colEXCEPTION_ORDER
            // 
            this.colEXCEPTION_ORDER.FieldName = "EXCEPTION_ORDER";
            this.colEXCEPTION_ORDER.Name = "colEXCEPTION_ORDER";
            this.colEXCEPTION_ORDER.Visible = true;
            this.colEXCEPTION_ORDER.VisibleIndex = 131;
            // 
            // colTAGGING
            // 
            this.colTAGGING.FieldName = "TAGGING";
            this.colTAGGING.Name = "colTAGGING";
            this.colTAGGING.Visible = true;
            this.colTAGGING.VisibleIndex = 132;
            // 
            // colPO_RELEASE_NO
            // 
            this.colPO_RELEASE_NO.FieldName = "PO_RELEASE_NO";
            this.colPO_RELEASE_NO.Name = "colPO_RELEASE_NO";
            this.colPO_RELEASE_NO.Visible = true;
            this.colPO_RELEASE_NO.VisibleIndex = 133;
            // 
            // colMTR_STATUS
            // 
            this.colMTR_STATUS.FieldName = "MTR_STATUS";
            this.colMTR_STATUS.Name = "colMTR_STATUS";
            this.colMTR_STATUS.Visible = true;
            this.colMTR_STATUS.VisibleIndex = 134;
            // 
            // colmarsallingOrdType
            // 
            this.colmarsallingOrdType.FieldName = "marsallingOrdType";
            this.colmarsallingOrdType.Name = "colmarsallingOrdType";
            this.colmarsallingOrdType.Visible = true;
            this.colmarsallingOrdType.VisibleIndex = 135;
            // 
            // colWMS_STATUS_PIPE
            // 
            this.colWMS_STATUS_PIPE.FieldName = "WMS_STATUS_PIPE";
            this.colWMS_STATUS_PIPE.Name = "colWMS_STATUS_PIPE";
            this.colWMS_STATUS_PIPE.Visible = true;
            this.colWMS_STATUS_PIPE.VisibleIndex = 136;
            // 
            // colWMS_MESSAGE_PIPE
            // 
            this.colWMS_MESSAGE_PIPE.FieldName = "WMS_MESSAGE_PIPE";
            this.colWMS_MESSAGE_PIPE.Name = "colWMS_MESSAGE_PIPE";
            this.colWMS_MESSAGE_PIPE.Visible = true;
            this.colWMS_MESSAGE_PIPE.VisibleIndex = 137;
            // 
            // colPRE_APPROVAL_AMT
            // 
            this.colPRE_APPROVAL_AMT.FieldName = "PRE_APPROVAL_AMT";
            this.colPRE_APPROVAL_AMT.Name = "colPRE_APPROVAL_AMT";
            this.colPRE_APPROVAL_AMT.Visible = true;
            this.colPRE_APPROVAL_AMT.VisibleIndex = 138;
            // 
            // colPOST_APPROVAL_AMT
            // 
            this.colPOST_APPROVAL_AMT.FieldName = "POST_APPROVAL_AMT";
            this.colPOST_APPROVAL_AMT.Name = "colPOST_APPROVAL_AMT";
            this.colPOST_APPROVAL_AMT.Visible = true;
            this.colPOST_APPROVAL_AMT.VisibleIndex = 139;
            // 
            // colKC_STATUS
            // 
            this.colKC_STATUS.FieldName = "KC_STATUS";
            this.colKC_STATUS.Name = "colKC_STATUS";
            this.colKC_STATUS.Visible = true;
            this.colKC_STATUS.VisibleIndex = 140;
            // 
            // colAPPROVAL_REQ_ID
            // 
            this.colAPPROVAL_REQ_ID.FieldName = "APPROVAL_REQ_ID";
            this.colAPPROVAL_REQ_ID.Name = "colAPPROVAL_REQ_ID";
            this.colAPPROVAL_REQ_ID.Visible = true;
            this.colAPPROVAL_REQ_ID.VisibleIndex = 141;
            // 
            // colDirectShip
            // 
            this.colDirectShip.FieldName = "DirectShip";
            this.colDirectShip.Name = "colDirectShip";
            this.colDirectShip.Visible = true;
            this.colDirectShip.VisibleIndex = 142;
            // 
            // colPONO2
            // 
            this.colPONO2.FieldName = "PONO2";
            this.colPONO2.Name = "colPONO2";
            this.colPONO2.Visible = true;
            this.colPONO2.VisibleIndex = 143;
            // 
            // colCUST_RFQ
            // 
            this.colCUST_RFQ.FieldName = "CUST_RFQ";
            this.colCUST_RFQ.Name = "colCUST_RFQ";
            this.colCUST_RFQ.Visible = true;
            this.colCUST_RFQ.VisibleIndex = 144;
            // 
            // colconvert_count
            // 
            this.colconvert_count.FieldName = "convert_count";
            this.colconvert_count.Name = "colconvert_count";
            this.colconvert_count.Visible = true;
            this.colconvert_count.VisibleIndex = 145;
            // 
            // colKC_GMStatus
            // 
            this.colKC_GMStatus.FieldName = "KC_GMStatus";
            this.colKC_GMStatus.Name = "colKC_GMStatus";
            this.colKC_GMStatus.Visible = true;
            this.colKC_GMStatus.VisibleIndex = 146;
            // 
            // colKC_GM_RequestID
            // 
            this.colKC_GM_RequestID.FieldName = "KC_GM_RequestID";
            this.colKC_GM_RequestID.Name = "colKC_GM_RequestID";
            this.colKC_GM_RequestID.Visible = true;
            this.colKC_GM_RequestID.VisibleIndex = 147;
            // 
            // colPICK_SLIP_PRINT_COUNT
            // 
            this.colPICK_SLIP_PRINT_COUNT.FieldName = "PICK_SLIP_PRINT_COUNT";
            this.colPICK_SLIP_PRINT_COUNT.Name = "colPICK_SLIP_PRINT_COUNT";
            this.colPICK_SLIP_PRINT_COUNT.Visible = true;
            this.colPICK_SLIP_PRINT_COUNT.VisibleIndex = 148;
            // 
            // colAttentionRequired
            // 
            this.colAttentionRequired.FieldName = "AttentionRequired";
            this.colAttentionRequired.Name = "colAttentionRequired";
            this.colAttentionRequired.Visible = true;
            this.colAttentionRequired.VisibleIndex = 149;
            // 
            // colB2B_Notes
            // 
            this.colB2B_Notes.FieldName = "B2B_Notes";
            this.colB2B_Notes.Name = "colB2B_Notes";
            this.colB2B_Notes.Visible = true;
            this.colB2B_Notes.VisibleIndex = 150;
            // 
            // colBUY_RCVD_PIPE
            // 
            this.colBUY_RCVD_PIPE.FieldName = "BUY_RCVD_PIPE";
            this.colBUY_RCVD_PIPE.Name = "colBUY_RCVD_PIPE";
            this.colBUY_RCVD_PIPE.Visible = true;
            this.colBUY_RCVD_PIPE.VisibleIndex = 151;
            // 
            // colSubStatus
            // 
            this.colSubStatus.FieldName = "SubStatus";
            this.colSubStatus.Name = "colSubStatus";
            this.colSubStatus.Visible = true;
            this.colSubStatus.VisibleIndex = 152;
            // 
            // colB2B_ID
            // 
            this.colB2B_ID.FieldName = "B2B_ID";
            this.colB2B_ID.Name = "colB2B_ID";
            this.colB2B_ID.Visible = true;
            this.colB2B_ID.VisibleIndex = 153;
            // 
            // colShipInProcess
            // 
            this.colShipInProcess.FieldName = "ShipInProcess";
            this.colShipInProcess.Name = "colShipInProcess";
            this.colShipInProcess.Visible = true;
            this.colShipInProcess.VisibleIndex = 154;
            // 
            // colLinkDescription
            // 
            this.colLinkDescription.FieldName = "LinkDescription";
            this.colLinkDescription.Name = "colLinkDescription";
            this.colLinkDescription.Visible = true;
            this.colLinkDescription.VisibleIndex = 155;
            // 
            // colBuildReference_ID
            // 
            this.colBuildReference_ID.FieldName = "BuildReference_ID";
            this.colBuildReference_ID.Name = "colBuildReference_ID";
            this.colBuildReference_ID.Visible = true;
            this.colBuildReference_ID.VisibleIndex = 156;
            // 
            // colBuildReferenceCompany_ID
            // 
            this.colBuildReferenceCompany_ID.FieldName = "BuildReferenceCompany_ID";
            this.colBuildReferenceCompany_ID.Name = "colBuildReferenceCompany_ID";
            this.colBuildReferenceCompany_ID.Visible = true;
            this.colBuildReferenceCompany_ID.VisibleIndex = 157;
            // 
            // colCreditRemaining
            // 
            this.colCreditRemaining.FieldName = "CreditRemaining";
            this.colCreditRemaining.Name = "colCreditRemaining";
            this.colCreditRemaining.Visible = true;
            this.colCreditRemaining.VisibleIndex = 158;
            // 
            // colCreditUsed
            // 
            this.colCreditUsed.FieldName = "CreditUsed";
            this.colCreditUsed.Name = "colCreditUsed";
            this.colCreditUsed.Visible = true;
            this.colCreditUsed.VisibleIndex = 159;
            // 
            // colCreditLimit
            // 
            this.colCreditLimit.FieldName = "CreditLimit";
            this.colCreditLimit.Name = "colCreditLimit";
            this.colCreditLimit.Visible = true;
            this.colCreditLimit.VisibleIndex = 160;
            // 
            // colCashSalePaid
            // 
            this.colCashSalePaid.FieldName = "CashSalePaid";
            this.colCashSalePaid.Name = "colCashSalePaid";
            this.colCashSalePaid.Visible = true;
            this.colCashSalePaid.VisibleIndex = 161;
            // 
            // colSLS_ID3
            // 
            this.colSLS_ID3.FieldName = "SLS_ID3";
            this.colSLS_ID3.Name = "colSLS_ID3";
            this.colSLS_ID3.Visible = true;
            this.colSLS_ID3.VisibleIndex = 162;
            // 
            // colSLS_ID4
            // 
            this.colSLS_ID4.FieldName = "SLS_ID4";
            this.colSLS_ID4.Name = "colSLS_ID4";
            this.colSLS_ID4.Visible = true;
            this.colSLS_ID4.VisibleIndex = 163;
            // 
            // colOUT_PCT2
            // 
            this.colOUT_PCT2.FieldName = "OUT_PCT2";
            this.colOUT_PCT2.Name = "colOUT_PCT2";
            this.colOUT_PCT2.Visible = true;
            this.colOUT_PCT2.VisibleIndex = 164;
            // 
            // colOUT_PCT3
            // 
            this.colOUT_PCT3.FieldName = "OUT_PCT3";
            this.colOUT_PCT3.Name = "colOUT_PCT3";
            this.colOUT_PCT3.Visible = true;
            this.colOUT_PCT3.VisibleIndex = 165;
            // 
            // colOE_Priority_ID
            // 
            this.colOE_Priority_ID.FieldName = "OE_Priority_ID";
            this.colOE_Priority_ID.Name = "colOE_Priority_ID";
            this.colOE_Priority_ID.Visible = true;
            this.colOE_Priority_ID.VisibleIndex = 166;
            // 
            // colcons_method_id
            // 
            this.colcons_method_id.FieldName = "cons_method_id";
            this.colcons_method_id.Name = "colcons_method_id";
            this.colcons_method_id.Visible = true;
            this.colcons_method_id.VisibleIndex = 167;
            // 
            // colcons_frequency_id
            // 
            this.colcons_frequency_id.FieldName = "cons_frequency_id";
            this.colcons_frequency_id.Name = "colcons_frequency_id";
            this.colcons_frequency_id.Visible = true;
            this.colcons_frequency_id.VisibleIndex = 168;
            // 
            // colCONSOLIDATE_INVOICES
            // 
            this.colCONSOLIDATE_INVOICES.FieldName = "CONSOLIDATE_INVOICES";
            this.colCONSOLIDATE_INVOICES.Name = "colCONSOLIDATE_INVOICES";
            this.colCONSOLIDATE_INVOICES.Visible = true;
            this.colCONSOLIDATE_INVOICES.VisibleIndex = 169;
            // 
            // colCommissionsPaid
            // 
            this.colCommissionsPaid.FieldName = "CommissionsPaid";
            this.colCommissionsPaid.Name = "colCommissionsPaid";
            this.colCommissionsPaid.Visible = true;
            this.colCommissionsPaid.VisibleIndex = 170;
            // 
            // colCompletionDate
            // 
            this.colCompletionDate.FieldName = "CompletionDate";
            this.colCompletionDate.Name = "colCompletionDate";
            this.colCompletionDate.Visible = true;
            this.colCompletionDate.VisibleIndex = 171;
            // 
            // colPickSlipPrinted
            // 
            this.colPickSlipPrinted.FieldName = "PickSlipPrinted";
            this.colPickSlipPrinted.Name = "colPickSlipPrinted";
            this.colPickSlipPrinted.Visible = true;
            this.colPickSlipPrinted.VisibleIndex = 172;
            // 
            // colPickSlipPrinted_pipe
            // 
            this.colPickSlipPrinted_pipe.FieldName = "PickSlipPrinted_pipe";
            this.colPickSlipPrinted_pipe.Name = "colPickSlipPrinted_pipe";
            this.colPickSlipPrinted_pipe.Visible = true;
            this.colPickSlipPrinted_pipe.VisibleIndex = 173;
            // 
            // colKC_RoutedApproval_Req_ID
            // 
            this.colKC_RoutedApproval_Req_ID.FieldName = "KC_RoutedApproval_Req_ID";
            this.colKC_RoutedApproval_Req_ID.Name = "colKC_RoutedApproval_Req_ID";
            this.colKC_RoutedApproval_Req_ID.Visible = true;
            this.colKC_RoutedApproval_Req_ID.VisibleIndex = 174;
            // 
            // colKC_RoutedForTraining
            // 
            this.colKC_RoutedForTraining.FieldName = "KC_RoutedForTraining";
            this.colKC_RoutedForTraining.Name = "colKC_RoutedForTraining";
            this.colKC_RoutedForTraining.Visible = true;
            this.colKC_RoutedForTraining.VisibleIndex = 175;
            // 
            // colKC_RoutedForCreditDays
            // 
            this.colKC_RoutedForCreditDays.FieldName = "KC_RoutedForCreditDays";
            this.colKC_RoutedForCreditDays.Name = "colKC_RoutedForCreditDays";
            this.colKC_RoutedForCreditDays.Visible = true;
            this.colKC_RoutedForCreditDays.VisibleIndex = 176;
            // 
            // colKC_RoutedForCreditDays_Req_ID
            // 
            this.colKC_RoutedForCreditDays_Req_ID.FieldName = "KC_RoutedForCreditDays_Req_ID";
            this.colKC_RoutedForCreditDays_Req_ID.Name = "colKC_RoutedForCreditDays_Req_ID";
            this.colKC_RoutedForCreditDays_Req_ID.Visible = true;
            this.colKC_RoutedForCreditDays_Req_ID.VisibleIndex = 177;
            // 
            // colManualQuote
            // 
            this.colManualQuote.FieldName = "ManualQuote";
            this.colManualQuote.Name = "colManualQuote";
            this.colManualQuote.Visible = true;
            this.colManualQuote.VisibleIndex = 178;
            // 
            // colRM_Opportunity_ID
            // 
            this.colRM_Opportunity_ID.FieldName = "RM_Opportunity_ID";
            this.colRM_Opportunity_ID.Name = "colRM_Opportunity_ID";
            this.colRM_Opportunity_ID.Visible = true;
            this.colRM_Opportunity_ID.VisibleIndex = 179;
            // 
            // colProbablityPct
            // 
            this.colProbablityPct.FieldName = "ProbablityPct";
            this.colProbablityPct.Name = "colProbablityPct";
            this.colProbablityPct.Visible = true;
            this.colProbablityPct.VisibleIndex = 180;
            // 
            // colSUPPLY_AND_INSTALL
            // 
            this.colSUPPLY_AND_INSTALL.FieldName = "SUPPLY_AND_INSTALL";
            this.colSUPPLY_AND_INSTALL.Name = "colSUPPLY_AND_INSTALL";
            this.colSUPPLY_AND_INSTALL.Visible = true;
            this.colSUPPLY_AND_INSTALL.VisibleIndex = 181;
            // 
            // colQuoteValidityID
            // 
            this.colQuoteValidityID.FieldName = "QuoteValidityID";
            this.colQuoteValidityID.Name = "colQuoteValidityID";
            this.colQuoteValidityID.Visible = true;
            this.colQuoteValidityID.VisibleIndex = 182;
            // 
            // colQuoteRoutingStatus
            // 
            this.colQuoteRoutingStatus.FieldName = "QuoteRoutingStatus";
            this.colQuoteRoutingStatus.Name = "colQuoteRoutingStatus";
            this.colQuoteRoutingStatus.Visible = true;
            this.colQuoteRoutingStatus.VisibleIndex = 183;
            // 
            // colQuoteRoutingStatusID
            // 
            this.colQuoteRoutingStatusID.FieldName = "QuoteRoutingStatusID";
            this.colQuoteRoutingStatusID.Name = "colQuoteRoutingStatusID";
            this.colQuoteRoutingStatusID.Visible = true;
            this.colQuoteRoutingStatusID.VisibleIndex = 184;
            // 
            // colBaseFolder
            // 
            this.colBaseFolder.FieldName = "BaseFolder";
            this.colBaseFolder.Name = "colBaseFolder";
            this.colBaseFolder.Visible = true;
            this.colBaseFolder.VisibleIndex = 185;
            // 
            // colEndConsumer
            // 
            this.colEndConsumer.FieldName = "EndConsumer";
            this.colEndConsumer.Name = "colEndConsumer";
            this.colEndConsumer.Visible = true;
            this.colEndConsumer.VisibleIndex = 186;
            // 
            // colREV_NO
            // 
            this.colREV_NO.FieldName = "REV_NO";
            this.colREV_NO.Name = "colREV_NO";
            this.colREV_NO.Visible = true;
            this.colREV_NO.VisibleIndex = 187;
            // 
            // colReleaseToDrafting
            // 
            this.colReleaseToDrafting.FieldName = "ReleaseToDrafting";
            this.colReleaseToDrafting.Name = "colReleaseToDrafting";
            this.colReleaseToDrafting.Visible = true;
            this.colReleaseToDrafting.VisibleIndex = 188;
            // 
            // colCUST_REF
            // 
            this.colCUST_REF.FieldName = "CUST_REF";
            this.colCUST_REF.Name = "colCUST_REF";
            this.colCUST_REF.Visible = true;
            this.colCUST_REF.VisibleIndex = 189;
            // 
            // colBillingType
            // 
            this.colBillingType.FieldName = "BillingType";
            this.colBillingType.Name = "colBillingType";
            this.colBillingType.Visible = true;
            this.colBillingType.VisibleIndex = 190;
            // 
            // colBillingComplete
            // 
            this.colBillingComplete.FieldName = "BillingComplete";
            this.colBillingComplete.Name = "colBillingComplete";
            this.colBillingComplete.Visible = true;
            this.colBillingComplete.VisibleIndex = 191;
            // 
            // colLockID
            // 
            this.colLockID.FieldName = "LockID";
            this.colLockID.Name = "colLockID";
            this.colLockID.Visible = true;
            this.colLockID.VisibleIndex = 192;
            // 
            // colBILL_TO_TELEPHONE
            // 
            this.colBILL_TO_TELEPHONE.FieldName = "BILL_TO_TELEPHONE";
            this.colBILL_TO_TELEPHONE.Name = "colBILL_TO_TELEPHONE";
            this.colBILL_TO_TELEPHONE.Visible = true;
            this.colBILL_TO_TELEPHONE.VisibleIndex = 193;
            // 
            // colBILL_TO_FAX
            // 
            this.colBILL_TO_FAX.FieldName = "BILL_TO_FAX";
            this.colBILL_TO_FAX.Name = "colBILL_TO_FAX";
            this.colBILL_TO_FAX.Visible = true;
            this.colBILL_TO_FAX.VisibleIndex = 194;
            // 
            // colPRE_APPROVED_AMT
            // 
            this.colPRE_APPROVED_AMT.FieldName = "PRE_APPROVED_AMT";
            this.colPRE_APPROVED_AMT.Name = "colPRE_APPROVED_AMT";
            this.colPRE_APPROVED_AMT.Visible = true;
            this.colPRE_APPROVED_AMT.VisibleIndex = 195;
            // 
            // colReleaseShipHold
            // 
            this.colReleaseShipHold.FieldName = "ReleaseShipHold";
            this.colReleaseShipHold.Name = "colReleaseShipHold";
            this.colReleaseShipHold.Visible = true;
            this.colReleaseShipHold.VisibleIndex = 196;
            // 
            // colEndConsumer_Customer_ID
            // 
            this.colEndConsumer_Customer_ID.FieldName = "EndConsumer_Customer_ID";
            this.colEndConsumer_Customer_ID.Name = "colEndConsumer_Customer_ID";
            this.colEndConsumer_Customer_ID.Visible = true;
            this.colEndConsumer_Customer_ID.VisibleIndex = 197;
            // 
            // colEndConsumer_ContactID
            // 
            this.colEndConsumer_ContactID.FieldName = "EndConsumer_ContactID";
            this.colEndConsumer_ContactID.Name = "colEndConsumer_ContactID";
            this.colEndConsumer_ContactID.Visible = true;
            this.colEndConsumer_ContactID.VisibleIndex = 198;
            // 
            // colReferencedSO
            // 
            this.colReferencedSO.FieldName = "ReferencedSO";
            this.colReferencedSO.Name = "colReferencedSO";
            this.colReferencedSO.Visible = true;
            this.colReferencedSO.VisibleIndex = 199;
            // 
            // colQuoteSent
            // 
            this.colQuoteSent.FieldName = "QuoteSent";
            this.colQuoteSent.Name = "colQuoteSent";
            this.colQuoteSent.Visible = true;
            this.colQuoteSent.VisibleIndex = 200;
            // 
            // colConfirmationSent
            // 
            this.colConfirmationSent.FieldName = "ConfirmationSent";
            this.colConfirmationSent.Name = "colConfirmationSent";
            this.colConfirmationSent.Visible = true;
            this.colConfirmationSent.VisibleIndex = 201;
            // 
            // colSO_Class_ID
            // 
            this.colSO_Class_ID.FieldName = "SO_Class_ID";
            this.colSO_Class_ID.Name = "colSO_Class_ID";
            this.colSO_Class_ID.Visible = true;
            this.colSO_Class_ID.VisibleIndex = 202;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_so_master_hdr1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlDataAdapter da_so_master_hdr;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ds_so_master_hdr ds_so_master_hdr1;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_PREFIX;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colQUOTE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOMER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPONO;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATOR_SAVED;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_SAVED;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATOR_LAST_MODIFIED;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_LAST_MODIFIED;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colHOLD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPLETE;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_HOLD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATOR_HOLD;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_HOLD;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATOR_RELEASED;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_RELEASED;
        private DevExpress.XtraGrid.Columns.GridColumn colTAX_EXEMPT;
        private DevExpress.XtraGrid.Columns.GridColumn colTAX_EXEMPT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBILLING_ADDR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_ADD_1;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_ADD_2;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_ADD_3;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_CITY;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_ZIP;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_COUNTRY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_COUNTRY_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACT_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_METHOD;
        private DevExpress.XtraGrid.Columns.GridColumn colTERMS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_USER_DEF1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_USER_DEF2;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMO_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_CANCEL;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERATOR_CANCEL;
        private DevExpress.XtraGrid.Columns.GridColumn colCANCEL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_INTERNAL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGST_FLAG;
        private DevExpress.XtraGrid.Columns.GridColumn colIN_PCT;
        private DevExpress.XtraGrid.Columns.GridColumn colOUT_PCT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_PCT;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_COMM;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_COMM;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_PROD;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_TAX;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_GST;
        private DevExpress.XtraGrid.Columns.GridColumn colNEXT_PO_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCASH;
        private DevExpress.XtraGrid.Columns.GridColumn colPAY_METHOD;
        private DevExpress.XtraGrid.Columns.GridColumn colDISC_PCT;
        private DevExpress.XtraGrid.Columns.GridColumn colEXP_SHIP_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colPREPARE_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colpri_num;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMOP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCATION;
        private DevExpress.XtraGrid.Columns.GridColumn colCASH_UPDATED;
        private DevExpress.XtraGrid.Columns.GridColumn colWHSE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIP_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFUTURE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCURRENCY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSIC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_DISCOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_QUOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_QUOTE_REF;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCKED;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCKED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colBR_CUSTOMER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CNTL_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMM_CNTL_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYMENT_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCHANGE_GIVEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSPLIT_COMM;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINTED;
        private DevExpress.XtraGrid.Columns.GridColumn colREV_SHIP_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEXTRACT_FLAG;
        private DevExpress.XtraGrid.Columns.GridColumn colEXP_COMMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCALL_BACK;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TYPE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_APPROVED;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTHORIZED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTHORIZED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colAUTHORIZED_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colSCHEDULED_QUOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYMENT_APPLIED;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOSIT_APPLIED;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOSIT_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOSIT_UPDATED;
        private DevExpress.XtraGrid.Columns.GridColumn colDELIVERY;
        private DevExpress.XtraGrid.Columns.GridColumn colRETURN_FLAG;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_TRN_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDELIVERY_CHARGE;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTOCKING_CHARGE;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTOCKING_PCT;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_DIV;
        private DevExpress.XtraGrid.Columns.GridColumn colAR_SETUP_GL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRICE_CODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINT_CNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCREDIT_REF;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMENT_INT;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMO;
        private DevExpress.XtraGrid.Columns.GridColumn colFOOTER_COMMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colWMS_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colWMS_MESSAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colMTR_REQUIRED;
        private DevExpress.XtraGrid.Columns.GridColumn colMETRIC_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colWMS_ORDER_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_WEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn colEXT_REFERENCE;
        private DevExpress.XtraGrid.Columns.GridColumn colLSD_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colORDERED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colFOB_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colinstaller_id;
        private DevExpress.XtraGrid.Columns.GridColumn colAD_CODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILE_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINT_PRICES;
        private DevExpress.XtraGrid.Columns.GridColumn colBUY_RCVD;
        private DevExpress.XtraGrid.Columns.GridColumn colHAS_PIPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREVIEWED;
        private DevExpress.XtraGrid.Columns.GridColumn colREQUIRED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colEXCEPTION_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGGING;
        private DevExpress.XtraGrid.Columns.GridColumn colPO_RELEASE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMTR_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colmarsallingOrdType;
        private DevExpress.XtraGrid.Columns.GridColumn colWMS_STATUS_PIPE;
        private DevExpress.XtraGrid.Columns.GridColumn colWMS_MESSAGE_PIPE;
        private DevExpress.XtraGrid.Columns.GridColumn colPRE_APPROVAL_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colPOST_APPROVAL_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colAPPROVAL_REQ_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectShip;
        private DevExpress.XtraGrid.Columns.GridColumn colPONO2;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_RFQ;
        private DevExpress.XtraGrid.Columns.GridColumn colconvert_count;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_GMStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_GM_RequestID;
        private DevExpress.XtraGrid.Columns.GridColumn colPICK_SLIP_PRINT_COUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colAttentionRequired;
        private DevExpress.XtraGrid.Columns.GridColumn colB2B_Notes;
        private DevExpress.XtraGrid.Columns.GridColumn colBUY_RCVD_PIPE;
        private DevExpress.XtraGrid.Columns.GridColumn colSubStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colB2B_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colShipInProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBuildReference_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBuildReferenceCompany_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditRemaining;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditUsed;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCashSalePaid;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colSLS_ID4;
        private DevExpress.XtraGrid.Columns.GridColumn colOUT_PCT2;
        private DevExpress.XtraGrid.Columns.GridColumn colOUT_PCT3;
        private DevExpress.XtraGrid.Columns.GridColumn colOE_Priority_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colcons_method_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcons_frequency_id;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSOLIDATE_INVOICES;
        private DevExpress.XtraGrid.Columns.GridColumn colCommissionsPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colCompletionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPickSlipPrinted;
        private DevExpress.XtraGrid.Columns.GridColumn colPickSlipPrinted_pipe;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_RoutedApproval_Req_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_RoutedForTraining;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_RoutedForCreditDays;
        private DevExpress.XtraGrid.Columns.GridColumn colKC_RoutedForCreditDays_Req_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colManualQuote;
        private DevExpress.XtraGrid.Columns.GridColumn colRM_Opportunity_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProbablityPct;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPPLY_AND_INSTALL;
        private DevExpress.XtraGrid.Columns.GridColumn colQuoteValidityID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuoteRoutingStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colQuoteRoutingStatusID;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseFolder;
        private DevExpress.XtraGrid.Columns.GridColumn colEndConsumer;
        private DevExpress.XtraGrid.Columns.GridColumn colREV_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colReleaseToDrafting;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_REF;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingType;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingComplete;
        private DevExpress.XtraGrid.Columns.GridColumn colLockID;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_TELEPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colBILL_TO_FAX;
        private DevExpress.XtraGrid.Columns.GridColumn colPRE_APPROVED_AMT;
        private DevExpress.XtraGrid.Columns.GridColumn colReleaseShipHold;
        private DevExpress.XtraGrid.Columns.GridColumn colEndConsumer_Customer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEndConsumer_ContactID;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencedSO;
        private DevExpress.XtraGrid.Columns.GridColumn colQuoteSent;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmationSent;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_Class_ID;
    }
}

