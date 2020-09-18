# mini-carsales

## Summary
The VehicleManagementSystem is build to support internal users to add new vehicles and view current vehicles with the APP.

It contains a RESTful WebApi writen in .NET Core, as well as a React frontend. This project is built with Minimum Viable Product concept in mind, but I added an additional feature to view all the vehicles that has been created, in order to easily verify the car creation feature.

## how to run
1. You will need .NET CORE 2.1+, and node environment installed on your machine to be able to run the app.
2. Backend directory is /Carsales.VehicleManagementSystem  (navigate to the API project directory first).  
    Run WebApi via visual studio or in command line, run `dotnet run`
3. The API will be hosted on http://localhost:5000. Endpoints are:  
  3.1 [get] localhost:5000/api/, 
  3.2 [post] localhost:5000/api/vehicle/car, provide CAR data as JSON in body
4. front end diretory is carsales-vms-frontend
   Navigate to the directory, in terminal, run `npm start`, if the website are not loaded automatically, go to browser and open http://localhost:3000
