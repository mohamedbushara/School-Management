using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace School.Settings.Models.Audit
{
    public class AuditExtension
    {
        [StringLength(128, MinimumLength = 2), Display(Name = "EnteredBy", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public string EnteredBy { get; set; }

        [StringLength(128, MinimumLength = 2), Display(Name = "ModifiedBy", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public string ModifiedBy { get; set; }

        [StringLength(128, MinimumLength = 2), Display(Name = "DeletedBy", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public string DeletedBy { get; set; }

        [Display(Name = "EnteredDate", ResourceType = typeof(ZeroRes))]
        public System.DateTime EnteredDate { get; set; }

        [Display(Name = "ModifiedDate", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public System.DateTime? ModifiedDate { get; set; }

        [StringLength(128, MinimumLength = 2), Display(Name = "Status", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public string Status { get; set; }

        [Display(Name = "Modifycount", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public int? Modifycount { get; set; } = 0;

        [Display(Name = "DeletedDate", ResourceType = typeof(ZeroRes)), ScaffoldColumn(false)]
        public System.DateTime? DeletedDate { get; set; }

        public long? Branch_ID { get; set; }

        [NotMapped]
        public bool IsDirty { get; set; } = true;

        public void AddEntity()
        {
            //EnteredBy = BaseController.CurrentUserId;
            EnteredDate = DateTime.Now;

            //===== Branch Id Handling ================
            if (Branch_ID == null || Branch_ID == 0)
            {
                //Branch_ID = BaseController.CurrentUserBranchId;
            }

            if (string.IsNullOrEmpty(Status))
            {
                Status = Const.STATUS_Active;
            }
        }

        public void ModifyEntity()
        {

            //ModifiedBy = BaseController.CurrentUserId;

            ModifiedDate = DateTime.Now;

            Modifycount += 1;

        }

        public void RemoveEntity()
        {

            //DeletedBy = BaseController.CurrentUserId;

            DeletedDate = DateTime.Now;

        }

    }
}