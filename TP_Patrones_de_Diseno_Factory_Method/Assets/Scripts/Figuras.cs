using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figuras : MonoBehaviour
{
    [SerializeField] private string _id;

    public string id => _id;
}
