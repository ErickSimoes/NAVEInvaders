using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    public GameObject laser;
    public Vector3 laserPosition;
    Rigidbody rb;
    private float inputH;

    void Start() {
        rb = GetComponent<Rigidbody>();
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
