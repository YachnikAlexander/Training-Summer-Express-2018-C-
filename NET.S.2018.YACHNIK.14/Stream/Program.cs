using System;
using FileWorks;
using System.Configuration;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFrom = @"C:\Users\Саша\Desktop\C#\Training-Summer-2018-c#\FileUpdates\TestingFiles\ByByteFileFrom.txt";
            string pathTo = @"C:\Users\Саша\Desktop\C#\Training-Summer-2018-c#\FileUpdates\TestingFiles\ByByteFileTo.txt";

            //Console.WriteLine($"ByteCopy() {Files.ByByteCopy(pathFrom, pathTo)}");

            //Console.WriteLine($"InMemoryByteCopy {Files.InMemoryByByteCopy(pathFrom, pathTo)}");
            //Console.WriteLine($"ByBlockCopy() {Files.ByBlockCopy(pathFrom, pathTo)}");
            //Console.WriteLine($"InMemoryByBlockCopy() {Files.InMemoryByBlockCopy(pathFrom, pathTo)}");
            //Console.WriteLine($"BuffereCopy() {Files.BuffereCopy(pathFrom, pathTo)}");
            //Console.WriteLine($"ByLineCopy() {Files.ByLineCopy(pathFrom, pathTo)}");
            Console.WriteLine(Files.IsContentEquals(pathFrom, pathTo));


            Console.ReadKey();
        }
    }
}
