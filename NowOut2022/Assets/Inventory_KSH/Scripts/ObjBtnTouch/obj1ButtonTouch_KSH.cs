using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class obj1ButtonTouch_KSH : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool obj1_1BtnTouch = false;
    public GameObject button;

    public Image obj1Image;
    public GameObject obj1canvas;


    public void OnPointerDown(PointerEventData eventData)
    {
        obj1_1BtnTouch = true;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        obj1canvas.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        obj1Image.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        obj1canvas.SetActive(false);
        Invoke("boolTouch", 0.2f);
    }
    public void boolTouch()
    {
        obj1_1BtnTouch = false;
    }
}
