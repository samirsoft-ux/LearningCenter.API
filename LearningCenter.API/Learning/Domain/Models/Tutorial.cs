namespace LearningCenter.API.Learning.Domain.Models;

public class Tutorial
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    
    //RELATIONSHIPS
    //el lado del dependiente
    //indicar el atributo donde va a reposar la persistencia
    //genera una columna para almacenar todas las categorias
    // a que categoria pertenece
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}