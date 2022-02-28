using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    public float velocity;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h_axis = Input.GetAxis("Horizontal");
        float v_axis = Input.GetAxis("Vertical");

        rigidBody.AddForce(new Vector3(h_axis, 0.0f, v_axis) * velocity);
    }
}