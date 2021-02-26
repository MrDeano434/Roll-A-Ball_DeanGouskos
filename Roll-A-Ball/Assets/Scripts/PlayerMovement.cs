using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;
    private int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space")) // or use (Input.GetKeyDown(KeyCode.[whicheverkeycomesup]))
        {
            //rb.AddForce(Vector3.up * jumpForce,);     Another way to add force

            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }

        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        rb.AddForce(x, 0, z);

        if(score >= 8)
        {
            print("Congrats, you yeeted dem cubes");
        }
    }

    void OnTriggerEnter(Collider otherObject)
    {
        //int score = 0; this is a local function and isnt saved/recognised outside THIS OnTriggerEnter
        //print("woo");
        if(otherObject.tag == "Pickup")
        {
            Destroy(otherObject.gameObject);
            //print("Yeet");
            score += 1;
            print("Score = " + score);
            //score = score + 1;
            //score++;
            //All three will add 1 to the score, score++ will only ever add 1
        }
    }

}
