using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{
    public Animator anim;

    public GameObject Bitti_Paneli;

    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI toplananAltýn_txt;

    public Transform yol1;
    public Transform yol2;

    public Rigidbody rb;

    bool sað = true;

    int puan = 0;
    int toplanan_altýn = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "son1")
        {
            yol2.position = new Vector3(yol1.position.x, yol1.position.y, yol1.position.z + 34);
        }

        if(other.gameObject.tag == "son2")
        {
            yol1.position = new Vector3(yol2.position.x, yol2.position.y, yol2.position.z + 34);
        }

        if(other.gameObject.tag == "engel")
        {
            Bitti_Paneli.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if(other.gameObject.tag == "altýn")
        {
            Destroy(other.gameObject);
            toplanan_altýn++;
            puan += 5;

            puan_txt.text = puan.ToString("00000");
            toplananAltýn_txt.text = toplanan_altýn.ToString();
        }
    }

    void Update()
    {
        Hareket();
    }

    void Hareket()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetBool("zýpla", true);
            rb.velocity = Vector3.up * 300f * Time.deltaTime;
            Invoke("Zýplama_iptal", 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sað = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sað = false;
        }

        if (sað)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(4.43f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(0.73f, transform.position.y, transform.position.z), Time.deltaTime * 3.0f);
        }

        transform.Translate(0, 0, 5 * Time.deltaTime);
    }   

    void Zýplama_iptal()
    {
        anim.SetBool("zýpla", false);
    }
}
