using System;
using System.Text;

namespace HTMLEditor
{
  public static class Editor
  {
    public static void Show()
    {
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("Editor Mode");
      Console.WriteLine("-------------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("----------------------------------------------------------------------");
      Console.Write("Would like to save the file? ");
      Viewer.Show(file.ToString());
    }
  }
}