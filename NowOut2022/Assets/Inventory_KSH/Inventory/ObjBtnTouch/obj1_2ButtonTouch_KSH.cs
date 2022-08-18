using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class obj1_2ButtonTouch_KSH : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool obj1_2BtnTouch = false;
    public GameObject obj1;
    public GameObject button;
    public Camera CanvasCamera;

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 uiElementPosition = CanvasCamera.WorldToScreenPoint(button.transform.position);
        Vector3 NewWorldPosition = Camera.main.ScreenToWorldPoint(uiElementPosition);
        obj1.transform.position = NewWorldPosition;
        obj1_2BtnTouch = true;
        obj1.SetActive(true);
        obj1.SetActive(false);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        obj1.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        obj1.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        obj1.SetActive(false);
        Invoke("boolTouch", 0.2f);
    }
    public void boolTouch()
    {
        obj1_2BtnTouch = false;
    }
}
