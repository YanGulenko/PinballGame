using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailZoneScript : MonoBehaviour
{
    public Text score;
    public GameObject rail;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        score.text = "0";
        rail.SetActive(false);
    }
}
