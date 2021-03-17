using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lightsaber_Builder_Game.Models;

namespace Lightsaber_Builder_Game.DataLayer
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Luke",
                Age = 23,
                JobTitle = Player.ForceSide.LightSide,
                Race = Character.RaceType.Human,
                Health = 100,
                Lives = 3,
            };
        }
        public static Map GameMap() 
        {
            Map gamemap = new Map();

            gamemap.Locations.Add
                (new Location() 
                    {
                        ID = 1,
                        Name = "Ship",
                        PlanetColor = "gray",
                        Description = "Your ship is a Radiant VII"+
                        "It is a weaponless, workmanlike Cruiser ",
                        Accessible = true,
                        Message = "Welcome to your ship, From your ship you can travel to other places. Dont forget "+
                        "to grab your Blaster"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 2,
                        Name = "Coruscant",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/Coruscant.jpg",
                        Description = "Coruscant is a city-covered planet with a population of one trillion beings." +
                        " Coruscant's surface was defined by its urban sprawl, which collectively was called Galactic City",
                        Accessible = true,
                        Message = "The city covered planet, It might be usefull to do some shopping while your here"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 3,
                        Name = "Hoth",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/Hoth.png",
                        Description = "Hoth is the sixth planet in the remote system of the same name, and was the site of the"+
                        " Rebel Alliance's Echo Base. It is a world of snow and ice, surrounded by numerous moons, and home to"+
                        " deadly creatures like the wampa.",
                        Accessible = true,
                        Message = "Make sure you have your warm clothes on and don't be out at night"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 4,
                        Name = "Mustafar",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/mustafar.jpg",
                        Description = "Once a garden world nourished by the Bright Star artifact, its orbit was shifted when "+
                        "Lady Corvax unleashed the energies of the Bright Star in an attempt to return her husband to life. "+
                        "The resulting gravimetric duel between the gas giants Jestefad and Lefrani over Mustafar heated the "+
                        "planet's core, transforming the lush world into an imbalanced volcanic hellscape.",
                        Accessible = true,
                        Message = "Welcome to Mustafar, Once a garden world nourished by the Bright Star artifact, its orbit"+
                        " was shifted when Lady Corvax unleashed the energies of the Bright Star in an attempt to return her"+
                        " husband to life. The resulting gravimetric duel between the gas giants Jestefad and Lefrani over "+
                        "Mustafar heated the planet's core, transforming the lush world into an imbalanced volcanic hellscape."
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 5,
                        Name = "Dagobah",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/Dagobah.jpg",
                        Description = "one of the purest places in the galaxy within the Force. A remote world of swamps and"+
                        " forests, it served as a refuge for Jedi Grand Master Yoda during his exile after the "+
                        "destruction of the Jedi Order.",
                        Accessible = true,
                        Message = "Welcome to Dagobah, If your lucky you may see jedi master Yoda"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 6,
                        Name = "Mandalore",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/Mandalore.png",
                        Description = "It was the homeworld of the Mandalorians, a fearsome warrior people who fought the "+
                        "Jedi and raided their temple during the fall of the Old Republic. Years of war left the planet "+
                        "inhospitable, forcing the Mandalorians to live within domed cities. ",
                        Accessible = true,
                        Message = "Watch your back around here, the mandalorians are known as a peaceful race now but they"+
                        " used to be the most fearsome race in the galaxy"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                    {
                        ID = 7,
                        Name = "Death Star",
                        PlanetColor = "/Lightsaber_Builder_Game;component/Graphics/DeathStar.png",
                        Description = "The Death Star was the Empire's ultimate weapon: a moon-sized space station with "+
                        "the ability to destroy an entire planet.",
                        Accessible = true,
                        Message = "This is the Death Star, here you can find the dark lords Darth Sidious and Darth Vader"
                    }
                );
            gamemap.Currentlocation = gamemap.Locations.FirstOrDefault(l => l.ID == 1);

            return gamemap;
        }
    }
}
