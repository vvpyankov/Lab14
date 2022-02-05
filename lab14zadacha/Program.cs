using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
абстрактное свойство - название животного.
В классе Animal нужно определить следующие методы:
конструктор, устанавливающий значение по умолчанию для названия;
абстрактный метод Say(), который выводит звук, который издает животное;
неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

свойство – название животного;
метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/

namespace lab14zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    abstract class Animal
    {
       public abstract string AnimalType { get; set; }
        public abstract void Say();

        public Animal(string animalType) 
        {
            this.animalType = animalType;
        }
        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("I am a {0}", AnimalType);
            Say();
        }
    }
    class Cat : Animal
    {
        string animalType;
        public Cat (string animalType)
        {
            AnimalType = animalType;
        }
        public override string AnimalType
        {
            get
            {
                return animalType;

            }
            set
            {
                animalType = "Cat";
            }
        }
        public override void Say()
        {
            Console.WriteLine("Meooow!");
        }
    }
    class Dog : Animal
    {
        string animalType;
        public Dog (string animalType)
        {
            AnimalType = animalType;
        }
        public override string AnimalType
        {
            get
            {
                return animalType;

            }
            set
            {
                animalType = "Dog";
            }
        }
        public override void Say()
        {
            Console.WriteLine("Bow-bow-bow!");
        }
    }
}
