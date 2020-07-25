using System;
using UnityEngine;

public class Math003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Floor: " + Mathf.Floor(6.283f));
        print("Ceil: " + Mathf.Ceil(6.283f));
        print("Round 2: " + System.Math.Round(6.283f, 2));
        print("Round 1: " + System.Math.Round(6.283f, 1));
        print("Power: "+ Mathf.Pow(2,24));
    }
}
