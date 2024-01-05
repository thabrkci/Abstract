namespace Abstract;

class Program
{
    static void Main(string[] args)
    {
          // Abstract sınıfın örneği oluşturulamaz, ancak türetilen sınıfların örnekleri oluşturulabilir
        Calculate dikdortgen = new Calculate();
        dikdortgen.Uzunluk = 5;
        dikdortgen.Genislik = 3;

        // Abstract metot kullanma
        double alan = dikdortgen.AlanHesapla();

        Console.WriteLine("Dikdörtgen Alanı: " + alan);

        // Abstract sınıfın örneği oluşturulamaz
        // Sekil sekil = new Sekil(); // Hata alırsınız

    }
}
