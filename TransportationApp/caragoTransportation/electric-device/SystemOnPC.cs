using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basics_lingar.inheritance
{
    public class SystemOnPC:PC
    {
        private string system;
        private string antiVirus;
        private Part part;

        public SystemOnPC(string model, string system, string antiVirus, Part part) : base(model)
        {
            this.system = system;
            this.antiVirus = antiVirus;
            this.part = part;
        }

        public override string ToString()
        {
            return $"{base.ToString()} with system {system}, antivirus {antiVirus}, and part {part}";
        }
    }
}
