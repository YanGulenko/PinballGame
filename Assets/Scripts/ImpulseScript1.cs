using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ImpulseScript1 : MonoBehaviour
{
    Rigidbody ball;
    Vector3 vec;
    [SerializeField] private float ImpulseForce;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        vec = collision.transform.position - transform.position;
        ball = collision.gameObject.GetComponent<Rigidbody>();
        ball.AddForce(vec * ImpulseForce * Time.deltaTime, ForceMode.Impulse);
        score.text = (Convert.ToInt32(score.text)+50).ToString();
    }
}
