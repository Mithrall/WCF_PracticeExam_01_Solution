using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWebApplication {
    public class AuctionsItem {
        public int ItemNumber;
        public string ItemDescription;
        public int RatingPrice;
        public int BidPrice;
        public string BidCustomName;
        public int BidCustomPhone;        
        public DateTime BidTimestamp;
    }
}