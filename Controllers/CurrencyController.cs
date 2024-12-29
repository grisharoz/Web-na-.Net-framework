using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_na_.net.Controllers
{
    public class Currency
    {
        public string Name = "";

        

        public int Id { get; set; }
    }
    
    public class CurrencyController : Controller
    {
        // GET: api/values
        [HttpGet,Route("currencies")]
        public IEnumerable<Currency> currencies()
        {
            Currency CurUsd = new Currency();
            CurUsd.Name = "USD";
            CurUsd.Id = 1;

            Currency CurEuro = new Currency();
            CurEuro.Name = "EURO";
            CurEuro.Id = 1;

            List<Currency> Lst = new List<Currency>();
            Lst.Add(CurUsd);
            Lst.Add(CurEuro);

            return Lst;


        }
        [HttpGet, Route("currencies/{id}")]
        public Currency currency(int id)
        {
            Currency CurUsd = new Currency();
            CurUsd.Name = "USD";
            CurUsd.Id = id;
            return CurUsd;
        }

       
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string name)
        {
            Console.WriteLine($"The name of currency is {name}");
        }

        

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

