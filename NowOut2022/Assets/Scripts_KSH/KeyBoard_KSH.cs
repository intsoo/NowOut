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
    [SerializeField] GameObject inputFieldCanvas;

    private void Awake()
    {
        inputFieldCanvas.SetActive(true);
        inputField.text = "";
        inputField.onValueChanged.AddListener(OnValueChangedEvent);
        inputField.onEndEdit.AddListener(OnEndEditEvent);
        inputField.onSelect.AddListener(OnSelectEvent);
        inputField.onDeselect.AddListener(OnDeselectEvent);

    }
    public void OnValueChangedEvent(string str)
    {
        inputField.text = str;
    }
    public void OnEndEditEvent(string str)
    {
        inputField.text = str;
        if (str == "wish")
        {
            inputFieldCanvas.SetActive(false);
            DataController.Instance.gameData.Ep1_Clear++;
        }
        else
            inputFieldCanvas.SetActive(true);
    }
    public void OnSelectEvent(string str)
    {
        inputField.text = str;
    }
    public void OnDeselectEvent(string str)
    {
        inputField.text = str;
    }

 
}
