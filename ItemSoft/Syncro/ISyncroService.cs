using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemSoft.Syncro
{
    interface ISyncroService
    {
        void SyncroCategories();
        void SyncroItems();
        void StartAllSyncro();
    }
}
