using System.Collections.Generic;
using System.Linq;
using TelefonDefteriData.Models;

namespace TelefonDefteriData
{
    public class PhoneListData
    {
        public List<TelefonDefteriEntity.PhoneList> ListPeople()
        {
            List<TelefonDefteriEntity.PhoneList> result = null;
            using (dbAdresDefteriContext context = new dbAdresDefteriContext())
            {
                result = context.PhoneLists.Select(l => new TelefonDefteriEntity.PhoneList
                {
                    ListId = l.ListId,
                    Name = l.Name,
                    LastName = l.LastName,
                    EMail = l.Email,
                    Status = l.Status.HasValue ? true : false

                }).ToList();

            }
            return result;
        }

        public TelefonDefteriEntity.PhoneList GetPeople(int Id)
        {
            TelefonDefteriEntity.PhoneList result = null;
            using (dbAdresDefteriContext context = new dbAdresDefteriContext())
            {
                result = context.PhoneLists.Select(l => new TelefonDefteriEntity.PhoneList
                {
                    ListId = l.ListId,
                    Name = l.Name,
                    LastName = l.LastName,
                    EMail = l.Email,
                    Status = l.Status.HasValue ? true : false

                }).Where(l => l.ListId == Id).FirstOrDefault();
            }
            return result;
        }

        public bool ListUpdate(TelefonDefteriEntity.PhoneList phoneList)
        {
            using (dbAdresDefteriContext context = new())
            {

                var people = context.PhoneLists.Where(l => l.ListId == phoneList.ListId).FirstOrDefault();
                if (people != null)
                {
                    people.Name = phoneList.Name;
                    people.LastName = phoneList.LastName;
                    people.Email = phoneList.EMail;
                    people.Status = phoneList.Status;
                }

                context.SaveChanges();

                return true;
            }
        }


        public bool ListDelete(int id)
        {
            using (dbAdresDefteriContext context = new())
            {
                var person = context.PhoneLists.Where(m => m.ListId == id).FirstOrDefault();

                if (person != null)
                {
                    context.PhoneLists.Remove(person);
                    context.SaveChanges();
                }
                return true;
            }
        }


        public bool ListAdd(PhoneList newList)
        {
            using (dbAdresDefteriContext context = new())
            {
                PhoneList user1 = new();
                user1.Name = newList.Name;
                user1.LastName = newList.LastName;
                user1.Email = newList.Email;
                user1.Address = newList.Address;
                user1.Phone = newList.Phone;
                user1.City = newList.City;
                user1.Status = newList.Status;


                context.PhoneLists.Add(user1);
                int ListId = context.SaveChanges();
                if (ListId > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }     
}
