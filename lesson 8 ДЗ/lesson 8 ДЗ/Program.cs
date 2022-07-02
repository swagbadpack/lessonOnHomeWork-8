
namespace lesson_8_ДЗ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var listRepository = new Repository();
            listRepository.RandomList();
            listRepository.Print();
            listRepository.Delete();
            listRepository.Print();
        }
    }
}
