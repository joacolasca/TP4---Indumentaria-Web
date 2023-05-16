namespace TP4.Models;
using System.Collections.Generic;
public static class Equipos
{
    
    public static List<string> ListaEquipos = new List<string> {"allboys" ,"Atlanta", "Ferro", "Chacarita", "Almagro", "San Lorenzo", "Boca", "Independiente", "Almirante Brown", "Belgrano"};
    public static List<string> ListaMedias = new List<string> {"medias violeta.webp", "Media amarilla.webp", "medias azules.webp", "medias blancas.jpg", "medias fluor.jpg", "medias grises.webp","medias naranjas.webp", "medias negras.png", "medias rojas.webp", "medias rosas.jpg"};
    public static List<string> ListaPantalones = new List<string> {"short banfiel.webp", "short brazil.webp", "short chacarita.webp", "short colon.webp", "short estudiantes.webp", "short multicolor.webp", "short napoli.webp", "short negro.webp", "short verde.webp", "short violeta.webp"};
    public static List<string> ListaRemeras = new List<string> {"camiseta alemania.webp", "camiseta belgrano.webp", "camiseta brasil.webp", "camiseta dorada.webp", "camiseta naranja.webp", "camiseta roja y blanca.webp", "camiseta seleccionArg.webp", "camiseta united.webp", "camiseta uruguay.webp", "camiseta verde.webp"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

 public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria indumentariaCargar)
    {
        bool existe = false;
        foreach (var equipo in EquiposIndumentaria)
        {
            if(EquipoSeleccionado == equipo.Key){
                existe = true;
            }
        }
        if(existe == false){
            Equipos.EquiposIndumentaria.Add(EquipoSeleccionado, indumentariaCargar);
        } 
        return existe;
    
}
}