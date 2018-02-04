using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries*100);
            uint days = (uint)(years*365.2422);
            ulong hours = (ulong)(days*24);
            ulong minutes = (ulong)(hours*60);
            ulong seconds = (ulong)(minutes*60);
            ulong milliseconds = (ulong)(seconds*1000);
            decimal microseconds = (milliseconds*1000);
            BigInteger nanoseconds = (BigInteger)(microseconds*1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days" +
                $" = {hours} hours = {minutes} minutes = {seconds} seconds" +
                $" = {milliseconds} milliseconds = {microseconds} microseconds" +
                $" = {nanoseconds} nanoseconds");
        }
    }
}
