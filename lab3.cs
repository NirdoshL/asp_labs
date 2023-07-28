using System;
using System.IO;

class FileHandling{
    static void Main(string[] args ){
        string filePath=@"originals.txt";
        string folderName="Original";
        FileMethods FileObj=new FileMethods();
        FileObj.createFile(filePath,folderName);
        FileObj.OpenFileDisplay(filePath,folderName);
        FileObj.copyFile(filePath,folderName);
    }
}

class FileMethods{
     public void createFile(string path,string folderName){
            var folder=Directory.CreateDirectory(folderName);
            var file=File.Create(folderName+"/"+path);
            file.Close();
            File.WriteAllText(folderName+"/"+path,"Hi, I am Nirdosh Lamichhane.");
            Console.WriteLine("1.File & folder Created Successfully.");
    }


    public void OpenFileDisplay(string path,string folderName){
         var isFile=File.Exists(folderName+"/"+path);
         if(isFile)
         {
            Console.WriteLine("2.Given path Content:");
            var content=File.ReadAllText(folderName+"/"+path);
            Console.WriteLine(content);
        }
        else{
            Console.WriteLine("Please Enter Valid file Path");
        }
    }


    public void copyFile(string path,string folderName){
       var isFile=File.Exists(folderName+"/"+path);
         if(isFile)
         {
            var copyFolder=Directory.CreateDirectory("Copy");
            File.Copy(folderName+"/"+path,copyFolder+"/copy.txt");
            Console.WriteLine("3.File Copied SuccessFully.");
             Console.WriteLine("Do you want to delete original file and folder? \n(Type y or yes to delete.)");
             string x= Console.ReadLine();
                if(x.ToLower()=="y"||x.ToLower()=="yes"){
                DeleteFile(folderName+"/"+path,folderName);
        }
        else{
            Console.WriteLine("Cannot delete the file.");
        }
        }
        else{
            Console.WriteLine("Please Enter Valid file Path.");
        }
    }


    public void DeleteFile(string path,string folderName){
       var isFolder=Directory.Exists(folderName); 
       var isFile=File.Exists(path);
         if(isFile && isFolder)
         {
            File.Delete(path);
            Directory.Delete(folderName);
            Console.WriteLine("4.Original File & Folder Deleted SuccessFully.");
        }
        else{
            Console.WriteLine("Please Enter Valid file Path or Folder not exists.");
        }
    }
}
