using kutuphaneSistemi.Entities.Enums;
using kutuphaneSistemi.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphaneSistemi.Entities.Concretes
{
    public abstract class Book : IEntity
    {
        public Guid Id { get; set ; }
        public string BookName { get; set; }      
        public string ISBN_Number { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public BookStatus Status { get; set; }
    }
}
