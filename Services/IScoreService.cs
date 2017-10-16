using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public interface IScoreService
    {
        Task<List<ScoreTable>> Get();
        Task<List<ScoreTable>> GetByID(int id);
        Task Post(ScoreTable item);
    }
}