using System;

namespace Entities.Abstract
{
    public interface IUpdatedEntity
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
