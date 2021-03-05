using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement Can use this to control multiple scenes

public class UIDisplay : MonoBehaviour
{
    public Text displayText;
    //private float count; used to enable deltatime
    private int count;
    private bool reverse;
    public Color upColor;

    void Start()
    {
        displayText.text = "";
        //displayText.color = upColor; Do in unity editor color selector
    }


    void Update()
    {
        if(reverse == false)
        {
            count = count + 1;
            //count -= 1; or any other number
            //count --; will only ever do it by 1
            displayText.text = "Count = " + count;
        }
        else
        {
            count = count - 1;
            //count += 1; or any other number
            //count ++; will only ever do it by 1
            displayText.text = "Count = " + count;
        }

        if(count >= 1000)
        {
            reverse = true;
            displayText.color = Color.red;
        }
        else if(count <= 0)
        {
            reverse = false;
            displayText.color = upColor;
        }
       

        /* if (count < 100)
        {
            //count = count + 1 * Time.deltaTime;
            count = count + 1;
            //displayText.text = count.ToString(); another way of displaying the counter
            displayText.text = "Count = " + count;

            if (count == 100) // (if the count continued counting beyond 100 then >=100 would be used rather than ==)
            {
                displayText.text = "Wow you're such a yeetus";
            }
            
        }*/
    }
}
