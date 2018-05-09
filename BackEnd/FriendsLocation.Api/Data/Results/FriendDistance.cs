using FriendsLocation.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsLocation.Api.Data.Results
{
    public class FriendDistance
    {

        public double distance { get; set; }

        public Friend friend { get; set; }

    }
}
