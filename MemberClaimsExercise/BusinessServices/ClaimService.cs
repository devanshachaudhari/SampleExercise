using System;
using System.Collections.Generic;
using System.Linq;
using BusinessModels.Csv;
using BusinessModels.Custom;
using Repositories;

namespace BusinessServices
{
    public class ClaimService : IClaimService
    {
        private readonly IRepository<Member> _memberRepository;
        private readonly IRepository<Claim> _claimRepository;
        
        public ClaimService(IRepository<Member> memberRepository, IRepository<Claim> claimRepository) {
            _memberRepository = memberRepository;
            _claimRepository = claimRepository;
        }


        public IList<MemberClaims> GetClaimsByMember(DateTime? asOfDate = null)
        {
            List<Member> members = _memberRepository.GetAll().ToList();
            List<Claim> claims = _claimRepository.GetAll().ToList();

            List<MemberClaims> result = members
                                        .Join(claims, m => m.MemberID, c => c.MemberID, (member, claim) => new { member, claim })
                                        .Where(x => asOfDate == null || x.claim.ClaimDate <= asOfDate.Value)
                                        .GroupBy(x => x.member)
                                        .Select( x=>
                                            new MemberClaims { 
                                                MemberID = x.Key.MemberID,
                                                FirstName = x.Key.FirstName,
                                                LastName = x.Key.LastName,
                                                EnrollmentDate = x.Key.EnrollmentDate,
                                                Claims = x.Select( y => y.claim)?.ToList()
                                            }
                                        ).ToList();

            return result;            
        }
    }
}
