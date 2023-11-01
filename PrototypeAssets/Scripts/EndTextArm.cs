using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class EndTextArm : MonoBehaviour
{
    public GameObject textObject;
    public GameObject ArmTime;
    // ���������� ��� �������� ������� �������� ����� ���������� ������
    public float delayTime = 2f;
    void Start()
    {
        textObject.gameObject.SetActive(false);
    }
    // ���������� ��� �������� ������� ���������� ����� ��������� ������� � snapzone
    private float elapsedTime = 0f;

    // ���������� ��� �����������, ����� �� ������ � snapzone
    private bool inSnapzone = false;

    IEnumerator HideMessage()
    {
        yield return new WaitForSeconds(3f); // ������������ ����������� ��������� (� ��������)
        textObject.gameObject.SetActive(false);
    }

    // ������� ���������� ��� ��������� ������� � snapzone
    private void OnSnapzoneTriggerEnter(Collider other)
    {
        if (other.gameObject == ArmTime)
        {
            textObject.gameObject.SetActive(true);
            StartCoroutine(HideMessage());
        }
    }
}