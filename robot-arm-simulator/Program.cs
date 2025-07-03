using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Robot Arm Simulator ===");
        Console.Write("1. bağlantı (L1) uzunluğunu girin (ör. 10): ");
        double link1 = double.Parse(Console.ReadLine());
        Console.Write("2. bağlantı (L2) uzunluğunu girin (ör. 7): ");
        double link2 = double.Parse(Console.ReadLine());

        var arm = new RobotArm(link1, link2);

        while (true)
        {
            Console.WriteLine("\nEklem açılarını derece cinsinden girin (Çıkmak için boş bırak):");
            Console.Write("Theta 1 (omuz): ");
            string t1s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(t1s)) break;
            Console.Write("Theta 2 (dirsek): ");
            string t2s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(t2s)) break;

            if (double.TryParse(t1s, out double theta1) && double.TryParse(t2s, out double theta2))
            {
                var pos = arm.ForwardKinematics(theta1, theta2);
                Console.WriteLine($"Uç efektör pozisyonu: X = {pos.x:F2}, Y = {pos.y:F2}");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }
        }

        Console.WriteLine("Simülasyon bitti. Çıkılıyor...");
    }
}