namespace Firstyoutubeproject.Models
{
    public class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public int Balance { get; set; }

        public student(string name,int age,string grade,int bal)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            this.Balance = bal;
        }

        public student()
        {
        }
    }
}
