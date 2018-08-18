using L.BF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layers.Controllers
{
    public class BatchController : Controller
    {
        // GET: Batch
        public ActionResult Index()
        {
            BatchService batchService = new BatchService();
            return View(batchService.GetBatches());
        }
    }
}