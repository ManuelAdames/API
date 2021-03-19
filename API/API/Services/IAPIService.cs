using System;
using System.Collections.Generic;
using System.Text;
using API.Models;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IAPIService
    {
        Task<Language> GetLanguageAsync(); 
    }
}
