using System;

namespace prep.collections
{
	public class Movie
	{
		public string title { get; set; }
		public ProductionStudio production_studio { get; set; }
		public Genre genre { get; set; }
		public int rating { get; set; }
		public DateTime date_published { get; set; }


		public bool MovieTitleMatches(Movie movie)
		{
			if ((movie.title).Equals(title))
				return true;
			else
				return false;
		}
	}

}