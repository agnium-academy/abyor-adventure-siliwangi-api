﻿using StudentRESTService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIStudentRESTServices" in both code and config file together.
    [ServiceContract]
    public interface IStudentRESTServices
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                  BodyStyle = WebMessageBodyStyle.Bare,
                                  UriTemplate = "GetStudentList/")]
        List<Students> GetStudentList();
    }
}