using Aerolinea.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Aerolinea.Data.Context
{
    public class AirlineContext : DbContext
    {
        public AirlineContext()
        {

        }

        public AirlineContext(DbContextOptions<AirlineContext> options) : base(options)
        {

        }

        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<Airplane> Airplane { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<FlightPath> FlightPath { get; set; }
        public virtual DbSet<Passage> Passage { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<StateFlight> StateFlight { get; set; }
        public virtual DbSet<TypeDocument> TypeDocument { get; set; }

    }
}
