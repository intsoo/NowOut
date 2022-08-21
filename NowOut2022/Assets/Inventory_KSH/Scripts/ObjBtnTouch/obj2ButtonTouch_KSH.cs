using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class obj2ButtonTouch_KSH : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool obj2_1BtnTouch = false;
    public GameObject button;

    public Image obj2Image;
    public GameObject obj2canvas;


    public void OnPointerDown(PointerEventData eventData)
    {
        obj2_1BtnTouch = true;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        obj2canvas.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        obj2Image.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        obj2canvas.SetActive(false);
        Invoke("boolTouch", 0.2f);
    }
    public void boolTouch()
    {
        obj2_1BtnTouch = false;
    }
}
