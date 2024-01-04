using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Fayl nomini kiriting: ");
        string filename = Console.ReadLine();

        try
        {
            string fullPath = FindFile(filename);

            if (!string.IsNullOrEmpty(fullPath))
            {
                Console.WriteLine($"Fayl topildi. Fayl joylashgan path: {fullPath}");
            }
            else
            {
                Console.WriteLine("Fayl topilmadi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Xatolik yuz berdi: {ex.Message}");
        }
    }

    static string FindFile(string filename)
    {
     
        string[] drives = Directory.GetLogicalDrives();

        foreach (var drive in drives)
        {
            string fullPath = Path.Combine(drive, filename);

            if (File.Exists(fullPath))
            {
                return fullPath;
            }
        }

        return null;
    }
}
