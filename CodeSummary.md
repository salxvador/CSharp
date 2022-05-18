# Introduction
My final project with The Tech Academy was a 2-week sprint in which we worked on an ASP.NET web application for a theater company. This included creating a data model for the theater's members using enity framework, and the corresponding create, read, update, and delete controllers and views for managing data stored on MS SQL Server.
<br>
On the front end, I primarily used Bootstrap, custom CSS, and JavaScript to maintain a consistent color scheme and a visually pleasing look.

#### Technologies Used
* .NET Framework/ASP.NET MVC Web Application
* Entity Framework
* SQL Express
* Bootstrap
* JQUERY/JavaScript
* git
### Back End Stories
* **Entity model for Theater Members**

I created a data model for saving information about various theater members. This included an enumerated field for the member's role, and a byte array for storing an image for the member:
<br>
![image](https://user-images.githubusercontent.com/98099229/169091254-aef7a434-2144-4261-ae1b-e62051601d56.png)

* **Photo Storage and Retrieval**

Upon creating a new theater member entry, the user has the option to upload an image of the user:
<br>
![image](https://user-images.githubusercontent.com/98099229/169093469-4d1b84ad-0485-4373-b339-fe04ae7a569c.png)
<br>
I created a method to take the image as an HTTPPostedFileBase object, and covert it to a byte array using a binary reader:
<br>
![image](https://user-images.githubusercontent.com/98099229/169093922-2bab192e-3e0b-4a84-929d-700ba986fb12.png)
<br>
When the form is submitted, the ConvertFile() method is used to store the byte array in the Theater Members table using Entity Framework.
<br>
![image](https://user-images.githubusercontent.com/98099229/169095252-7ff242ac-3b55-4a95-9fff-0a0ac6e700e9.png)
<br>
On retrieval, the view uses Razor syntax to convert the byte array to a string, and read it into the browser.
<br>
![image](https://user-images.githubusercontent.com/98099229/169095787-ea73a5c1-9c33-4c05-bb57-252184b1c409.png)

* **Index page search feature**

The home page for the Theater Members area lists out all members with limited details. I implemented a feature that allows a user of the site to search for a member by name. All unmatched names are then hidden from the list. Index controller:
<br>
![image](https://user-images.githubusercontent.com/98099229/169096668-58ba44ca-3c55-4ded-a24b-9ff2905ea911.png)
![image](https://user-images.githubusercontent.com/98099229/169097120-cdbfd65d-b158-4cc5-a876-575b9d0f1570.png)

* **Restrict Access to Admin Members**

We needed to restrict access to the create, update, and delete functionality to admin members only. TO achieve this, I used the Authorize decorator over the Theater Members Controller, and specified that only the index page should [AllowAnonymous], as this page only offers read functionality.
<br>
![image](https://user-images.githubusercontent.com/98099229/169098160-5e913437-a69b-47d3-9cc2-9b9d485eeef7.png)
<br>
This means that if an unauthorized user attempts to create, edit, or delete a theater member entry, they will be prompted to log in, and their user's stored role must be 'Administrator'
![image](https://user-images.githubusercontent.com/98099229/169099263-578dd592-8475-4924-a43e-c459bd507578.png)

### Front End Stories
* **Add Developer Count to Sign In Page (JS)**
* **Page stylings -common color schemes**
* **Edit Page Photo retrieval and Image Upload Preview**
### Other Skills Learned
* Agile/Scrum Methodologies
* Visual Studio 2019
* FontAwesome Icons
