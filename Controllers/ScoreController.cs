using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [Route("api/[controller]")]
    public class ScoreController : Controller
    {
        private IScoreService _scoreService;

        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpGet]
        //[Route("user/all")]
        public Task<List<ScoreTable>> GetAll()
        {
            return _scoreService.Get();
        }

        [HttpGet("{id}")]
        public Task<List<ScoreTable>> GetID(int id)
        {
            return _scoreService.GetByID(id);
        }

        [HttpPost]
        //[Route("user/add")]
        public void PostNew([FromBody] ScoreTable item)
        {
            _scoreService.Post(item);
        }

    }
}