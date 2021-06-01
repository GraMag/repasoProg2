using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Files.Xml;
using Application.Models;
using Application.Files;

namespace Application.DataAcces
{
    // <summary>
    // Servicio para deserializar y serializar un cliente
    // </summary>
    public class CustomerSerializer : Xml<List<Customer>>
    {
        public bool Save(List<Customer> customer)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "OtherCustomers.xml";

            return base.Save(path, customer);

        }

        public List<Customer> Read(string path)
        {
            List<Customer> customers = new List<Customer>();


            if (!base.Read(path, out customers))
            {
                throw new Exception();//TODO: implementar
            }

            return customers;

        }
    }
}
