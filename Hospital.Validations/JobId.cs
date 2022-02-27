using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Validations
{
    public static class JobId
    {
        // Extintion method to identify the job id
        public static int JobIdIdentify(this string username)
        {
            int jobId = 0;
            using (var hosDB = new HospitalDBContext())
            {
                try
                {
                    jobId = Convert.ToInt32(hosDB.Employees.Include(e => e.Account)
                        .Where(a => a.Account.Username == username)
                        .Select(e => e.JobId).First());
                }
                catch (InvalidOperationException)
                {
                }
            }
            return jobId;
        }
    }
}
