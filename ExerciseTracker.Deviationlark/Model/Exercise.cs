namespace ExerciseTracker;
public class Exercise
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Duration { get; set; }
    public string Comments { get; set; }
}