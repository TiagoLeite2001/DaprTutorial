# DaprTutorial
DaprTutorial


API Service
```bash
dapr run --app-id weatherapi --app-port 5001 --dapr-http-port 50001 dotnet run
```

MVC Service
```bash
dapr run --app-id frontend --app-port 5002 --dapr-http-port 50002 dotnet run
```

