using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    public GameObject karakter;
    Vector3 mesafe;
    void Start()
    {       
        mesafe = transform.position - karakter.transform.position;

    }   
    void Update()
    {
        transform.position = mesafe + karakter.transform.position;
    }
}
