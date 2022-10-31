using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyBoard_KSH : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField] GameObject inputFieldCanvas;
    public GameObject DataController;

    private void Awake()
    {
        inputFieldCanvas.SetActive(true);
        inputField.text = "";
        inputField.onValueChanged.AddListener(OnValueChangedEvent);
        inputField.onEndEdit.AddListener(OnEndEditEvent);
        inputField.onSelect.AddListener(OnSelectEvent);
        inputField.onDeselect.AddListener(OnDeselectEvent);
    }

    void Update()
    {
        if (DataController.GetComponent<DataController>().gameData.checkKeyboard == 1)
            inputFieldCanvas.SetActive(false);
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
            DataController.GetComponent<DataController>().gameData.checkKeyboard = 1;
            DataController.GetComponent<DataController>().SaveGameData();
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
