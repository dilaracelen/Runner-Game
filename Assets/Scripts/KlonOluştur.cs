using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlonOluştur : MonoBehaviour
{
    public GameObject altın;
    public GameObject araba;
    public GameObject taş;
    public GameObject kütük;

    public Transform oyuncu;

    float silinmeZamanı = 30f;

    float sağ_x_kordinat = 4.43f;
    float sol_x_kordinat = 0.73f;


    void Start()
    {
        InvokeRepeating("Nesne_Klonla", 0, 0.5f);
    }

    void Nesne_Klonla()
    {
        int rastsayı = Random.Range(0, 100);

        if(rastsayı > 0 && rastsayı < 55)
        {
            Klonla(altın, 1f);
        }
        
        if(rastsayı > 55 && rastsayı < 70)
        {
            Klonla(kütük, 0f);
        }

        if(rastsayı > 70 && rastsayı < 85)
        {
            Klonla(taş, 0f);
        }

        if(rastsayı > 85 && rastsayı < 100)
        {
            Klonla(araba, 0.5f);
        }
    }

    void Klonla(GameObject nesne, float y_kordinat)
    {
        GameObject yeniKlon = Instantiate(nesne);

        int rastsayı = Random.Range(0, 100);

        if (rastsayı < 50)
        {
            yeniKlon.transform.position = new Vector3(sağ_x_kordinat, y_kordinat, oyuncu.position.z * 2f);
        }
        else if(rastsayı > 50)
        {
            yeniKlon.transform.position = new Vector3(sol_x_kordinat, y_kordinat, oyuncu.position.z * 2f);
        }

        Destroy(yeniKlon, silinmeZamanı);
    }
}
