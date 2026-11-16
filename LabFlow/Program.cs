
using LabFlow.Business.LaboratoryOperationsResults.Interfaces;
using LabFlow.Business.LaboratoryOperationsResults.Services;
using LabFlow.Business.PatientRequestManagement.Interfaces;
using LabFlow.Business.PatientRequestManagement.Services;
using LabFlow.Data.LaboratoryOperationsResults.Repositories;
using LabFlow.Data.PatientRequestManagement.Repositories;

namespace LabFlow.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // TODO: Replace repository placeholders with persistence-backed
            // implementations when the data model and database are introduced.
            builder.Services.AddScoped<IPatientService, PatientService>();
            builder.Services.AddScoped<IAnalysisRequestService, AnalysisRequestService>();
            builder.Services.AddScoped<ISampleService, SampleService>();
            builder.Services.AddScoped<IAnalysisProcessingService, AnalysisProcessingService>();
            builder.Services.AddScoped<IResultService, ResultService>();
            builder.Services.AddScoped<IReportService, ReportService>();

            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddScoped<IAnalysisRequestRepository, AnalysisRequestRepository>();
            builder.Services.AddScoped<ISampleRepository, SampleRepository>();
            builder.Services.AddScoped<IResultRepository, ResultRepository>();
            builder.Services.AddScoped<IReportRepository, ReportRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
