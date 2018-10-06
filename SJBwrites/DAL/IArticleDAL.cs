using SJBwrites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SJBwrites.DAL
{
    public interface IArticleDAL
    {
        Tuple<List<Review>, List<Preview>, List<Feature>> ShowPortfolio();
    }
}
