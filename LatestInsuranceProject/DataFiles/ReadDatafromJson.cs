using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace LatestInsuranceProject.DataFiles
{
    [TestFixture]
    public class ReadDatafromJson
    {

        public class config
        {


      
            public string InsuranceName { get; set; }
            public string Breakdowncover { get; set; }

            public string Windscreenrepair { get; set; }
            public string user_id { get; set; }
            public string incidents { get; set; }
            public string Registration { get; set; }
            public string Annualmileage { get; set; }
            public string Estimatedvalue { get; set; }
            public string ParkingLocation { get; set; }
            public string Startofpolicy { get; set; }

   
        }


        public static ArrayList readData(String path)
        {

            string filePath = File.ReadAllText(path);
            var config =JsonSerializer.Deserialize<config>(filePath);
            Console.WriteLine(config.InsuranceName);
          ArrayList list = new ArrayList();
            list.Add(config.InsuranceName);
            list.Add(config.Breakdowncover);
            list.Add(config.Windscreenrepair);
            list.Add(config.user_id);
            list.Add(config.incidents);
            list.Add(config.Registration);
            list.Add(config.Annualmileage);
            list.Add(config.Estimatedvalue);
            list.Add(config.ParkingLocation);
            list.Add(config.Startofpolicy);


            return list;
        }

     
    }
}
