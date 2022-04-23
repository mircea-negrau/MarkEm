using System;

namespace Org.Webelopers.Api.Models.Persistence.Contracts
{
    public class ContractEnriched
    {
        public Guid Id { get; set; }
        public long? SignedAt { get; set; }
        public string? Specialisation { get; set; }
        public string? Faculty { get; set; }
    }
}
