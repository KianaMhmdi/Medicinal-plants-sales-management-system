using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalMedicinesProject
{
    class Person
    {
        public string Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }//برای تولید عدد تصادفی است حتی اگر دو نفر رمز عبور یکسانی داشته باشند  به صورت هش متفاوت ذخیره شود
        public string Address{ get; set; }
        public DateTime BirthDate { get; set; }
        public string Role{ get; set; }
        public string Email{ get; set; }
        public int Lockout { get; set; } = 0;//تعداد دفعات لاگین اشتباه
    }
}
