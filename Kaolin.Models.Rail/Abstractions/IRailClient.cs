﻿using System.Threading.Tasks;
using Kaolin.Infrastructure.SessionStore;

namespace Kaolin.Models.Rail.Abstractions
{
    public interface IRailClient
    {
        Task<SearchTrains.Result> SearchTrainsAsync(ISessionStore session, SearchTrains.Request request);
        Task<GetTrain.Result> GetTrainAsync(ISessionStore session, GetTrain.Request request);
    }
}
