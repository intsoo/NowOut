using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CheckKeyBoardInput : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    // input text°¡ wish¸é input.SetActive(false);
    public void Check(TMP_InputField f)
    {
        if (f.text == "wish")
        {
            canvas.SetActive(false);
        }
    }
}
