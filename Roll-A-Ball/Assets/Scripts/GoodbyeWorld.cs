using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodbyeWorld : MonoBehaviour
{
    // Start is called before the first frame update

    public int playerHealth = 100;
    float gameTime = 0.5f;
    string welcomeMessage = "yeet";
    bool playerDead = false;

    void Start()
    {
        if (playerHealth > 0)
        {
            print(welcomeMessage);
            playerDead = false;
        }

        else
        {
            print("Just don't die lol");
            playerDead = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Objection()
    {
       
    }
}
