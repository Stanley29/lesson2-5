namespace Lesson_2
{
    class Lesson
    {
        static void Main (string[] args)
        {

            int num_1 = 3;
            int num_2 = 20;
            var res_1 = Math.Abs(num_1) * Math.Sin(num_2);
            Console.WriteLine(res_1);

            int num = -6;
            var Xx = num * Math.Pow(num, 3) + 5 * Math.Pow(num, 2) - 10 * num + 15;


            Console.WriteLine(Xx);

            int num2 = 2;

            var res = num2 * Math.PI * num2;

            Console.WriteLine(res);


            int num_3 = 10;
            int num_4 = 125;

            var result = Math.Max(num_3, num_4);
            Console.WriteLine(result);

           

            


        }
    }
}






