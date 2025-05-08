using FluentNHibernate.Cfg;
using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prevent.DAL
{
    public class PreventDbContext : DbContext
	{
		public PreventDbContext(DbContextOptions<PreventDbContext> options) : base(options)
		{
		}

		public DbSet<Activite> Activites { get; set; }
		public DbSet<Risque> Risques { get; set; }
		public DbSet<MesurePrevention> Preventions { get; set; }
		public DbSet<Employe> Employes { get; set; }
		public DbSet<Espace> Espaces { get; set; }
		public DbSet<Evenement> Evenements { get; set; }
		public DbSet<Audit> Audits { get; set; }
		public DbSet<Signalement> Signalements { get; set; }
		public DbSet<PlanAction> PlanActions { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new FluentConfiguration.PorteeAudit_FluentConfiguration());
			modelBuilder.ApplyConfiguration(new FluentConfiguration.ActiviteRisque_FluentConfiguration());
			//modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 1, BrandName = "Brand 1" });

			/*
			modelBuilder.Entity<ActiviteRisque>()
				.HasKey(ra => new { ra.ActiviteId, ra.RisqueId });

			modelBuilder.Entity<ActiviteRisque>()
				.HasOne(a => a.Risque)
				.WithMany()
				.HasForeignKey(ra => ra.RisqueId);

			modelBuilder.Entity<ActiviteRisque>()
				.HasOne(a => a.Activite)
				.WithMany()
				.HasForeignKey(ra => ra.ActiviteId);
			*/
		}

		// 1. add-migration amazingMigration
		// 2. update-database

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=nameofyourdb;Database=nameofyourserver;TrustServerCertificate=True;Trusted_Connection=True;");
	}
}
