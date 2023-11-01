using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterZone : MonoBehaviour
{
    public GameObject obj1; // ������, ������� ����� ��������
    public GameObject obj2; // ������, �� ������� ����� ��������
    public float checkDuration = 3.0f; // ������������ �������� (3 �������)
    private bool waterInsideZone = false;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (waterInsideZone)
        {
            timer += Time.deltaTime;
            if (timer >= checkDuration)
            {
                // ���� ������ ������ ���� � ������� 3 ������
                ReplaceObject();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water")) // ���������, ����� ��� ������������ ��� ����
        {
            waterInsideZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water")) // ���������, ����� ��� ������������ ��� ����
        {
            waterInsideZone = false;
            timer = 0.0f; // �������� ������, ����� ���� �������� ����
        }
    }

    private void ReplaceObject()
    {
        if (obj1 != null && obj2 != null)
        {
            obj1.SetActive(false);
            obj2.SetActive(true);
        }
    }
    // Update is called once per frame
}
