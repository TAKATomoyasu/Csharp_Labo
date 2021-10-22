using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Study_Csharp
{
    public class InterfaceTest : IStartable
    {

        //実行用
        public void Start()
        {
            Pour(new CoffeeDrink());
        }

        void Pour(IDrinkPour drinkPour)
        {
            drinkPour.Pour();
        }

        public InterfaceTest()
        {

        }
    }
    interface IDrinkPour
    {
        void Pour();
    }
    class CoffeeDrink : IDrinkPour
    {
        public void Pour()
        {
            Console.WriteLine("Coffeeeeee!");
        }
    }


    public interface PrinterInterface
    {
        void Print();
    }
    class HtmlPrinter : PrinterInterface
    {
        public void Print()
        {
            Console.WriteLine();
        }
    }
}


//public function print(Printer $printer) {
//    $printer->print();
//}

//Interface PrinterInterface {
//    public function print();
//}

//class HtmlPrinter implements PrinterInterface {
//    public function print() {
//}
//}

//class TextPrinter implements PrinterInterface {
//    public function print() {
//}
//}

//class PlainPrinter implements PrinterInterface {
//    public function print() {
//}
//}