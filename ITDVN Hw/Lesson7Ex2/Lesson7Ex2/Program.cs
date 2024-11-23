using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateArray array = new CreateArray();
            var trains = array.TrainArr();
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine(trains[i].NumberOfTrain);
            }
        }
    }
    
    struct Train
    {
        public string Destination {  get; private set; }
        public int NumberOfTrain { get; private set; }
        public string TimeToGo { get; private set; }
        public Train(string destination, string timeToGo, int numberOfTrain)
        {
            Destination = destination;
            TimeToGo = timeToGo;
            NumberOfTrain = numberOfTrain;
        }
    }


    class CreateArray
    {
        public Train[] TrainArr()
        {
            Train[] array = CreateArr();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0;  j < array.Length - 1; j++)
                {
                    if (array[j].NumberOfTrain > array[j + 1].NumberOfTrain)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        private Train[] CreateArr()
        {
            Train[] array = new Train[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = CreateTrain(i);
            }
            return array;
        }

        private Train CreateTrain(int number)
        {
            Train train = new Train();
            switch (number)
            {
                case 0:
                    Train firstTrain = new Train("Москва", "12:00", 1);
                    return firstTrain;
                case 1:
                    Train secondTrain = new Train("Москва", "12:00", 10);
                    return secondTrain;
                case 2:
                    Train thirdTrain = new Train("Москва", "12:00", 3);
                    return thirdTrain;
                case 3:
                    Train fourthTrain = new Train("Москва", "12:00", 6);
                    return fourthTrain;
                case 4:
                    Train fifthTrain = new Train("Москва", "12:00", 4);
                    return fifthTrain;
                case 5:
                    Train sixthTrain = new Train("Москва", "12:00", 78);
                    return sixthTrain;
                case 6:
                    Train seventhTrain = new Train("Москва", "12:00", 65);
                    return seventhTrain;
                case 7:
                    Train eighthTrain = new Train("Москва", "12:00", 24);
                    return eighthTrain;
                default:
                    return train;
            }
        }
    }
}
