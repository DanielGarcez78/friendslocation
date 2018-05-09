using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsLocation.Api.Data.Entities;
using FriendsLocation.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FriendsLocation.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Locator")]
    public class LocatorController : Controller
    {

        [HttpGet("{id}")]
        public List<Friend> getNearFriends(int id)
        {
            try
            {
                FriendService friendService = new FriendService();
                LocationService locationService = new LocationService();

                List<Friend> friends = new List<Friend>();

                Friend friend = friendService.Recuperar(id);
                if (friend != null)
                {
                    friends = locationService.GetNearFriends(id, friend.latitude, friend.longitude).ToList();
                }

                return friends;
            }
            catch (Exception e)
            {
                throw e;
                //return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }

    }
}