using System;
using System.IO;

namespace Octo.Robot
{
    public class FileHandling
    {
        public void Run()
        {
            //PathHandling();
            HandleDirectory();
        }

        public void HandleDirectory()
        {
            if (!Directory.Exists("Test"))
            {
                Directory.CreateDirectory("Test");
            }
        }

        public void PathHandling()
        {
            Console.WriteLine("Enter the path");
            var p = Console.ReadLine();
            var fullPath = Path.GetFullPath(p);
            Console.WriteLine(fullPath);
            var filename = Path.GetFileName(fullPath);
            var extension = Path.GetExtension(fullPath);
            var fileOnly = Path.GetFileNameWithoutExtension(fullPath);
            var directory = Path.GetDirectoryName(fullPath);
            Console.WriteLine($"Filename => {filename}");
            Console.WriteLine($"Directory => " + directory);
            Console.WriteLine($"Extension => {extension}");
            Console.WriteLine($"Fileonly => {fileOnly}");

            //var path1 = "abc";
            var path2 = Path.Combine("abc", "xyz.txt");
            Console.WriteLine(path2);
            var temp = Path.GetTempPath();
            Console.WriteLine(temp);

            /*
                #reset 64
                Resetting execution engine.
                Loading context from 'CSharpInteractive.rsp'.
                > using System.IO;

                > var path2 = Path.Join("abc", "xyz.txt");
                (1,18): error CS0117: 'Path' does not contain a definition for 'Join'

                > Path.Combine("abc","xyz.txt")
                "abc\\xyz.txt"

                > var p = Path.Combine("abc", "xyz.txt");
                > p
                "abc\\xyz.txt"

                > Path.GetTempPath()
                "C:\\Users\\Chand\\AppData\\Local\\Temp\\"

                > Path.GetTempFileName()
                "C:\\Users\\Chand\\AppData\\Local\\Temp\\tmp5143.tmp"

                > Path.GetRandomFileName()
                "uns1gh2d.eek"

                > var random = Path.GetRandomFileName();
                >  random
                "zdmav2ty.o00"

                > var fullPath = Path.GetFullPath(random);
                >  fullPath
                "C:\\Users\\Chand\\zdmav2ty.o00"

                >  Path.ChangeExtension(fullPath,"txt")
                "C:\\Users\\Chand\\zdmav2ty.txt"

                > Path.ChangeExtension(fullPath,"random")
                "C:\\Users\\Chand\\zdmav2ty.random"
             */
        }
    }
}