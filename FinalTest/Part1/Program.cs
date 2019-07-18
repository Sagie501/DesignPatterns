using FinalTest.Question2;
using FinalTest.Question5;
using FinalTest.Question7;
using FinalTest.Question8;
using FinalTest.Question9;
using FinalTest.Question10;
using FinalTest.Question12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // Question 2
            //Question2();

            // Question 5
            //Question5();

            // Question 7
            //Question7();

            // Question 8
            //Question8();

            // Question 9
            //Question9();

            // Question 10
            //Question10();

            // Question 12
            //Question12();
        }

        public static void Question2()
        {
            Component root = new Composite(3);
            Component circle1 = new Leaf(5);
            Component rectangle = new Leaf(3);
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite(2);
            Component circle2 = new Leaf(6);
            Component circle3 = new Leaf(1);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite(7);
            Component t1 = new Leaf(4);
            Component t2 = new Leaf(2);
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            Console.WriteLine("The sum is: " + root.Sum());
            Console.WriteLine("IsEven: " + Component.IsEven(root));
        }

        public static void Question5()
        {
            LogHandler fatal = new FatalLogHandler();
            LogHandler error = new ErrorLogHandler();
            LogHandler info = new InfoLogHandler();

            LogHandler logger = info;
            info.SetNext(error);
            error.SetNext(fatal);

            logger.Log("Fatal Error", LogLevelEnum.Fatal);
            logger.Log("Error level log", LogLevelEnum.Error);
            logger.Log("Just Info log", LogLevelEnum.Info);
        }

        public static void Question7()
        {
            User sagie = new User("Sagie");
            User itay = new User("Itay");

            sagie.SendMessageToChatRoom("Hey all!!");
            itay.SendMessageToUser(sagie, "Hey sagie");
        }

        public static void Question8()
        {
            BodyBuildingPractice bodyBuildingPractice = new BodyBuildingPractice();
            bodyBuildingPractice.Run();

            RunningPractice runningPractice = new RunningPractice();
            runningPractice.Run();
        }

        public static void Question9()
        {
            AbstractFactory carFactory1 = FactoryProducer.GetFactory(false);
            Car car1 = carFactory1.getCar();
            Console.WriteLine(car1);

            AbstractFactory carFactory2 = FactoryProducer.GetFactory(true);
            Car car2 = carFactory2.getCar();
            Console.WriteLine(car2);
        }

        public static void Question10()
        {
            IWindow window = new FlickeringBackgroundOption(new ShadowingOption(new BaseWindow()));
            Console.WriteLine(window.GetDetails());
        }

        public static void Question12()
        {
            ComputerBuilder computerBuilder = new GamingComputerBuilder();
            computerBuilder.BuildComputer();
        }
    }
}
