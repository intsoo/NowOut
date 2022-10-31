using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;


public class UseItem2_KSH : MonoBehaviour
{
    public bool isTouchSister = false;
    private obj2ButtonTouch_KSH bool_script;
    public GameObject Btn;
    public GameObject objCanvas;
    public GameObject DataController;
    private void Start()
    {
        bool_script = Btn.GetComponent<obj2ButtonTouch_KSH>();
    }

    void Update()
    {
        if (bool_script.obj2_1BtnTouch)
        {
            if (Input.GetMouseButton(0))
            {
                CheckTouchClear();

            }
        }
        // �ּ� ó���� �κ��� ��ġ �ν��ε� �׽�Ʈ�غ��� ���� ���콺 �Է��� ����.
        //foreach (Touch touch in Input.touches)
        //{
        //    if (touch.phase == TouchPhase.Began)
        //    CheckTouchClear();
    }

    void CheckTouchClear()
    {
        TouchSister();
        if (isTouchSister)
        {
            DataController.GetComponent<DataController>().gameData.Ep1_Clear++;
            DataController.GetComponent<DataController>().gameData.Ep1_obj2Order = 0;
            DataController.GetComponent<DataController>().SaveGameData();
            bool_script.obj2_1BtnTouch = false;
            objCanvas.SetActive(false);
        }

    }

    void TouchSister()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Sister"))
                isTouchSister = true;
        }

        //Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    if (hit.collider == GetComponent<BoxCollider>())
        //    {
        //        isTouchSister = true;
        //    }
        //}
    }
}


