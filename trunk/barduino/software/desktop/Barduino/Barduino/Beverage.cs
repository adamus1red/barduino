using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barduino
{
    public class Beverage
    {
        public void Drink()
        {
            
        }
    }

    public class Ingredient
    {
        /// <summary>
        /// Types of liquid available in Barduino.
        /// Other- Sugar, salt, bitters, etc.
        /// </summary>
        public enum IngredientType { Soda, Water, Liquor, Fruit, Other}


        /// <summary>
        /// Ingredient that makes up a drink. ex: pineapple chunk, cherry, Orange slice,...
        /// </summary>
        /// <param name="Type">Soda, Water, Liquor</param>
        /// <param name="Name">Brand and type. e.g: Bacardi- Rum, Malibu- Coconut Rum</param>
        /// <param name="Serving">Amount per serving- In ounces</param>
        public Ingredient(IngredientType IngType, string BrandName, string Name, int Serving)
        {
            Type = IngType;
            Brand = BrandName;
            this.Name = Name;
            this.Serving = Serving;
        }
        private IngredientType _type;
        /// <summary>
        /// Get/Set for Type of liquid
        /// </summary>
        public IngredientType Type
        {
            get { return _type; }
            set {
                _type = value;
            }
        }

        private string _brandName;
        /// <summary>
        /// The brand of the ingredient
        /// </summary>
        public string Brand
        {
            get { return _brandName; }
            set
            {
               _brandName = value;
            }
        }

        private string _name;
        /// <summary>
        /// Name of the ingredient: Coke, Orange, Salt, Rum,
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        private int _serving;

        public int Serving
        {
            get { return _serving; }
            set
            {
                _serving = value;
            }
        }

    }
}
