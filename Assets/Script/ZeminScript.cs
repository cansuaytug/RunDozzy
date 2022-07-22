using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminScript : MonoBehaviour
{
    public GameObject zemin;
    public int zeminSay;
    public static ZeminScript Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
       
        for (int i = 0; i < 5; i++)
        {
            Instantiate(zemin, new Vector3(0, -1, i * 10), zemin.transform.rotation);
            zeminSay++;
        }
    }
      
}
