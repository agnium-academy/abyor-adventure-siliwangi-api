using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRESTService.Model
{
    public class StudentList
    {
        private static readonly StudentList _instance = new StudentList();
        private StudentList() { }
        public static StudentList Instance
        {
            get { return _instance; }
        }
        public List<Students> studentlist
        {
            get { return students; }
        }
        private List<Students> students = new List<Students>()
        {
            new Students() {NIM = 1, Nama = "Trio", Alamat="Brebes" ,Umur=17},
            new Students() {NIM = 2, Nama = "Dwi", Alamat="Cilacap" ,Umur=18},
            new Students() {NIM = 3, Nama = "Sofi", Alamat="Banten" ,Umur=18},
            new Students() {NIM = 4, Nama = "Ucu", Alamat="Kalimantan" ,Umur=20},
            new Students() {NIM = 5, Nama = "Ambar", Alamat="Jogja" ,Umur=31}
        };
    }
}