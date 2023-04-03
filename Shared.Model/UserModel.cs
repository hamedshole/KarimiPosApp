namespace Shared.Model
{
    public class UserModel : PersonModel
    {
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserModel()
        {

        }
        public UserModel(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public UserModel(string name, string mobileNumber, string role, string userName, string password, string address, string personGroup = "") : base(name, mobileNumber, address, personGroup)
        {
            Role = role;
            UserName = userName;
            Password = password;
        }
        public UserModel(int id, string name, string mobileNumber, string role, string userName, string password, string address, string personGroup = "") : base(id, name, mobileNumber, address, personGroup)
        {
            Role = role;
            UserName = userName;
            Password = password;
        }
        public UserModel(int id, string code, string name, string mobileNumber, string role, string userName, string password, string address, long balance, string personGroup = "") : base(id, code, name, mobileNumber, address, balance, personGroup)
        {
            Role = role;
            UserName = userName;
            Password = password;
        }
    }
}
