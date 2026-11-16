using LabFlow.Business.LaboratoryOperationsResults.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabFlow.API.Controllers.LaboratoryOperationsResults;

[ApiController]
[Route("api/[controller]")]
public sealed class ResultsController(IResultService resultService) : ControllerBase
{
    private readonly IResultService _resultService = resultService;
}
