
using System.Collections.Generic;
using demo05.Data;
using demo05.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo05.Controllers
{
    [Route("api/members")] //url của api
    [ApiController]
    public class MemberController:ControllerBase
    {
        private readonly IMemberRepo _repository; //repo này sẽ map với SqlRepo
        public MemberController(IMemberRepo repository) //khởi tạo
        {
            _repository = repository;
        }
        //GET: api/members
        [HttpGet]
        public ActionResult <IEnumerable<Member>> GetAllMember()
        {
            var memberList = _repository.GetAllMember();
            return Ok((IEnumerable<Member>)(memberList));
        }
         //GET: api/members/{id}
        [HttpGet("{id}")]
        public ActionResult <Member> GetMemberById(int id)
        {
            var member = _repository.GetMember(id);
            if(member!=null)
                return Ok((Member)(member));
            return NotFound();
        }

         //POST: api/members
        [HttpPost]
        public ActionResult CreateMember(Member member)
        {
            if(member!=null)
                _repository.CreateMember(member);
            return NoContent();
        }
         //PUT: api/members/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMember(int id,Member member)
        {      
            if(member!=null){
                member.MemberId = id;
                _repository.UpdateMember(member);
            }
            return NoContent();
        }
          //DELETE: api/members/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMember(int id)
        {      
            var member = _repository.GetMember(id);
            if(member!=null){
                _repository.DeleteMember(member);
            }
            return NoContent();
        }
    }
}