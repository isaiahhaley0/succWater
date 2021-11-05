using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace succWater.Model
{
     class WaterEvent
     {
          [PrimaryKey, AutoIncrement]
          public int ID { get; set; }
          public int plantID { get; set; }
          public DateTime waterDate{get; set;}
     }
}
