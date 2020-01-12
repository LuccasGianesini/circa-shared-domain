using System.Collections;
using System.Collections.Generic;

namespace Circa.Shared.Domain
{
    public class Campaign : BasicInformation
    {
        public User Dm { get; set; }
        public List<User> Players { get; set; }
        public Stack<Act> Acts { get; set; }

    }
}