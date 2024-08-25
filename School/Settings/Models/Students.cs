using School.Settings.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School.Settings.Models
{
    /// <summary>
    ///  جدول الطالب
    /// </summary>
    /// 
    public class Students : AuditExtension
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long ID { get; set; }

        /// <summary>
        /// اسم الطالب  
        /// </summary>
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        /// <summary>
        /// اسم ولي الامر  
        /// </summary>
        [Display(Name = "Guardian Name")]
        public string GuardianName { get; set; }

        /// <summary>
        ///    هاتف ولي الامر  
        /// </summary>
        [Display(Name = "Phone Guardian")]
        public string PhoneGuardian  { get; set; }

        /// <summary>
        ///    هاتف  اخر  
        /// </summary>
        [Display(Name = "Next Phone")]
        public string NextPhone { get; set; }

        /// <summary>
        /// اسم  الام  
        /// </summary>
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        /// <summary>
        ///    العمر  
        /// </summary>
        [Display(Name = "Age")]
        public int Age { get; set; }

        /// <summary>
        ///  الصف الدراسي
        /// </summary>
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        /// <summary>
        ///   الصوروة
        /// </summary>
        [Display(Name = "Image")]
        public string Image { get; set; }

        ///   /// <summary>
        ///    نوع الطالب
        ///    [ ذكر - انثي]
        /// </summary>
        [Display(Name = "Student Type")]
        public string StudentType { get; set; }

        /// <summary>
        /// العنوان    
        /// </summary>
        [Display(Name = "Adderss")]
        public string Adderss { get; set; }

    }
}