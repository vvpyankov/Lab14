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
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Cat", "Meooow!");
            cat.ShowInfo();

            Dog dog = new Dog("Dog", "Bow-bow-bow!");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string AnimalType { get; set; }
        public abstract void Say();

        public Animal(string animalType)
        {
            AnimalType = animalType;
        }
        /*public string AnimalType
        {
            get => animalType;
            set => animalType = value;
        }*/
        public void ShowInfo()
        {
            Console.WriteLine("I am a {0}", AnimalType);
            Say();
        }
    }
    class Cat : Animal
    {
        string say;
        string animalType;
        public Cat(string animalType, string say)
            : base(animalType)
        {
            this.say = say;
        }
        public override string AnimalType
        {
            get
            {
                return animalType;

            }
            set
            {
                animalType = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Meooow!");
        }
    }
    class Dog : Animal
    {
        string say;
        string animalType;
        public Dog(string animalType, string say)
            : base(animalType)
        {
            this.say = say;
        }
        public override string AnimalType
        {
            get
            {
                return animalType;

            }
            set
            {
                animalType = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Bow-bow-bow!");
        }
    }
}