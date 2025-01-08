using System;

namespace AsiaSushiOnCSharp.Domain.Entity.Base
{
    public abstract class AuditableBaseEntity : BaseEntity
    {
        public DateTimeOffset CreationDateTime { get; set; }
        public DateTimeOffset? ModifyDateTime { get; set; }
    }
}