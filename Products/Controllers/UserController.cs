using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.BL.Contracts;
using Products.DomainModel;
using Products.Model;

namespace Products.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUser blUser;
        public UserController(IMapper mapper, IUser user)
        {
            this.mapper = mapper;
            this.blUser = user;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            var users = blUser.GetUsers();
            return mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            var _user = blUser.GetUser(id);
            return mapper.Map<User, UserModel>(_user);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] UserModel user)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
