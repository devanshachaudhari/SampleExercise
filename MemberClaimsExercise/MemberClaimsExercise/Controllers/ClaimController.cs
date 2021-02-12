using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessModels.Custom;
using BusinessServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberClaimsAPI.Controllers
{
    [Route("api/claims")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _service;

        public ClaimController(IClaimService service) {
            _service = service;
        }

        /// <summary>
        /// Get Claims by Member when passed a Date Param for claims made upto the DateParam
        /// </summary>
        /// <param name="date">As of Date</param>
        /// <returns>List of Claims by Members</returns>
        [HttpGet]
        public IList<MemberClaims> Get()
        {
            return _service.GetClaimsByMember();
        }

        /// <summary>
        /// Get Claims by Member when passed a Date Param for claims made upto the DateParam
        /// </summary>
        /// <param name="date">Use Date format as "YYYY-MM-DD"</param>
        /// <returns>List of Claims by Members</returns>
        [Route("{date?}")]
        [HttpGet]
        public IList<MemberClaims> GetClaimsByMember(DateTime? date)
        {
            return _service.GetClaimsByMember(date);
        }
    }
}