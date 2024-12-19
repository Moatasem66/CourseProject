
using ClassRoomProject.Services;
using CourseProject.Contracts;
using CourseProject.Services;
using Microsoft.EntityFrameworkCore;
using Project.Contracts;
using Project.Data;
using Newtonsoft.Json;
using Project.Services;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }); 


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<AppDBContext>(
                o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") )
                );

            /// <summary>Register Contracts and his Concrete classes</summary> 
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IClassRoomService, ClassRoomService>();
            builder.Services.AddScoped<IInstructorService, InstructorService>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();
            builder.Services.AddScoped<IAssignmentService, AssignmentService>();
            builder.Services.AddScoped<IStudentAssignmentService, StudentAssignmentService>();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Course Project");
                    options.DocExpansion(DocExpansion.None); 
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
