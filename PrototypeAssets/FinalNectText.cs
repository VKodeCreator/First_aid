using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;
using TMPro;
//using static System.Net.Mime.MediaTypeNames;

public class FinalNectText : MonoBehaviour
{
    public GameObject obj;
    [SerializeField] private Text messageText;
    [SerializeField] private string initialMessage = "Перевязывание завершено!";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == obj) // Проверяем, что объект obj1 попал в snapzone
        {
            StartCoroutine(DisplayMessage()); // Запускаем корутину для отображения сообщения
        }
    }

    IEnumerator DisplayMessage()
    {
        messageText.text = initialMessage; // Задаем начальное сообщение
        messageText.gameObject.SetActive(true); // Активируем текстовое поле

        yield return new WaitForSeconds(3f); // Ждем 3 секунды

        messageText.gameObject.SetActive(false); // Скрываем текстовое поле
    }
    //public GameObject snapMessagePrefab; // Unity объект, содержащий текст сообщения
    //private GameObject snapMessageInstance; // Экземпляр сообщения
    //public Transform vrHeadset; // Камера VR

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Жгут")) // Проверяем, что объект попал в snap zone
    //    {
    //        // Позиционируем сообщение в середине камеры VR
    //        Vector3 messagePosition = vrHeadset.position + vrHeadset.forward * 2f;
    //        Quaternion messageRotation = vrHeadset.rotation;

    //        // Создаем экземпляр сообщения
    //        snapMessageInstance = Instantiate(snapMessagePrefab, messagePosition, messageRotation);
    //        Destroy(snapMessageInstance, 3f); // Удаляем сообщение через 3 секунды
    //    }
    //}
    //public GameObject obj;
    //[SerializeField] private Text messageText;

    //IEnumerator HideMessage()
    //{
    //    yield return new WaitForSeconds(3f); // Длительность отображения сообщения (в секундах)
    //    messageText.gameObject.SetActive(false);
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("obj1"))
    //    {
    //        messageText.text = "Перевязывание завершено!";
    //        messageText.gameObject.SetActive(true);
    //        StartCoroutine(HideMessage());
    //    }
    //}
    //public GameObject obj1;
    //public Text messageText;

    //private bool snapComplete = false;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject == obj1)
    //    {
    //        snapComplete = true;
    //        messageText.text = "Перевязка завершена";
    //        // Можно также добавить другие действия или эффекты, например, изменение цвета или визуальные эффекты, чтобы подчеркнуть завершение перевязки.
    //    }
    //}

    //private void Update()
    //{
    //    if (snapComplete)
    //    {
    //        // Если вы хотите, чтобы сообщение исчезло через некоторое время, вы можете использовать таймер и сбросить флаг snapComplete после определенного интервала времени.
    //        // Например, чтобы установить время отображения сообщения на 2 секунды:
    //        StartCoroutine(HideMessageAfterDelay(3f));
    //    }
    //}

    //IEnumerator HideMessageAfterDelay(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    snapComplete = false;
    //    messageText.text = ""; // Если вы хотите полностью скрыть сообщение, установите пустую строку ("").
    //}
}

