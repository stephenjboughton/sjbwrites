using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SJBwrites.Models;

namespace SJBwrites.DAL
{
    public class ArticleDAL : IArticleDAL
    {
        private string connectionString;

        public ArticleDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Tuple<List<Review>, List<Preview>, List<Feature>> ShowPortfolio()
        {
            List<Review> reviews = new List<Review>();
            List<Preview> previews = new List<Preview>();
            List<Feature> features = new List<Feature>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = $"SELECT * FROM articles";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string currentStoryType = Convert.ToString(reader["storyType"]);

                        if (currentStoryType == "review")
                        {
                            Review review = new Review();
                            review.ArtistName = Convert.ToString(reader["artistName"]);
                            review.StoryType = Convert.ToString(reader["storyType"]);
                            review.PublishDate = Convert.ToDateTime(reader["publishDate"]);
                            review.Title = Convert.ToString(reader["title"]);
                            review.Label = Convert.ToString(reader["label"]);
                            review.Url = Convert.ToString(reader["url"]);
                            review.Image = Convert.ToString(reader["image"]);
                            review.StoryBody = ellipsify(Convert.ToString(reader["StoryBody"]));
                            reviews.Add(review);
                        }

                        if (currentStoryType == "preview")
                        {
                            Preview preview = new Preview();
                            preview.ArtistName = Convert.ToString(reader["artistName"]);
                            preview.StoryType = Convert.ToString(reader["storyType"]);
                            preview.PublishDate = Convert.ToDateTime(reader["publishDate"]);
                            preview.ConcertInfo = Convert.ToString(reader["concertInfo"]);
                            preview.Url = Convert.ToString(reader["url"]);
                            preview.Image = Convert.ToString(reader["image"]);
                            preview.StoryBody = ellipsify(Convert.ToString(reader["StoryBody"]));

                            previews.Add(preview);
                        }

                        if (currentStoryType == "feature")
                        {
                            Feature feature = new Feature();
                            feature.ArtistName = Convert.ToString(reader["artistName"]);
                            feature.StoryType = Convert.ToString(reader["storyType"]);
                            feature.PublishDate = Convert.ToDateTime(reader["publishDate"]);
                            feature.Head = Convert.ToString(reader["head"]);
                            feature.Deck = Convert.ToString(reader["deck"]);
                            feature.ConcertInfo = Convert.ToString(reader["concertInfo"]);
                            feature.Url = Convert.ToString(reader["url"]);
                            feature.Image = Convert.ToString(reader["image"]);
                            feature.StoryBody = ellipsify(Convert.ToString(reader["StoryBody"]));

                            features.Add(feature);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            var portfolio = Tuple.Create(reviews, previews, features);
            return portfolio;
        }

        public string ellipsify(string description)
        {
            return description.Substring(0, 150) + " . . . ";
        }
    }
}
