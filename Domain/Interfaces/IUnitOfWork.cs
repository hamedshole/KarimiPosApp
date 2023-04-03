namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAcounting Acounting { get; }
        IAuthentication Authentication { get; }
        IBatch Batch { get; }
        IDepartment Department { get; }
        IDiscount Discount { get; }
        IHardwareKey HardWarekey { get; }
        IInventory Inventory { get; }
        IInventoryGroup InventoryGroup { get; }
        IInventoryManagement InventoryManagement { get; }
        IItem Item { get; }
        IItemCategory ItemCategory { get; }
        IOrder Order { get; }
        IPaymentMethod PaymentMethod { get; }
        IPaymentTransaction PaymentTransaction { get; }
        IPaymentType PaymentType { get; }
        IPayoutTransaction PayoutTransaction { get; }
        IPerson Person { get; }
        IPersonGroup PersonGroup { get; }
        IPlu Plu { get; }
        IPosInfo PosInfo { get; }
        IReceipt Receipt { get; }
        IRegister Register { get; }
        ISupplier Supplier { get; }
        ISupplierCompany SupplierCompany { get; }
        ITransaction Transaction { get; }
        ITransactionType TransactionType { get; }
        IUser User { get; }
        IUserRole UserRole { get; }
        IWorkstation Workstation { get; }
    }
}