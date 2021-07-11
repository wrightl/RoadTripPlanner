## Mongodb

-   To start mongodb as a service run `brew services start mongodb-community@4.4`

-   To stop mongodb run `brew services stop mongodb-community@4.4`

-   To check if mongodb is running `brew services list`

## Run UnitTest

Run `dotnet watch --project ./tests/RoadTripPlanner.UnitTests test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info`

Use 'Watch' option in statusbar to view code coverage in VS Code

<!-- ## Code Coverage

Make sure guid is right and run `reportgenerator "-reports:tests/RoadTripPlanner.UnitTests/TestResults/4f2de660-7c02-4eda-a0a6-4f6cfeb10673/coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html` -->

## To run the services

Run `dotnet watch --project ./src/RoadTripPlanner/RoadTripPlanner.csproj`

## To run the Angular app

Run:

-   cd `./src/RoadTripPlanner/ClientApp`
-   `npm start`

# Postman

## Using API's with Postman:

-   Login via the app
-   Use DevTools to get Authorisation token
-   Add 'Authorization' header key with the token (including the 'Bearer' prefix)

## Auth

To authorize api requests either manually add the 'Authorization' header key with a bearer token (preferably using a collection-based variable), or set the collection to use 'Bearer Token' Authorization and enter the token (without the 'Bearer' prefix).

Always remember to update the value before any new session though

\*\*\* I'm currently using a collection variable because eventually there'll be more variables so this keeps them in one place
