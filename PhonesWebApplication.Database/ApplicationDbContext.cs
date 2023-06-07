namespace PhonesWebApplication.Database;

public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Accessory> Accessories { get; set; }
    public DbSet<PhoneAccessory> PhoneAccessories { get; set; }
    public DbSet<Cart> Carts { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUsers>().ToTable("AspNetUsers");
        builder.Entity<IdentityRole>().ToTable("AspNetRoles");

        base.OnModelCreating(builder);
        builder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.HasMany(e => e.PhoneAccessories)
                .WithOne(e => e.Phone)
                .HasForeignKey(e => e.PhoneId);
            entity.HasMany(e => e.PhoneAccessories)
                .WithOne(e => e.Phone)
                .HasForeignKey(e => e.PhoneId);
        });
        
        builder.Entity<Accessory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.HasMany(e => e.PhoneAccessories)
                .WithOne(e => e.Accessory)
                .HasForeignKey(e => e.AccessoryId);
        });

        builder.Entity<PhoneAccessory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.HasOne(e => e.Phone)
                .WithMany(e => e.PhoneAccessories)
                .HasForeignKey(e => e.PhoneId);
            entity.HasOne(e => e.Accessory)
                .WithMany(e => e.PhoneAccessories)
                .HasForeignKey(e => e.AccessoryId);
        });

        builder.Entity<ApplicationUsers>()
            .HasOne(u => u.Cart)
            .WithOne(c => c.ApplicationUsers)
            .HasForeignKey<Cart>(e => e.UserId);

        builder.Entity<CartPhone>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            entity.HasOne(e => e.Cart)
                .WithMany(e => e.CartPhones)
                .HasForeignKey(e => e.CartId);
            entity.HasOne(e => e.Phone)
                .WithMany(e => e.CartPhones)
                .HasForeignKey(e => e.PhoneId);
        });
        
        var adminRole = new IdentityRole
        {
            Name = "admin",
            NormalizedName = "ADMIN"
        };
        
        builder.Entity<IdentityRole>().HasData(adminRole);
        
        var adminUser = new ApplicationUsers
        {
            UserName = "admin@gmail.com",
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            NormalizedUserName = "ADMIN@GMAIL.com"
        };

        var passwordHasher = new PasswordHasher<ApplicationUsers>();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin123!");

        builder.Entity<ApplicationUsers>().HasData(adminUser);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = adminRole.Id,
            UserId = adminUser.Id
        });
    }
}