using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayerStandard.DataEntities;

namespace RoboWaiterWeb.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IPrinterBillsHistoryDE PrinterBillHistory { get { return new BusinessLayer.Context(@"C:\PosLite\PosLite.s3db").Get<IPrinterBillsHistoryDE>();  } }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return PrinterBillHistory.GetAll().Select(x => x.Bill);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var printerBilHistory = PrinterBillHistory.GetById(id);
            return printerBilHistory == null ? "Not existing" : printerBilHistory.Bill;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
