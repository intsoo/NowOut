using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_LJY : MonoBehaviour
{
    //float hAxis_LJY;
    //float vAxis_LJY;
    //Vector3 moveCamVec_LJY;

    public Transform target_LJY;
    public Vector3 offset_LJY;
    public GameObject DataController;

    void Update()
    {
        //hAxis_LJY = Input.GetAxisRaw("Horizontal");
        //vAxis_LJY = Input.GetAxisRaw("Vertical");

        //moveCamVec_LJY = new Vector3(hAxis_LJY, 0, vAxis_LJY).normalized;

        transform.position = target_LJY.position + offset_LJY;
        DataController.GetComponent<DataController>().gameData.cameraOffset = offset_LJY;
        //transform.RotateAround(target_LJY.position, Vector3.up, 20*Time.deltaTime);
        //transform.LookAt(transform.position + moveCamVec_LJY);
    }
}
