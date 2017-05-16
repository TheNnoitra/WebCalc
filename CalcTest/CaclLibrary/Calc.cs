using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CaclLibrary
{



    public class Calc
    {

        public Calc()
        {
            operation = new List<IOperation>();
            var assm = Assembly.GetAssembly(typeof(IOperation));
            var types = assm.GetTypes();
            foreach (var t in types)
            {
                var interfaces = types.getin;
                if (interfaces.Contains(typeof(IOperation)))
                {
                    var opers = Activator.CreateInstance(types) as IOperation;
                    if (opers != null)
                    {
                        operation.Add(opers);
                    }
                }
            }
            var oper = assm.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IOperation)));
           
         
        }
        /// <summary>
        /// Список доступных операций
        /// </summary>

        private IList<IOperation> operation { get; set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <param name="operation">Название операции</param>
        /// <param name="args">Аргументы операции</param>
        /// <returns></returns>
        public object Execute(string operation, object[] args)
        {
            // находим операцию в списке доступных
            var oper = operation.FirstOrDefault(it => it.Name == operation);

            //если не нашли, возвращаем ошибку
            if (oper == null)
            {
                return "Error";
            }
            else
            {
                //если нашли, разбираем аргументы
                int x;
                int.TryParse(args[0].ToString(), out x); //v args zapisivaet v X

                int y;
                int.TryParse(args[1].ToString(), out y); //v args zapisivaet v Y
                //вызываем саму операцию
                var result = oper.Calc(x, y);
                //return результат
                return result;
            }
        }
        [Obsolete("НЕ использовать!")]
        public double Sum(int x, int y)
        {
            return (int)Execute("sum", new object [] {x,y});
        }

        public double Divide(int x, int y)

        {
            return (int)Execute("divide", new object[] { x, y });
        }
    }
}
