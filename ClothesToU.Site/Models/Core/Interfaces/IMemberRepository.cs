using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesToU.Site.Models.Core.Interfaces
{
    internal interface IMemberRepository
    {
        bool IsExist(string account);
       

    }
}
