using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EngelScript : MonoBehaviour
{
    public GameObject engel;
    public Vector3 baslangic, bitis;
    public float sayac;
    bool carpti = false;

    void Start()
    {
        
    }

    void Update()
    {

        sayac += Time.deltaTime;
        if (carpti)
        {
            engel.transform.position = Vector3.Lerp(baslangic, bitis, sayac);
        }
    }
}
