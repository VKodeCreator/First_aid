using System.Collections;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 25;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentStream = null;
    private float pourStartTime = 0.0f;
    private const float pourDuration = 3.0f;

    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;

        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();
            }
            else
            {
                EndPour();
            }
        }

        if (isPouring)
        {
            UpdatePourDuration();
        }
    }

    private void StartPour()
    {
        currentStream = CreateStream();
        currentStream.Begin();
        pourStartTime = Time.time;
    }

    private void EndPour()
    {
        currentStream.End();
        currentStream = null;
    }

    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }

    private void UpdatePourDuration()
    {
        float elapsedPourTime = Time.time - pourStartTime;

        if (elapsedPourTime >= pourDuration)
        {
            EndPour();
            // Здесь вызывайте трансформации объекта, если необходимо
            // Например, создание нового объекта и уничтожение старого
        }
    }