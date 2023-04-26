using CW.Models;

namespace CW.Controllers.Data
{
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cars
                if(!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<CarsModel>()
                    {
                        new CarsModel()
                        {
                            Model = "Camaro",
                            Picture = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.dreamstime.com%2Fphotos-images%2Fchevrolet-camaro.html&psig=AOvVaw3cJdVUpoaSXyrAMzovtFuB&ust=1682572959752000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCKD7uO7mxv4CFQAAAAAdAAAAABAE",
                            Condition = "good",
                            Availability = "yes",
                            RentPrice = 12000
                        },
                        new CarsModel()
                        {
                            Model = "Mustang",
                            Picture = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFord_Mustang&psig=AOvVaw2lT1FZEUvXdTqXj54A5bC-&ust=1682573075410000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCMifxqXnxv4CFQAAAAAdAAAAABAE",
                            Condition = "good",
                            Availability = "yes",
                            RentPrice = 15000
                        },
                        new CarsModel()
                        {
                            Model = "Gt-R",
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCF6I7qJ2l75x1MG9z5oDIc6qV5wrUEIvAZWNsoSCROQ&s",
                            Condition = "good",
                            Availability = "yes",
                            RentPrice = 200000
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
