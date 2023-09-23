using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace _2.Models
{
    public class HW_DB
    {
        SortedSet<Data> database = null;
        string path = "D:\\University\\pis\\labs\\2\\2\\phoneNumbers.json";
    public HW_DB()
        {
            //this.database = new SortedSet<Data>
            //(
            //new Data[]
            //{
            //    new Data(1, "aaa1", "375291111111"),
            //    new Data(2, "ccc2", "375292222222"),
            //    new Data(3, "bbb3", "375293333333"),
            //    new Data(4, "ddd4", "375294444444"),
            //    new Data(5, "eee5", "375295555555"),
            //}
            //);
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //        JsonSerializer.Serialize<List<Data>>(fs, database);
            //}
            DeserializeFromFile();
        }

        public void DeserializeFromFile()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var data = JsonSerializer.Deserialize<List<Data>>(fs);
                this.database = new SortedSet<Data>(data);
            }
        }

        public void SerializeIntoFile()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                fs.SetLength(0);
                JsonSerializer.Serialize(fs, database);
            }
        }

        public Data Find(int id)
        {
            return database.Where(e => e.Id == id).First();
        }

        public bool Insert(Data data) 
        {
            if(database.Where(e => e.Id == data.Id).Count() == 0)
            {
                database.Add(data);
                SerializeIntoFile();
                return true;
            }
            return false;
        }

        public bool Update(Data data)
        {
            if (database.Where(e => e.Id == data.Id).Count() != 0)
            {
                Data oldItem = database.Where(e => e.Id == data.Id).First();
                database.Remove(oldItem);
                database.Add(data);
                SerializeIntoFile();
                return true;
            }
            return false;
        }

        public bool Delete(Data data) 
        {
            if(database.Where(e => e.Id == data.Id).Count() != 0)
            {
            Data oldItem = database.Where(e => e.Id == data.Id).First();
                database.Remove(oldItem);
                SerializeIntoFile();
                return true;
            }
            return false;
        }
        public Data[] GetAll() 
        {
            return database.ToArray();
        }

    }
}