using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterZone : MonoBehaviour
{
    public GameObject obj1; // Объект, который нужно заменить
    public GameObject obj2; // Объект, на который нужно заменить
    public float checkDuration = 3.0f; // Длительность проверки (3 секунды)
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
                // Вода льется внутри зоны в течение 3 секунд
                ReplaceObject();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water")) // Проверьте, какой тег используется для воды
        {
            waterInsideZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water")) // Проверьте, какой тег используется для воды
        {
            waterInsideZone = false;
            timer = 0.0f; // Сбросите таймер, когда вода покидает зону
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
