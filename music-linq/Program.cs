using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist newL = Artists.Where( s => s.Hometown == "Mount Vernon").Single();
            Console.WriteLine($"{newL.ArtistName} from Mt. Vernon is {newL.Age}");

            //Who is the youngest artist in our collection of artists?
            Artist young = Artists.OrderBy(a => a.Age).First();
            Console.WriteLine($"{young.ArtistName} is the youngest");

            //Display all artists with 'William' somewhere in their real name
            List<Artist> williams = Artists.Where( w => w.RealName.Contains("William")).ToList();
            foreach(Artist w in williams){
                Console.WriteLine($"{w.RealName}");
            }
            //Display groups with names less than 8 characters in length
            List<Group> shorty = Groups.Where( n => n.GroupName.Length < 8).ToList();
            foreach(Group p in shorty){
                Console.WriteLine($"{p.GroupName}");
            }
            //Display the 3 oldest artist from Atlanta
            List<Artist> atl = Artists.Where( x => x.Hometown == "Atlanta").OrderByDescending(y => y.Age).ToList();
            for(int i = 0; i < 3; i++){
                Console.WriteLine($"{atl[i].RealName} is {atl[i].Age}");
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            List<Artist> notNY = Artists.Where( z => z.Hometown != "New York City").ToList();
            List<string> combo = notNY.Join(Groups, Art => Art.GroupId, Grou => Grou.Id, (Art, Grou)=> { Art.Group = Grou; return Art; }).Select(artist => artist.Group.GroupName).Distinct().ToList();
            
            foreach(string v in combo){
            Console.WriteLine($"{v}");
            }
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group WuTang = Groups.Where(group => group.GroupName == "Wu-Tang Clan")
            .GroupJoin(Artists, 
            group => group.Id,
            artist => artist.GroupId,
            (group, artists) => { group.Members = artists.ToList(); return group;})
            .Single();
            Console.WriteLine("List of Artist in the Wu-Tang Clan:");
            foreach(var artist in WuTang.Members){
            Console.WriteLine(artist.ArtistName);
        }
    }
}
}
