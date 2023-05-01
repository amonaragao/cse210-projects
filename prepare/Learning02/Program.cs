using System;
using Learning02;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = " Microsoft";
        job2._startYear = 2019;
        job2._endYear =  2020;

        Resume resume1 = new Resume();
        resume1._name = "Charles Smith";
        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);

        resume1.Display();
    }
}