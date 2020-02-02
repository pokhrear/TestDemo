using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Models
{
    public static class RegisterModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>().HasData(
                new Register
                {
                    
                   Email="abc@gmail.com",
                   Password="",
                   Confirm_Password=""

                }

                    ); 
        }
    }
}
