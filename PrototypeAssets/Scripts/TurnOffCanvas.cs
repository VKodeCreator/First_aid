using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TurnOffCanvas : MonoBehaviour
{
    public GameObject canvas2; // ������ �� ������ Canvas

    public void TurnOffCanvases()
    {
        canvas2.SetActive(false);  // �������� ������ Canvas
    }
}
