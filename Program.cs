using System;

namespace letter_grade_calculator_Andrew_Creswick{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the number score you have in your class:");
            int numberScore = int.Parse(Console.ReadLine());
            if(numberScore >=100){
                Console.WriteLine("Letter Grade: A+");
                Console.WriteLine("Nicely done!");
            }
            else if(numberScore >=90){
                Console.WriteLine("Letter Grade: A");
                Console.WriteLine("Good Job!");
            }
            else if(numberScore >=80){
                Console.WriteLine("Letter Grade: B");
                Console.WriteLine("Keep it up!");
            }
            else if(numberScore >=70){
                Console.WriteLine("Letter Grade: C");
                Console.WriteLine("Just a little bit more work!");
            }
            else if(numberScore >= 60 ){
                Console.WriteLine("Letter Grade: D");
                Console.WriteLine("Don't stop trying!");
            }
            else {
                Console.WriteLine("Letter Grade: E");
                Console.WriteLine("Can't get any lower than this so don't stop!");
            }
        }
    }
}