namespace Shared.Model
{
    public class UserSettingsModel
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string CashierRibbon { get; set; }
        public UserSettingsModel()
        {

        }

        public UserSettingsModel(string role, string cashierRibbon)
        {
            Role = role;
            CashierRibbon = cashierRibbon;
        }

        public UserSettingsModel(int id, string role, string cashierRibbon)
        {
            Id = id;
            Role = role;
            CashierRibbon = cashierRibbon;
        }
    }
}
