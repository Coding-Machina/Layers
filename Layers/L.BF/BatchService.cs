using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L.EF;

namespace L.BF
{
    public class BatchService
    {

        private DataDemoEntities ctx;

        public BatchService()
        {
            ctx = new DataDemoEntities();
        }
        public Batch Add_Batch(Batch batch)
        {
            ctx.Batches.Add(batch);
            ctx.SaveChanges();
            return batch;
        }

        public IQueryable<Batch> GetBatches()
        {
            return ctx.Batches.AsQueryable();
        }


    }
}
