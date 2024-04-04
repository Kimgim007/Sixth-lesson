using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sixth_lesson
{
    internal class Program
    {
        //Основное задание
        //1.Класс Phone.
        //Создайте класс Phone, который содержит переменные number, model и weight.

        //Добавить конструктор в класс Phone, который принимает на вход три параметра
        //для инициализации переменных класса -number, model и weight.

        //Добавить конструктор, который принимает на вход два параметра для
        //инициализации переменных класса - number, model.

        //Добавить конструктор без параметров.

        //Вызвать из конструктора с тремя параметрами конструктор с двумя.
        public class Phone
        {
            public Phone() { }
            public Phone(float number, string model)
            {
                this.number = number;
                this.model = model;
            }
            public Phone(float number, string model, int weight)
            {
                this.number = number;
                this.model = model;
                this.weight = weight;
            }

            public float number { get; set; }
            public string model { get; set; }
            public int weight { get; set; }

            public void ReceiveCall(string name)
            {
                Console.WriteLine($"Звонит {name}");
            }
            public void ReceiveCall(string name, float number)
            {
                Console.WriteLine($"Звонит {name}, номер - {number}");
            }

            public float GetNumber()
            {
                return number;
            }

            public void SendMessage(float number)
            {
                Console.WriteLine("Введи сообщение");
                string messege = Console.ReadLine();

                Console.WriteLine($"{number} прислал вам сообщение - {messege}");
            }
        }


        //2.Создать класс CreditCard c полями номер счета, текущая сумма на счету.
        public class CreditCard
        {
            public CreditCard() { }
            public CreditCard(float numberCreaditCard,float sumInCreaditCard)
            {
                this.numberCreaditCard = numberCreaditCard;
                this.sumInCreaditCard =sumInCreaditCard;
            }
            public float numberCreaditCard { get; set; }
            public float sumInCreaditCard { get; set;}

            public void CreditCardReplenishment(float sum)
            {
                sumInCreaditCard += sum;
            }

            public void CreditCardGetMoney(float sum)
            {
               
                sumInCreaditCard -= sum;   
               
            }

            public void InfoForSumGard()
            {
                Console.WriteLine($"Вот столько денег на счету {sumInCreaditCard}");
            }
        }

     
       
        static void Main(string[] args)
        {

            //Создайте три экземпляра этого класса.

            //Phone phoneOne = new Phone() { number = 542433333, model = "IFon", weight = 1 };
            //Phone phoneTwo = new Phone() { number = 842544444, model = "Motorolla", weight = 45 };
            //Phone phoneThree = new Phone() { number = 874645645, model = "Nokia", weight = 100 };

            //Выведите на консоль значения их переменных.

            //Console.WriteLine($"{phoneOne.number} - {phoneOne.model} - {phoneOne.weight}");
            //Console.WriteLine($"{phoneTwo.number} - {phoneTwo.model} - {phoneTwo.weight}");
            //Console.WriteLine($"{phoneThree.number} - {phoneThree.model} - {phoneThree.weight}");

            //Добавить в класс Phone методы: ReceiveCall, имеет один параметр – имя звонящего.
            //Выводит на консоль сообщение “Звонит { name}”.
            //GetNumber – возвращает номер телефона.Вызвать эти методы для каждого из объектов.

            //phoneOne.ReceiveCall("Мама");
            //Console.WriteLine(phoneOne.GetNumber());

            //phoneTwo.ReceiveCall("Папа");
            //Console.WriteLine(phoneTwo.GetNumber());

            //phoneThree.ReceiveCall("Дядя");
            //Console.WriteLine(phoneThree.GetNumber());



            //Добавьте перегруженный метод ReceiveCall, который принимает два параметра - имя
            //звонящего и номер телефона звонящего.
            //Вызвать этот метод.

            //phoneOne.ReceiveCall("Мама", 23423423);

            //Создать метод sendMessage с аргументами переменной длины.
            //Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение.
            //Метод выводит на консоль номера этих телефонов.

            //phoneOne.SendMessage(1231231);



            //2........

            //Добавьте метод, который позволяет начислять сумму на кредитную карточку.

            //CreditCard creditCard = new CreditCard() { };
            //creditCard.CreditCardReplenishment(23);
            //Console.WriteLine(creditCard.sumInCreaditCard);

            //Добавьте метод, который позволяет снимать с карточки некоторую сумму.


            //creditCard.CreditCardGetMoney(24);
            //Console.WriteLine(creditCard.sumInCreaditCard);

            //Добавьте метод, который выводит текущую информацию о карточке.

            //creditCard.InfoForSumGard();

            //Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма

            //CreditCard creditCardOne = new CreditCard() { numberCreaditCard = 2342352,sumInCreaditCard = 11 };
            //CreditCard creditCardTwo = new CreditCard() { numberCreaditCard = 6557757, sumInCreaditCard = 22 };
            //CreditCard creditCardThree = new CreditCard() { numberCreaditCard = 7878687, sumInCreaditCard = 33 };

            //Тестовый сценарий для проверки:
            //Положите деньги на первые две карточки и снимите с третьей.

            //creditCardOne.CreditCardReplenishment(11);
            //creditCardTwo.CreditCardReplenishment(22);
            //creditCardThree.CreditCardGetMoney(33);

            //Выведите на экран текущее состояние всех трех карточек.


            //creditCardOne.InfoForSumGard();
            //creditCardTwo.InfoForSumGard();
            //creditCardThree.InfoForSumGard();




            //Дополнительное задание


          

        }
    }
}
