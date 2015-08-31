using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestEverything.Handlers
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            Person[] res = GetUsers();
            var linq = (from u in res
                        where u.Genger == 'M'
                        select u);
        }

        private Person[] GetUsers()
        {
            List<Person> pList = new List<Person>();
            pList.Add(new Person()
            {
                UserID = 1,
                FirstName = "Mike",
                LastName = "H",
                Age = 40,
                Genger = 'M'
            });
            pList.Add(new Person()
            {
                UserID = 2,
                FirstName = "Viki",
                LastName = "G",
                Age = 33,
                Genger = 'F'
            }); pList.Add(new Person()
            {
                UserID = 3,
                FirstName = "Eliana",
                LastName = "G",
                Age = 8,
                Genger = 'F'
            });
            return pList.ToArray();
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class Person
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Genger { get; set; }
    }
}