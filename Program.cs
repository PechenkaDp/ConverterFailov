namespace Converterfailov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь до файла: ");
            string pathtofile = Console.ReadLine();
            readandsave file = new readandsave(pathtofile);
            file.readFile();
        }
    }
}