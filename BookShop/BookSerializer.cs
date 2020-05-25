using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    class BookSerializer : ISerializer
    {
        //string path = "Employee.bin";
        private BinaryFormatter formatter;
        public BookSerializer()
        {
            formatter = new BinaryFormatter();
        }
        public void Serialize(List<Book> books, string path) 
        {
            if (path == "")
                path = "Books.bin";
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, books);
            }
        }
        public List<Book> Deserialize(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                /*try
                {*/
                    List<Book> books = (List<Book>)formatter.Deserialize(fileStream);
                    return books;
               // }
                /*catch (SerializationException ex)
                {
                    MessageBox.Show("Ошибка! Не удалось открыть файл");
                    return null;
                }*/
            }
        }
    }
}
