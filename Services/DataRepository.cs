using System;
using APIWorkGroup.Models;
using APIWorkGroup.Services;
using Microsoft.VisualBasic;
using System.Linq;

namespace APIWorkGroup.Services
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _context;
        public DataRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public IEnumerable<Admin_TB> Admin_TBs_Show()
        {
            return _context.admin_TBs.ToList();
        }
    }
}