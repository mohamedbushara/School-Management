
using School.Settings.Models.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sudan_jobs_WebApp.Models.Sudan_jobs
{
    /// <summary>
    ///  جدول المدن
    /// </summary>
    public class City: AuditExtension
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// اسم المدينة
        /// </summary>
        [Display(Name = "City Name")]
        public string City_name { get; set; }

        //-----------------------   العلاقات ----------------------------

        /// <summary>
        /// fk من جدول الولايات 
        /// </summary>
        [ForeignKey(nameof(State))]
        public long StateId { get; set; }
        public virtual State State { get; set; }

    }
}