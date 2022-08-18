using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventoryUI_KSH : MonoBehaviour
{
    [SerializeField] GameObject button1_1;
    [SerializeField] GameObject button1_2;
    [SerializeField] GameObject button2_1;
    [SerializeField] GameObject button2_2;

    // Update is called once per frame
    void Update()
    {
        RedrawUI();
    }

    public void RedrawUI()
    {
        if(DataController.Instance.gameData.Ep1_obj2Order == 0 && DataController.Instance.gameData.Ep1_obj1Order == 2)
        {
            DataController.Instance.gameData.Ep1_obj1Order = 1;
        }

        if (DataController.Instance.gameData.Ep1_obj1Order == 0 && DataController.Instance.gameData.Ep1_obj2Order == 2)
        {
            DataController.Instance.gameData.Ep1_obj2Order = 1;
        }

        switch (DataController.Instance.gameData.Ep1_obj1Order)
        {
            case 0:
                button1_1.SetActive(false);
                button1_2.SetActive(false);
                break;
            case 1:
                button1_1.SetActive(true);
                button1_2.SetActive(false);
                break;
            case 2:
                button1_1.SetActive(false);
                button1_2.SetActive(true);
                break;
        }
        switch (DataController.Instance.gameData.Ep1_obj2Order)
        {
            case 0:
                button2_1.SetActive(false);
                button2_2.SetActive(false);
                break;
            case 1:
                button2_1.SetActive(true);
                button2_2.SetActive(false);
                break;
            case 2:
                button2_1.SetActive(false);
                button2_2.SetActive(true);
                break;
        }

    }
}
