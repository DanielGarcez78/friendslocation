using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsLocation.Api.Data.Entities;
using FriendsLocation.Api.Services;
using FriendsLocation.Api.Util;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FriendsLocation.Api.Controllers
{
    [Route("api/friends")]
    public class FriendsController : Controller
    {

        [HttpGet]
        public List<Friend> getFriends(int id)
        {
            try
            {
                FriendService friendService = new FriendService();
                List<Friend> friends = friendService.RecuperarTodos().ToList();
                return friends;
            }
            catch (Exception e)
            {
                throw e;
                //return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult getFriend(int id)
        {
            try
            {
                FriendService friendService = new FriendService();
                Friend friend = friendService.Recuperar(id);
                return new ObjectResult(friend);
            }
            catch (Exception e)
            {
                return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }

        [HttpPost]       
        public IActionResult setFriend([FromBody] Friend friend)
        {
            try
            {
                FriendService friendService = new FriendService();
                friendService.Incluir(friend);

                return new ObjectResult(friend);
            }
            catch (Exception e)
            {
                return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }


        [HttpPut("{id}")]
        public IActionResult updFriend(int id, [FromBody] Friend friend)
        {
            try
            {
                FriendService friendService = new FriendService();
                if (id != 0)
                {
                    friendService.Atualizar(friend);
                }
                return new ObjectResult(friend);
            }
            catch (Exception e)
            {
                return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult excFriend(int id)
        {
            try
            {
                FriendService friendService = new FriendService();
                if (id != 0)
                {
                    friendService.Excluir(id);
                }
                return new ObjectResult("");
            }
            catch (Exception e)
            {
                return new ObjectResult(new ApiResponse() { codErro = "9999", msgErro = e.GetBaseException().Message });
            }
        }

    }
}