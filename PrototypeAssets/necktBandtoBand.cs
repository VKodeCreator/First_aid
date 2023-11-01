using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class necktBandtoBand : MonoBehaviour
{
    public GameObject obj1; // band on body
    public GameObject obj2; // tourniq
    public GameObject snap_zone;
    public bool isObj1Active = false; // Флаг активации obj1 при старте

    void Start()
    {
        if (isObj1Active)
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
            snap_zone.SetActive(true);

        }
        else
        {
            snap_zone.SetActive(false);
            obj1.SetActive(false);
            obj2.SetActive(true);
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
            snap_zone.SetActive(true);
            Destroy(gameObject);
            Destroy(obj2);
        }
    }
}
