using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class KeyBoard_KSH : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField] GameObject canvas;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(OnValueChangedEvent);
        inputField.onEndEdit.AddListener(OnEndEditEvent);
        inputField.onSelect.AddListener(OnSelectEvent);
        inputField.onDeselect.AddListener(OnDeselectEvent);

        CheckKeyBoardInput();
    }
    public void OnValueChangedEvent(string str)
    {
        text.text = str;
    }
    public void OnEndEditEvent(string str)
    {
        text.text = str;
    }
    public void OnSelectEvent(string str)
    {
        text.text = str;
    }
    public void OnDeselectEvent(string str)
    {
        text.text = str;
    }

    // input text°¡ wish¸é input.SetActive(false);
    private void CheckKeyBoardInput()
    {
        if(text.text == "wish")
        {
            canvas.SetActive(false);
        }
    }
}
