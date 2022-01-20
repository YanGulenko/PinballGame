using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballScript : MonoBehaviour
{
    public GameObject platform;
    public GameObject stick1;
    public GameObject stick2;
    public GameObject downSide;
    public float force;
    private Rigidbody _body;
    private HingeJoint _s1;
    private HingeJoint _s2;
    Vector3 vec;
    private void Start()
    {
       _body = platform.GetComponent<Rigidbody>();
       _s1 = stick1.GetComponent<HingeJoint>();
       _s2 = stick2.GetComponent<HingeJoint>();
       vec = platform.transform.position - downSide.transform.position;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _body.AddForce(-vec * Time.deltaTime * force, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            _s1.useMotor = true;
        }
        else
        {
            _s1.useMotor = false;
        }
        if (Input.GetKey(KeyCode.X))
        {
            _s2.useMotor = true;
        }
        else
        {
            _s2.useMotor = false;
        }

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
