using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    GameObject aswinPed;
    GameObject gunaPed;
    GameObject sriramPed;
    GameObject rahulPed;
    // Start is called before the first frame update
    void Start()
    {
        aswinPed = GameObject.Find("aswinBody");
        gunaPed = GameObject.Find("gunaBody");
        sriramPed = GameObject.Find("sriramBody");
        rahulPed = GameObject.Find("rahulBody");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("space is pressed");
            aswinPed.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
            gunaPed.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
            sriramPed.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
            rahulPed.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }
    }
}
