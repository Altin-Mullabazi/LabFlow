using LabFlow.Business.LaboratoryOperationsResults.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabFlow.API.Controllers.LaboratoryOperationsResults;

[ApiController]
[Route("api/[controller]")]
public sealed class ReportsController(IReportService reportService) : ControllerBase
{
    private readonly IReportService _reportService = reportService;
}
