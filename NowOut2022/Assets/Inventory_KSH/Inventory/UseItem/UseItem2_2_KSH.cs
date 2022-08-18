using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;


public class UseItem2_2_KSH : MonoBehaviour
{
    public bool isTouchSister = false;
    private obj2_2ButtonTouch_KSH bool_script2;
    public GameObject Btn;
    Touch touch;
    private void Start()
    {
        bool_script2 = Btn.GetComponent<obj2_2ButtonTouch_KSH>();
    }

    void Update()
    {
        if (bool_script2.obj2_2BtnTouch)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                    CheckTouchClear();
            }
        }
    }

        

    void CheckTouchClear()
    {
        TouchSister();
        if (isTouchSister)
        {
            DataController.Instance.gameData.Ep1_Clear++;
            DataController.Instance.gameData.Ep1_obj2 = 0;
            DataController.Instance.gameData.Ep1_obj2Order = 0;
            bool_script2.obj2_2BtnTouch = false;
        }

    }

    void TouchSister()
    {
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Sister"))
                isTouchSister = true;
        }

        // Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //        RaycastHit hit;
        //        if (Physics.Raycast(ray, out hit))
        //        {
        //            if (hit.collider == GetComponent<BoxCollider>())
        //            {
        //                isTouchSister = true;
        //            }
        //        }
    }
}



