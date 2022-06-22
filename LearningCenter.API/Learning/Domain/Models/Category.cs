namespace LearningCenter.API.Learning.Domain.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    //RELATIONSHIPS
    //puede abarcar varios tutorials
    //entonces una coleccion de tutorials
    //category puede saber quienes son sus tutorials
    public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
}