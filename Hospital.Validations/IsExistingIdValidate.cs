using Hospital.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Validations
{
    public static class IsExistingIdValidate
    {
        // Extintion method to check the given identity number existing in the database
        // using ref return person id by the identity number
        public static bool IsExistingId(this string id, ref Person person)
        {
            bool IsValidId = false;
            using (var hosDB = new HospitalDBContext())
            {
                try
                {
                    var personDb = hosDB.People
                        .Where(p => p.IdentityNumber == id);
                    if (personDb.ToList().Count() == 1 && id.IsIsraelIdentityNumber())
                    {
                        IsValidId = true;
                        person = (Person)personDb.ToList().First();
                    }
                }
                catch (InvalidOperationException)
                {
                }
            }
            return IsValidId;
        }
    }
}
