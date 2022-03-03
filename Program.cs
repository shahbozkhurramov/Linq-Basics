using System.Collections;
namespace LinqBasics;

public class Program
{
    public static void Main(string[] args)
    {
        // string[] cars = {"bmw", "merc", "ferrari", "lamborghini", "bugatti"};
        // var myCar = from car in cars
        //             where car.Contains('a')
        //             select car;
        // myCar.ToList().ForEach(car => Console.WriteLine(car));
        // var myCar1 = cars.Where((c, i)=> i%2==0?true:false);
        // myCar1.ToList().ForEach(car => Console.WriteLine(car));

        // IList mixedList = new ArrayList(){"one", 2, "three", 4, "five"};
        // var stringResult = mixedList.OfType<string>();
        // stringResult.ToList().ForEach(res => Console.WriteLine(res));

        // List<string> students = new(){"shahboz", "muhammad", "john", "umar"};
        // var sortedStudents = from student in students
        //                     orderby student
        //                     select student;
        // sortedStudents.ToList().ForEach(c => Console.WriteLine(c));

        // var desStudents = students.OrderByDescending(s => s);
        // desStudents.ToList().ForEach(c => Console.WriteLine(c));

        IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } 
        };

        // var groupedResult = from s in studentList
        //                     group s by s.Age;
                
        // foreach(var group in groupedResult)
        // {
        //     Console.WriteLine(group.Key);
        //     foreach (var item in group)
        //     {
        //         Console.WriteLine(item.StudentName);
        //     }
        // }

        // var lookupResult = studentList.ToLookup(s => s.Age);

        // foreach (var group in lookupResult)
        // {
        //     Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 
                    
        //     foreach(Student s in group)  //Each group has a inner collection  
        //         Console.WriteLine("Student Name: {0}", s.StudentName);
        // }

        // IList<Student> studentList = new List<Student>() { 
        //     new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
        //     new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
        //     new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
        //     new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
        //     new Student() { StudentID = 5, StudentName = "Ron"  },
        //     new Student() { StudentID = 6, StudentName = "Shah"  } 
        // };

        // IList<Standard> standardList = new List<Standard>() { 
        //     new Standard(){ StandardID = 1, StandardName="Standard 1"},
        //     new Standard(){ StandardID = 2, StandardName="Standard 2"},
        //     new Standard(){ StandardID = 3, StandardName="Standard 3"},
        //     new Standard(){ StandardID = 4, StandardName="Standard 4"}
        // };

        // var innerJoin = studentList.Join(
        //                     standardList,
        //                     student => student.StandardID,
        //                     standard => standard.StandardID, 
        //                     (student, standard) => new 
        //                                     {
        //                                         StudentName = student.StudentName,
        //                                         StandardName = standard.StandardName
        //                                     });
        // innerJoin.ToList().ForEach(i => Console.WriteLine($"{i.StudentName}-{i.StandardName}"));

        // var groupJoin = standardList.GroupJoin(studentList,
        //                         standard => standard.StandardID,
        //                         student => student.StandardID,
        //                         (standard, studentsGroup) => new
        //                         {
        //                             Students = studentsGroup,
        //                             StandardFullName = standard.StandardName
        //                         });
        // var groupJoin1 = studentList.GroupJoin(standardList,
        //                         student => student.StandardID,
        //                         standard => standard.StandardID,
        //                         (student, standarts) => new
        //                         {
        //                             Student1 = student,
        //                             Standards = standarts
        //                         });

        // foreach (var item in groupJoin)
        // { 
        //     Console.WriteLine(item.StandardFullName);
        //     foreach(var stud in item.Students)
        //         Console.WriteLine(stud.StudentName);
        // }

        var agecheck = studentList.All(s => s.Age>20);
        Console.WriteLine(agecheck);
        
    }
}

public class Student
{
    public int StudentID { get; set; }
    
    public string StudentName { get; set; }
    
    public int Age { get; set; }
}
// public class Student{ 
//     public int StudentID { get; set; }
//     public string StudentName { get; set; }
//     public int StandardID { get; set; }
// }

// public class Standard{ 
//     public int StandardID { get; set; }
//     public string StandardName { get; set; }
// }