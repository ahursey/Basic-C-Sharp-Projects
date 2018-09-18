using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesExercise
{
    public class DaisyChain
    {
        public DaisyChain(int ID, Guid uniqueID, string userName)
        {
            uniqueID = Guid.NewGuid();
        }

        public DaisyChain(int ID, string userName) : this(ID, Guid.NewGuid(), userName)
        {
            uniqueID = Guid.NewGuid();
        }

    public int ID { get; set; }
    public Guid uniqueID { get; set; }
    public string userName { get; set; }
}
}
