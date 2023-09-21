using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_figuras : MonoBehaviour
{
    [SerializeField] private Factory_Figuras _factoryFiguras;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _factoryFiguras.create_figure("cubo");
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            _factoryFiguras.create_figure("esfera");
        }
    }
}
