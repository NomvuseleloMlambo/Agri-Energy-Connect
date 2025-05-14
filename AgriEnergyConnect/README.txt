ST10264503 - Nomvuselelo Akhona Mlambo

Github repo link: https://github.com/NomvuseleloMlambo/Agri-Energy-Connect.git

Tools used
DB Browser SQLite


1. Download/Open the project, build the project (Build > Build Solution).

2. Update database (Tools > NuGet Package Manager > Package Manager Console)
   in the cconsole run the following: Update-Database

3. Run application by pressing the green start button. 

4. On the first page select a role from the drop down.

5. Employee
   Are able to register themselves via the register page (first time only).
   Can then login using their credentials.
   Can access the employee dashboard which allows the to:
       Add a new farmer (create a farmer account).
       View all products submitted by all farmers.
       Can also filter the products by date, category, or farmer username.
       
6. Farmer
   Are added by employees and can managed their own products.
   They log in using credentials provided by the employee
   Can access the farmer dashboard which allows them to:
       Add a new product with a name, category, production date, and image.
       View their own products
       access the sustainable farming hub
       can join the discussion forum where they can create and view posts.

7. Discussion forum 
   Accessible only to logged in farmers
   Users can:
      View all forum posts
      Start a new discusion, adds a title and a message.
      Can view who posted and when.
   It is accessible through the farmer dashboard and the sustainable farming hub

8. Sustainable farming hub
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


References:
EDB. (2024). Beautiful view green farm field. [electronic print]. Available at: https://www.lifeinsuranceinternational.com/news/landus-health-coverage-farmers/ [Accessed 08 May 2025]. 
Stackoverflow. (2017). Can't add Migration in Visual Studio for entityFrameworkcore [Online]. Available at: https://stackoverflow.com/questions/45187224/cant-add-migration-in-visual-studio-code-for-entityframeworkcore [Accessed 12 May 2025].
Seedterra. ([s.a.]). Spinach Bloomsdale Non GMO seeds - Spinach Oleracea. [electronic print]. Available at: https://seedterra.com/malabar-spinach-red-stem-non-gmo-seeds---basella-rubra/ [Accessed 13 May 2025].
Fresh California Fruit. ([s.a.]). Yellow Peaches. [electronic print]. Available at: https://www.freshcaliforniafruit.com/shop-online/peaches/yellow-peaches/organic-yellow-clingstone-peaches/ [Accessed 13 May 2025].
iStock. (2016). Corn in Burlap bag isolated on white. [electronic print]. Available at: https://www.istockphoto.com/es/foto/ma%C3%ADz-en-bolsa-de-arpillera-aislado-sobre-blanco-gm589938508-101311779 []Accessed 13 May 2025 .
OpenAI (2025). ChatGPT explained how to link project to database. [App]. Available at: https://chatgpt.com/ [Accessed 12 May 2025]
OpenAI (2025). ChatGPT explained link views to other views. [App]. Available at: https://chatgpt.com/ [Accessed 12 May 2025]
   



