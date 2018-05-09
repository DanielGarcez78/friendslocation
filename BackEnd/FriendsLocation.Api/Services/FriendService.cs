using FriendsLocation.Api.Data.Context;
using FriendsLocation.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsLocation.Api.Services
{
    public class FriendService
    {


        public List<Friend> RecuperarTodos()
        {
            try
            {

                using (var _context = new FriendsLocationContext())
                {
                    return _context.Friend.OrderBy(f=> f.nome).ToList();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Friend> RecuperarTodosExcetoVisited(int id)
        {
            try
            {

                using (var _context = new FriendsLocationContext())
                {
                    return _context.Friend.Where(f => f.id != id).OrderBy(f => f.nome).ToList();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Friend Recuperar(int id)
        {
            try
            {
                using (var _context = new FriendsLocationContext())
                {
                    Friend friend = _context.Friend.Where(f => f.id == id).FirstOrDefault();
                    return friend;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Incluir(Friend friend)
        {
            try
            {
                using (var _context = new FriendsLocationContext())
                {
                    _context.Friend.Add(friend);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Atualizar(Friend friend)
        {
            try
            {
                using (var _context = new FriendsLocationContext())
                {
                    Friend friendUpd = _context.Friend.Where(f => f.id == friend.id).FirstOrDefault();
                    if (friendUpd != null)
                    {
                        friendUpd.nome = friend.nome;
                        _context.Update(friendUpd);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Excluir(int id)
        {
            try
            {
                using (var _context = new FriendsLocationContext())
                {
                    Friend friendExc = _context.Friend.Where(f => f.id == id).FirstOrDefault();
                    if (friendExc != null)
                    {
                        _context.Remove(friendExc);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
