using System;
using DepartmentNamespace;
using UsersNamespace;
using DoctorsNamespace;
using ShowMenuNamespace;
using ReservNamespace;
using System.ComponentModel.DataAnnotations;


var pediatricsDoctors = new List<Doctor>
{
    new Doctor("Sevda","Ehmedova",6),
    new Doctor("Selim","Eliyev",4),
    new Doctor("Leyla","Memmedli",7)
};

var traumatologyDoctors = new List<Doctor>
{
    new Doctor("Yasin","Hakverdiyev",9),
    new Doctor("Revan","Aliyev",3),
    new Doctor("Nuray","Memmedova",5)
};

var stomotologyDoctors = new List<Doctor>
{
    new Doctor ("Ramin","Hesenli",3),
    new Doctor ("Anar","Suleymanov",7),
    new Doctor ("Medine","Qurbanli",8)
};

var departments = new List<Department>
{
    new Department("Pediatriya",pediatricsDoctors),
    new Department("Travmotologiya",traumatologyDoctors),
    new Department("Stomologiya",stomotologyDoctors)
};

//var hours = new List<string> { "09:00-11:00", "12:00-14:00", "15:00-17:00" };

while (true)
{
    System.Console.WriteLine("Enter your Name: ");
    string name = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Surname: ");
    string surname = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Mail: ");
    string email = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Phone Number: ");
    string phonenumber = Console.ReadLine()!;

    System.Console.WriteLine();

    var depNames = new List<string>();
    foreach (var d in departments)
        depNames.Add(d.DepartmentName!);

    int depIndex = ShowMenuHelper.ShowMenu(depNames, "Choose Department:");

    var selectedDepartment = departments[depIndex];
    var doctorNames = new List<string>();
    foreach (var doc in selectedDepartment.Doctors)
        doctorNames.Add($"{doc.Name} {doc.Surname}");

    int docIndex = ShowMenuHelper.ShowMenu(doctorNames, "Choose Doctor:");

    int hourIndex;

    while (true)
    {
        var hours = new List<string>();
        for (int i = 0; i < selectedDepartment.Doctors[docIndex].Reserved.Count; i++)
        {
            hours.Add(selectedDepartment.Doctors[docIndex].Reserved[i].Time);
        }

        hourIndex = ShowMenuHelper.ShowMenu(hours, "Choose an hour:");

        if (!selectedDepartment.Doctors[docIndex].Reserved[hourIndex].IsReserved)
        {
            selectedDepartment.Doctors[docIndex].Reserved[hourIndex].IsReserved = true;
            break;
        }

        Console.WriteLine("This hour is full,choose another hour");
        Console.ReadKey();
    }

    Console.Clear();
    Console.WriteLine($"Thanks {name} {surname}!");
    Console.WriteLine($"{depNames[depIndex]} department Dr.{doctorNames[docIndex]} , {selectedDepartment.Doctors[docIndex].Reserved[hourIndex].Time} reserved.");
    Console.ReadLine();
}
