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
    [SerializeField] private string initialMessage = "������������� ���������!";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == obj) // ���������, ��� ������ obj1 ����� � snapzone
        {
            StartCoroutine(DisplayMessage()); // ��������� �������� ��� ����������� ���������
        }
    }

    IEnumerator DisplayMessage()
    {
        messageText.text = initialMessage; // ������ ��������� ���������
        messageText.gameObject.SetActive(true); // ���������� ��������� ����

        yield return new WaitForSeconds(3f); // ���� 3 �������

        messageText.gameObject.SetActive(false); // �������� ��������� ����
    }
    //public GameObject snapMessagePrefab; // Unity ������, ���������� ����� ���������
    //private GameObject snapMessageInstance; // ��������� ���������
    //public Transform vrHeadset; // ������ VR

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("����")) // ���������, ��� ������ ����� � snap zone
    //    {
    //        // ������������� ��������� � �������� ������ VR
    //        Vector3 messagePosition = vrHeadset.position + vrHeadset.forward * 2f;
    //        Quaternion messageRotation = vrHeadset.rotation;

    //        // ������� ��������� ���������
    //        snapMessageInstance = Instantiate(snapMessagePrefab, messagePosition, messageRotation);
    //        Destroy(snapMessageInstance, 3f); // ������� ��������� ����� 3 �������
    //    }
    //}
    //public GameObject obj;
    //[SerializeField] private Text messageText;

    //IEnumerator HideMessage()
    //{
    //    yield return new WaitForSeconds(3f); // ������������ ����������� ��������� (� ��������)
    //    messageText.gameObject.SetActive(false);
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("obj1"))
    //    {
    //        messageText.text = "������������� ���������!";
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
    //        messageText.text = "��������� ���������";
    //        // ����� ����� �������� ������ �������� ��� �������, ��������, ��������� ����� ��� ���������� �������, ����� ����������� ���������� ���������.
    //    }
    //}

    //private void Update()
    //{
    //    if (snapComplete)
    //    {
    //        // ���� �� ������, ����� ��������� ������� ����� ��������� �����, �� ������ ������������ ������ � �������� ���� snapComplete ����� ������������� ��������� �������.
    //        // ��������, ����� ���������� ����� ����������� ��������� �� 2 �������:
    //        StartCoroutine(HideMessageAfterDelay(3f));
    //    }
    //}

    //IEnumerator HideMessageAfterDelay(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    snapComplete = false;
    //    messageText.text = ""; // ���� �� ������ ��������� ������ ���������, ���������� ������ ������ ("").
    //}
}

