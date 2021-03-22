using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace convenience_store
{
    [Serializable]
    class Tutorial
    {
        public int Age;
        public String Name;
        public void Tutorial1(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.Age = 12;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Admin\source\repos\serialtext\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\Admin\source\repos\serialtext\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.Age);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}