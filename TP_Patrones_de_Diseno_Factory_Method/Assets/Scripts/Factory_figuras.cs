using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory_Figuras : MonoBehaviour
{
    [SerializeField] private Figuras cubo;
    [SerializeField] private Figuras esfera;

    public Figuras create_figure(string id)
    {
        switch (id)
        {
            case "cubo":
                return Instantiate(cubo);
            case "esfera":
                return Instantiate(esfera);
            default: return null;
        }
    }
}
