using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proiect_licenta.Entities.TvShows
{
    public class TvShow
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
        public string ReleaseDate { get; set; }
        public string RuntimeMins { get; set; }
        public string RuntimeStr { get; set; }
        public string Plot { get; set; }
        public string PlotLocal { get; set; }
        public bool PlotLocalIsRtl { get; set; }
        public string Awards { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }
        public string Stars { get; set; }
        public List<TvShowStarList> StarList { get; set; }
        public List<TvShowActorList> ActorList { get; set; }
        public string Genres { get; set; }
        public List<TvShowGenreList> GenreList { get; set; }
        public string Companies { get; set; }
        public List<TvShowCompanyList> CompanyList { get; set; }
        public string Countries { get; set; }
        public List<TvShowCountryList> CountryList { get; set; }
        public string Languages { get; set; }
        public List<TvShowLanguageList> LanguageList { get; set; }
        public string ContentRating { get; set; }
        public string ImDbRating { get; set; }
        public string ImDbRatingVotes { get; set; }
#nullable enable
        public string? MetacriticRating { get; set; }
#nullable disable
        public TvShowRatings Ratings { get; set; }
        public TvShowWikipedia Wikipedia { get; set; }
        public TvShowImages Images { get; set; }
        public TvShowTrailer Trailer { get; set; }
        public TvShowBoxOffice BoxOffice { get; set; }
        public string Keywords { get; set; }
        public List<TvShowSimilar> Similars { get; set; }
        public TvSeriesInfo TvSeriesInfo { get; set; }
        public IList<AppUserTvShowItem> AppUserTvShow { get; set; }
    }
}
