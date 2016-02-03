using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StudentRESTService
{
    [DataContract]
    public class Students
    {
        [DataMember]
       public string Alamat { get; set; }

        [DataMember]

        public int NIM { get; set; }

        [DataMember]
        public string Nama { get; set; }

        [DataMember]
        public int Umur { get; set; }


    }
}