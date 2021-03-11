using ReCap.Core.DataAccess;
using ReCap.Core.Entities.Concrete;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

        List<OperationClaim> GetClaims(User user);

    }
}
