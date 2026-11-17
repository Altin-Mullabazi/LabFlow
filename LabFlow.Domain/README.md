# LabFlow.Domain

This project holds the domain model shared by the application and data layers.

## Organisation

- `PatientRequestManagement`: patient and analysis-request domain concepts.
- `LaboratoryOperationsResults`: sample, analysis-result and laboratory-report domain concepts.
- `Common`: reusable domain building blocks.

DTOs remain in `LabFlow.Business`, and persistence configuration remains in `LabFlow.Data`.

The entity model is intentionally not defined here yet: it must be aligned with the approved nine-class conceptual model before persistence is introduced.
