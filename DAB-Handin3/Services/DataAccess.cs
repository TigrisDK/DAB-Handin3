﻿using DAB_Handin3.Models;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Handin3.Services
{
    public class DataAccess
    {
        //public IMongoCollection<Facility> _facilitys;
        //public IMongoCollection<Citizen> _citizens;
        //public IMongoCollection<MaintenanceLog> _maintenanceLog;
        private const string connectionString = "mongodb://localhost:27017";
        private const string databaseName = "Handin3";
        private const string FacilityCollection = "Facility";
        private const string CitizenCollection = "Citizen";
        private const string MaintanceLogCollection = "MaintainceLog";
        
        /*public DataAccess()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

        } */
        public IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            return db.GetCollection<T>(collection);
        }
        
        
    }
}
