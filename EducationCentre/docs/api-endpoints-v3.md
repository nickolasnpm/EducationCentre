# API endpoints v3 (placeholder)

The host exposes `GET /health`. Each module currently exposes one scaffold
endpoint that returns HTTP 501 until its use cases are implemented:

| Module | Placeholder endpoint |
| --- | --- |
| Identity | `GET /api/identity/_placeholder` |
| Academic | `GET /api/academic/_placeholder` |
| Attendance | `GET /api/attendance/_placeholder` |
| Examination | `GET /api/examination/_placeholder` |
| Discussion | `GET /api/discussion/_placeholder` |
| Notification | `GET /api/notifications/_placeholder` |
| Audit | `GET /api/audit/_placeholder` |
| Content | `GET /api/content/_placeholder` |

The Discussion SignalR hub is mapped at `/hubs/discussion`; its hub methods are
not implemented. Authentication, authorization, request contracts, and
versioning are not configured yet.
