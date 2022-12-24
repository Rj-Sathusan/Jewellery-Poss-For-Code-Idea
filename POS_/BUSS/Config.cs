using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_.BUSS
{
    class Config
    {
        public static string ApplicationName = "POS";
       
        public static int Storeid = 0;
        public static int PrintSoFar = 60;
        public static int Branchid;
        public static bool isAskPrintMessage = false;
        public static bool isZeroQty = false;
        public static bool isRetailSale = true;
        public static bool isSalesAmountChange = true;
        public static bool isSalesReturn = false;
        public static bool isItemDiscountPercentage = false;
       
        public static bool isPrinter80mm = true ;
        public static bool isSizeWiseGroup = false;
        public static bool isSubTotal = false;


        public static bool isStaffWiseSaleCom = false;
        public static bool isInvoiceWiseSaleCom = false;
        public static bool isLoyaltyActivated = false;

        public static bool isShowPrevesDue = true;
        public static bool isShowPrevesDueIntoSaleForm = true;

        public static bool isInvoiceDiscountActivated = true;

        public static bool isMinPriceBarcode = false;
        public static bool isReorderLevelCheck = false;
        public static bool isPreveItemSaleAmount = false;

        public static bool isOnOff = true;
        public static bool isFullPaper = false;
        public static bool isPrivewOpen = false;

        public static bool isBrcodeDisplay = true;
        public static bool onlyItemSearch = false;

        public static bool isMultifilBranch = false;
        public static bool LineDiscountShow = true;
        public static string invoiceBranchDumyCode = "I";
        public static bool isMainBarnch = false;
        public static string  invoiceBranchCode;

        public static bool FirstItemFistShow = false;


        public static bool isShowGrossAmount = true;
        public static bool isPaymentFormOpenWhenAddButtonClick = false;
        public static bool isTotalLineDiscountPrint = true;

        public static bool InvoiceHeaderShow = false;

        public static bool isLocalServerActevaed = false
            ;
        public static bool isLocalServerInvoiceSaved = false;

        public static bool isTxtileShop = true;

        public static String UserPassWord ="";
        public static String EmailOrFaceebook = "E-Mail :  ";
        public static bool isOnline = true;// don't change
        //createServiceItems
        public static bool createServiceItems= true;

       // public static string ConnectionString = @"server=145.14.152.51;user id=u913025093_mul;database=u913025093_mul;password='Mul@1107';default command timeout=1000";
        //central_point //mul_system_online_check   //admin_accountpos

        public static string ConnectionString = @"server=127.0.0.1;user id=root;database=ming_dis;default command timeout=1000";
     
 // public static string ConnectionString = @"server=accountpos.cglmjreb6led.ap-south-1.rds.amazonaws.com;user id=admin;database=arif_org;password=admin1234;default command timeout=1000";

        public static string LocalServerConnectionString = @"server=127.0.0.1;user id=root;database=new_online_system;default command timeout=1000";
       // public static string ConnectionString = @"database='admin_accountpos'; datasource='192.168.1.10'; username='root'; password='12345'";//
  
    }
}
