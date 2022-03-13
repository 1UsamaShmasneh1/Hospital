using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital.Entities.Models
{
    public partial class SomeDBContext : DbContext
    {
        public SomeDBContext()
        {
        }

        public SomeDBContext(DbContextOptions<SomeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-UUKIMMC\\SQLEXPRESS;Initial Catalog=SomeDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.TeamId, "IX_Players_TeamId");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(50)
                    .HasColumnName("Player_Name");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.TeamTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Team_Title");
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Address>().HasData(
                    new Address
                    {
                        AddressId = 1,
                        City = "Jaljulia",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 45850,
                        Street = "127",
                        HouseNumber = 29
                    },

                    new Address
                    {
                        AddressId = 2,
                        City = "Betah Tekva",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 54769,
                        Street = "HaShalom",
                        HouseNumber = 30
                    },

                    new Address
                    {
                        AddressId = 3,
                        City = "Hertzlya",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 23456,
                        Street = "Gabotenski",
                        HouseNumber = 107
                    },

                    new Address
                    {
                        AddressId = 4,
                        City = "Tel Aviv",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 57888,
                        Street = "Shlomo HaMeleck",
                        HouseNumber = 5
                    },

                    new Address
                    {
                        AddressId = 5,
                        City = "Jaljulia",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 45850,
                        Street = "19",
                        HouseNumber = 10
                    },

                    new Address
                    {
                        AddressId = 6,
                        City = "Rosh HaAyen",
                        State = "IL",
                        Country = "Israel",
                        ZipCode = 45768,
                        Street = "Shbazy",
                        HouseNumber = 45
                    }
                );

            modelBuilder.Entity<Hospital>().HasData(
                    new Hospital
                    {
                        HospitalId = 1,
                        HospitalTitle = "Belenson",
                        AddressId = 1
                    }
                );

            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        DepartmentId = 1,
                        HospitalId = 1,
                        DepartmentTitle = "JaljuliaHOS"
                    }
                );

            modelBuilder.Entity<Job>().HasData(
                    new Job
                    {
                        JobId = 1,
                        JobTitle = "Admin"
                    },

                    new Job
                    {
                        JobId = 2,
                        JobTitle = "Secretary"
                    },

                    new Job
                    {
                        JobId = 3,
                        JobTitle = "Nurse"
                    },

                    new Job
                    {
                        JobId = 4,
                        JobTitle = "Doctor"
                    }
                );

            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        EmployeeId = 1,
                        PersonId = 1,
                        ManagerId = 4,
                        JobId = 4,
                        DepartmentId = 1,
                        AccountId = 1
                    },

                    new Employee
                    {
                        EmployeeId = 2,
                        PersonId = 2,
                        ManagerId = 4,
                        JobId = 2,
                        DepartmentId = 1,
                        AccountId = 2
                    },

                    new Employee
                    {
                        EmployeeId = 3,
                        PersonId = 3,
                        ManagerId = 4,
                        JobId = 3,
                        DepartmentId = 1,
                        AccountId = 3
                    },

                    new Employee
                    {
                        EmployeeId = 4,
                        PersonId = 4,
                        ManagerId = null,
                        JobId = 1,
                        DepartmentId = 1,
                        AccountId = 4
                    }
                );

            modelBuilder.Entity<MedicalFile>().HasData(
                    new MedicalFile
                    {
                        MedicalFileId = 1,
                        PersonId = 1
                    },

                    new MedicalFile
                    {
                        MedicalFileId = 2,
                        PersonId = 2
                    },

                    new MedicalFile
                    {
                        MedicalFileId = 3,
                        PersonId = 3
                    },

                    new MedicalFile
                    {
                        MedicalFileId = 4,
                        PersonId = 4
                    },

                    new MedicalFile
                    {
                        MedicalFileId = 5,
                        PersonId = 5
                    },

                    new MedicalFile
                    {
                        MedicalFileId = 6,
                        PersonId = 6
                    }
                );

            modelBuilder.Entity<Person>().HasData(
                    new Person
                    {
                        Id = 1,
                        IdentityNumber = "308127125",
                        FirstName = "Usama",
                        LastName = "Shmasneh",
                        AddressId = 1,
                        PhoneNumber = "0525382178",
                        Email = "us.05.07.91@gmail.com",
                        MedicalFileId = 1,
                        DateOfBirth = new DateTime(1991, 07, 05),
                        Gender = "Male"
                    },

                    new Person
                    {
                        Id = 2,
                        IdentityNumber = "209127125",
                        FirstName = "Avi",
                        LastName = "Loko",
                        AddressId = 2,
                        PhoneNumber = "0525637825",
                        Email = "email@gmail.com",
                        MedicalFileId = 2,
                        DateOfBirth = new DateTime(1990, 05, 07),
                        Gender = "Male"
                    },

                    new Person
                    {
                        Id = 3,
                        IdentityNumber = "209117225",
                        FirstName = "Lemor",
                        LastName = "Hakmon",
                        AddressId = 3,
                        PhoneNumber = "0524628657",
                        Email = "email@gmail.com",
                        MedicalFileId = 3,
                        DateOfBirth = new DateTime(1987, 05, 30),
                        Gender = "Female"
                    },

                    new Person
                    {
                        Id = 4,
                        IdentityNumber = "208127225",
                        FirstName = "Lofy",
                        LastName = "MonkyDe",
                        AddressId = 4,
                        PhoneNumber = "0527548656",
                        Email = "email@gmail.com",
                        MedicalFileId = 4,
                        DateOfBirth = new DateTime(1995, 03, 27),
                        Gender = "Male"
                    },

                    new Person
                    {
                        Id = 5,
                        IdentityNumber = "208137125",
                        FirstName = "Adham",
                        LastName = "Ahmed",
                        AddressId = 5,
                        PhoneNumber = "0527654794",
                        Email = "email@gmail.com",
                        MedicalFileId = 5,
                        DateOfBirth = new DateTime(2001, 11, 15),
                        Gender = "Male"
                    },

                    new Person
                    {
                        Id = 6,
                        IdentityNumber = "208137323",
                        FirstName = "Rahil",
                        LastName = "Mezrahi",
                        AddressId = 6,
                        PhoneNumber = "05296355862",
                        Email = "email@gmail.com",
                        MedicalFileId = 6,
                        DateOfBirth = new DateTime(1975, 10, 19),
                        Gender = "Female"
                    }
                );

            modelBuilder.Entity<Account>().HasData(
                    new Account
                    {
                        AccountId = 1,
                        Username = "doctor",
                        Password = "12345678",
                        Status = 0
                    },

                    new Account
                    {
                        AccountId = 2,
                        Username = "secretary",
                        Password = "12345678",
                        Status = 0
                    },

                    new Account
                    {
                        AccountId = 3,
                        Username = "nurse",
                        Password = "12345678",
                        Status = 0
                    },

                    new Account
                    {
                        AccountId = 4,
                        Username = "admin",
                        Password = "12345678",
                        Status = 0
                    }
                );

            modelBuilder.Entity<Turn>().HasData(
                    new Turn
                    {
                        TurnId = 1,
                        TurnTitle = "A1",
                        Status = 1
                    },

                    new Turn
                    {
                        TurnId = 2,
                        TurnTitle = "A2",
                        Status = 1
                    },

                    new Turn
                    {
                        TurnId = 3,
                        TurnTitle = "A3",
                        Status = 3
                    },

                    new Turn
                    {
                        TurnId = 4,
                        TurnTitle = "A4",
                        Status = 1
                    },

                    new Turn
                    {
                        TurnId = 5,
                        TurnTitle = "A5",
                        Status = 1
                    },

                    new Turn
                    {
                        TurnId = 6,
                        TurnTitle = "A6",
                        Status = 1
                    }
                );

            modelBuilder.Entity<SeverityOfDisease>().HasData(
                    new SeverityOfDisease
                    {
                        SeverityOfDiseaseId = 1,
                        SeverityOfDeseaseTitle = "Low"
                    },

                    new SeverityOfDisease
                    {
                        SeverityOfDiseaseId = 2,
                        SeverityOfDeseaseTitle = "Medium"
                    },

                    new SeverityOfDisease
                    {
                        SeverityOfDiseaseId = 3,
                        SeverityOfDeseaseTitle = "Hight"
                    }
                );

            modelBuilder.Entity<PatientStatus>().HasData(
                    new PatientStatus
                    {
                        StatusId = 1,
                        StatusTitle = "WaitingToSecretary"
                    },

                    new PatientStatus
                    {
                        StatusId = 2,
                        StatusTitle = "WaitingToNurse"
                    },

                    new PatientStatus
                    {
                        StatusId = 3,
                        StatusTitle = "WaitingToDoctor"
                    },

                    new PatientStatus
                    {
                        StatusId = 4,
                        StatusTitle = "EndTreatment"
                    },

                    new PatientStatus
                    {
                        StatusId = 5,
                        StatusTitle = "InTreatment"
                    }
                );

            modelBuilder.Entity<Medication>().HasData(
                    new Medication
                    {
                        MedicationId = 0,
                        MedicationTitle = "Optalgin 500"
                    },

                    new Medication
                    {
                        MedicationId = 1,
                        MedicationTitle = "Voltren"
                    },

                    new Medication
                    {
                        MedicationId = 2,
                        MedicationTitle = "Tramadol"
                    },

                    new Medication
                    {
                        MedicationId = 3,
                        MedicationTitle = "Tramadex"
                    },

                    new Medication
                    {
                        MedicationId = 4,
                        MedicationTitle = "Papaverin"
                    },

                    new Medication
                    {
                        MedicationId = 5,
                        MedicationTitle = "Spasmalgin"
                    },

                    new Medication
                    {
                        MedicationId = 6,
                        MedicationTitle = "Colotal"
                    },

                    new Medication
                    {
                        MedicationId = 7,
                        MedicationTitle = "Akamol"
                    }
                );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
