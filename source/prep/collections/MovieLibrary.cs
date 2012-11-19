using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
    	foreach (var movie in movies)
    	{
    		yield return movie;
    	}
    }

    public void add(Movie movie)
    { //should have movie class decide if titles are equal so that if it changes, then MovieLibray would not be affected
		bool movieFound = false;

		foreach (var movie1 in movies)
		{
			if (movie1.title == movie.title)
			{
				movieFound = true;
				break;
			}
		}

		if (!movieFound)
		{
			movies.Add(movie);
		}		
	}

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
    	var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
		    if(movie.production_studio == ProductionStudio.Pixar)
		    {
				movieList.Add(movie);
		    }
		}

		return movieList;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.production_studio == ProductionStudio.Pixar || movie.production_studio == ProductionStudio.Disney)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

	  

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.production_studio != ProductionStudio.Pixar)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.date_published.Year > year)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

    public IEnumerable<Movie> all_kid_movies()
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.genre == Genre.kids)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

    public IEnumerable<Movie> all_action_movies()
    {
		var movieList = new List<Movie>();

		foreach (var movie in movies)
		{
			if (movie.genre == Genre.action)
			{
				movieList.Add(movie);
			}
		}

		return movieList;
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}