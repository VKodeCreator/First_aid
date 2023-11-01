using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class BandToTourniquet : MonoBehaviour
{
    public GameObject obj1; // band+tour
    public GameObject obj2; // tourniq
    public GameObject obj3; // band only
    public GameObject TimeSnapzone;
    public bool isObj1Active = false; // Флаг активации obj1 при старте

    void Start()
    {
        if (isObj1Active)
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
            TimeSnapzone.SetActive(true);
        }
        else
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
            TimeSnapzone.SetActive(false);
        }
    }

    public bool isBandageOn()
    {
        return isObj1Active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == obj2)
        {
            Instantiate(obj1, transform.position, transform.rotation);
            //obj2.SetActive(false);
            obj1.SetActive(true);
            TimeSnapzone.SetActive(true);
            Destroy(obj3);
            Destroy(gameObject);
            Destroy(obj2);
        }
    }
}
