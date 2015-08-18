using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public partial class DataStoreManager
    {
        GTCombatRatingsEntry _GTCombatRatingsEntry = new GTCombatRatingsEntry();

        [DBCLoad]
        public void LoadGTableDBCs()
        {
            _GTCombatRatingsEntry.Load("gtCombatRatings.dbc");
        }
    }
}
