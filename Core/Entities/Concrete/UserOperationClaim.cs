﻿using Core.Entities.Abstract;

namespace Core.Entities.Concrete;

public class UserOperationClaim : Entity<int>
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual User User { get; set; } = null!;
    public virtual OperationClaim OperationClaim { get; set; } = null!;

    public UserOperationClaim() { }

    public UserOperationClaim(int id, int userId, int operationClaimId)
        : this()
    {
        Id = id;
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}
