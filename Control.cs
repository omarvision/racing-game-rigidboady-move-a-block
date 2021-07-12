using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float Acceleration = 1.5f;
    public float TurnSpeed = 90;
    private Rigidbody rb = null;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //turn
        float X = Input.GetAxis("Horizontal");  // -1 ... 1
        this.transform.rotation *= Quaternion.AngleAxis(TurnSpeed * X * Time.deltaTime, Vector3.up);

        //move
        float Z = Input.GetAxis("Vertical");  // -1 ... 1
        rb.AddRelativeForce(Vector3.forward * Z * Acceleration, ForceMode.VelocityChange);
    }
}