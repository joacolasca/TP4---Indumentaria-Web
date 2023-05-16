namespace TP4.Models;

public class Indumentaria
{
    
    public string Medias {get; private set;}
    public string Pantalon {get; private set;}
    public string Camiseta {get; private set;} 

    public Indumentaria(string med, string pan, string cam){
    Medias = med;
    Pantalon = pan;
    Camiseta = cam;  
    }
}