FROM swr.cn-south-1.myhuaweicloud.com/mcr/aspnet:3.1-alpine
WORKDIR /app
COPY . . 
EXPOSE 8081 
ENTRYPOINT ["dotnet", "NQI_LIMS.Api.dll","-b","0.0.0.0"]