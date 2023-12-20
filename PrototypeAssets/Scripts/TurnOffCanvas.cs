using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TurnOffCanvas : MonoBehaviour
{
    public GameObject canvas2; // —сылка на второй Canvas

    public void TurnOffCanvases()
    {
        canvas2.SetActive(false);  // ¬ключаем второй Canvas
    }
}
