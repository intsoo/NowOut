using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardDiary : MonoBehaviour
{
    public string inputText = " ";
    private TouchScreenKeyboard keyboard;
    public static bool hideInput;
    public static bool isInPlaceEditingAllowed=true;
    [SerializeField] Rect TextButton;
    [SerializeField] Rect InputField;
    void OnGUI()
    {
        inputText = GUI.TextField(InputField, inputText, 5);

        if (GUI.Button(TextButton, inputText))
        {
            keyboard = TouchScreenKeyboard.Open(inputText);
        }
        if (keyboard != null)
            inputText = keyboard.text;
    }

}
