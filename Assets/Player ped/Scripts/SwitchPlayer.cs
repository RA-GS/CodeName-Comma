using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    int curplayerid = 1;
    public GameObject aswincam;
    public GameObject gunacam;
    public GameObject sriramcam;
    public GameObject rahulcam;
    // Start is called before the first frame update
    void Start()
    {
        if (curplayerid == 1)
        {
            Debug.Log("Switched to: aswin");
            curplayerid = 1;
            aswincam.SetActive(true);
            gunacam.SetActive(false);
            sriramcam.SetActive(false);
            rahulcam.SetActive(false);
        }
        if (curplayerid == 2)
        {
            Debug.Log("Switched to: guna");
            curplayerid = 2;
            aswincam.SetActive(false);
            gunacam.SetActive(true);
            sriramcam.SetActive(false);
            rahulcam.SetActive(false);
        }
        if (curplayerid == 3)
        {
            Debug.Log("Switched to: sriram");
            curplayerid = 3;
            aswincam.SetActive(false);
            gunacam.SetActive(false);
            sriramcam.SetActive(true);
            rahulcam.SetActive(false);
        }
        if (curplayerid == 4)
        {
            Debug.Log("Switched to: rahul");
            curplayerid = 4;
            aswincam.SetActive(false);
            gunacam.SetActive(false);
            sriramcam.SetActive(false);
            rahulcam.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // player switch
        if (Input.GetButtonDown("player1"))
        {
            Debug.Log("Switched to: aswin");
            curplayerid = 1;
            aswincam.SetActive(true);
            gunacam.SetActive(false);
            sriramcam.SetActive(false);
            rahulcam.SetActive(false);
        }
        if (Input.GetButtonDown("player2"))
        {
            Debug.Log("Switched to: guna");
            curplayerid = 2;
            aswincam.SetActive(false);
            gunacam.SetActive(true);
            sriramcam.SetActive(false);
            rahulcam.SetActive(false);
        }
        if (Input.GetButtonDown("player3"))
        {
            Debug.Log("Switched to: sriram");
            curplayerid = 3;
            aswincam.SetActive(false);
            gunacam.SetActive(false);
            sriramcam.SetActive(true);
            rahulcam.SetActive(false);
        }
        if (Input.GetButtonDown("player4"))
        {
            Debug.Log("Switched to: rahul");
            curplayerid = 4;
            aswincam.SetActive(false);
            gunacam.SetActive(false);
            sriramcam.SetActive(false);
            rahulcam.SetActive(true);
        }
    }
}
