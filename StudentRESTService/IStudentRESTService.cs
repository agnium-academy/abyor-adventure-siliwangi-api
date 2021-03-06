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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentRESTService" in both code and config file together.
    [ServiceContract]
    public interface IStudentRESTService
    {
        // Similar function with getStudenList();
        //[OperationContract]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
        //                           BodyStyle = WebMessageBodyStyle.Bare,
        //                           UriTemplate = "Students/")]
        //List<Students> Students();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Students/")]
        List<Students> GetStudentList();

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Students/{NIM}")]
        Students GetStudentByID(string NIM);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "StudentName/{Nama}")]
        Students GetStudentByName(string Nama);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddStudents/{NIM}")]
        string AddBook(Students student, string NIM);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateStudents/{NIM}")]
        string UpdateBook(Students student, string NIM);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteStudents/{NIM}")]
        string DeleteBook(string NIM);
    }
}
