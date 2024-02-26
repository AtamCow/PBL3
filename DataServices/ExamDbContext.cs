using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using OnlineExamSystem.DataServicesLayer.Model.School;
using OnlineExamSystem.DataServicesLayer.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OnlineExamSystem.DataServicesLayer
{
    public class ExamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }      
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestTaker> TestTakers { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies()
                              .UseSqlServer(@"Server=tcp:db.dutlearning.koding.tk,1433;Database=OnlineExamSystem_Dev2;User ID=sa;Password=68RsyRjLfc5uqSsGYA3x;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassStudent>()
                .HasKey(cs => new { cs.ClassId, cs.UserId });

            modelBuilder.Entity<ClassStudent>()
                .HasOne(cs => cs.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(cs => cs.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ClassStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(u => u.ClassStudents)
                .HasForeignKey(cs => cs.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Class>()
                .HasOne(c => c.OwnedTeacher)
                .WithMany()
                .HasForeignKey(c => c.OwnedTeacherId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Question>()
                .HasOne(t => t.Test)
                .WithMany(t => t.Questions)
                .HasForeignKey(t => t.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Test>()
                .HasOne(t => t.Creator)
                .WithMany(u => u.TestsCreated)
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.AnswerOptions)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TestTakerResult>()
                .HasOne(ttr => ttr.TestTaker)
                .WithMany(tt => tt.TestTakerResults)
                .HasForeignKey(ttr => ttr.TestTakerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentAnswerResponse>()
                .HasOne(sar => sar.TestTaker)
                .WithMany(ttr => ttr.AnswerResponses)
                .HasForeignKey(sar => sar.TestTakerResultId)
                .OnDelete(DeleteBehavior.NoAction); 

        }
    }
}
