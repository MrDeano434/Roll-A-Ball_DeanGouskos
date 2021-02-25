﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;
    public float moveSpeed;

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

    }
}