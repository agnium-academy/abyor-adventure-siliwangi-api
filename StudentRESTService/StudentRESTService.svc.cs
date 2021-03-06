﻿using System;
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
        //public List<Students> Students()
        //{
        //    return StudentList.Instance.studentlist;
        //}

        static IStudentsRepository repository = new StudentRepository();

        //GET Methods
        public List<Students> GetStudentList()
        {
            return repository.GetAllStudents();
        }

        //GET Methods
        public Students GetStudentByID(string NIM)
        {
            return repository.GetStudentsId(int.Parse(NIM));
        }

        //GET Methods for Name
        public Students GetStudentByName(string Nama)
        {
            return repository.GetStudentByName(Nama);
        }

        //POST Methods
        public string AddBook(Students student, string NIM)
        {
            Students newStudent = repository.AddNewStudents(student);
            return "NIM =" + newStudent.NIM;
        }

        //PUT Methods
        public string UpdateBook(Students student, string NIM)
        {
            bool updated = repository.UpdateAStudents(student);
            if (updated)
                return "Student with id = " + NIM + " updated successfully";
            else
                return "Unable to update student with NIM = " + NIM;
        }

        public string DeleteBook(string NIM)
        {
            bool deleted = repository.DeleteAStudents(int.Parse(NIM));
            if (deleted)
                return "Student with id = " + NIM + " deleted successfully";
            else
                return "Unable to delete book with id = " + NIM;
        }

    }
}