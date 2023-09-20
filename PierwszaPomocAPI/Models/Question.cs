namespace PierwszaPomocAPI.Models;

public class Question
{
    public string question { get; set; }
    public string[] answers { get; set; }
    public int correctAnswer { get; set; }
}