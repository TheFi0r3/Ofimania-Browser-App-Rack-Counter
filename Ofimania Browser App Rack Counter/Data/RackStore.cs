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

        public RackStore(int storeStock, string storeCode, string storeName)
        {
//            if (storeCode == null)
            StoreStock = storeStock;
            StoreCode = storeCode;
            StoreName = storeName;
        }

        public void Clear()
        {
            StoreStock = 0;
            StoreCode = "";
            StoreName = "";
        }
    }
}
