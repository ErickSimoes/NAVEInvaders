using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    Rigidbody rigidbody;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        
    }

    private void FixedUpdate() {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
