using Microsoft.EntityFrameworkCore;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.BLL.Concrete;
using UniSystem2API.BLL.Mappers;
using UniSystem2API.DAL;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DAL.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();//.AddJsonOptions(options =>
                                  //{
                                  //  options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                                  //options.JsonSerializerOptions.MaxDepth = 10; 
                                  //});


builder.Services.AddDbContext<UniDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
});

builder.Services.AddSwaggerDocument();
builder.Services.AddEndpointsApiExplorer();



builder.Services.AddScoped<IUniSystemCourseService, UniSystemCourseManager>();
builder.Services.AddScoped<IUniSystemDepartmentService, UniSystemDepartmentManager>();
builder.Services.AddScoped<IUniSystemEnrollmentService, UniSystemEnrollmentManager>();
builder.Services.AddScoped<IUniSystemExamService, UniSystemExamManager>();
builder.Services.AddScoped<IUniSystemExamResultService, UniSystemExamResultManager>();
builder.Services.AddScoped<IUniSystemInstructorService, UniSystemInstructorManager>();
builder.Services.AddScoped<IUniSystemStudentService, UniSystemStudentManager>();
builder.Services.AddScoped<IUniSystemTuitionService, UniSystemTuitionManager>();
//----------------
builder.Services.AddScoped<IUniSystemCourseRepository, UniSystemCourseRepository>();
builder.Services.AddScoped<IUniSystemDepartmentRepository, UniSystemDepartmentRepository>();
builder.Services.AddScoped<IUniSystemEnrollmentRepository, UniSystemEnrollmentRepository>();
builder.Services.AddScoped<IUniSystemExamRepository, UniSystemExamRepository>();
builder.Services.AddScoped<IUniSystemExamResultRepository, UniSystemExamResultRepository>();
builder.Services.AddScoped<IUniSystemInstructorRepository, UniSystemInstructorRepository>();
builder.Services.AddScoped<IUniSystemStudentRepository, UniSystemStudentRepository>();
builder.Services.AddScoped<IUniSystemTuitionRepository, UniSystemTuitionRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.UseOpenApi();
app.UseSwaggerUi3();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
