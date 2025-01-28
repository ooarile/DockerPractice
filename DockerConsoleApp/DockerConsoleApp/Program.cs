using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "/app"; // Docker 컨테이너 내의 경로
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine($"Directory created at {path}");
        }
        else
        {
            Console.WriteLine($"Directory 삭제 : {path}");
            Directory.Delete(path, true); // true parameter enables recursive deletion
        }

        path = "/app/myfolder"; // Docker 컨테이너 내의 경로
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine($"Directory created at {path}");
        }
        else
        {
            Console.WriteLine($"Directory 삭제 : {path}");
            Directory.Delete(path, true); // true parameter enables recursive deletion
        }
    }
}