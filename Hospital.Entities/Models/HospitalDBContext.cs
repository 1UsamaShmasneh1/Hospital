using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital.Entities.Models
{
    public partial class HospitalDBContext : DbContext
    {
        public HospitalDBContext()
        {
        }

        public HospitalDBContext(DbContextOptions<HospitalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Hospital> Hospitals { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<MedicalFile> MedicalFiles { get; set; } = null!;
        public virtual DbSet<Medication> Medications { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientStatus> PatientStatuses { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<SeverityOfDisease> SeverityOfDiseases { get; set; } = null!;
        public virtual DbSet<Treatment> Treatments { get; set; } = null!;
        public virtual DbSet<TreatmentInfo> TreatmentInfos { get; set; } = null!;
        public virtual DbSet<TreatmentMedication> TreatmentMedications { get; set; } = null!;
        public virtual DbSet<Turn> Turns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-UUKIMMC\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.Username, "UK_Accounts")
                    .IsUnique();

                entity.Property(e => e.AccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("Account_Id");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId)
                    .ValueGeneratedNever()
                    .HasColumnName("Address_Id");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.HouseNumber).HasColumnName("House_Number");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasColumnName("Zip_Code");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.DepartmentTitle, "UK_Departments")
                    .IsUnique();

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Department_Id");

                entity.Property(e => e.DepartmentTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Department_Title");

                entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_Departments_Hospitals");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.PersonId, "UK_Employees")
                    .IsUnique();

                entity.HasIndex(e => e.AccountId, "UK_Employees2")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.JobId).HasColumnName("Job_Id");

                entity.Property(e => e.ManagerId).HasColumnName("Manager_Id");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.AccountId)
                    .HasConstraintName("FK_Employees_Accounts");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employees_Departments");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Employees_Jobs");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Employees_Employees");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.PersonId)
                    .HasConstraintName("FK_Employees_People");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.HasIndex(e => e.HospitalTitle, "UK_Hospital")
                    .IsUnique();

                entity.Property(e => e.HospitalId)
                    .ValueGeneratedNever()
                    .HasColumnName("Hospital_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.Property(e => e.HospitalTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Hospital_Title");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Hospitals)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Hospitals_Address");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasIndex(e => e.JobTitle, "UK_Jobs")
                    .IsUnique();

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("Job_Id");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Job_Title");
            });

            modelBuilder.Entity<MedicalFile>(entity =>
            {
                entity.ToTable("Medical_File");

                entity.HasIndex(e => e.PersonId, "UK_Medical_File")
                    .IsUnique();

                entity.Property(e => e.MedicalFileId)
                    .ValueGeneratedNever()
                    .HasColumnName("Medical_File_Id");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.HasOne(d => d.MedicalFileNavigation)
                    .WithOne(p => p.MedicalFileMedicalFileNavigation)
                    .HasPrincipalKey<Person>(p => p.MedicalFileId)
                    .HasForeignKey<MedicalFile>(d => d.MedicalFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medical_File_People");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.MedicalFilePerson)
                    .HasForeignKey<MedicalFile>(d => d.PersonId)
                    .HasConstraintName("FK_Medical_File_People1");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.HasIndex(e => e.MedicationTitle, "UK_Medicians")
                    .IsUnique();

                entity.Property(e => e.MedicationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Medication_Id");

                entity.Property(e => e.MedicationTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Medication_Title");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasIndex(e => e.TurnId, "UK_Patients1")
                    .IsUnique();

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("Patient_Id");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.PersonId).HasColumnName("Person_Id");

                entity.Property(e => e.SeverityOfDiseaseId).HasColumnName("Severity_Of_Disease_Id");

                entity.Property(e => e.TreatmentId).HasColumnName("Treatment_Id");

                entity.Property(e => e.TurnId).HasColumnName("Turn_Id");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Patients_Departments");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Patients_People");

                entity.HasOne(d => d.SeverityOfDisease)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.SeverityOfDiseaseId)
                    .HasConstraintName("FK_Patients_Severity_Of_Disease");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Patients_PatientStatuses");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.TreatmentId)
                    .HasConstraintName("FK_Patients_Treatments");

                entity.HasOne(d => d.Turn)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.TurnId)
                    .HasConstraintName("FK_Patients_Turns");
            });

            modelBuilder.Entity<PatientStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.IdentityNumber, "UK_IdentityNumber")
                    .IsUnique();

                entity.HasIndex(e => e.MedicalFileId, "UK_People")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressId).HasColumnName("Address_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Identity_Number")
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MedicalFileId)
                    .IsRequired()
                    .HasColumnName("Medical_File_Id");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Phone_Number")
                    .IsFixedLength();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_People_Address_Id_Address_Id");
            });

            modelBuilder.Entity<SeverityOfDisease>(entity =>
            {
                entity.ToTable("Severity_Of_Disease");

                entity.HasIndex(e => e.SeverityOfDeseaseTitle, "UK_Severity_Of_Disease")
                    .IsUnique();

                entity.Property(e => e.SeverityOfDiseaseId)
                    .ValueGeneratedNever()
                    .HasColumnName("Severity_Of_Disease_Id");

                entity.Property(e => e.SeverityOfDeseaseTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Severity_Of_Desease_Title");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.HasIndex(e => e.TreatmentInfoId, "UK_Treatments")
                    .IsUnique();

                entity.Property(e => e.TreatmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Treatment_Id");

                entity.Property(e => e.MedicalFileId).HasColumnName("Medical_File_Id");

                entity.Property(e => e.TreatmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Treatment_Date");

                entity.Property(e => e.TreatmentInfoId).HasColumnName("Treatment_Info_Id");

                entity.HasOne(d => d.MedicalFile)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.MedicalFileId)
                    .HasConstraintName("FK_Treatments_Medical_File");

                entity.HasOne(d => d.TreatmentInfo)
                    .WithOne(p => p.Treatment)
                    .HasForeignKey<Treatment>(d => d.TreatmentInfoId)
                    .HasConstraintName("FK_Treatments_Treatment_Info");
            });

            modelBuilder.Entity<TreatmentInfo>(entity =>
            {
                entity.ToTable("Treatment_Info");

                entity.Property(e => e.TreatmentInfoId)
                    .ValueGeneratedNever()
                    .HasColumnName("Treatment_Info_id");

                entity.Property(e => e.BloodPressure)
                    .HasMaxLength(10)
                    .HasColumnName("Blood_Pressure")
                    .IsFixedLength();

                entity.Property(e => e.BloodTest)
                    .HasColumnType("text")
                    .HasColumnName("Blood_Test");

                entity.Property(e => e.DiseaseDiagnosis)
                    .HasColumnType("text")
                    .HasColumnName("Disease_Diagnosis");

                entity.Property(e => e.Heartbeat)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Heat)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsSmoking).HasColumnName("Is_Smoking");

                entity.Property(e => e.MedicalAdvice)
                    .HasColumnType("text")
                    .HasColumnName("Medical_Advice");

                entity.Property(e => e.OxginInBlood)
                    .HasMaxLength(10)
                    .HasColumnName("Oxgin_In_Blood")
                    .IsFixedLength();

                entity.Property(e => e.ReasonOfComing)
                    .HasColumnType("text")
                    .HasColumnName("Reason_of_coming");

                entity.Property(e => e.Sensitive).HasColumnType("text");

                entity.Property(e => e.UrineTest)
                    .HasColumnType("text")
                    .HasColumnName("Urine_Test");
            });

            modelBuilder.Entity<TreatmentMedication>(entity =>
            {
                entity.ToTable("Treatment_Medication");

                entity.Property(e => e.TreatmentMedicationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Treatment_Medication_Id");

                entity.Property(e => e.BerBite).HasColumnName("Ber_Bite");

                entity.Property(e => e.BerDay).HasColumnName("Ber_Day");

                entity.Property(e => e.MedicationId).HasColumnName("Medication_Id");

                entity.Property(e => e.TreatmentId).HasColumnName("Treatment_Id");

                entity.HasOne(d => d.Medication)
                    .WithMany(p => p.TreatmentMedications)
                    .HasForeignKey(d => d.MedicationId)
                    .HasConstraintName("FK_Treatment_Medician_Medicians");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.TreatmentMedications)
                    .HasForeignKey(d => d.TreatmentId)
                    .HasConstraintName("FK_Treatment_Medician_Treatments");
            });

            modelBuilder.Entity<Turn>(entity =>
            {
                entity.HasIndex(e => e.TurnTitle, "UK_Turns")
                    .IsUnique();

                entity.Property(e => e.TurnId)
                    .ValueGeneratedNever()
                    .HasColumnName("Turn_Id");

                entity.Property(e => e.TurnTitle)
                    .HasMaxLength(10)
                    .HasColumnName("Turn_Title")
                    .IsFixedLength();
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
