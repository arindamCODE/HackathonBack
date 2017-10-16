using System;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ScoreService : IScoreService
    {
        private HackathonContext _context;

        public ScoreService(HackathonContext context)
        {
            _context = context;
        }

        public async Task<List<ScoreTable>> Get()
        {
            return await _context.ScoreTable.ToListAsync();
        }

        public async Task<List<ScoreTable>> GetByID(int id)
        {
            //var objectNews = _context.News.Where(p => p.Source.ToUpper().Contains(source.ToUpper()));
            //News objectNews = _context.News.Where(p => p.Source.ToUpper().Contains(source.ToUpper()));
            ScoreTable objectScore = await _context.ScoreTable.FirstOrDefaultAsync(pi => pi.ID == id);
            List<ScoreTable> product = new List<ScoreTable>();
            try
            {
                product.Add(objectScore);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public async Task Post(ScoreTable item)
        {
            try
            {
                _context.ScoreTable.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}