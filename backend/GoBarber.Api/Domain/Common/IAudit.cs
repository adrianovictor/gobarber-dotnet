using System;

namespace GoBarber.Api.Domain.Common
{
    public interface IAudit
    {
         DateTime CreatedAt { get; set; }
         int CreatedBy { get; set; }
         DateTime? UpdatedAt { get; set; }
         int? UpdatedBy { get; set; }
    }
}