using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Factory_Figuras : MonoBehaviour
{
    //Se crea lista para almacenar los objetos que van a ir en el diccionario
    [SerializeField] private Figuras[] listaFiguras; 
    //se crea diccionario
    private Dictionary<string, Figuras> diccionarioFiguras;

    private void Awake()
    {
        
        diccionarioFiguras = new Dictionary<string, Figuras>();
        //Se cargan los valores de id para referir a la key y el objeto como valor
        foreach (var fig in listaFiguras)
        {
            diccionarioFiguras.Add(fig.id, fig);
        }
    }
  
    public Figuras create_figure(string id)
    {
        diccionarioFiguras.TryGetValue(id, out var nuevaFigura);
        return Instantiate(nuevaFigura);
        
    }

    
}
