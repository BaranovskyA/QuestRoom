using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repositories;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T:class 
    {
        //Repository<Roles> RolesUowRepository { get; }
        //Repository<Rating> RatingUowRepository { get; }
        //Repository<Users> UsersUowRepository { get; }
        //Repository<QuestsLogos> QuestLogosUowRepository { get; }
        //Repository<QuestsRooms> QuestRoomsUowRepository { get; }

        Repository<T> GenericUowRepository { get; }
        void Save();
    }
}
