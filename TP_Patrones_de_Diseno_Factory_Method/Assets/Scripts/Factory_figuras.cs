using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory_Figuras : MonoBehaviour
{
    [SerializeField] private Figuras cubo;
    [SerializeField] private Figuras esfera;

    public void create_figure(string id)
    {
        if (id == "cubo")
        {
            Instantiate(cubo);
        }
        if (id == "esfera")
        {
            Instantiate(esfera);
        }
    }
}
