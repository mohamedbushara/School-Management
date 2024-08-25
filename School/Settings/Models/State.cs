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
    ///  جدول الولايات
    /// </summary>
    public class State: AuditExtension
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        /// <summary>
        /// اسم الولاية
        /// </summary>
        [Display(Name = "State Name")]
        public string State_name { get; set; }

    }
}