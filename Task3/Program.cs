 Student[] students = new Student[5];

        students[0] = new Student { Name = "Shahrom Sharipov", GradeLevel = 10, Scores = new int[] { 85, 90, 88, 92, 89 } };
        students[1] = new Student { Name = "Abdullo Abdulloev", GradeLevel = 11, Scores = new int[] { 75, 80, 78, 82, 79 } };
        students[2] = new Student { Name = "Nurullo Sulaymonov", GradeLevel = 9, Scores = new int[] { 65, 70, 68, 72, 69 } };
        students[3] = new Student { Name = "Alijon Zabiri", GradeLevel = 8, Scores = new int[] { 95, 92, 98, 88, 91 } };
        students[4] = new Student { Name = "Olimjon Tojiev", GradeLevel = 12, Scores = new int[] { 60, 65, 62, 68, 64 } };

        foreach (Student student in students)
        {
            double averageScore = student.GetAverage();
            Console.Write($"{student.Name} - Average Score: {averageScore:F2} - ");

            if (averageScore > 85)
            {
                Console.WriteLine("Congratulations! Keep up the good work!");
                System.Console.WriteLine("_______________________________");
            }
            else if (averageScore < 70)
            {
                Console.WriteLine("You may need some additional support. Seek help if needed.");
                System.Console.WriteLine("________________________________");
            }
            else
            {
                Console.WriteLine("Great job! Keep striving for improvement!");
                System.Console.WriteLine("___________________________________");
            }
        }
















class Student{
    public string Name;
    public int GradeLevel;
    public int[] Scores;

    public double GetAverage(){
        int sum = 0;
        for (int i = 0; i < Scores.Length; i++)
        {
            sum += i;
        }
        return sum/Scores.Length;
    }

}


