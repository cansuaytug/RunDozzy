using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public bool toplandimi = false;
    public float sayac = 0;
   
    void Update()
    {
        if (toplandimi)
        {
            sayac += 0.5f * Time.deltaTime;
            transform.position += Vector3.up * 5f * Time.deltaTime*sayac+Vector3.forward*5f*Time.deltaTime;
            transform.Rotate(3600 * Time.deltaTime*sayac, 0, 0);
        }
    }
}
