Getting Started
Follow these steps to set up the project:

Clone the repository:

bash
Copy code
git clone https://github.com/aminsh1063/TennisCourtBookingAPI.git
Open the project in your code editor.

Update the appsettings.json file:

Set the database connection string under "ConnectionStrings" to point to your MySQL database.
Configure the "JwtSettings" section with your JWT token settings.
Install required packages:

Copy code
dotnet restore
Apply database migrations to create the schema:

bash
Copy code
dotnet ef database update
Running the API
To run the API locally, use the following command:

bash
Copy code
dotnet run
The API will start and be accessible at https://localhost:5001.

API Endpoints
Here are the main endpoints provided by the API:

User Authentication:

POST /api/users/register - Register a new user.
POST /api/users/login - Authenticate and log in a user.
Tennis Courts:

GET /api/tennis-courts - Get a list of all tennis courts.
POST /api/tennis-courts - Create a new tennis court.
PUT /api/tennis-courts/{id} - Update an existing tennis court.
DELETE /api/tennis-courts/{id} - Delete a tennis court.
Bookings:

POST /api/bookings/make - Make a booking.
GET /api/bookings - Get a list of all bookings.
PUT /api/bookings/{id} - Update an existing booking.
DELETE /api/bookings/{id} - Cancel a booking.
Testing
To test the API, you can use tools like Postman or the API documentation (if available) to make requests to the endpoints.
