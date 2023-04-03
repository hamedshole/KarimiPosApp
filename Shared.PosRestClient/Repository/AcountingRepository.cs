using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KarimiApp.Client.Repository.Repository
{
    internal class AcountingRepository : IAcounting
    {
       private HttpClientAccess httpClient;
        private string _route="acounting/";

        public AcountingRepository(HttpClientAccess httpClient)
        {
            this.httpClient = httpClient;
        }

        List<PayoutTransactionModel> IAcounting.PayoutList(DateTime date)
        {
            var result = Task.Run(async()=>await this.httpClient.Post<DateTime,List<PayoutTransactionModel>>(date,_route + "PayoutList")).Result;
            return result;
        }

        private List<PersonCreditHeaderModel> CreditListResult()
        {
            return Task.Run(async () => await this.httpClient.Get<List<PersonCreditHeaderModel>>(_route + "PersonCreditList")).Result;
        }

        List<PersonCreditHeaderModel> IAcounting.PersonCreditList()
        {
            var result = this.CreditListResult();
            return result;
        }
    }
}
