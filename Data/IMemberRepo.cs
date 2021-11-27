using System.Collections.Generic;
using demo05.Models;

namespace demo05.Data
{
    public interface IMemberRepo
    {
        List<Member> GetAllMember(); //lấy hết ds
        Member GetMember(int id); //lấy theo id
        void DeleteMember(Member member); //xóa
        void UpdateMember(Member member); //cập nhật
        void CreateMember(Member member); //thêm
    }
}