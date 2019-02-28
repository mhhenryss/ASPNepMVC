using System;
using System.Collections.Generic;

namespace MVSSka.Models
{
    public class TranslationData
    {
        public TranslationData()
        {
            Datas = new List<Data>();
            CreateRandomData();
        }

        public List<Data> Datas { get; set; }

        private void CreateRandomData()
        {

            var rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                var type = rnd.Next() % 2 == 1 ? "支出" : "收入";
                var price = rnd.Next() / 10000000 * 100;
                var data = new Data(type, DateTime.Now, price);
                this.Datas.Add(data);
            }
        }
    }

    public class Data
    {
        public Data(string type, DateTime dateTime, decimal price)
        {
            Type = type;
            DateTime = dateTime;
            Price = price;
        }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }
        public Decimal Price { get; set; }
    }
}