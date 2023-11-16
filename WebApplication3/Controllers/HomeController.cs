using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private static string _generateDesc() => new string (Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz", 20)
                                      .Select(s => s[new Random().Next(s.Length)]).ToArray());

        [Route("/")]
        public IActionResult Index()
        {

            return View(getDummyDatas());
        }



        private Dictionary<string, dynamic> getDummyDatas()
        {
            return new Dictionary<string, dynamic>() {

                {
                    
                    "blogs", 
                    
                    new List<Blog>(){

                        new Blog(

                                title: "Nice Blog 1",
                                description: HomeController._generateDesc(),
                                authorName: "Author1",
                                image: "https://random.imagecdn.app/500/500"
                                ),


                         new Blog(

                                title: "Nice Blog 2",
                                description: HomeController._generateDesc(),
                                authorName: "Author2",
                                image: "https://random.imagecdn.app/500/500"
                                ),

                          new Blog(

                                title: "Nice Blog 3",
                                description: HomeController._generateDesc(),
                                authorName: "Author3",
                                image: "https://random.imagecdn.app/500/500"
                                ),


                    } 
                
                
                },


                {


                   "features",
                   
                   new List<Feature>(){
                   
                   
                            new Feature(
                                
                                
                                    name: "My Feature1",
                                    desc: HomeController._generateDesc()

                                ),


                             new Feature(


                                    name: "My Feature2",
                                    desc: HomeController._generateDesc()

                                ),

                              new Feature(


                                    name: "My Feature3",
                                    desc: HomeController._generateDesc()

                                ),


                               new Feature(


                                    name: "Feature4",
                                    desc: HomeController._generateDesc()

                                ),



                   }
                
                
                
                }
                    
            
            };
           
        }

        

    }
}
