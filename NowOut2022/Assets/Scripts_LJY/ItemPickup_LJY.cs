using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup_LJY : MonoBehaviour
{
    public GameObject pickupText_LJY;
    public GameObject pickupBtn_LJY;
    bool isPickup;

    void Start()
    {
        pickupText_LJY.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isPickup)
            pickupBtn_LJY.gameObject.SetActive(true);
            //PickUp_LJY();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            pickupText_LJY.gameObject.SetActive(true);
            isPickup = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            pickupText_LJY.gameObject.SetActive(false);
            isPickup = false;
        }
    }

    public void PickUp_LJY()
    {
        Destroy(gameObject);
        DataController.Instance.gameData.Ep1_obj1 = 1;
    }
}
