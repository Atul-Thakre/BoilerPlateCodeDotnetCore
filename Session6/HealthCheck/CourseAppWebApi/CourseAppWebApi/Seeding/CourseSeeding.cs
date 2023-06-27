using CourseAppWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Metrics;

namespace CourseAppWebApi.Seeding
{
    public class CourseSeeding : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(

                new Course
                {
                    CourseId = 1,
                    CourseName = "Java",
                    CoursePrice = 8000,
                   



                },

                new Course
                {
                    CourseId = 2,
                    CourseName = "Python",
                    CoursePrice = 5000,
                   
                }
                );  
 
        }   
    }


}
