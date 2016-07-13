using System;

namespace Domain.Entities {

    public interface IEntity {

        Guid Key { get; set; }
    }
}