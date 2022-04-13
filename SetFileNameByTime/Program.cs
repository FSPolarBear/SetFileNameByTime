// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//SetFileNameByTime.SetName.SetFileNameByTime(@"D:\manga\新建文件夹\2", @"D:\manga\新建文件夹\2\result");

if(args.Length < 2)
{
    Console.WriteLine("need args:");
    Console.WriteLine("1: Source directory");
    Console.WriteLine("2: Target directory");
}
else
{
    string dirSource = args[0];
    string dirTarget = args[1];
    SetFileNameByTime.SetName.SetFileNameByTime(dirSource, dirTarget);
}