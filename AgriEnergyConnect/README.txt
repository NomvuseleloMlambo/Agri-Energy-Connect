ST10264503

Github repo link: https://github.com/NomvuseleloMlambo/Agri-Energy-Connect.git

Tools used
DB Browser SQLite


1. Download/Open the project, update database then run the application

2. On visual studio press the green start button to run the project

3. On the first page select a role from the drop down.

4. Employee
   Are able to register themselves via the register page (first time only).
   Can then login using their credentials.
   Can access the employee dashboard which allows the to:
       Add a new farmer (create a farmer account).
       View all products submitted by all farmers.
       Can also filter the products by date, category, or farmer username.
       
5. Farmer
   Are added by employees and can managed their own products.
   They log in using credentials provided by the employee
   Can access the farmer dashboard which allows them to:
       Add a new product with a name, category, production date, and image.
       View their own products
       access the sustainable farming hub
       can join the discussion forum where they can create and view posts.

6. Discussion forum 
   Accessible only to logged in farmers
   Users can:
      View all forum posts
      Start a new discusion, adds a title and a message.
      Can view who posted and when.
   It is accessible through the farmer dashboard and the sustainable farming hub

7. Sustainable farming hub
   Contains conent with the best farming practices 
   Button to access the forum where farmers can interact

The system uses a single database for all data
Uploaded images are stored in the /wwroot/uploads folder
Role-based access ensures users only see the pages relevant to them.

Sample usage guide: 
Register a new employee
Log in as the employee and add a new farmer.
Go back, and log in as the farmer using the credentials created.
Add a new product, view it under View My Products.
Navigate to the forum, create and view posts.
Log back in as the employee to View All Products and applu filters.

Sample data you can use:

username: Employee1
password: Emp@123

username: Farmer1
password: Farm@123

username: Farmer2
password: Farm@124

   



