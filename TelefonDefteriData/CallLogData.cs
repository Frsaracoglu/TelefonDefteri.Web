using System.Collections.Generic;
using System.Linq;
using TelefonDefteriData.Models;

namespace TelefonDefteriData
{
    public class CallLogData
    {
        public List<TelefonDefteriEntity.CallLog> CallLogListPeople(int userId)
        {
            List<TelefonDefteriEntity.CallLog> result = null;
            using (dbAdresDefteriContext context = new dbAdresDefteriContext())
            {
                result = context.CallLogs.Where(l => l.UserId == userId).Select(l => new TelefonDefteriEntity.CallLog
                {
                    ListId = l.ListId,
                    CalledName = l.CalledName,
                    CalledLastName = l.CalledLastName,
                    CalledPhone = l.CalledPhone

                }).Distinct().ToList();
            }
            return result;
        }

        public List<TelefonDefteriEntity.CallLog> GetCallListDetail(int listId)
        {
            List<TelefonDefteriEntity.CallLog> result = new List<TelefonDefteriEntity.CallLog>();

            using (dbAdresDefteriContext context = new())
            {
                result = context.CallLogs.Where(l => l.ListId == listId)
                    .Select(l => new TelefonDefteriEntity.CallLog
                    {
                        CallDate = l.CallDate,
                        CallResult = l.CallResult,
                    }).ToList();
            }

            return result;
        }
     
    }
}
