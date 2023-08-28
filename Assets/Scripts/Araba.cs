using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
{
    float hýz = 5;

    void Update()
    {
        transform.Translate(0, 0, hýz * Time.deltaTime);
    }
}
