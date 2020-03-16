using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    public GameObject laser;
    public Vector3 laserPosition;
    Rigidbody rigidbody;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetButtonDown("Jump")) {
            Instantiate(laser, transform.position + laserPosition, Quaternion.identity);
        }
    }

    private void FixedUpdate() {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
