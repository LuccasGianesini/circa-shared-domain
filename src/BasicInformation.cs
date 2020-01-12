using System;
using System.Collections.Generic;

namespace Circa.Shared.Domain
{
    public class BasicInformation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public Permission Permission { get; set; }
    }
}