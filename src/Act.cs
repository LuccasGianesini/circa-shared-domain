using System.Collections.Generic;

namespace Circa.Shared.Domain
{
    public class Act : BasicInformation
    {
        public List<Combat> Combats { get; set; }

    }
}