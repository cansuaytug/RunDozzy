using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;


public class hareket : MonoBehaviour
{
    public bool jump = false;
    public int lane = 0,lane2;
    public float speed = 5f;
    public bool stop = false;
    float y = 0;
    public Text score; 
    public int puan = 0;
    public Text text;
    public bool gameover = false;
    Animator animator;
    public GameObject gameoverpanel;
 

    void Update()
    {
        if (gameover) return;
        if (SwipeInput.swipedUp)
        {
            Debug.Log("asasasa");
            GetComponent<Animator>().SetTrigger("jump");
                
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (SwipeInput.swipedLeft && lane>-1)
        {
            Debug.Log("sol");
            lane--;
            
        }
        if (SwipeInput.swipedRight && lane<1)
        {
            Debug.Log("sað");
            lane++;
        }


        speed += Time.deltaTime;
        if ((transform.position.x<=-1.5f  && lane<0 )|| (transform.position.x >= 1.5f && lane > 0))
        {
            lane2 = 0;
        }
        else
        {
            lane2 = lane;
        }

        // GetComponent<CharacterController>().Move(Vector3.right*lane*lane2*Time.deltaTime*speed+ Vector3.forward * Time.deltaTime * speed);
        if (Physics.Raycast(transform.position+Vector3.up*.5f, Vector3.forward, speed*.2f,1<<6))
        {
            y = 1;
        }
    
        else if (Physics.Raycast(transform.position+Vector3.up*.5f, Vector3.down, .6f)) 
        {
            y = 0;
        }
        else
        {
            y = -3;
                
        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, lane * 1.5f,5*Time.deltaTime), transform.position.y + Time.deltaTime * speed*y, transform.position.z+ Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<coinScript>())
        {
            other.GetComponent<coinScript>().toplandimi = true;
        }
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            puan++;
            score.text = puan.ToString();
        }
        if (other.CompareTag("engel"))
        {
            Debug.Log("gameover");
            gameover = true;
            gameoverpanel.SetActive(true);
            speed = 0;
           // SceneManager.LoadScene("yeniden");
        }
      
        
    }
    
}
