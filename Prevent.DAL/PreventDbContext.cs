using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Models;


namespace Prevent.DAL
{
    public class PreventDbContext : DbContext
	{
		public PreventDbContext(DbContextOptions<PreventDbContext> options) : base(options)
		{
		}

		public DbSet<Activite> Activites { get; set; }
		public DbSet<ActiviteReferencee> ActivitesReferencees { get; set; }
		public DbSet<ActiviteRisque> ActivitesRisques { get; set; }
		public DbSet<Audit> Audits { get; set; }

        //public DbSet<DetailSignalement> DetailsSignalement { get; set; }
        //public DbSet<EffetInduit> EffetsInduits { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<EmployeReference> EmployesReferences { get; set; }
        public DbSet<Espace> Espaces { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanRisque> PlansRisques { get; set; }
		public DbSet<PorteeAudit> PorteesAudits { get; set; }
		public DbSet<PorteeEvenement> PorteesEvenements { get; set; }
		public DbSet<PorteePlan> PorteesPlans { get; set; }
		
		public DbSet<Prevention> Preventions { get; set; }
		public DbSet<PreventionReferencee> PreventionsReferencees { get; set; }
		public DbSet<PreventionRisque> PreventionsRisques { get; set; }
		public DbSet<Risque> Risques { get; set; }
		public DbSet<RisqueReference> RisquesReferencees { get; set; }
		public DbSet<Signalement> Signalements { get; set; }
		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Activite>().ToTable("Activite", "Prevention");
			modelBuilder.Entity<Audit>().ToTable("Audit", "Prevention");
			modelBuilder.Entity<Employe>().ToTable("Employe", "Prevention");
			modelBuilder.Entity<Espace>().ToTable("Espace", "Prevention");
            modelBuilder.Entity<Evenement>().ToTable("Evenement", "Prevention");
            modelBuilder.Entity<Plan>().ToTable("Plan", "Prevention");
            modelBuilder.Entity<Prevention>().ToTable("Prevention", "Prevention");
            modelBuilder.Entity<Risque>().ToTable("Risque", "Prevention");
            modelBuilder.Entity<Signalement>().ToTable("Signalement", "Prevention");


            //modelBuilder.ApplyConfiguration(new FluentConfiguration.Audit_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.Activite_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.Espace_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.Evenement_FluentConfiguration());

            modelBuilder.ApplyConfiguration(new FluentConfiguration.ActiviteRisque_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.ActiviteReferencee_FluentConfiguration());

            modelBuilder.ApplyConfiguration(new FluentConfiguration.EmployeReference_FluentConfiguration());

            modelBuilder.ApplyConfiguration(new FluentConfiguration.PorteeAudit_FluentConfiguration());
			modelBuilder.ApplyConfiguration(new FluentConfiguration.PorteeEvenement_FluentConfiguration());
			modelBuilder.ApplyConfiguration(new FluentConfiguration.PorteePlan_FluentConfiguration());

            modelBuilder.ApplyConfiguration(new FluentConfiguration.PreventionReferencee_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.PreventionRisque_FluentConfiguration());
            modelBuilder.ApplyConfiguration(new FluentConfiguration.RisqueReference_FluentConfiguration());

        }

		// 1. add-migration amazingMigration
		// 2. update-database

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=nameofyourdb;Database=nameofyourserver;TrustServerCertificate=True;Trusted_Connection=True;");
	}
}
