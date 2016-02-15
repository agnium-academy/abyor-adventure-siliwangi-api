using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentRESTService.Model;

namespace StudentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        static IStudentsRepository repository = new StudentRepository();

        //GET Methods
        public List<Students> getStudentList()
        {
            return repository.GetAllStudents();
        }

        //GET Methods
        public Students getStudentByID(string NIM)
        {
            return repository.GetStudentsId(int.Parse(NIM));
        }

        //POST Methods
        public string addBook(Students student, string NIM)
        {
            Students newStudent = repository.AddNewStudents(student);
            return "id=" + newStudent.NIM;
        }

        //PUT Methods
        public string updateBook(Students student, string NIM)
        {
            bool updated = repository.UpdateAStudents(student);
            if (updated)
                return "Student with id = " + NIM + " updated successfully";
            else
                return "Unable to update student with NIM = " + NIM;
        }

        public string deleteBook(string NIM)
        {
            bool deleted = repository.DeleteAStudents(int.Parse(NIM));
            if (deleted)
                return "Student with id = " + NIM + " deleted successfully";
            else
                return "Unable to delete book with id = " + NIM;
        }
    }
}
