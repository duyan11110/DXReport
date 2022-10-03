using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Module1.RemittanceTransactions
{
    public interface IRemittanceTransactionAppService : IApplicationService
    {
        Task<LoadResult> GetListAsync(DataSourceLoadOptions loadOptions);
    }
}
