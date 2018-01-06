using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWebApplication {
    public class Repo {
        public static IEnumerable<AuctionsItem> Items = new List<AuctionsItem> {
            new AuctionsItem {
                ItemNumber = 123456,
                ItemDescription = "PH 5 Classic lampe Hvid mat",
                RatingPrice = 2100,
                BidPrice = 2100,
                BidCustomName = "Bjørk Boye Busch",
                BidCustomPhone = 63129162,
                BidTimestamp = DateTime.Now
            },
            new AuctionsItem {
                ItemNumber = 654321,
                ItemDescription = "Yellow balloon",
                RatingPrice = 50000,
                BidPrice = 50000,
                BidCustomName = "Bob",
                BidCustomPhone = 88888888,
                BidTimestamp = DateTime.Now
            }
        };


        public static IEnumerable<Bid> Bids = new List<Bid> {
            new Bid {
                ItemNumber = 123456,
                Price = 2100,
                CustomName = "Bjørk Boye Busch",
                CustomPhone = 63129162,
            },
            new Bid {
                ItemNumber = 654321,
                Price = 50000,
                CustomName = "Bob",
                CustomPhone = 88888888,
            }
        };
    }
}