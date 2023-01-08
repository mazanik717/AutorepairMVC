﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AutorepairMVC.Models
{
    public class Mechanic
    {
        [Key]
        [Display(Name = "Код автомеханика")]
        public int MechanicId { get; set; }

        [Display(Name = "Имя автомеханика")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия автомеханика")]
        public string MiddleName { get; set; }

        [Display(Name = "Отчество автомеханика")]
        public string LastName { get; set; }

        [Display(Name = "Код должности автомеханика")]
        public int QualificationId { get; set; }

        [Display(Name = "Стаж работы")]
        public int Experience { get; set; }

        public Qualification Qualification { get; set; }
        public ICollection<Payment> Payments { get; set; }

        // ctor for DbInitializer(for future)
        public Mechanic()
        {
            Payments = new List<Payment>();
        }
        public override string ToString()
        {
            return MechanicId + " " + FirstName + " " + MiddleName + " " + LastName + " " + QualificationId + " " + Experience;
        }
    }
}
