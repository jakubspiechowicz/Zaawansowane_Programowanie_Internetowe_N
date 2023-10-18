using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Model.Entities
{
    public class StationaryStoreEmployee : User
    {
        #region properties
        [Key]
        public int Id {get; set;}
        public int StationaryStoreId {get;set;}
        public virtual StationaryStore StationaryStore {get;set;}
        #endregion
    }
}