using ClothesToU.Site.Models.Core.Interfaces;
using ClothesToU.Site.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesToU.Site.Models.Repositorties
{
    public class MemberRepository : IMemberRepository
    {
        private AppDbContext db = new AppDbContext();

        public bool IsExist(string account)
        {
            var entity = db.Members.SingleOrDefault(member => member.Account == account);
            var result = entity == null? false: true;
            return result;
        }
    }
}