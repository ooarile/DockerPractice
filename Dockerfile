# .NET SDK 이미지를 사용하여 애플리케이션을 빌드합니다.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# 작업 디렉토리를 설정합니다.
WORKDIR /app

# 프로젝트 파일을 복사하고 복원합니다.
COPY DockerTEST/DockerTEST.csproj ./
RUN dotnet restore

# 나머지 애플리케이션 코드를 복사합니다.
COPY . ./

# 애플리케이션을 빌드합니다.
RUN dotnet publish -c Release -o out

# 최종 이미지
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

# 애플리케이션을 실행하는 명령어
ENTRYPOINT ["dotnet", "DockerTEST.dll"]