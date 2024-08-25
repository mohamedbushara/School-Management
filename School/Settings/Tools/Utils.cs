
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School
{

    /// <summary>
    /// Written By : M.Omer & A.Murtada
    /// 
    /// Date : 10/10/2018
    ///
    /// this class represent all utilities 'Variables' that is needed 
    /// in this project without any function logics.
    /// 
    /// </summary>
    public partial class Utils
    {

        //Bootstrap Styles
        public static string Style_Active = "active";
        public static string Style_Success = "success";
        public static string Style_Info = "info";
        public static string Style_Warning = "warning";
        public static string Style_Danger = "danger";

        //Gender
        public static string GENDER_Male = "Male";
        public static string GENDER_Female = "Female";

        //Salary Detail Types
        public static short DETAILTYPE_Allowance = 1;
        public static short DETAILTYPE_Deduction = 2;

        // Work Salary Calculation Type
        public static short WORKTYPE_ByMonth = 1;
        public static short WORKTYPE_ByHour = 2;

        //VacationType
        public static string VACATIONTYPE_Yearly = "Yearly";
        public static string VACATIONTYPE_Permission = "Permission";
        public static string VACATIONTYPE_Sick = "Sick";

        //Dergee Levels
        public static string Diploma = "دبلوم";
        public static string Bachelor = "بكالوريس";
        public static string Master = "ماجستر";
        public static string DR = "دكتوره";
        public static string Prof = "برفيسور";
        public static string Course = "كورس تدريبي";

        public static string CurrentUser;
    }

    public partial class Utils
    {

        public static IEnumerable<string> getGenders()
        {
            return new List<string>{ "Male", "Female" };
        }

        public static IEnumerable<string> getSocialStatuses()
        {
            return new List<string> { "Single", "Married", "Divorced", "widow" };
        }
        public static string getGender(string value)
        {
            switch(value)
            {
                case "Male":
                    return Const.Male;
                case "Female":
                    return Const.Female;
                default:
                    return "";
            }
        }

        public static string getSocialStatus(string value)
        {
            switch (value)
            {
                case "Single":
                    return Const.Single;
                case "Married":
                    return Const.Married;
                case "Divorced":
                    return Const.Divorced;
                case "widow":
                    return Const.Widow;
                default:
                    return "";
            }
        }

        public static string getRowColor(string status)
        {
            switch (status)
            {
                case "Active":
                    return Style_Success;

                case "CloseToEnd":
                    return Style_Warning;

                case "Ended":
                    return Style_Danger;

                default:
                    return null;

            }

        }

    }

}