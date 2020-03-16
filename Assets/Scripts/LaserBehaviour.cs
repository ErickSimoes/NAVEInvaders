using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LaserBehaviour : MonoBehaviour {
    public float speed;
    public int lifeTime;
    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, lifeTime);
    }

    void Update() {

    }

    void FixedUpdate() {
        rb.velocity = Vector3.up * speed;
    }

}
