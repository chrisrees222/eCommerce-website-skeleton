# eCommerce-website-skeleton

A file for ecommerce web app for moovies, cinemas, actors and producers which was created with visual studio and by instruction of a Udemy course "Learn to build fast and secure eCommerce application with ASP.NET MVC and Entity Framework Core".

To recreate, clone the repository, within visual studio create a local server and copy the data source. 
In the appssettings.json file, add the following and replace astericks with your datasource 
"ConnectionStrings": {
  "DefaultconnectionString": "Data Source=(localdb)\\****************************************************************************************"
}, 

in package manager, carry out following
Add-Migrations initial
update-database

then run the app (CTRl F5)
