using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barduino
{
    public class Beverage
    {
        public enum BeverageType {Alcoholic, Virgin};

        /// <summary>
        /// Constructor for a beverage
        /// </summary>
        /// <param name="Ingredients"></param>
        /// <param name="Instructions"></param>
        /// <param name="Name"></param>
        /// <param name="Type"></param>
        public void Drink(List<Ingredient> Ingredients, List<string> Instructions, string Name, BeverageType Type)
        {
            
        }

        private List<Ingredient> _ingredients;
        /// <summary>
        /// List of ingredients necessary for drinks
        /// </summary>
        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set
            {
                _ingredients = value;
            }
        }

        private List<string> _instructions;
        /// <summary>
        /// List of instructions on how to make the drink
        /// </summary>
        public List<string> Instructions
        {
            get{ return _instructions; }
            set
            {
               _instructions = value;
            }
        }

        private string _name;
        /// <summary>
        /// Name of the drink
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        private BeverageType _type;
        /// <summary>
        /// Type of the drink
        /// </summary>
        public BeverageType Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
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
        /// <param name="Serving">Amount per serving(Liquids are in ounces)</param>
        public Ingredient(IngredientType IngType, string BrandName, string Name, double Serving)
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

        private double _serving;
        /// <summary>
        /// Serving size of ingredient
        /// Liquid: in ounces
        /// </summary>
        public double Serving
        {
            get { return _serving; }
            set
            {
                _serving = value;
            }
        }
    }
}
