using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Barduino
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        Ingredient Rum = new Ingredient(Ingredient.LiquidType.Soda, "CocaCola", "Coke", 8);

    }
}
