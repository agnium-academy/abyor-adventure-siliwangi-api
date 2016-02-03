using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Repository
    {
        private static Dictionary<string, Students> responses;
        static Repository()
        {
            responses = new Dictionary<string, Students>();
            responses.Add("Trio A", new Students
            {
                Name = "Trio",
                Email = "trio@example.com",
                WillAttend = true
            });
            responses.Add("Ucu", new Students
            {
                Name = "Ucu",
                Email = "ucu@example.com",
                WillAttend = true
            });
            responses.Add("dwi", new Students
            {
                Name = "dwi",
                Email = "dwi@example.com",
                WillAttend = true
            });
            responses.Add("Sofi", new Students
            {
                Name = "sofi",
                Email = "soi@example.com",
                WillAttend = true
            });
        }
        public static void Add(Students newResponse)
        {
            string key = newResponse.Name.ToLowerInvariant();
            if (responses.ContainsKey(key))
            {
                responses[key] = newResponse;
            }
            else {
                responses.Add(key, newResponse);
            }
        }
        public static IEnumerable<Students> Responses
        {
            get { return responses.Values; }
        }
    }
}