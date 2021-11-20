using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataApi.Models;
using System.IO;

namespace DataApi.Controllers
{
    public class FruchtController : ApiController
    {
        //List<Frucht> FruitData = new List<Frucht>();
        public FruchtController()
        {
            

            
        }
        // GET: api/Frucht


        public FruchtD Get()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\steph\source\repos\DataApi\json\example_1.json");

            //string fileName = "example_1.json";
            //string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
           
            FruchtD Data = JsonConvert.DeserializeObject<FruchtD>(json);
        
            //FruitData = myObject.ToObject<List<Frucht>>();
        
            return Data;
            //return people;
        }

        //public Frucht Get()
        //{
        //    var webClient = new WebClient();
        //    var json = webClient.DownloadString(@"C:\Users\steph\source\repos\DataApi\json\example_1.json");
        //    Frucht Data = JsonConvert.DeserializeObject<List<Frucht>>(json);
        //
        //    //FruitData = myObject.ToObject<List<Frucht>>();
        //
        //    return Data;
        //    //return people;
        //}
        //public IEnumerable<Frucht> Get()
        //{
        //    var webClient = new WebClient();
        //    var json = webClient.DownloadString(@"C:\Users\steph\source\repos\DataApi\json\example_1.json");
        //    var FruitData = JsonConvert.DeserializeObject<Frucht>(json);
        //
        //    return FruitData;
        //}

        // GET: api/Frucht/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Frucht
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Frucht/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Frucht/5
        public void Delete(int id)
        {
        }
    }
}
