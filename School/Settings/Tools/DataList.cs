//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using School.Models;

//namespace School
//{

//    public class DataList
//    {

//        public enum DepName { XCV, OP, KOL }

//        public enum AnnualPlanTrainingStatus{ Entered, AnnualPlan, DirectorManagers, SecretaryGeneral, GeneralManager, ChiefFinancialOfficer }

//        public enum Gender{Male,Female}

//        public enum TaskType { Internal, External }

//        public static IEnumerable<SelectListItem> LoanType()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  ZeroRes.LoanRequired , Value =  Const.LoanRequired},

//                new SelectListItem{Text = ZeroRes.LoanDue , Value =  Const.LoanDue}

//            };
//        }

//        public static IEnumerable<SelectListItem> TypeActionClient()
//        {
//            return new List<SelectListItem>
//            {
//                new SelectListItem{ Text = ZeroRes.Search  , Value = Const.Search},

//                new SelectListItem{ Text = ZeroRes.AddNew , Value =  Const.AddNew }
//            };
//        }

//        public static IEnumerable<SelectListItem> ModePrinterSale()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  Const.A4 , Value =  Const.A4},

//                new SelectListItem{Text = ZeroRes.SamllPrinter , Value =  Const.SamllPrinter}

//            };

//        }

//        public static IEnumerable<SelectListItem> EnablePriceSell()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  ZeroRes.Yes , Value =  Const.Yes},

//                new SelectListItem{Text = ZeroRes.No , Value =  Const.No}

//            };

//        }

//        public static IEnumerable<SelectListItem> TypeQuantities()
//		{

//			return new List<SelectListItem>
//			{

//				new SelectListItem{ Value = Const.Quantities , Text = ZeroRes.Quantities},

//				new SelectListItem{ Value = Const.Wieght , Text =  ZeroRes.Wieghts},

//			};

//		}

//        public static IEnumerable<SelectListItem> BranchLevelDropList()
//        {
//            return new List<SelectListItem>
//            {

//               new SelectListItem{ Text = ZeroRes.MainBranch , Value=Const.MainBranch},

//               new SelectListItem{ Text = ZeroRes.SubBranch , Value=Const.SubBranch  }
//            };
//        }

//        public static IEnumerable<SelectListItem> LevelQuantities()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.LowQuantity , Text = "1-5"},

//                new SelectListItem{ Value = Const.MidQuantity , Text =  "5-10" },

//                new SelectListItem{ Value = Const.HighQuantity , Text =  "10-15"},

//            };

//        }

//		public static IEnumerable<SelectListItem> LevelWieghts()
//		{

//			return new List<SelectListItem>
//			{

//				new SelectListItem{ Value = Const.LowQuantity , Text = "1,000-5,000"},

//				new SelectListItem{ Value = Const.MidQuantity , Text =  "5,000-10,000" },

//				new SelectListItem{ Value = Const.HighQuantity , Text =  "10,000-15,000"},

//			};

//		}

//        public static IEnumerable<SelectListItem> TypePersonal()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.Customer , Text = ZeroRes.Customer },

//                new SelectListItem{ Value = Const.Supplier , Text = ZeroRes.Supplier },

//            };

//        }

//        public static IEnumerable<SelectListItem> SelectLanguage()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.Arabic , Text = ZeroRes.Arabic },

//                new SelectListItem{ Value = Const.English , Text = ZeroRes.English },

//            };

//        }

//        public static IEnumerable<SelectListItem> SelectActivity_VAT()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.Yes , Text = ZeroRes.Yes },

//                new SelectListItem{ Value = Const.No , Text = ZeroRes.No },

//            };

//        }

//        public static IEnumerable<SelectListItem> TypeLevelAccount()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.ForkedAccount , Text = ZeroRes.ForkedAccount },

//                new SelectListItem{ Value = Const.FinalAccount , Text = ZeroRes.FinalAccount },

//            };

//        }

//        public static IEnumerable<SelectListItem> PayTypeBill()
//        {

//            return new List<SelectListItem>
//            {

//				new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//                new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank },

//                new SelectListItem{ Value=Const.Deffered , Text = ZeroRes.Deferred},

//                new SelectListItem{ Value = Const.FirstDuration , Text = ZeroRes.FirstDuration},
                
//            };

//        }

//        public static IEnumerable<SelectListItem> ReverseType()
//        {

//            return new List<SelectListItem>
//            {

//                 new SelectListItem{ Value = Const.PartReverse , Text = ZeroRes.ReversPart},

//                 new SelectListItem{ Value = Const.FullReverse , Text = ZeroRes.ReversOverall }

//            };

//        }

//        public static IEnumerable<SelectListItem> PayType()
//		{

//			return new List<SelectListItem>
//			{

//				new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//				new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank},

//				new SelectListItem{ Value=Const.Deffered , Text = ZeroRes.Deffered},

//			};

//		}

//        public static IEnumerable<SelectListItem> PayTypeCashBank()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//                new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank},

//            };

//        }

//        public static IEnumerable<SelectListItem> PayTypeByValue()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//                new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank},

//                new SelectListItem{ Value=Const.Deffered , Text = ZeroRes.Deffered},

//            };

//        }

//        public static IEnumerable<SelectListItem> PayTypeDamage()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Value = Const.DateExpired , Text = ZeroRes.DateFinish},

//                new SelectListItem{ Value = Const.Damage , Text = ZeroRes.Damage },
//            };
//        }

//        public static IEnumerable<SelectListItem> PayTypeWithoutLoan()
//        {
//            return new List<SelectListItem>
//            {
//                new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//                new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank }
//            };
//        }

//		public static IEnumerable<SelectListItem> PayTypeWithCard()
//		{

//			return new List<SelectListItem>
//			{

//				new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},

//				new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank },

//				new SelectListItem{ Value=Const.CardBank , Text = ZeroRes.CardBank },

//			};

//		}

//        public static IEnumerable<SelectListItem> PayTypeCard()
//        {
//            return new List<SelectListItem>
//            {
//                new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},
//                new SelectListItem{ Value=Const.CardBank , Text = ZeroRes.CardBank },
//            };
//        }

//		public static IEnumerable<SelectListItem> SalePayType()
//		{
//			return new List<SelectListItem>
//			{
//				new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},
//				new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank },
//				new SelectListItem{ Value = Const.CashBank , Text = ZeroRes.CashBank },
//                new SelectListItem{ Value=Const.Deffered , Text = ZeroRes.Deffered },
//            };
//		}

//        public static IEnumerable<SelectListItem> SalePayTypeOut()
//        {
//            return new List<SelectListItem>
//            {
//                new SelectListItem{ Value=Const.Cash , Text = ZeroRes.Cash},
//                new SelectListItem{ Value=Const.Bank , Text = ZeroRes.Bank },
//                new SelectListItem{ Value=Const.Deffered , Text = ZeroRes.Deffered },
//            };
//        }

//        public static IEnumerable<SelectListItem> EvaTrianing()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  "1" , Value =  "1"},

//                new SelectListItem{Text =  "2" , Value =  "2"},

//                new SelectListItem{Text =  "3" , Value =  "3"},

//                new SelectListItem{Text =  "4" , Value =  "4"},

//                new SelectListItem{Text =  "5" , Value =  "5"},

//                new SelectListItem{Text =  "6" , Value =  "6"},

//                new SelectListItem{Text =  "7" , Value =  "7"},

//                new SelectListItem{Text =  "8" , Value =  "8"},

//                new SelectListItem{Text =  "9" , Value =  "9"},

//                new SelectListItem{Text =  "10" , Value =  "10"}

//            };

//        }

//        public static IEnumerable<SelectListItem> GenderDrop()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  ZeroRes.Male , Value =  ZeroRes.Male},

//                new SelectListItem{Text = ZeroRes.Female , Value =  ZeroRes.Female}

//            };

//        }

//        public static IEnumerable<SelectListItem> DebentureType()
//        {

//            return new List<SelectListItem>
//            {
//                new SelectListItem{Text = ZeroRes.Revenues , Value =  Const.Revenues},

//                new SelectListItem{Text = ZeroRes.Loans , Value =  Const.Loan},

//                 new SelectListItem{Text = ZeroRes.Custody , Value =  Const.Custody},

//                  new SelectListItem{Text = ZeroRes.Advance , Value =  Const.Advance},

//                new SelectListItem{Text =  ZeroRes.Expenses , Value =  Const.Expense}

//            };

//        }

//        public static IEnumerable<SelectListItem> GenderVacation()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{Text =  ZeroRes.Male , Value =  ZeroRes.Male},

//                new SelectListItem{Text = ZeroRes.Female , Value =  ZeroRes.Female},

//                new SelectListItem{Text = ZeroRes.Both , Value =  ZeroRes.Both}

//            };

//        }

//        public static IEnumerable<SelectListItem> BillType()
//        {

//            return new List<SelectListItem>
//            {

//                new SelectListItem{ Text = ZeroRes.Buy, Value = "1" },

//                new SelectListItem{ Text = ZeroRes.Sell, Value = "2" }

//            };

//        }

//        public static IEnumerable<SelectListItem> VacationType()
//        {

//            return new List<SelectListItem>
//            {
//                new SelectListItem { Value = ZeroRes.VACATION_Yearly, Text = ZeroRes.VACATION_Yearly },

//                new SelectListItem { Value = ZeroRes.VACATION_Sick, Text = ZeroRes.VACATION_Sick },

//                new SelectListItem { Value = ZeroRes.VACATION_Permission, Text = ZeroRes.VACATION_Permission  },

//                new SelectListItem { Value = ZeroRes.VACATION_Marrid, Text = ZeroRes.VACATION_Marrid  },

//                new SelectListItem { Value = ZeroRes.VACATION_RepSalary, Text = ZeroRes.VACATION_RepSalary  },

//                new SelectListItem { Value = ZeroRes.VACATION_Pregnancy, Text = ZeroRes.VACATION_Pregnancy  },

//                new SelectListItem { Value = ZeroRes.VACATION_NoSalary, Text = ZeroRes.VACATION_NoSalary  },

//            };

//        }

//        public static IEnumerable<SelectListItem> InstructiionsTypes()
//        {

//            return new List<SelectListItem>
//            {

//               new SelectListItem{Text=ZeroRes.Attention_First , Value=ZeroRes.Attention_First},

//                 new SelectListItem{Text=ZeroRes.Attention_Second , Value=ZeroRes.Attention_Second  },

//                 new SelectListItem{Text=ZeroRes.Attention_Finaly , Value=ZeroRes.Attention_Finaly },

//                 new SelectListItem{Text=ZeroRes.Warning_First , Value=ZeroRes.Warning_First},

//                 new SelectListItem{Text=ZeroRes.Warning_Second , Value=ZeroRes.Warning_Second  },

//                 new SelectListItem{Text=ZeroRes.Warning_Finaly , Value=ZeroRes.Warning_Finaly }

//            };

//        }

//        public static IEnumerable<SelectListItem> SupplierMenu(long Val_ID)
//        {

//            using (TrunksDb db = new TrunksDb())
//            {

//                var itexs = from a in db.personals.Where(a => a.AccType == Const.Supplier).ToList()
//                            select new
//                            {
//                                ID = a.ID,

//                                Name = a.Name

//                            };

//                return (new SelectList(itexs, "ID", "Name" , Val_ID));

//            }

//        }

//    }

//}