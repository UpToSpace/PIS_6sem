using System;

namespace _4.Models
{
    public class Data : IComparable
    {
        private int id;
        private string surname;
        private string phoneNumber;

        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Id { get => id; set => id = value; }

        public Data() { }
        public Data(int id, string surname, string number)
        {
            this.id = id;
            this.surname = surname;
            this.phoneNumber = number;
        }

        public int CompareTo(object obj)
        {
            if (obj is Data data)
            {
                return Surname.CompareTo(data.Surname);
            }
            throw new ArgumentException("Object is not correct");
        }
    }
}