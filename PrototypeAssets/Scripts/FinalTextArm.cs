using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class FinalTextArm : MonoBehaviour
{
    //// Переменная для хранения текстового объекта
    //public GameObject textObject;
    //public GameObject tourniquet;
    //// Переменная для указания времени задержки перед появлением текста
    //public float delayTime = 2f;
    //void Start()
    //{
    //    textObject.gameObject.SetActive(false);
    //}
    //// Переменная для контроля времени прошедшего после попадания объекта в snapzone
    //private float elapsedTime = 0f;

    //// Переменная для определения, попал ли объект в snapzone
    //private bool inSnapzone = false;

    //IEnumerator HideMessage()
    //{
    //    yield return new WaitForSeconds(3f); // Длительность отображения сообщения (в секундах)
    //    textObject.gameObject.SetActive(false);
    //}

    //// Функция вызывается при попадании объекта в snapzone
    //private void OnSnapzoneTriggerEnter(Collider other)
    //{
    //    if (other.gameObject == tourniquet)
    //    {
    //        textObject.gameObject.SetActive(true);
    //        StartCoroutine(HideMessage());
    //    }
    //}

}