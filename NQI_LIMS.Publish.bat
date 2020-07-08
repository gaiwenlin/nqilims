color B

del  .PublishFiles\*.*   /s /q

dotnet restore

dotnet build

cd NQI_LIMS.Api

dotnet publish -o ..\NQI_LIMS.Api\bin\Debug\netcoreapp3.1\

md ..\.PublishFiles

xcopy ..\NQI_LIMS.Api\bin\Debug\netcoreapp3.1\*.* ..\.PublishFiles\ /s /e 

echo "Successfully!!!! ^ please see the file .PublishFiles"

cmd