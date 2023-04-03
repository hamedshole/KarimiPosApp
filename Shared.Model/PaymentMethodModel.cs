using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class PaymentMethodModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PaymentType { get; set; }
        public string Pos { get; set; }
        public int PosCom { get; set; }
        public bool Active { get; set; }
        public PaymentMethodModel()
        {

        }
        public PaymentMethodModel(string title)
        {
            Title = title;
        }

        public PaymentMethodModel(string title, string paymentType, string pos, bool active)
        {
            Title = title;
            PaymentType = paymentType;
            Pos = pos;
            Active = active;
        }

        public PaymentMethodModel(int id, string title, string paymentType, string pos, bool active, int posCom = 0)
        {
            Id = id;
            Title = title;
            PaymentType = paymentType;
            Pos = pos;
            PosCom = posCom;
            Active = active;
        }
    }
}
