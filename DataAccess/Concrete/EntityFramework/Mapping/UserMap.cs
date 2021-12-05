using Entities.Concrete.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // @"dbo" şema
            builder.ToTable("User", @"dbo")
                ;
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.UserName)
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired(); 
            
            builder.Property(x=>x.FirstName)
                .HasColumnName("FirsName")
                .HasMaxLength(50)
                .IsRequired(); 
            
            builder.Property(x=>x.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired(); 
            
            builder.Property(x=>x.Password)
                .HasColumnName("Password")
                .HasMaxLength(20)
                .IsRequired(); 
            
            builder.Property(x=>x.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x=>x.Gender)
                .HasColumnName("Gender")
                .IsRequired();
            
            builder.Property(x=>x.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.HasData(new User
            {
                Id = 1,
                UserName = "uzayk",
                FirstName = "Uzay KAHRAMAN",
                LastName = "Alkın",
                Password = "12345",
                Email = "uzay@gmail.com",
                Gender = true,
                DateOfBirth = Convert.ToDateTime("20-08-1998"),
                CreatedDate = DateTime.Now,
                Address = "Ankara",
                CreatedUserId = 1
            });
        }
    }
}
