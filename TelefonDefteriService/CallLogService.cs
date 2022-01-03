using System.Collections.Generic;
using TelefonDefteriData;

namespace TelefonDefteriService
{
    public class CallLogService
    {
        public List<TelefonDefteriEntity.CallLog> CallLogListPeople(int userId)
        {
               CallLogData list = new();
            return list.CallLogListPeople(userId);
        }

        public List<TelefonDefteriEntity.CallLog> GetCallListDetail(int listId)
        {
            CallLogData list = new();
            return list.GetCallListDetail(listId);
        }
    }
}
