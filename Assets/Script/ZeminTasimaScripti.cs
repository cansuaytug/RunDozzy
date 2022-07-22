using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminTasimaScripti : MonoBehaviour
{
    public GameObject coin,merdiven,engelp;
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("zemin"))
        {
            other.gameObject.transform.position = new Vector3(0, -1, ZeminScript.Instance.zeminSay++ * 10);
            for (int i = 0; i < 10; i++)
            {
                Instantiate(coin, other.gameObject.transform.position+Vector3.up*1.5f+Vector3.right*Random.Range(-1,2)*1.5f+Vector3.forward*Random.Range(-4f,4f), coin.transform.rotation);

            }
            int rnd = Random.Range(0, 5);
            if (rnd==1)
            {
                Instantiate(merdiven, other.gameObject.transform.position+Vector3.up, merdiven.transform.rotation);

            }
            else if (rnd == 2)
            {
                Instantiate(engelp,other.gameObject.transform.position+Vector3.up*2,engelp.transform.rotation);

            }
        }
    }
  
}
