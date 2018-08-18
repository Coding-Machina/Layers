using L.EF;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using L.BF;

namespace Layers.Controllers.WebApiController
{
    public class BatchController : ODataController
    {

        [EnableQuery]
        [System.Web.Http.HttpGet]
        public IQueryable<Batch> Get()
        {
            BatchService batchService = new BatchService();
            return batchService.GetBatches();
        }
        public IHttpActionResult Post(Batch batch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BatchService batchService = new BatchService();
            return Created(batchService.Add_Batch(batch));
        }

    }
}
