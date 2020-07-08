git pull;
rm -rf .PublishFiles;
dotnet build;
dotnet publish -o /home/NQI_LIMS/NQI_LIMS.Api/bin/Debug/netcoreapp3.1;
cp -r /home/NQI_LIMS/NQI_LIMS.Api/bin/Debug/netcoreapp3.1 .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";