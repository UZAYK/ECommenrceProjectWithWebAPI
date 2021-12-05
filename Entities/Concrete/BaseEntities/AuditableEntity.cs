using Entities.Abstract;
using System;

namespace Entities.Concrete.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity, IUpdatedEntity
    {
        int ICreatedEntity.CreatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IUpdatedEntity.CreatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime ICreatedEntity.CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IUpdatedEntity.CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
