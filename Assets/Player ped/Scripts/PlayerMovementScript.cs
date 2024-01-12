using Players;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    int curplayerid = 1;
    public GameObject aswin;
    public GameObject guna;
    public GameObject sriram;
    public GameObject rahul;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody curplayer = null;
        if (curplayerid == 1)
        {
            curplayer = aswin.GetComponent<Rigidbody>(); ;
        }
        else if (curplayerid == 2)
        {
            curplayer = guna.GetComponent<Rigidbody>(); ;
        }
        else if (curplayerid == 3)
        {
            curplayer = sriram.GetComponent<Rigidbody>(); ;
        }
        else if (curplayerid == 4)
        {
            curplayer = rahul.GetComponent<Rigidbody>(); ;
        }
        Debug.Log(curplayer.name);

        if (Input.GetButtonDown("forward"))
        {
            curplayer.velocity = new Vector3(curplayer.velocity.x, curplayer.velocity.y, 5);
        }
        else if (Input.GetButtonDown("backward"))
        {
            curplayer.velocity = new Vector3(curplayer.velocity.x, curplayer.velocity.y, -5);
        }
        else if (Input.GetButtonDown("left"))
        {
            curplayer.velocity = new Vector3(-5, curplayer.velocity.y, curplayer.velocity.z);
        }
        else if (Input.GetButtonDown("right"))
        {
            curplayer.velocity = new Vector3(5, curplayer.velocity.y, curplayer.velocity.z);
        }
        else if (Input.GetButtonDown("jump"))
        {
            curplayer.velocity = new Vector3(curplayer.velocity.x, 5, curplayer.velocity.y);
        }
    }
}
