using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartZoneScript : MonoBehaviour
{
    public GameObject rail;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        rail.SetActive(true);
    }
}
