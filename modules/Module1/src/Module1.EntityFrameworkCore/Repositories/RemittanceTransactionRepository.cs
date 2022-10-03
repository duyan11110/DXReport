using Microsoft.EntityFrameworkCore;
using Module1.EntityFrameworkCore;
using Module1.RemittanceTransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.MultiTenancy;

namespace Module1.Repositories
{
    public class RemittanceTransactionRepository : EfCoreRepository<Module1DbContext, RemittanceTransaction, Guid>, IRemittanceTransactionRepository
    {
        public RemittanceTransactionRepository(IDbContextProvider<Module1DbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
