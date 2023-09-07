namespace Section9Demos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //DONT RUN THIS FILE. THIS FILE IS JUST NOTES
             
            var filepath = @"c:\temp\somefile.jpg";
            var dirPath = @"c:\temp\folder1";

            //STATIC METHODS
            //small number of operations
            //security checking 
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);    //true is if file is there i can override it
            File.Delete(filepath);
            if(File.Exists(filepath))
            {
                //
            }
            var content = File.ReadAllText(filepath);

            //FILE INFO
            //INSTANCE METHODS
            //more efficient to create an object
            var fileInfo = new FileInfo(content);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //
            }
            
            //******************************************************************************************************//

            //DIRECTORY
            //STATIC METHODS
            Directory.CreateDirectory(dirPath);
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach( var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(dirPath, "*.*", SearchOption.AllDirectories);
            foreach( var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(dirPath);

            //DIRECTORY INFO
            //INSTANCE METHODS
            var directoryInfo = new DirectoryInfo(dirPath);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            //******************************************************************************************************//

            //PATH
            var demoPath = @"C:\Projects\Fundamentals\HelloWorld\HelloWorld.sln";

            //Poor way
            var dotIndex = demoPath.IndexOf('.');
            var extension = demoPath.Substring(dotIndex);

            //better way
            Console.WriteLine("Extension: " + Path.GetExtension(demoPath));
            Console.WriteLine("File Name w/o Ext: " + Path.GetFileNameWithoutExtension(demoPath));
            Console.WriteLine("File Name: " + Path.GetFileName(demoPath));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(demoPath));

        }
    }

}
