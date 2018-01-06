using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWebApplication {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {

        private static readonly object Lock = new object();

        public IEnumerable<AuctionsItem> GetAllItems() {
            return Repo.Items;
        }

        public AuctionsItem GetItem(int ItemNumber) {

            var item = Repo.Items.FirstOrDefault(x => x.ItemNumber == ItemNumber);

            if(item != null) {
                return item;
            } else {
                return null;
            }
        }

        public string Bid(Bid Bid) {
            var item = Repo.Items.FirstOrDefault(x => x.ItemNumber == Bid.ItemNumber);
            if(item != null) {
                if(Bid.Price > item.BidPrice) {
                    lock(Lock) {
                        item.BidPrice = Bid.Price;
                        item.BidCustomName = Bid.CustomName;
                        item.BidCustomPhone = Bid.CustomPhone;
                        item.BidTimestamp = DateTime.Now;
                    }
                    return "OK";
                } else {
                    return "Bud for lavt";
                }
            } else {
                return "Vare findes ikke";
            }
        }
    }
}
