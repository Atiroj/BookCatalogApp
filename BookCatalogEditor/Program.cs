using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookCatalogEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      string param = GetParam();
      while (!string.Equals("EXIT", param, StringComparison.InvariantCultureIgnoreCase))
      {
        switch (param)
        {
          case "PRINTPROPERTIES":
            HandlePrintPropertiesCommand();
            break;

          case "ADDPROPERTY":
            HandleAddPropertiesCommand();
            break;
        }

        param = GetParam();
      }
    }

    private static void HandleAddPropertiesCommand()
    {
      string input = Console.ReadLine();
      string[] splitInput = input.Split(',');
      var controller = new AddPropertyController(splitInput[0], splitInput[1]);
      controller.Execute();
    }

    private static void HandlePrintPropertiesCommand()
    {
      var controller = new PrintPropertiesController();

      controller.Execute();
    }

    private static string GetParam()
    {
      return (Console.ReadLine() ?? "EXIT").ToUpper();
    }
  }
}
