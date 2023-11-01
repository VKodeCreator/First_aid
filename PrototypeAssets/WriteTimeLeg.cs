using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WriteTimeLeg : MonoBehaviour
{
    public GameObject obj2;
    public GameObject obj3;
    void Start()
    {
        obj3.SetActive(false);//hide note+time
    }
    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Проверка точки контакта
            if (contact.otherCollider.gameObject == obj2)
            {
                //obj2.SetActive(false); // Скрыть obj2
                obj3.SetActive(true); // Показать obj3
                Destroy(obj2);
                break;
            }
        }
    }
}
