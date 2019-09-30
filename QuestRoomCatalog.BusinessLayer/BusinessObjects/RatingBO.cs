namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Rating")]
    public class RatingBO
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        public int RatingLevel { get; set; }

        public QuestsRoomsBO QuestsRooms { get; set; }
    }
}
