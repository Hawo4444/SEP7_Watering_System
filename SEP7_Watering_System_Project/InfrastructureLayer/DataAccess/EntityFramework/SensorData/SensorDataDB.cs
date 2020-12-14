using DomainLayer.Models.SensorData;
using System;
using System.Data.Entity;
using System.Linq;

namespace InfrastructureLayer.DataAccess.EntityFramework.SensorData
{

    public class SensorDataDB : DbContext
    {
        public SensorDataDB(): base("name=SensorDB")
        {

        }

        public virtual DbSet<SensorDataModel> SensorData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}