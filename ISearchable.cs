    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssytem
{
    // Interface för sökbara objekt
    internal interface ISearchable
    {
        // Sök efter ett nyckelord
        void Search(string keyword);
    }
}
