using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectFirstTest.Models
{
	public class FinalProjectDbContext : DbContext
	{
		public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
		{

		}

		public DbSet<User> Users { get; set; }

		public DbSet<Service> Services { get; set; }

		public DbSet<Seller>Sellers { get; set; }

		public DbSet<Room_Picture> Room_Pictures { get; set; }

		public DbSet<Room> Rooms { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Camping_Area> Camping_Areas { get; set; }

		public DbSet<Camping_Area_Picture> Camping_Area_Pictures { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			var Camping_AreaJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Json/Camping_Area.json", Encoding.UTF8);
			IList<Camping_Area> Camping_Areas = JsonConvert.DeserializeObject<IList<Camping_Area>>(Camping_AreaJsonData);
			modelBuilder.Entity<Camping_Area>().HasData(Camping_Areas);

			var Camping_Area_PictureJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Json/Camping_Area_Picture.json", Encoding.UTF8);
			IList<Camping_Area_Picture> Camping_Area_Pictures = JsonConvert.DeserializeObject<IList<Camping_Area_Picture>>(Camping_Area_PictureJsonData);
			modelBuilder.Entity<Camping_Area_Picture>().HasData(Camping_Area_Pictures);

			var RoomJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Json/Room.json", Encoding.UTF8);
			IList<Room> Rooms = JsonConvert.DeserializeObject<IList<Room>>(RoomJsonData);
			modelBuilder.Entity<Room>().HasData(Rooms);

			var Room_PictureJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Json/Room_Picture.json", Encoding.UTF8);
			IList<Room_Picture> Room_Pictures = JsonConvert.DeserializeObject<IList<Room_Picture>>(Room_PictureJsonData);
			modelBuilder.Entity<Room_Picture>().HasData(Room_Pictures);

			var ServiceJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Json/Service.json", Encoding.UTF8);
			IList<Service> Services = JsonConvert.DeserializeObject<IList<Service>>(ServiceJsonData);
			modelBuilder.Entity<Service>().HasData(Services);

			base.OnModelCreating(modelBuilder);
		}
	}
}
