using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using DevExtreme.AspNet.Mvc;

namespace Module1.RemittanceTransactions
{
    public class RemittanceTransactionAppService: Module1AppService, IRemittanceTransactionAppService
    {       
        IRemittanceTransactionRepository _remittanceRepository;

        private IConfiguration _configuration;
        public RemittanceTransactionAppService(IRemittanceTransactionRepository remittanceRepository
            )
        {
            _remittanceRepository = remittanceRepository;
        }
        public async Task<LoadResult> GetListAsync(DataSourceLoadOptions loadOptions)
        {
            if (loadOptions.Sort == null)
            {
                var sortinfo = new SortingInfo[]
                {
                    new SortingInfo() {Desc = true, Selector = "RegisterDate"},
                    new SortingInfo() {Desc = false, Selector = "GroupReferenceNo"},
                    new SortingInfo() {Desc = false, Selector = "LineNumber"}
                };
                loadOptions.Sort = sortinfo;
            }
            loadOptions.RequireTotalCount = true;
            var remit = await _remittanceRepository.GetQueryableAsync();
            var result = await DataSourceLoader.LoadAsync(remit, loadOptions);

            return result;
        }
    }
}
