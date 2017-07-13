using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullRequestSandbox
{
    class Gadget
    {
        Dictionary<string, string> values = new Dictionary<string, string>();

        public void SetBlerp(string value)
        {
            Guard.NotNull(value, nameof(value));

            values["blerp"] = value;
        }

        public void SetBloop(string value)
        {
            Guard.NotNull(value, nameof(value));

            values["bloop"] = value;
        }
    }
}
