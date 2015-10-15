using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public partial class DataStoreManager
    {
        private GTCombatRatingsEntry _GTCombatRatingsEntry = new GTCombatRatingsEntry();

        [DataStoreLoader]
        public List<Task> LoadGTableDBCs()
        {
            List<Task> ret = new List<Task>();
            ret.Add(_GTCombatRatingsEntry.Load("gtCombatRatings.dbc"));
            return ret;
        }
    }
}