using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelRoomManagement_EF_Core
{
    public class HotelDbContext : DbContext
    {
        //to override the OnConfiguring method to set the connection string ...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-IUF9HHIH;Initial Catalog=HotelDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
