﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {
        void Add(Member member);
    }
}
