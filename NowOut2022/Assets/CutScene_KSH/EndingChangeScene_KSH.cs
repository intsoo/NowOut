using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndingChangeScene_KSH : MonoBehaviour
{
    public GameObject DataController;
    void Update()
    {
        if (DataController.GetComponent<DataController>().gameData.checkKeyboard == 1&& DataController.GetComponent<DataController>().gameData.Ep1_Clear ==2)
            SceneManager.LoadScene("EndingCutScene");
    }
}
