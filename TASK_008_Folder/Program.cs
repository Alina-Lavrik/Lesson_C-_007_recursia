// Как смотреть содержимое папки
// когда была создана папка
string path = "C:/Програмирование/GeekBrains";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
// какие внутри содержатся файлы
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
