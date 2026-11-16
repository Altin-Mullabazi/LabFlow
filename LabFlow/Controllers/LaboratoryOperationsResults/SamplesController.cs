using LabFlow.Business.LaboratoryOperationsResults.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabFlow.API.Controllers.LaboratoryOperationsResults;

[ApiController]
[Route("api/[controller]")]
public sealed class SamplesController(ISampleService sampleService) : ControllerBase
{
    private readonly ISampleService _sampleService = sampleService;
}
