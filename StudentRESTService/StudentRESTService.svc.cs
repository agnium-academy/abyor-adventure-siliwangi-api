using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentRESTService.Model;

namespace StudentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentRESTService.svc or StudentRESTService.svc.cs at the Solution Explorer and start debugging.
    public class StudentRESTService : IStudentRESTService
    {
        public List<Students> Students()
        {
            return StudentList.Instance.studentlist;
        }
    }
}
