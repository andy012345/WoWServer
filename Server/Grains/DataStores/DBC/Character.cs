using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public partial class DataStoreManager
    {
        CharStartOutfitStore _CharacterOutfitStore = new CharStartOutfitStore();
        ChrClassesStore _ChrClassesStore = new ChrClassesStore();
        ChrRacesStore _ChrRacesStore = new ChrRacesStore();

        [DBCLoad]
        public List<Task> LoadCharacterDBCs()
        {
            List<Task> ret = new List<Task>();
            ret.Add(_CharacterOutfitStore.Load("CharStartOutfit.dbc"));
            ret.Add(_ChrClassesStore.Load("ChrClasses.dbc"));
            ret.Add(_ChrRacesStore.Load("ChrRaces.dbc"));
            return ret;
        }

        public Task<ChrClasses> GetChrClasses(UInt32 Class)
        {
            return Task.FromResult(_ChrClassesStore.Get(Class));
        }

        public Task<ChrRaces> GetChrRaces(UInt32 Race)
        {
            return Task.FromResult(_ChrRacesStore.Get(Race));
        }
    }
}
