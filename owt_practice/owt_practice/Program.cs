using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter The List Of Subjects");
int subjectmarks = Convert.ToInt32(Console.ReadLine());
String[] subjectname = new string[subjectmarks];

int[] marks = new int[subjectmarks];
int total = 0;
int per = 0;
int fail = 0;



for (int i = 0; i < subjectname.Length; i++)
{
    Console.WriteLine("Enter The Subject: ");
    subjectname[i] = Console.ReadLine();
     
    Console.WriteLine("Enter The Subject Marks: ");
    marks[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < subjectname.Length; i++)
{
    Console.WriteLine("Subject Name: " + subjectname[i]);
    Console.WriteLine("Subject Marks: " + marks[i]);
    total += marks[i];


    per = total / subjectname.Length;


    if (marks[i] <= 35)
    {
        fail++;

        Console.WriteLine("Fail" + fail);

    }

    else if (true)
    {
        if (per >= 35 && per <= 50)
        {
            Console.WriteLine("Pass");
        }

        else if (per >= 50 && per <= 60)
        {
            Console.WriteLine("Second Class");
        }

        else if (per >= 60 && per <= 80)
        {
            Console.WriteLine("First Class");
        }

        else if (per >= 90 && per <= 100)
        {
            Console.WriteLine("Dist");
        }
    }

}
Console.WriteLine("total " + total);
Console.WriteLine("Per " + per);