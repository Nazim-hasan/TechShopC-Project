﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Entities db;

        static DataAccessFactory()
        {
            db = new Entities();
        }



        public static IRepository<Manager, int> ManagerDataAccess()
        {
            return new ManagerRepo(db);
        }
    }
}
