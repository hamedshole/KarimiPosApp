namespace Shared.Model
{
    public class SupplierAgentModel : PersonModel
    {
        public string Company { get; set; }
        public SupplierAgentModel()
        {

        }
        public SupplierAgentModel(string name, string mobileNumber, string company, string address, string personGroup = "") : base(name, mobileNumber, address, personGroup)
        {
            Company = company;
        }
        public SupplierAgentModel(int id, string code, string name, string mobileNumber, string company, string address, long balance, string personGroup = "") : base(id, code, name, mobileNumber, address, balance, personGroup)
        {
            Company = company;
        }
        public SupplierAgentModel(int id, string name, string mobileNumber, string company, string address, string personGroup = "") : base(id, name, mobileNumber, address, personGroup)
        {
            Company = company;
        }
    }
}
