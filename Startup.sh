#!/bin/bash
ROOTDIRECTORY=$(cd -P -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd -P)
cd "$ROOTDIRECTORY"/InternalMarksCGPACalculatorApp.Models
echo "The current directory is : Expecting Model folder"
pwd
echo Mahat@123# | sudo -S  dotnet build
cd "$ROOTDIRECTORY"/InternalMarksCGPACalculatorApp.DAL
echo "The current directory is : Expecting DAL folder"
pwd
echo Mahat@123# | sudo -S  dotnet build
cd "$ROOTDIRECTORY"/
echo Mahat@123# | sudo -S  rm -f "$ROOTDIRECTORY"/InternalMarksCGPACalculatorApp.sln
echo Mahat@123# | sudo -S  dotnet new sln --name InternalMarksCGPACalculatorApp
echo Mahat@123# | sudo -S  dotnet sln add "$ROOTDIRECTORY"/InternalMarksCGPACalculatorApp.Models/InternalMarksCGPACalculatorApp.Models.csproj
echo Mahat@123# | sudo -S  dotnet sln add "$ROOTDIRECTORY"/InternalMarksCGPACalculatorApp.DAL/InternalMarksCGPACalculatorApp.DAL.csproj



                    cd "$ROOTDIRECTORY"/InternalMarksCGPACalculatorAppWebApi
                    echo Mahat@123# | sudo -S  dotnet build
                    echo Mahat@123# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/WebApi
cd "$ROOTDIRECTORY"
                cd "$ROOTDIRECTORY"/Admin
                echo Mahat@123# | sudo -S  dotnet build
                echo Mahat@123# | sudo -S  dotnet publish -o "$ROOTDIRECTORY"/Publish/Admin
                echo Mahat@123# | sudo -S  mkdir "$ROOTDIRECTORY"/Publish/Admin/wwwroot/uploads
                echo Mahat@123# | sudo -S  cp /home/ubuntu/Automaton/AutomatonClient/wwwroot/BackupFiles/InternalMarksCGPACalculatorApp/AdminUploads/*.* "$ROOTDIRECTORY"/Publish/Admin/wwwroot/uploads


echo "Setting up the Publish Evnrionment"
                        cd /home/ubuntu/Automaton/AutomatonClient/wwwroot/PublishedFiles
                        echo Mahat@123# | sudo -S  chown -R ubuntu InternalMarksCGPACalculatorApp
                        cd "$ROOTDIRECTORY"
                        echo Mahat@123# | sudo -S  rm -f /etc/nginx/sites-enabled/mauser-137
                        echo Mahat@123# | sudo -S  rm -f /etc/supervisor/conf.d/InternalMarksCGPACalculatorAppWebApi.conf
                        echo Mahat@123# | sudo -S  rm -f /etc/supervisor/conf.d/InternalMarksCGPACalculatorAppClient.conf
                        echo Mahat@123# | sudo -S  rm -f /etc/supervisor/conf.d/InternalMarksCGPACalculatorAppAdmin.conf
                        echo Mahat@123# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/*.conf /etc/supervisor/conf.d/
                        echo Mahat@123# | sudo -S  cp "$ROOTDIRECTORY"/PublishRequisites/mauser-137 /etc/nginx/sites-enabled/
                        echo Mahat@123# | sudo -S  supervisorctl reread
                        echo Mahat@123# | sudo -S  supervisorctl update
                        echo Mahat@123# | sudo -S  supervisorctl restart InternalMarksCGPACalculatorAppWebApi
                        echo Mahat@123# | sudo -S  supervisorctl restart InternalMarksCGPACalculatorAppClient
                        echo Mahat@123# | sudo -S  supervisorctl restart InternalMarksCGPACalculatorAppAdmin 
                        echo Mahat@123# | sudo -S  service nginx reload
curl -v --header "Connection: keep-alive" "http://localhost:5011/ContactUs/sentPublishedNotification?projectid=63edb2d4-f311-4884-bfe1-c71a237d772b"
sudo -s /home/ubuntu/Automaton/AutomatonClient/wwwroot/git.sh InternalMarksCGPACalculatorApp "2026-07-31 12:12" https://mauser-137:@devgit.craftmyapp.in/mauser-137/InternalMarksCGPACalculatorApp mauser-137 

