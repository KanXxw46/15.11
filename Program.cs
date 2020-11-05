using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _15._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<string>
            {
                "Ламборгини", "ВАЗ", "Нисан","Таета","Хонда","Ферари","Порш"
            };

            var result = List.AsParallel()
                .Where(carName =>
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {carName} ");
                    return carName.Contains("a");
                })
        .ToList();
            Console.ReadLine();
        }
    }
}
