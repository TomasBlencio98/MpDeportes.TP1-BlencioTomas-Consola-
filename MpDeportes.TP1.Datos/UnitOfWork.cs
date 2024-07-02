using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDeportes.TP1.Datos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MpDeportesDbContext _context;
        private IDbContextTransaction? _transaction;
        public UnitOfWork(MpDeportesDbContext context)
        {
            _context = context;
        }
        public void BeginTransaction()
        {
            //_transaction = _context.Database.BeginTransaction();
            if (_transaction != null)
            {
                throw new InvalidOperationException("A transaction is already in progress.");
            }

            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            //try
            //{
            //    SaveChanges();
            //    _transaction?.Commit();
            //}
            //catch (Exception)
            //{
            //    Rollback();
            //    throw;
            //}
            if (_transaction == null)
            {
                throw new InvalidOperationException("No transaction in progress.");
            }

            try
            {
                _context.SaveChanges();
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction = null; // Reset transaction
            }
        }

        public void Rollback()
        {
            //_transaction?.Rollback();
            if (_transaction == null)
            {
                throw new InvalidOperationException("No transaction in progress.");
            }

            try
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction = null; // Reset transaction
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
