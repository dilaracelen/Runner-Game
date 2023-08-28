using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform TakipEdilen;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, TakipEdilen.position, Time.deltaTime * 3.0f);
    }
}
