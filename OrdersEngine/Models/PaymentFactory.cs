using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class PaymentFactory
    {
        private List<Tuple<string, IProductFactory>> namedFactories =
            new List<Tuple<string, IProductFactory>>();

        public PaymentFactory()
        {
            // !Here we can replace Reflection with some of IoC containers like Autofac or Ninject
            foreach (var t in typeof(PaymentFactory).Assembly.GetTypes())
            {
                if (typeof(IProductFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    namedFactories.Add(Tuple.Create(
                      t.Name.Replace("Factory", string.Empty), (IProductFactory)Activator.CreateInstance(t)));
                }
            }
        }


        
        public IPaymentResult GetPaymentResult()
        {
            Console.WriteLine("Available payments:");
            for (var index = 0; index < namedFactories.Count; index++)
            {
                var tuple = namedFactories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < namedFactories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return namedFactories[i].Item2.CreateProduct(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again.");
            }
        }
    }
}
