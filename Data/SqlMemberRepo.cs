using System.Collections.Generic;
using System.Linq;
using demo05.EF;
using demo05.Models;

namespace demo05.Data
{
    public class SqlMemberRepo : IMemberRepo
    {
        MemberContext _context;
        public SqlMemberRepo(MemberContext context){
            this._context = context;
        }
        // phần này dùng như Entity connect console
        public void CreateMember(Member member)
        {
            _context.Add(member);
            _context.SaveChanges();
        }

        public void DeleteMember(Member member)
        {
            _context.Remove(member);
            _context.SaveChanges();
        }

        public List<Member> GetAllMember()
        {
            return _context.Members.ToList();
        }

        public Member GetMember(int id)
        {
            return _context.Members.FirstOrDefault(p=>p.MemberId == id);
        }

        public void UpdateMember(Member member)
        {
            _context.Update(member);
            _context.SaveChanges();
        }
    }
}