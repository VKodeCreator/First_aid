using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollow : MonoBehaviour
{
    public Transform headsetTransform;  // ������ �� ������ ������

    private void Update()
    {
        transform.position = headsetTransform.position;  // ����������� Canvas � ������������ � ���������� ������ ������
        transform.rotation = headsetTransform.rotation;  // ������������ Canvas � ������������ � ����������� ������ ������
    }
}
