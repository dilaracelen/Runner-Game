using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    float h�z = 5;

    void Update()
    {
        transform.Translate(0, 0, h�z * Time.deltaTime);
    }
}
