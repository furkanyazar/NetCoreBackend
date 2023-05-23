﻿namespace Core.Entities.Abstract;

public class Entity<TId> : IEntityTimestamps
{
    public TId Id { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }

    public Entity() { }

    public Entity(TId id, bool status)
        : this()
    {
        Id = id;
        Status = status;
    }
}
