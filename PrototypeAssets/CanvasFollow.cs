using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollow : MonoBehaviour
{
    public Transform headsetTransform;  // —сылка на голову игрока

    private void Update()
    {
        transform.position = headsetTransform.position;  // ѕередвигаем Canvas в соответствии с положением головы игрока
        transform.rotation = headsetTransform.rotation;  // ѕоворачиваем Canvas в соответствии с ориентацией головы игрока
    }
}
