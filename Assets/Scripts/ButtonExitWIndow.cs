using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExitWIndow : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject thisWindow;
    public GameObject exitWindow;

    public void ExitWindow()
    {
        thisWindow.SetActive(false);
        exitWindow.SetActive(false);
    }
}
