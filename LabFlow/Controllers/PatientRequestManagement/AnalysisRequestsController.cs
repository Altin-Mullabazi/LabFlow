using LabFlow.Business.PatientRequestManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabFlow.API.Controllers.PatientRequestManagement;

[ApiController]
[Route("api/[controller]")]
public sealed class AnalysisRequestsController(IAnalysisRequestService analysisRequestService) : ControllerBase
{
    private readonly IAnalysisRequestService _analysisRequestService = analysisRequestService;
}
