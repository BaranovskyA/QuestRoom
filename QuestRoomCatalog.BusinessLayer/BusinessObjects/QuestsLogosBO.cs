namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class QuestsLogosBO
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public bool IsLogo { get; set; }

        public QuestsRoomsBO QuestsRooms { get; set; }
    }
}
