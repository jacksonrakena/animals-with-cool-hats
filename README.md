# animalswithcoolhats.com

Animals With Cool Hats is your number #1 stop for pictures of animals wearing cool hats on the internet.
  
  
Come stop by at [animalswithcoolhats.com](https://animalswithcoolhats.com)!


### Infrastructure
`Awch.Site` is an ASP.NET 6 site serving Razor pages with image URLs stored in a Postgres database.  
The default connection string is `Host=localhost;Username=awch;Password=awch;Database=awch` (edited in `appsettings.json`).

You can sync your database with the AWCH schema by running `dotnet ef database update`.

From then on you can run with `dotnet run -c Release`, or `dotnet publish -c Release -o /srv/awch && dotnet /srv/awch/Awch.Site.dll`.

### Interactivity
<img width="600" alt="image" src="https://user-images.githubusercontent.com/44521335/160269018-cf5b6c33-ca76-4ff7-b175-d5e885792900.png" />
  
You can add new images to the database by navigating to `<url>/Admin`, which will ask you to log in.    
Currently there's no way to register new users (we don't want to provide access to users, only administrators), but CLI support is coming soon.

### Copyright & Acknowledgements
Animals With Cool Hats is powered by ASP.NET, Cloudflare, [Core Admin](https://github.com/edandersen/core-admin), cat pics on the internet, and a lot of love.  
This repository is &copy; 2022 Jackson Rakena under the MIT License.  
All images are copyright of their respective owners. This repository does not contain any copyrighted image files.
