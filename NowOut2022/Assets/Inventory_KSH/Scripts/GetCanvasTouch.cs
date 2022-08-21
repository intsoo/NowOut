using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;


public class GetCanvasTouch : MonoBehaviour, IPointerDownHandler
{
    private obj1ButtonTouch_KSH bool_script;
    private obj2ButtonTouch_KSH bool_script2;
    private obj1_2ButtonTouch_KSH bool_script1_2;
    private obj2_2ButtonTouch_KSH bool_script2_2;
    public GameObject Btn1_1;
    public GameObject Btn1_2;
    public GameObject Btn2_1;
    public GameObject Btn2_2;
    private void Start()
    {
        bool_script = Btn1_1.GetComponent<obj1ButtonTouch_KSH>();
        bool_script1_2 = Btn1_2.GetComponent<obj1_2ButtonTouch_KSH>();
        bool_script2 = Btn2_1.GetComponent<obj2ButtonTouch_KSH>();
        bool_script2_2 = Btn2_2.GetComponent<obj2_2ButtonTouch_KSH>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
    //    //    eventData.selectedObject = gameObject;
    //    if (!gameObject.CompareTag("obj1Btn"))
        bool_script.obj1_1BtnTouch = false;
        bool_script2.obj2_1BtnTouch = false;
        bool_script1_2.obj1_2BtnTouch = false;
        bool_script2_2.obj2_2BtnTouch = false;
    }
  
}
