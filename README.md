# ASP.NET_Fantasy

1. ## Clone the repository.
2. ## Set up the database
    Current config searches for a database with the name Fantasy. If you change the DB Name, be sure to update this in the appsettings.json. 
    Code first entity framework was used. Run a database migratition to create the database and schema from the FantasyData project where all business modesl are. 
    For sample data, execute the sql_scripts/player_data_insert_script.sql . Current codebase is only utilizing the player table. 
   
3. ## Import the project and launch. 
   The existing WebApplication solution file should contain everything needed. If there are any issues, just import the 3 projects and set the models and services as dependencies on the webapp.
   Launch in IIS and your favorite browser. 
   Currently implemented the Players controller. Please select Players at the top of the website to see a basic table of available players and salaries. Implemented an additional detail view that can be accessed by clicking on a player image. 
   The additional detail pane was supposed to call a twitter API to search, however twitter has yet to approve me for a developer account as I need the app to be launched on a website. Willing to implement any other API here on request.
   
### Notes:
  - Just a basic view app that shows the standard structure of .NET MVC app. I **"borrowed"** the opendorse site main image to give homepage some color outside of the standard Microsoft templates.
  - Boilerplate CSS was used with some basic bootstrap. 
  - If you would like anything implemented, like actual lineup construction, let me know. Please reach out any questions, etc. 
