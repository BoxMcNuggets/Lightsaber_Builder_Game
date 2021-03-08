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
                
                LocationId = 2
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
                        Description = "Your ship is a Radiant VII"+
                        "It is a weaponless, workmanlike Cruiser ",
                        Accessible = true,
                        Message = "You have been tasked to build your own lightsaber, go from planet to planet to "+
                        "gain quests and get the parts you need to build your very own lightsaber"
                    }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 2,
                    Name = "Coruscant",
                    Description = "Coruscant is a city-covered planet with a population of one trillion beings." +
                    " Coruscant's surface was defined by its urban sprawl, which collectively was called Galactic City",
                    Accessible = false,
                    Message = "blah"
                }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 3,
                    Name = "Hoth",
                    Description = "Hoth is the sixth planet in the remote system of the same name, and was the site of the"+
                    " Rebel Alliance's Echo Base. It is a world of snow and ice, surrounded by numerous moons, and home to"+
                    " deadly creatures like the wampa.",
                    Accessible = true,
                    Message = "boo"
                }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 4,
                    Name = "Mustafar",
                    Description = "Once a garden world nourished by the Bright Star artifact, its orbit was shifted when "+
                    "Lady Corvax unleashed the energies of the Bright Star in an attempt to return her husband to life. "+
                    "The resulting gravimetric duel between the gas giants Jestefad and Lefrani over Mustafar heated the "+
                    "planet's core, transforming the lush world into an imbalanced volcanic hellscape.",
                    Accessible = true,
                    Message = "ree"
                }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 5,
                    Name = "Dagobah",
                    Description = "one of the purest places in the galaxy within the Force. A remote world of swamps and"+
                    " forests, it served as a refuge for Jedi Grand Master Yoda during his exile after the "+
                    "destruction of the Jedi Order.",
                    Accessible = true,
                    Message = "lmao"
                }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 6,
                    Name = "Mandalore",
                    Description = "It was the homeworld of the Mandalorians, a fearsome warrior people who fought the "+
                    "Jedi and raided their temple during the fall of the Old Republic. Years of war left the planet "+
                    "inhospitable, forcing the Mandalorians to live within domed cities. ",
                    Accessible = true,
                    Message = "lol"
                }
                );
            gamemap.Locations.Add
                (new Location()
                {
                    ID = 7,
                    Name = "Death Star",
                    Description = "The Death Star was the Empire's ultimate weapon: a moon-sized space station with "+
                    "the ability to destroy an entire planet.",
                    Accessible = false,
                    Message = "F"
                }
                );
            gamemap.Currentlocation = gamemap.Locations.FirstOrDefault(l => l.ID == 1);

            return gamemap;
        }
    }
}
