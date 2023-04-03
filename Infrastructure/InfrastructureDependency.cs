using Domain.Interfaces;
using Infrastructure.Util;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureDependency
    {
        public static IServiceCollection RegisterDbAccess(this IServiceCollection services,string connectionstring)
        {
            DbAccess dbAccess=new DbAccess(connectionstring);
            services.AddSingleton<IBatchRepo>(dbAccess);
            services.AddSingleton<IDepartment>(dbAccess);
            services.AddSingleton<IHardwareKey>(dbAccess);
            services.AddSingleton<IInventoryGroup>(dbAccess);
            services.AddSingleton<IInventory>(dbAccess);
            services.AddSingleton<IItemCategory>(dbAccess);
            services.AddSingleton<IItem>(dbAccess);
            services.AddSingleton<IPaymentMethod>(dbAccess);
            services.AddSingleton<IPaymentType>(dbAccess);
            services.AddSingleton<IPersonGroup>(dbAccess);
            services.AddSingleton<IPerson>(dbAccess);
            services.AddSingleton<IPlu>(dbAccess);
            services.AddSingleton<IPosInfo>(dbAccess);
            services.AddSingleton<IRegister>(dbAccess);
            services.AddSingleton<ISupplier>(dbAccess);
            services.AddSingleton<ISupplierCompany>(dbAccess);
            services.AddSingleton<ITransactionType>(dbAccess);
            services.AddSingleton<IUser>(dbAccess);
            services.AddSingleton<IUserRole>(dbAccess);
            services.AddSingleton<IUserSettings>(dbAccess);
            services.AddSingleton<IWorkstation>(dbAccess);
            services.AddSingleton<IPaymentTransaction>(dbAccess);
            services.AddSingleton<IPayoutTransaction>(dbAccess);
            services.AddSingleton<IAuthentication>(dbAccess);
            services.AddSingleton<ITransactionRepo>(dbAccess);
            services.AddSingleton<IReceiptRepo>(dbAccess);
            services.AddSingleton<IOrder>(dbAccess);
            services.AddSingleton<IAcountingRepo>(dbAccess);
            services.AddSingleton<IDiscount>(dbAccess);
            services.AddSingleton<IInventoryManagement>(dbAccess);
            services.AddSingleton<DbAccess>(dbAccess);
            return services;

        }
    }
}
