﻿using DAB_Handin3.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Handin3.Services
{
    public class CitizenService
    {
        DataAccess db;
        private const string CitizenCollection = "Citizen";
        private IMongoCollection<Citizen> Collection;

        public CitizenService(DataAccess db)
        {
            this.db = db;
            Collection = db.ConnectToMongo<Citizen>(CitizenCollection);
        }

    }
}