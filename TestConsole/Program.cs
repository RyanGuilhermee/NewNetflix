using Application.Services;
using Domain.Models;

MovieService service = new MovieService(); 
Movie movie = new Movie()
{ MvId = 11, MvTitle = "Matrix Ressurection", MvDate = "2021-12-17", MvImg = @"https://someimg.png", MvDuration = 130, GrId = 1 };

//int id = service.AddUpdateMovie(movie);

//Movie movieData = service.GetMovie(14);

/*foreach (movieData in service.GetAllMovies())
{
    Console.WriteLine(movieData.MvTitle);
    Console.WriteLine(movieData.MvDate);
    Console.WriteLine(movieData.MvDuration);
    Console.WriteLine(movieData.MvImg);
    Console.WriteLine();
}*/

//service.Delete(14);

//Console.WriteLine(id);

/*Console.WriteLine(movieData.MvTitle);
Console.WriteLine(movieData.MvDate);
Console.WriteLine(movieData.MvDuration);
Console.WriteLine(movieData.MvImg);*/
