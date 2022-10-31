using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup_LJY : MonoBehaviour
{
    //public GameObject pickupText_LJY;
    public GameObject pickupBtn_LJY;
    public GameObject pickupPhone_LJY;
    public GameObject pickupEarphone_LJY;
    bool isPickup = false;
    public GameObject DataController;

    void Start()
    {
        //pickupText_LJY.gameObject.SetActive(false);
        pickupPhone_LJY.gameObject.SetActive(false);
        pickupEarphone_LJY.gameObject.SetActive(false);
    }

    void Update()
    {
        
        if (isPickup)
            pickupBtn_LJY.gameObject.SetActive(true);
            //PickUp_LJY();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Phone"))
        {
            pickupPhone_LJY.gameObject.SetActive(true);
            isPickup = true;
            if (DataController.GetComponent<DataController>().gameData.Ep1_obj2Order == 0)
                DataController.GetComponent<DataController>().gameData.Ep1_obj1Order = 1;
            else
                DataController.GetComponent<DataController>().gameData.Ep1_obj1Order = 2;
        }
        if (col.gameObject.CompareTag("Earphone"))
        {
            pickupEarphone_LJY.gameObject.SetActive(true);
            isPickup = true;
            if (DataController.GetComponent<DataController>().gameData.Ep1_obj1Order == 0)
                DataController.GetComponent<DataController>().gameData.Ep1_obj2Order = 1;
            else
                DataController.GetComponent<DataController>().gameData.Ep1_obj2Order = 2;
        }
    }
    
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag.Equals("Phone"))
        {
            pickupPhone_LJY.gameObject.SetActive(false);
            isPickup = false;
        }
        if (col.gameObject.tag.Equals("Earphone"))
        {
            pickupEarphone_LJY.gameObject.SetActive(false);
            isPickup = false;
        }
    }
    
    /*
    public void PickUp_LJY()
    {
        Destroy(gameObject);
        DataController.Instance.gameData.Ep1_obj1 = 1;
    }
    */
}
