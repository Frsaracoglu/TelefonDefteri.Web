using System.Collections.Generic;
using TelefonDefteriData;

namespace TelefonDefteriService
{
    public class PhoneListService
    {
        public List<TelefonDefteriEntity.PhoneList> ListPeople()
        {
            PhoneListData list = new();
            return list.ListPeople();
        }

        public TelefonDefteriEntity.PhoneList GetPeople(int Id)
        {
            PhoneListData list = new();
            return list.GetPeople(Id);
        }

        public bool ListUpdate(TelefonDefteriEntity.PhoneList list)
        {
            PhoneListData listData = new();
            return listData.ListUpdate(list);
        }

        public bool ListDelete(int id)
        {
            PhoneListData list = new();
            return list.ListDelete(id);
        }

        public bool ListAdd(TelefonDefteriData.Models.PhoneList newList)
        {
            PhoneListData list = new();
            return list.ListAdd(newList);
        }
    }
}
