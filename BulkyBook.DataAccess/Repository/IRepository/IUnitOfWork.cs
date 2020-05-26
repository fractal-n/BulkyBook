using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }

        ISpCall SpCall { get; }

        void Save();
    }
}
