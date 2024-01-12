using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldAndPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class World
{
   
}

public class Player
{
    public string Name;
    public string[] Ability;
    public float Health;
    public float Speed;
    public float Jump;
}

public class aswinPed : Player
{
    public aswinPed()
    {
        Name = "aswin";
        Ability = new string[] { "lockpick" };
        Health = 100;
        Speed = 5;
        Jump = 5;
    }
}

public class gunaPed : Player
{
    public gunaPed()
    {
        Name = "guna";
        Ability = new string[] { "strong" };
        Health = 140;
        Speed = 3;
        Jump = 3;
    }
}

public class sriramPed : Player
{
    public sriramPed()
    {
        Name = "sriram";
        Ability = new string[] { "fastmovement" };
        Health = 90;
        Speed = 6;
        Jump = 6;
    }
}

public class rahulPed : Player
{
    public rahulPed()
    {
        Name = "rahul";
        Ability = new string[] { "eagleeye" };
        Health = 90;
        Speed = 5;
        Jump = 5;
    }
}