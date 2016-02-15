using StudentRESTService.Model;
using System;
using System.Collections.Generic;

namespace StudentRESTService
{
    public class StudentRepository : IStudentsRepository
    {
        private List<Students> students = new List<Students>();
        private int counter = 1;

        public StudentRepository()
        {
            AddNewStudents(new Students { NIM = 4, Nama = "Ucu", Alamat = "Kalimantan", Umur = 20 });
            AddNewStudents(new Students { NIM = 1, Nama = "Trio", Alamat = "Brebes", Umur = 17 });
            AddNewStudents(new Students { NIM = 2, Nama = "Dwi", Alamat = "Cilacap", Umur = 18 });
            AddNewStudents(new Students { NIM = 3, Nama = "Sofi", Alamat = "Banten", Umur = 18 });
            AddNewStudents(new Students { NIM = 5, Nama = "Ambar", Alamat = "Jogja", Umur = 18 });
        }

        //1. Create Students
        public Students AddNewStudents(Students newStudent)
        {
            if (newStudent == null)
                throw new ArgumentNullException("newStudent");
            newStudent.NIM = counter++;
            students.Add(newStudent);
            return newStudent;
        }

        //2. Get List All Students
        public List<Students> GetAllStudents()
        {
            return students;
        }

        //3. Get Students By NIM
        public Students GetStudentsId(int NIM)
        {
            return students.Find(b => b.NIM == NIM);
        }

        //4. Get Students By Name
        public Students GetStudentByName(string Nama)
        {
            return students.Find(b => b.Nama.Contains(Nama));
        }

        //3. Update Students
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

        //4. Delete Students
        public bool DeleteAStudents(int NIM)
        {
            int idx = students.FindIndex(b => b.NIM == NIM);
            if (idx == -1)
                return false;
            students.RemoveAll(b => b.NIM == NIM);
            return true;
        }

        

    }


}