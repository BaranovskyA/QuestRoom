namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RolesBO
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        //public virtual ICollection<Users> Users { get; set; }
    }
}
