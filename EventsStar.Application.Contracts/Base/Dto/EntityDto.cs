using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsStar.Application.Contracts.Base.Dto
{
    public class EntityDto<TKey>
    {
        public TKey Id
        {
            get;
            set;
        }
    }
}
