using Application.Repositories.Repository;
using Domain.Interfaces;
using Infrastructure.Util;


namespace Application.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbAccess dbCommand;

        public UnitOfWork(DbAccess dbAccess)
        {
            dbCommand = dbAccess;
        }


        private IItemCategory _itemCategoryRepository;
        private IInventory _inventoryRepository;
        private IInventoryGroup _inventoryGroupRepository;
        private IItem _itemRepository;
        private IPersonGroup _persoGroupRepository;
        private IUserRole _userRoleRepository;
        private IDepartment _departmentRepository;
        private IHardwareKey _hardwareKeyRepository;
        private ISupplierCompany _supplierCompany;
        private IPlu _pluRepository;
        private IWorkstation _workstationRepository;
        private ITransaction _transactionRepository;
        private IPaymentTransaction _paymentTransactionRepository;
        private IPayoutTransaction _payoutTransactionRepository;
        private IUser _userRepository;
        private IAuthentication _authenticationRepository;
        private IBatch _batchRepository;
        private IPerson _personRepository;
        private IReceipt _receiptRepository;
        private IOrder _orderrepository;
        private IPosInfo _posInfoRepository;
        private IRegister _registerRepository;
        private ISupplier _supplierRepository;
        private ITransactionType _transactionType;
        private IPaymentType _paymentTypeRepository;
        private IPaymentMethod _paymentMethodRepository;
        private IAcounting _acountingRepository;
        private IDiscount _discountRepository;
        private IInventoryManagement _inventoryManagement;


        public IItemCategory ItemCategory
        {
            get
            {
                if (_itemCategoryRepository == null)
                {
                    _itemCategoryRepository = new ItemCategoryRepository(dbCommand);
                }
                return _itemCategoryRepository;
            }
        }

        public IItem Item
        {
            get
            {
                if (_itemRepository == null)
                {
                    _itemRepository = new ItemRepository(dbCommand);
                }
                return _itemRepository;
            }
        }
        public IInventoryGroup InventoryGroup
        {
            get
            {
                if (_inventoryGroupRepository == null)
                {
                    _inventoryGroupRepository = new InventoryGroupRepository(dbCommand);
                }
                return _inventoryGroupRepository;
            }
        }
        public IInventory Inventory
        {
            get
            {
                if (_inventoryRepository == null)
                {
                    _inventoryRepository = new InventoryRepository(dbCommand);
                }
                return _inventoryRepository;
            }
        }
        public IPersonGroup PersonGroup
        {
            get
            {
                if (_persoGroupRepository == null)
                {
                    _persoGroupRepository = new PersonGroupRepository(dbCommand);
                }
                return _persoGroupRepository;
            }
        }
        public IUserRole UserRole
        {
            get
            {
                if (_userRoleRepository == null)
                {
                    _userRoleRepository = new UserRoleRepository(dbCommand);
                }
                return _userRoleRepository;
            }
        }
        public IDepartment Department
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(dbCommand);
                }
                return _departmentRepository;
            }
        }
        public IHardwareKey HardWarekey
        {
            get
            {
                if (_hardwareKeyRepository == null)
                {
                    _hardwareKeyRepository = new HardwareKeyRepository(dbCommand);
                }

                return _hardwareKeyRepository;
            }
        }
        public ISupplierCompany SupplierCompany
        {
            get
            {
                if (_supplierCompany == null)
                {
                    _supplierCompany = new SupplierCompanyRepository(dbCommand);
                }
                return _supplierCompany;
            }
        }
        public IPlu Plu
        {
            get
            {
                if (_pluRepository == null)
                {
                    _pluRepository = new PluRepository(dbCommand);
                }
                return _pluRepository;
            }
        }
        public IWorkstation Workstation
        {
            get
            {
                if (_workstationRepository == null)
                {
                    _workstationRepository = new WorkstationRepository(dbCommand);
                }
                return _workstationRepository;
            }
        }
        public ITransaction Transaction
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new TransactionRepository(dbCommand);
                }
                return _transactionRepository;
            }
        }
        public IPaymentTransaction PaymentTransaction
        {
            get
            {
                if (_paymentTransactionRepository == null)
                {
                    _paymentTransactionRepository = new PaymentTransactionRepository(dbCommand);
                }
                return _paymentTransactionRepository;
            }
        }
        public IPayoutTransaction PayoutTransaction
        {
            get
            {
                if (_payoutTransactionRepository == null)
                {
                    _payoutTransactionRepository = new PayoutTransactionRepository(dbCommand);
                }
                return _payoutTransactionRepository;
            }
        }
        public IUser User
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(dbCommand);
                }
                return _userRepository;
            }
        }
        public IAuthentication Authentication
        {
            get
            {
                if (_authenticationRepository == null)
                {
                    _authenticationRepository = new AuthenticationRepository(dbCommand);
                }
                return _authenticationRepository;
            }
        }
        public IBatch Batch
        {
            get
            {
                if (_batchRepository == null)
                {
                    _batchRepository = new BatchRepository(dbCommand);
                }
                return _batchRepository;
            }
        }
        public IPerson Person
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(dbCommand);
                }
                return _personRepository;
            }
        }
        public IReceipt Receipt
        {
            get
            {
                if (_receiptRepository == null)
                {
                    _receiptRepository = new ReceiptRepository(dbCommand);
                }
                return _receiptRepository;
            }
        }
        public IOrder Order
        {
            get
            {
                if (_orderrepository == null)
                {
                    _orderrepository = new OrderTransactionRepository(dbCommand);
                }
                return _orderrepository;
            }
        }
        public IPosInfo PosInfo
        {
            get
            {
                if (_posInfoRepository == null)
                {
                    _posInfoRepository = new PosInfoRepository(dbCommand);
                }
                return _posInfoRepository;
            }
        }
        public IRegister Register
        {
            get
            {
                if (_registerRepository == null)
                {
                    _registerRepository = new RegisterRepository(dbCommand);
                }
                return _registerRepository;
            }
        }
        public ISupplier Supplier
        {
            get
            {
                if (_supplierRepository == null)
                {
                    _supplierRepository = new SupplierRepository(dbCommand);
                }
                return _supplierRepository;
            }
        }
        public ITransactionType TransactionType
        {
            get
            {
                if (_transactionType == null)
                {
                    _transactionType = new TransactionTypeRepository(dbCommand);
                }
                return _transactionType;
            }
        }
        public IPaymentType PaymentType
        {
            get
            {
                if (_paymentTypeRepository == null)
                {
                    _paymentTypeRepository = new PaymentTypeRepository(dbCommand);
                }
                return _paymentTypeRepository;
            }
        }
        public IPaymentMethod PaymentMethod
        {
            get
            {
                if (_paymentMethodRepository == null)
                {
                    _paymentMethodRepository = new PaymentMethodRepository(dbCommand);
                }
                return _paymentMethodRepository;
            }
        }
        public IAcounting Acounting
        {
            get
            {
                if (_acountingRepository == null)
                {
                    _acountingRepository = new AcountingRepository(dbCommand);
                }
                return _acountingRepository;
            }
        }
        public IDiscount Discount
        {
            get
            {
                if (_discountRepository == null)
                {
                    _discountRepository = new DiscountRepository(dbCommand);
                }
                return _discountRepository;
            }
        }
        public IInventoryManagement InventoryManagement
        {
            get
            {
                if (_inventoryManagement == null)
                {
                    _inventoryManagement = new InventoryManagementRepository(dbCommand);
                }
                return _inventoryManagement;
            }
        }
    }
}
