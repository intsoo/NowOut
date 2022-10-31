using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventoryUI_KSH : MonoBehaviour
{
    [SerializeField] GameObject button1_1;
    [SerializeField] GameObject button1_2;
    [SerializeField] GameObject button2_1;
    [SerializeField] GameObject button2_2;
    public GameObject DataController;
    [SerializeField] GameObject Phone;
    [SerializeField] GameObject Earphone;

    void Update()
    {
        RedrawUI();
        if (DataController.GetComponent<DataController>().gameData.Ep1_obj1Order != 0)
            Phone.SetActive(false);
        if (DataController.GetComponent<DataController>().gameData.Ep1_obj2Order != 0)
            Earphone.SetActive(false);

    }

    public void RedrawUI()
    {
        if(DataController.GetComponent<DataController>().gameData.Ep1_obj2Order == 0 && DataController.GetComponent<DataController>().gameData.Ep1_obj1Order == 2)
        {
            DataController.GetComponent<DataController>().gameData.Ep1_obj1Order = 1;
        }

        if (DataController.GetComponent<DataController>().gameData.Ep1_obj1Order == 0 && DataController.GetComponent<DataController>().gameData.Ep1_obj2Order == 2)
        {
            DataController.GetComponent<DataController>().gameData.Ep1_obj2Order = 1;
        }

        switch (DataController.GetComponent<DataController>().gameData.Ep1_obj1Order)
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
        switch (DataController.GetComponent<DataController>().gameData.Ep1_obj2Order)
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
