using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Education.Model.RequestModels
{
    public partial class EducationContext : DbContext
    {
        public EducationContext()
        {
        }

        public EducationContext(DbContextOptions<EducationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Benefit> Benefit { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Budget> Budget { get; set; }
        public virtual DbSet<BudgetDocument> BudgetDocument { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Competence> Competence { get; set; }
        public virtual DbSet<CompetenceGroup> CompetenceGroup { get; set; }
        public virtual DbSet<DefinitionType> DefinitionType { get; set; }
        public virtual DbSet<DefinitionTypeDetail> DefinitionTypeDetail { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<EducationCompetence> EducationCompetence { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ExpenseGroup> ExpenseGroup { get; set; }
        public virtual DbSet<ExpenseItem> ExpenseItem { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserDocument> UserDocument { get; set; }
        public virtual DbSet<UserEducation> UserEducation { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserGroupRelationship> UserGroupRelationship { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Education;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Benefit>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Benefit)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Benefit_Education");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentAddress).HasMaxLength(250);

                entity.Property(e => e.DepartmentEmail).HasMaxLength(50);

                entity.Property(e => e.DepartmentManagerEmail).HasMaxLength(50);

                entity.Property(e => e.DepartmentManagerName).HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentPhone).HasMaxLength(20);

                entity.Property(e => e.DepartmentTaxNo).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Branch_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_Company");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Branch_Town");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.BudgetCode)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.BudgetMonth)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.BudgetYear)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyType).HasMaxLength(11);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.TotalAmount).HasMaxLength(11);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ExpenseGroup)
                    .WithMany(p => p.Budget)
                    .HasForeignKey(d => d.ExpenseGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Budget_ExpenseGroup");

                entity.HasOne(d => d.ExpenseItem)
                    .WithMany(p => p.Budget)
                    .HasForeignKey(d => d.ExpenseItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Budget_ExpenseItem");
            });

            modelBuilder.Entity<BudgetDocument>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.FileDescription).HasMaxLength(250);

                entity.Property(e => e.FileExtensionKey)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FileExtensionName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.BudgetDocument)
                    .HasForeignKey(d => d.BudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BudgetDocument_Budget");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryDescription).HasMaxLength(150);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category_Company");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(e => e.EducationId)
                    .HasName("NonClusteredIndex-20200201-231203");

                entity.Property(e => e.CommentLine)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Education");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyAddress).HasMaxLength(250);

                entity.Property(e => e.CompanyEmail).HasMaxLength(50);

                entity.Property(e => e.CompanyManagerEmail).HasMaxLength(50);

                entity.Property(e => e.CompanyManagerName).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPhone).HasMaxLength(20);

                entity.Property(e => e.CompanyTaxNo).HasMaxLength(50);

                entity.Property(e => e.CompanyTaxOffice).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.Property(e => e.CompetenceName).HasMaxLength(250);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompetenceGroup)
                    .WithMany(p => p.Competence)
                    .HasForeignKey(d => d.CompetenceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competence_CompetenceGroup");
            });

            modelBuilder.Entity<CompetenceGroup>(entity =>
            {
                entity.Property(e => e.CompetenceGroupDescription).HasMaxLength(500);

                entity.Property(e => e.CompetenceGroupName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DefinitionType>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.TypeDescription).HasMaxLength(250);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DefinitionTypeDetail>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DefinitionTypeDetailDescription).HasMaxLength(250);

                entity.Property(e => e.DefinitionTypeDetailName).HasMaxLength(50);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.DefinitionType)
                    .WithMany(p => p.DefinitionTypeDetail)
                    .HasForeignKey(d => d.DefinitionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DefinitionTypeDetail_DefinitionType");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Branch");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.FileExtensionKey)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FileExtensionName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.TotalDuration).HasMaxLength(11);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Education");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EducationCode).HasMaxLength(20);

                entity.Property(e => e.EducationDescription).HasMaxLength(150);

                entity.Property(e => e.EducationName).HasMaxLength(100);

                entity.Property(e => e.EducationRequirements).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Education_Category");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Education_Company");

                entity.HasOne(d => d.DefinitionTypeDetail)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.DefinitionTypeDetailId)
                    .HasConstraintName("FK_Education_DefinitionTypeDetail");

                entity.HasOne(d => d.DefinitionType)
                    .WithMany(p => p.Education)
                    .HasForeignKey(d => d.DefinitionTypeId)
                    .HasConstraintName("FK_Education_DefinitionType");
            });

            modelBuilder.Entity<EducationCompetence>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Competence)
                    .WithMany(p => p.EducationCompetence)
                    .HasForeignKey(d => d.CompetenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationCompetence_Competence");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.EducationCompetence)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationCompetence_Education");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CitizenshipNumber).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeAddress).HasMaxLength(250);

                entity.Property(e => e.EmployeeEmail).HasMaxLength(50);

                entity.Property(e => e.EmployeeFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeePhone).HasMaxLength(50);

                entity.Property(e => e.EmployeePhoto).HasMaxLength(500);

                entity.Property(e => e.EmployeeTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_City");

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Department");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Town");
            });

            modelBuilder.Entity<ExpenseGroup>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseGroupDescription).HasMaxLength(250);

                entity.Property(e => e.ExpenseGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExpenseItem>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseItemDescription).HasMaxLength(150);

                entity.Property(e => e.ExpenseItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ExpenseGroup)
                    .WithMany(p => p.ExpenseItem)
                    .HasForeignKey(d => d.ExpenseGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseItem_ExpenseGroup");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_Education");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.ContactEmail).HasMaxLength(30);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LocationAddress)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LocationDescription).HasMaxLength(250);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ManagerName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PlanDescription).HasMaxLength(150);

                entity.Property(e => e.PlanName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Education");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Location");

                entity.HasOne(d => d.Traniner)
                    .WithMany(p => p.Plan)
                    .HasForeignKey(d => d.TraninerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plan_Trainer");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RoleMenu)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleMenu_Menu");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMenu)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleMenu_Role");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierAddress).HasMaxLength(250);

                entity.Property(e => e.SupplierCode).HasMaxLength(10);

                entity.Property(e => e.SupplierEmail).HasMaxLength(50);

                entity.Property(e => e.SupplierManagerEmail).HasMaxLength(50);

                entity.Property(e => e.SupplierManagerName).HasMaxLength(50);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierPhone).HasMaxLength(20);

                entity.Property(e => e.SupplierTaxNo).HasMaxLength(50);

                entity.Property(e => e.SupplierTaxOffice).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Supplier_City");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Supplier_Company");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Supplier_Town");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Town)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Town_City");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.TrainerAddress).HasMaxLength(250);

                entity.Property(e => e.TrainerEmail).HasMaxLength(30);

                entity.Property(e => e.TrainerFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrainerLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrainerPhone).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Trainer)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trainer_Supplier");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Employee");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<UserDocument>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.PauseDuration).HasMaxLength(11);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.UserDocument)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDocument_Document");
            });

            modelBuilder.Entity<UserEducation>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.UserEducation)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEducation_Education");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEducation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserEducation_User");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserGroupRelationship>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UserGroupRelationship)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroupRelationship_UserGroup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroupRelationship)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroupRelationship_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
