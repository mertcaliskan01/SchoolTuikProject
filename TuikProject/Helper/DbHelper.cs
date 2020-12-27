using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Data;
using TuikProject.Models;

namespace TuikProject.Helper
{
    public class DbHelper : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool disposedValue;

        public DbHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }


        public IEnumerable<IssizlikOraniT1> getIssizlikOraniT1()
        {
            IEnumerable<IssizlikOraniT1> list = null;
            try
            {
                list = (IEnumerable<IssizlikOraniT1>) _context.IssizlikOraniT1.ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }

        public IEnumerable<IssizlikOraniT2> getIssizlikOraniT2()
        {
            IEnumerable<IssizlikOraniT2> list = null;
            try
            {
                list = (IEnumerable<IssizlikOraniT2>) _context.IssizlikOraniT2.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }





    }
}
