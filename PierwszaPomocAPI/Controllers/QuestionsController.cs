using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using PierwszaPomocAPI.Models;

namespace PierwszaPomocAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly IWebHostEnvironment _env;
    private readonly List<Question> _questions;
    
    public QuestionsController(IWebHostEnvironment env)
    {
        _env = env;
        _questions = LoadQuestions();
    }

    private List<Question> LoadQuestions()
    {
        var jsonFilePath = Path.Combine(_env.ContentRootPath, "Questions.json");

        try
        {
            using (var streamReader = new StreamReader(jsonFilePath))
            {
                var jsonString = streamReader.ReadToEnd();
                var questions = JsonSerializer.Deserialize<List<Question>>(jsonString);
                return questions;
            }
        }
        catch (Exception ex)
        {
            return new List<Question>();
        }
    }

    [HttpGet("all", Name = "AllQuestions")]
    public IActionResult AllQuestions()
    {
        return Ok(_questions);
    }

    [HttpGet("random", Name = "RandomQuestion")]
    public IActionResult RandomQuestion([FromQuery] int count = 1)
    {
        if (count <= 0)
        {
            return BadRequest("Parametr 'count' musi być większy od zera.");
        }
        
        var random = new Random();
        var selectedQuestions = new List<Question>();

        for (int i = 0; i < count; i++)
        {
            var randomIndex = random.Next(_questions.Count);
            selectedQuestions.Add(_questions[randomIndex]);
        }

        return Ok(selectedQuestions);
    }

    [HttpGet("info", Name = "Info")]
    public IActionResult GetQuestion()
    {
        var info = new
        {
            QuestionCount = _questions.Count
        };

        return Ok(info);
    }
}