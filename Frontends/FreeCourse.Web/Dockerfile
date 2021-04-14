FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/FreeCourse.Shared/*.csproj Shared/FreeCourse.Shared/
COPY Frontends/FreeCourse.Web/*.csproj Frontends/FreeCourse.Web/
RUN dotnet restore Frontends/FreeCourse.Web/*.csproj
COPY . .
RUN dotnet publish Frontends/FreeCourse.Web/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCourse.Web.dll" ]




