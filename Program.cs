using Lib;

namespace App
{
  public static class Program
  {
    public static int Main()
    {
      var manager = new SmartManager();
      manager.DoSmsVerySmart();
      return 0;
    }
  }
}
