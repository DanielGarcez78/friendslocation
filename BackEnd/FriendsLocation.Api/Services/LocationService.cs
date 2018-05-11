using FriendsLocation.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsLocation.Api.Services
{
    public class LocationService
    {

        public IEnumerable<Friend> GetNearFriends(int id,  double latitude, double longitude)
        {

            try
            {
                FriendService friendsService = new FriendService();
                IEnumerable<Friend> friends = new List<Friend>();
                IEnumerable<Friend> nearFriends = new List<Friend>();

                friends = friendsService.RecuperarTodosExcetoVisited(id);

                nearFriends = OrderFriendsByNearLocation(friends, latitude, longitude);

                return nearFriends;
            }
            catch (Exception e)
            {
                throw e;
            }



        }


        private IEnumerable<Friend> OrderFriendsByNearLocation(IEnumerable<Friend> listFriends, double latitude, double longitude)
        {

            try
            {
                List<Friend> distanceFriends = new List<Friend>();
                List<Friend> nearFriends = new List<Friend>();

                foreach(Friend friend in listFriends)
                {
                    friend.distance = CalculaDistancia(friend, latitude, longitude);
                    distanceFriends.Add(friend);
                }

                foreach (Friend friendDistance in distanceFriends.OrderBy(f => f.distance).Take(2).AsEnumerable())
                {
                    nearFriends.Add(friendDistance);
                }

                return nearFriends.AsEnumerable();

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private double CalculaDistancia(Friend friend, double latitude, double longitude)
        {
            try
            {
                double cateto1 = friend.latitude - latitude;
                double cateto2 = friend.longitude - longitude;

                return Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
