﻿namespace Netflix_Clone.Data.DTOs
{
    public class TMDBMovieDto
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
        public string Release_Date { get; set; }
        public float Vote_Average { get; set; }
    }
}
