using EFEntityRelationsApp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModrelCreateApp
{
    public class Employee
    {
        //Company? company;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        
        public int? CompanyId { get; set; } // внешний ключ
        //[ForeignKey("CompanyForeignId")]
        //public string? CompanyTitle { set; get; }

        public Company? Company { set; get; } // навигационное свойство
        //{
        //    get => company ?? throw new Exception("Null property Company");
        //    set => company = value;
        //}

        public Position Position { get; set; } = null!;

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
