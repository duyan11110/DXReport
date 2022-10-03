using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Module1.RemittanceTransactions
{
    public interface IRemittanceTransactionRepository : IRepository<RemittanceTransaction,Guid>
    {
        
    }
}
