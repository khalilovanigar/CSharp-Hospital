using System;
using DepartmentNamespace;
using UsersNamespace;
using DoctorsNamespace;
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
while (true)
{
    System.Console.WriteLine("Enter your Name: ");
    string username = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Surname: ");
    string surname = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Mail: ");
    string email = Console.ReadLine()!;

    System.Console.WriteLine("Enter your Phone Number: ");
    string phonenumber = Console.ReadLine()!;
    
}

/*

Tesevvur edek ele bir program yaziriq ki bu program sayesinde istifadeci istediyi taride istediyi hekimin gebuluna yazila biler
Esas sertler asagdakilardir.

1. Xestexanin uc sobesi var:
- Pediatriya
- Travmatologiya
- Stamotologiya

2. Her sobede hekim sayi ferqlidir (3,2,4)
- Hekimin asagdaki parametrleri var
+ Adi
+ Soyadi
+ Is tecrubesi (il olaraq)

3. Her hekimin de gun erzinde 3 gebul saati var:
+ 09:00-11:00
+ 12:00-14:00
+ 15:00-17:00
Proqrami ise salanda:
1. User oz melumatlarini daxil edir (Ad, Soyad, Email, Telefon)
2. 3 sobeden birini secir
3. Hemen sobede isleyen bir hekimi secir
4. Hansi saati rezerv elemek isteyirse on secir. (saatlarin yaninda rezerv olunub ve ya olunmayib yazilmalidir). Baslangic olarag butun saatlarin gabaginda rezerv olunmayib yazilir. Rezerv olunmus tarixi secse yazilmalidir hemen vat artig rezerv olunub zehmet olmasa basqa bir vat secin. Yene de secim sansi verir program dayanmir (rekursiya)
Vati rezerv edenden sonra yazilir ki tesekkurler Eli Eliyev siz sat 12:00 de Hesen hekimin qebuluna yazildiniz. Proqram qayidir en basa. Yeni User yaradib gebula yazilmaq istedikde artiq Hesen hekimin 12:00-14:00 ucun olan tarixinin qabagina rezerv olunub yazilmalidir
*Bu merheleni bitirenler eger daha da qelizlesdirmek istese. Onda tarixlerle islesinler. Yeni istifadeci birinci tarixi sececek sonra hemen tariden saat sececek.



*/