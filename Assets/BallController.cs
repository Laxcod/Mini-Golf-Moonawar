using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float force; 
    bool shoot;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shoot = true;
        }
    }

    private void FixedUpdate() {
        if(shoot)
        {
            shoot = false;
            Vector3 direction = Camera.main.transform.forward;
            direction.y = 0;
            rb.AddForce(direction * force, ForceMode.Impulse);
        }
    }
}