using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ClaimsMS.ClaimsSystem;

namespace ClaimsMS.UseCases
{
    public class ViewClaimsByBeneId
    {

        private readonly ClaimsRepository claimsRepository;

        public ViewClaimsByBeneId(ClaimsRepository claimsRepository)
        {
            this.claimsRepository = claimsRepository;
        }
  
        public async Task<IEnumerable<Claims>> ExecuteAsync(string name)
        {


        }
    }
}
