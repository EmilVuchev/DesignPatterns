using System.Text;
using Builder.Interfaces;

namespace Builder.ConcreteImplementation
{
    public class Burger
    {
        private int mSize;
        private bool mCheese;
        private bool mPepperoni;
        private bool mLettuce;
        private bool mTomato;

        public Burger(BurgerBuilder builder)
        {
            this.mSize = builder.Size;
            this.mCheese = builder.Cheese;
            this.mPepperoni = builder.Pepperoni;
            this.mLettuce = builder.Lettuce;
            this.mTomato = builder.Tomato;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"This is {this.mSize} inch Burger. ");

            var productList = new List<IProduct> 
            { 
                new Cheese(this.mCheese), 
                new Pepperoni(this.mPepperoni), 
                new Lettuce(this.mLettuce), 
                new Tomato(this.mTomato) 
            };

            foreach (var product in productList)
            {
                AddDescription(sb, product.Name, product.IsAvailable);
            }

            return sb.ToString();
        }

        private void AddDescription(StringBuilder sb, string productName, bool haveProduct)
        {
            if (haveProduct)
            {
                sb.AppendLine($"With {productName}.");
            }
        }
    }
}
