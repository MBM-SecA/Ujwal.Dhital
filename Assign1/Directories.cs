
//Create a folder name "ABC" and create 10 sub folder where each folder should contain C# with a program to print Hello World.
using System;

using System.IO; 
 
public class CreateDirExecute
{
 
internal bool CreateDir(){
Directory.CreateDirectory(@"D:\6th sem\DOTnet\Ujwal.Dhital\Assign1\ABC");
return true;
}
 
internal bool CreateSubDir()
{
bool res = CreateDir();
if(res){
for(int i=1;i<=10;i++){
Directory.CreateDirectory($"ABC/abc{i}");
string programSource = "using System;namespace Assignment_Q { class PrintHelloWorld {void Display(){ Console.WriteLine(\"Hello world\");}}}";
File.WriteAllText($"ABC/abc{i}/program.cs",programSource);
}
}
return true;
}
}

