using LabFlow.Business.PatientRequestManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabFlow.API.Controllers.PatientRequestManagement;

[ApiController]
[Route("api/[controller]")]
public sealed class PatientsController(IPatientService patientService) : ControllerBase
{
    private readonly IPatientService _patientService = patientService;
}
