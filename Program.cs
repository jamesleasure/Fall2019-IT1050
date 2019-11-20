using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course("IT 1050");
            //course1.courseNumber = "IT 1050";
            course1.title = "Programming Logic";
            course1.maxEnrollment = 23;
            // this should fail because IT classes can only take a value D204 or D205
            course1.SetRoom("C245");
            // this one should work
            course1.SetRoom("D205");
            course1.Display();

            for (int i = 0; i < 28; i++)
            {
                course1.addStudent();
            }
            course1.Display();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Now working with course 2...");

            Course course2 = new Course("ENG 1010");
            //course1.courseNumber = "IT 1050";
            course2.title = "English";
            course2.maxEnrollment = 60;
            // this should work because we can assign any value to a non-IT course
            course2.SetRoom("C245");
            course2.Display();

            for (int i = 0; i < 42; i++)
            {
                course2.addStudent();
            }
            course2.Display();

        }
    }

    class Course
    {
        public string courseNumber;
        public string title;
        public int maxEnrollment;
        private int currentEnrollment;
        private string room;

        // constructor method
        //   Remember constructor methods: 1) no return type 2) Same name as class
        public Course(string courseNumber)
        {
            this.courseNumber = courseNumber;
        }

        // add 1 to currentEnrollment
        public void addStudent()
        {
            if (currentEnrollment < this.maxEnrollment) { 
                currentEnrollment++;
            }
            else
            {
                Console.WriteLine("addStudents() failed: Over the max enrollment");
            }
            return;
        }

        public int RemainingSeats()
        {
            int remainingSeats;
            remainingSeats = maxEnrollment - currentEnrollment;
            return remainingSeats;
        }

        public void Display()
        {
            Console.WriteLine($"Course: {courseNumber}\nTitle: {title}\nCurrent Enroll: {currentEnrollment}\nMax Enrollment: {maxEnrollment}");
            Console.WriteLine($"Remaining Seats: {RemainingSeats()}");
            Console.WriteLine($"Room number: {room}\n");
        }

        /*
         * Add a room number property
         * if the coursenumber starts with the letters "IT"
         *      then the room number can only be D204 or D205
         * show the program working for an it class and a non-IT class using 2 objects in the main method
         * use Display() to show the room number with the course
         */
         public void SetRoom(string room)
        {
            if (this.courseNumber.Substring(0,2) == "IT")
            {
                if (room == "D204" || room == "D205")
                {
                    this.room = room;
                }
                else
                {
                    Console.WriteLine("SetRoom() failed: IT classes can only be in room 204 or 205");
                }
            }
            else
            {
                this.room = room;
            }
        }

    }
}
