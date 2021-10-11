using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class Student
    {
        private int studentNumber;
        private string name;
        private string surname;
        private string dateOfBirth;
        private string phoneNumber;
        private string address;
        private byte[] photo;
        private string moduleCode;

        public Student() { }
        public Student(int studentNumber, string name, string surname, string dateOfBirth, string phoneNumber, string address, byte[] photo, string moduleCode)
        {
            this.StudentNumber = studentNumber;
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Photo = photo;
            this.ModuleCode = moduleCode;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Photo { get => photo; set => photo = value; }
        public string ModuleCode { get => moduleCode; set => moduleCode = value; }

        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }
}
