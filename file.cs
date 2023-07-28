// using System;

// class FileHandling{
//     static void Main2(string[] args ){
//         string filePath=@"./nir.txt";
//         FileOpen FileObj=new FileOpen();
//         FileDelete FileObj2=new FileDelete();
//         FileObj.OpenFileDisplay(filePath);
//         Console.WriteLine("Do you want to delete the file? \n(Type y or yes to delete.)");
//         string x= Console.ReadLine();
//         if(x.ToLower()=="y"||x.ToLower()=="yes"){
//            FileObj2.Delete(filePath);
//         }
//         else{
//             Console.WriteLine("Cannot delete the file.");
//         }
//     }
// }

// class FileOpen{
//     public void OpenFileDisplay(string path){
//          var isFile=File.Exists(path);
//          if(isFile)
//          {
//             var content=File.ReadAllText(path);
//             Console.WriteLine(content);
//         }
//         else{
//             Console.WriteLine("Please Enter Valid file Path");
//         }
//     }
// }

// class FileDelete{
//     public void Delete(string path){
//        var isFile=File.Exists(path);
//          if(isFile)
//          {
//             File.Delete(path);
//             Console.WriteLine("File Deleted SuccessFully.");
//         }
//         else{
//             Console.WriteLine("Please Enter Valid file Path.");
//         }
//     }
// }