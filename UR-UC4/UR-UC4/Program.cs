using System.Reflection;

namespace UR_UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UseCase-4!");

            Type type = Type.GetType("User");

            Console.WriteLine("Class name is :{0}", type.Name);

            Console.WriteLine("Methods in User Class : ");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Properties in User Class : ");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in User Class : ");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}