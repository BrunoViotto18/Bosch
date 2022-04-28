namespace DAO;
using Microsoft.EntityFrameworkCore;


public class DAOContext : DbContext
{
    public DbSet<Armas> Armas { get; set; }
    public DbSet<Batalhas> Batalhas { get; set; }
    public DbSet<Herois> Herois { get; set; }
    public DbSet<HeroisBatalhas> HeroisBatalhas { get; set; }
    public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = JVLPC0524; Initial Catalog = HeroiApp; Integrated Security = True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Armas>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Nome);
            entity.HasOne(f => f.Heroi);
        }
        );

        modelBuilder.Entity<Batalhas>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Nome);
            entity.Property(e => e.Descricao);
            entity.Property(e => e.DtInicio);
            entity.Property(e => e.DtFim);
        }
        );

        modelBuilder.Entity<Herois>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(e => e.Nome);
        }
        );

        modelBuilder.Entity<HeroisBatalhas>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.HasOne(f => f.Heroi);
            entity.HasOne(f => f.Batalha);
        }
        );

        modelBuilder.Entity<IdentidadeSecreta>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(e => e.NomeReal);
            entity.HasOne(f => f.Heroi);
        }
        );
    }
}
