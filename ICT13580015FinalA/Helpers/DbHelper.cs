using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580015FinalA.Models;
using SQLite;


namespace ICT13580015FinalA.Helpers
                           
{
    public class DbHelper
    {
        SQLiteConnection db;
        public DbHelper(String dbPath)

        {

            db = new SQLiteConnection(dbPath);
            db.CreateTable<Pooh>();

        }
        public int Add(Pooh pooh)
        {
            db.Insert(pooh);
            return pooh.Id;

        }
        public List<Pooh> GetPoohs()
        {
            return db.Table<Pooh>().ToList();


        }
        public int UpdatePooh(Pooh pooh)
        {
            return db.Update(pooh);
        }
        public int DeletePooh(Pooh pooh)
        {
            return db.Delete(pooh);
        }
    }
        }
