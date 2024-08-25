using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;



namespace School
{
    /// <summary>
    /// 
    /// This Class Represent All Variable That is Needed To Use in This Project .
    ///     
    /// Written By : Misara  && Ahmed
    /// 
    /// Date : 2019 / 03 / 13
    /// 
    /// </summary>
    public class Const
    {
        public static Encoding unicode = Encoding.UTF8;


        //******** Name Crystal Report Files *********************
        public const string SYSTEM_LANGUAGE_ENGLISH = "en-AU";

        public const string SYSTEM_LANGUAGE_ARABIC = "ar-SA";
        
        
        //***** Names Crystal Files For Bills *****************************
        public const string  RPTSale_A4 = "Bills_Maintenance", RPT_ShowPrices = "Bills_Maintenance",  RPTSale_Small = "BillsCasherAbo", 
                             RPTBuy_ExchangeStores_A4 = "SaleBillsSaramik" , RPTBuy_ExchangeStores_Small = "BillsByFlag";
        
        public const string RPTBuy_A4 = "Bills_Maintenance";
        

        /// <summary>
        /// NameAr : Used This Proportories As Parameters To Report ***********************
        /// </summary>
        public static string Sale_Print = "Sale", Sale_Reverse_Print = "Sale_Reverse" , Sale_ShowPrices_Print = "ShowPrices" , Buy_ExchangeStores = "ExchangeStores";
        
        public static long RoleSuperviersNumber { get; set; } = 2;

        public static long RoleCashers { get; set; } = 3;

        public static string NameAdmin { get; set; } = "Admin";

        public static string AllSuperviers { get; set; } = "AllSuperviers";



        //Status : Type Status Social
        public static string Single = "Single", Married = "Married",
                             Divorced = "Divorced", Widow = "Widow";


        //Status : Type Status Social
        public static string Male = "Male", Female = "Female", IsPayed = "Payed", PDF = "PDF"

            , Excel = "Excel", A4 = "A4", SamllPrinter = "SamllPrinter";

        public static string SearchByBarCode = "SearchByBarCode" , SearchById = "SearchById";

        //Dergee Levels
        public static string Diploma = "Diploma", Bachelor = "Bachelor",
                                                    DR = "DR",
                                                    Prof = "Prof",
                                                    Course = "Course";


        //Status : Loads Trucks
        public static string Start = "Start",
            Inprocess = "Inprocess",
            Finished = "Finished";


        //Status : Orders WorkShop For Store
        public static string Creation = "Creation",
            Available = "Available",
            NotAvailable = "NotAvailable";


        //Status : Limitions Accountings 
        public static string CreationLimit = "Creation",
            InproccessLimit = "Inproccess",
            FinishedLimit = "Finished";



        //Status : Limitions Accountings 
        public static string Hours = "Hours", Days = "Days", Minutes = "Minutes",
            Months = "Months",
            Years = "Years";


        //Status : User Access To System -----------------------------
        public static string Active = "Active", Disabled = "Disabled" , CricualQty = "CricualQty" , ZeroQty = "ZeroQty";


        //Status : Debenture  Type
        public static string Expense = "Expenses", Expenses = "Expenses" , Expense_Operation = "Expense_Operation",

            Receipt = "Receipts", ExpenseDebenture = "ExpenseDebenture",

            AdancesExpense = "AdancesExpense", AdancesReceipt = "AdancesReceipt",

            Custody = "Custody", ReceiptDebenture = "ReceiptDebenture", Revenues = "Revenues",

            CustodyExpense = "CustodyExpense", CustodyReceipt = "CustodyReceipt",

            Advance = "Advance", Advances = "Advances";



        // Type Of Level Branch------------------------

        public static string MainBranch = "الفرع الرئيسي", SubBranch = " فرع فرعي";

        //Status : Type Status Maintenance -------------------------------
        public static string StartMaintenance = "Start_Maintenance", FinishMaintenance = "Finish_Maintenance", OpenLoanSupplier = "OpenLoanSupplier",

            PendingImplementation = "PendingImplementation", Finish_Maintenance_Payed = "Finish_Maintenance_Payed" , OpenLoanCustomer = "OpenLoanCustomer";

        //Check-Value : Layout Navigation Name
        public static string Transport = "Transport",
           Inventory = "Inventory",
            WorkShop = "WorkShop",
            Membership = "Membership",
            HR = "HR",
           Accounting = "Accounting";


        //Status : Type Back Load-Shipping -------------------------------
        public static string Empty = "Empty", Back_Load = "Back-Load" , PayToSupplier = "PayToSupplier";


        //Status : Annual Plan Training -------------------
        public static string AnnualPlan = "AnnualPlan",

            Internal = "Internal", External = "External";

        public const decimal VAT = 0.15M;
        public const decimal VATShort = 1.15M;
        public const decimal VATNocatin = 2;


        //Status : Type Status ------------------- 
        public static string Yes = "Yes", No = "No", New = "New" , Add = "Add", Remove = "Remove", RemoveAll = "RemoveAll",

            English = "English" , Arabic = "Arabic" , FavoriteLangauge = "FavoriteLangauge";
        
        //Status : Type Status Spare Parts ------------------- 
        public static string DeliveryPartSpare = "DeliveryPartSpare", ApprovedDelivery = "ApprovedDelivery";
        


        //Status : Type Account In Chart-Accounting ------------------- 
        public static string ForkedAccount = "ForkedAccount", FinalAccount = "FinalAccount"  , Done = "Done", NotData = "NotData" , Error = "Error" ;
        
        //Status : Type Loan 
        public static string LoanRequired = "LoanRequired", LoanDue = "LoanDue", ShowPrices = "ShowPrices" , Search = "Search";


        //Status : Level Quantity
        public static string Wieght = "Wieght", Quantities = "Quantities", LowQuantity = "LowQuantity", MidQuantity = "MidQuantity", HighQuantity = "HighQuantity";


        //Status : Type Products For (Buy - Sale)
        public static string Buy = "Buy", Sale = "Sale", SalePending = "SalePending",
            AddNew = "AddNew", Damage = "Damage", DateExpired = "DateExpired", Reverse = "Reverse", ExchangeToSendStore = "ExchangeToSendStore",
            ReverseBuy = "ReverseBuy", ReverseSell = "ReverseSell", FullReverse = "FullReverse", PartReverse = "PartReverse";


        // Status : Pay Method ( Debentures & Bills )
        public static string Cash = "Cash", Bank = "Bank", CardBank = "CardBank", CashBank = "CashBank", FirstDuration = "FirstDuration",
                             Loan = "Loan", Deffered = "Deffered", TransferBank = "TransferBank";



        // Status : Type Personal (Customer - Supplier - Both)
        public static string Customer_Supplier = "Customer-Supplier",
                                                Customer = "Customer",
                                                Supplier = "Supplier";



        //Urls
        public const string TransPersonal = "TransPersonal";

        public const string LoginController = "Account";
        public const string LoginAction = "Login";
        public const string LoginUrl = "/Account/Login";


        //Check-Value : Entity Status
        public const string STATUS_Active = "Active";
        public const string STATUS_Deleted = "Deleted";

        public const string STATUS_Finished = "Finished";
        public const string STATUS_Sold = "sold";
        public const string STATUS_Exist = "Exist";

        public static string STATUS_Ended = "Ended";
        public static string STATUS_CloseToEnd = "CloseToEnd";

        public static string STATUS_Disabled = "Disabled";
        public static string STATUS_Enabled = "Enabled";

        public static string STATUS_Entered = "Entered";
        public static string STATUS_Approved = "Approved";
        public static string STATUS_Rejected = "Rejected";




        //Status : Levels Approved
        public static string STATUS_FirstApproved = "FirstApproved";
        public static string STATUS_SecondApproved = "SecondApproved";
        public static string STATUS_LastApproved = "LastApproved";





        //Status : Levels Approved
        public static string Approved_DirectorManagers = "Approved_DirectorManagers";

        public static string Approved_SecretaryGeneral = "Approved_SecretaryGeneral";


        public static string Approved_GeneralManager = "Approved_SecretaryGeneral";


        public static string Approved_ChiefFinancialOfficer = "Approved_SecretaryGeneral";

    }


}