using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItButton_LJY : MonoBehaviour
{
    public UnityEvent unityEvent_LJY = new UnityEvent();
    public GameObject cluebtn_LJY;

    // Start is called before the first frame update
    void Start()
    {
        cluebtn_LJY = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit)&& hit.collider.gameObject == gameObject)
            {
                unityEvent_LJY.Invoke();
            }
        }
    }
}
