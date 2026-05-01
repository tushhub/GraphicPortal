using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using PortfolioApp.Models;

namespace PortfolioApp.Data
{
    public class ProjectRepository
    {
        private readonly string _dataPath;

        public ProjectRepository(string dataPath)
        {
            _dataPath = dataPath;
        }

        public List<Project> GetAll()
        {
            var json = File.ReadAllText(_dataPath);
            return JsonSerializer.Deserialize<List<Project>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<Project>();
        }

        public Project? GetBySlug(string slug)
        {
            return GetAll().Find(p => p.Slug == slug);
        }
    }
}
