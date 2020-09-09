using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice
{
    public static class GroupDishes
    {
        public static string[][] Run(string[][] dishes)
        {
            var ingredients = new Dictionary<string, HashSet<string>>();
            foreach(var dish in dishes)
            {
                var dishName = dish[0];
                for (int i = 1; i < dish.Length; ++i)
                {
                    var ingredient = dish[i];
                    if (!ingredients.ContainsKey(ingredient))
                        ingredients.Add(ingredient, new HashSet<string>());

                    if (!ingredients[ingredient].Contains(dishName))
                        ingredients[ingredient].Add(dishName);
                }
            }

            var ingredientNames = ingredients.Keys.ToList();
            ingredientNames.Sort();
            var result = new List<string[]>();
            foreach(var ingredientName in ingredientNames)
            {
                var newList = new List<string> { ingredientName };
                var otherDishes = new List<string>(ingredients[ingredientName]);
                otherDishes.Sort();
                newList.AddRange(otherDishes);

                result.Add(newList.ToArray());
            }

            return result.ToArray();
        }
    }
}
