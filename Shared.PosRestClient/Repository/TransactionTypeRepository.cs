﻿using KarimiApp.Client.Repository.Util;
using KarimiApp.Interface.Client;
using Shared.Model;

namespace KarimiApp.Client.Repository.Repository
{
    internal class TransactionTypeRepository : MainRepository<TransactionTypeModel>, ITransactionType
    {
        public TransactionTypeRepository(HttpClientAccess httpClient) : base("transactiontype", httpClient)
        {
        }

    }
}
