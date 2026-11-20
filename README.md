# PRC 11 - Smart Campus Service Portal (Feature Extension)

**Subject:** .NET Technologies (01CE1523) - Marwadi University, Department of Computer Engineering
**Name:** Rohan Zinzuvadiya
**Enrollment No:** 92400103411
**Lab Batch:** B

## Aim
Develop Smart Campus Service Portal - Feature Extension (Integrate MVC + Database + API).

## What it does
- **MVC:** dashboard, request list with status filter, raise-request form with validation, update status, delete.
- **Database:** SQLite through Entity Framework Core. The file `smartcampus.db` is created automatically on first run with 4 sample requests.
- **REST API:** `/api/requests` works on the same database.

## How to run
1. Open `PRC11_SmartCampusServicePortal.csproj` in Visual Studio 2022 (.NET 8 SDK, internet needed once to restore the EF Core package).
2. Press F5. The portal opens at `https://localhost:7220`.

## API endpoints
| Method | URL | Result |
|---|---|---|
| GET | /api/requests | all requests (optional `?status=Pending`) |
| GET | /api/requests/{id} | one request or 404 |
| POST | /api/requests | 201 Created, or 400 if invalid |
| PUT | /api/requests/{id}/status | body `{ "status": "Completed" }` |
| DELETE | /api/requests/{id} | 204 No Content |
