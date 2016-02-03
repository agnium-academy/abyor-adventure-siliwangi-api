using StudentRESTService;
using StudentRESTService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRESTService
{
    public class StudentRepository : IStudentsRepository
    {
        private List<Students> students = new List<Students>();
        private int counter = 1;

        public StudentRepository()
        {
            AddNewStudents(new Students { Nama = "Ucu", Alamat = "Kalimantan", Umur = 20 });
            AddNewStudents(new Students { Nama = "Trio", Alamat = "Brebes", Umur = 17 });
            AddNewStudents(new Students { Nama = "Dwi", Alamat = "Cilacap", Umur = 18 });
            AddNewStudents(new Students { Nama = "Sofi", Alamat = "Banten", Umur = 18 });
            AddNewStudents(new Students { Nama = "Ambar", Alamat = "Jogja", Umur = 18 });
        }

        public List<Students> GetAllStudents()
        {
            return students;
        }

        //public Students GetStudentByNIM(int NIM)
        //{
           
        //}

        public Students AddNewStudents(Students newStudent)
        {
            if (newStudent == null)
                throw new ArgumentNullException("newStudent");
            newStudent.NIM = counter++;
            students.Add(newStudent);
            return newStudent;
        }

        

        public Students GetStudentsId(int NIM)
        {
            return students.Find(b => b.NIM == NIM);
        }

        public bool DeleteAStudents(int NIM)
        {
            int idx = students.FindIndex(b => b.NIM == NIM);
            if (idx == -1)
                return false;
            students.RemoveAll(b => b.NIM == NIM);
            return true;
        }

        public bool UpdateAStudents(Students updatedStudents)
        {
            if (updatedStudents == null)
                throw new ArgumentNullException("updatedStudent");
            int idx = students.FindIndex(b => b.NIM == updatedStudents.NIM);
            if (idx == -1)
                return false;
            students.RemoveAt(idx);
            students.Add(updatedStudents);
            return true;
        }
    }


}