using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class CreateFinalText : MonoBehaviour
{
    public GameObject obj;//object to fit in snapzone(timeNote)
    public GameObject text;

    void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == obj)
        {
            text.SetActive(true);
        }
    }
}
