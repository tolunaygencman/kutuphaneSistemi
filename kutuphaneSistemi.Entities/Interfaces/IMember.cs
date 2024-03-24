using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphaneSistemi.Entities.Interfaces
{
    public interface IMember : IEntity
    {
        string Name { get; set; }
        string SurName { get; set; }
        string MemberNumber { get; set; }
        public List<Book> LoanedBooks { get; set; }
    }
}
