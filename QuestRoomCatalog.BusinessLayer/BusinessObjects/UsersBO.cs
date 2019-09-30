namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UsersBO
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int RoleId { get; set; }

        public RolesBO Roles { get; set; }
    }
}
