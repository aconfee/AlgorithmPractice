using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class GroupDishesTests
    {
        [Fact]
        public void Test()
        {
            var input = new[] {
                new string[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce" },
                 new string[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough" },
                 new string[] {"Quesadilla", "Chicken", "Cheese", "Sauce" },
                 new string[] {"Sandwich", "Salad", "Bread", "Tomato", "Cheese" } 
            };

            var wat = GroupDishes.Run(input);
        }
    }
}
