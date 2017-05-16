using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class Calc
    {
        public Calc()
        {
            Operations = new List<IOperation>();
            //tipy iz sborki
            var assm = Assembly.GetAssembly(typeof(IOperation));

            var types = assm.GetTypes().ToList();
            //найти длл рядом с нашим exe
            var dlls =  Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll");
            foreach (var dll in dlls)
            {
                //загрузить ее как сборку
                assm = Assembly.LoadFile(dll);
                //добавить типы
                types.AddRange(assm.GetTypes());
        
            }

            

            var ioper = typeof(IOperation);

            foreach (var type in types)
            {
                if (type.IsInterface)
                    continue;

                var interfaces = type.GetInterfaces();
                if (interfaces.Contains(ioper))
                {
                    var oper = Activator.CreateInstance(type) as IOperation;
                    if (oper != null)
                    {
                        Operations.Add(oper);
                    }
                }
            }
        }

        /// <summary>
        /// Список доступных операций
        /// </summary>
        public IList<IOperation> Operations { get; private set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <param name="operation">Название операции</param>
        /// <param name="args">Аргументы операции</param>
        /// <returns></returns>
       public object Execute(string operation, object[] args)
        {
            // находим операцию в списке доступных
            var oper = Operations.FirstOrDefault(it => it.NameofOperation == operation);

            // если не нашли - возращаем ошибку
            if (oper == null)
            {
                return "Error";
            }

            // если нашли
            // разибраем аргрументы
           
         
            var operArgs = oper as IOperationargs;

            // вызываем саму операцию
            var result = oper.Execute(x, y);
            if (operArgs != null)
            {
                result = operArgs.Execute(args.Cast<double>());

            }
            else
            {
                int x;
                int.TryParse(args[0].ToString(), out x);

                int y;
                int.TryParse(args[1].ToString(), out y);

                result = oper.Execute(x,y);

            }


            // возвращаем результат
            return result;
        }
        

        [Obsolete("Не используйте")]
        public int Sum(int x, int y)
        {
            var r = Execute("sum", new object[] { x, y });
            return int.Parse(r.ToString());
        }

        public double Divide(int x, int y)
        {
            var r = Execute("divide", new object[] { x, y });
            return int.Parse(r.ToString());
        }
    }
}
