using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_figuras : MonoBehaviour
{
    [SerializeField] private Factory_Figuras _factoryFiguras;

    private void Update()
    {
        if (Input.GetButtonUp("Key_1"))
        {
            _factoryFiguras.create_figure("cubo");
        }
        else if (Input.GetButtonUp("Key_2"))
        {
            _factoryFiguras.create_figure("esfera");
        }
    }
}
