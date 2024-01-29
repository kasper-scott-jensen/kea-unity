using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushable : MonoBehaviour
{
    
    public float pushForce;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Rigidbody squareRigidbody = GetComponent<Rigidbody>();
            Vector3 pushDirection = collision.contacts[0].normal;
            squareRigidbody.AddForce(pushDirection * pushForce);
        }
    }
    
}
