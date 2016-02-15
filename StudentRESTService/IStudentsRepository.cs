using StudentRESTService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRESTService
{
    public interface IStudentsRepository 
    {
        List<Students> GetAllStudents();

        Students GetStudentsId(int Id);

        Students GetStudentByName(string Nama);

        Students AddNewStudents(Students item);

        bool DeleteAStudents(int Id);

        bool UpdateAStudents(Students item);
    }
}
