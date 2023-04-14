using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Threading.Tasks;

namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class RackStore
    {
        public int StoreStock { get; set; }

        public string StoreCode { get; set; }

        public string StoreName { get; set; }

        public RackStore() { }

        public RackStore(int storeStock, string storeCode)
        {
            if (storeCode == null)
            StoreStock = storeStock;
            StoreCode = storeCode;
            StoreName = storeCode;
        }

        public void Clear()
        {
            StoreStock = 0;
            StoreCode = "";
            StoreName = "";
        }
    }
}
