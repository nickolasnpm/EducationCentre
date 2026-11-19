# EducationCentre

One repository, three independently deployable apps.

| Folder | What | Dev URL |
|---|---|---|
| [EducationCentre/](./EducationCentre) | .NET 10 modular-monolith API (8 modules, Scalar docs at `/scalar/v1`) | http://localhost:5042 |
| [FrontendAngular/](./FrontendAngular) | Angular frontend | http://localhost:4200 |
| [FrontendReact/](./FrontendReact) | React + Vite frontend | http://localhost:5173 |

Both frontends talk to the API over HTTP only. CORS origins are configured in `Cors:AllowedOrigins`.

## Run

```bash
# Backend
cd EducationCentre && dotnet run --project src/Host/EducationCentre.Api --launch-profile http

# Angular
cd FrontendAngular && npm install && npm start

# React
cd FrontendReact && npm install && npm run dev
```

## Deploy separately

Each app builds from its own folder, so they can be deployed independently:

- Backend: `dotnet publish EducationCentre/src/Host/EducationCentre.Api -c Release`
- Angular: `npm run build` in `FrontendAngular/`
- React: `npm run build` in `FrontendReact/`

Each folder has its own `.gitignore`. Self-hosted infrastructure (PostgreSQL, RabbitMQ, Kafka, Elasticsearch, object storage) is defined in `EducationCentre/infra/docker-compose.yml`.
