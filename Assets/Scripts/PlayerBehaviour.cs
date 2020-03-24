﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    public GameObject laser;
    public Vector3 laserPosition;
    [SerializeField]
    private Rigidbody rb;
    private float inputH;

    void Start() {
        
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) {
            Instantiate(laser, transform.position + laserPosition, Quaternion.identity);
        }
    }

    private void FixedUpdate() {
        inputH = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector3(inputH * speed, 0f);
    }
}
