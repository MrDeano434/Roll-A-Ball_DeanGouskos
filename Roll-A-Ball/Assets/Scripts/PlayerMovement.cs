using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;
    private int score = 0;
    public Text scoreText;
    public Text winText;
    public Image winImage;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreText.text = "Score = " + score;
        winText.text = "";
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

        if(score >=8)
        {
            winText.text = "Congrats, you won!";
            winText.color = Color.green;
            scoreText.text = "Winner, Winner Winner!";
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
            scoreText.text = ("Score = " + score);
            //score = score + 1;
            //score++;
            //All three will add 1 to the score, score++ will only ever add 1
        }
    }

}
