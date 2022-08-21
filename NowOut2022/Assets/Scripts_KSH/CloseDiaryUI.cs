using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

namespace EasyUI.Dialogs
{
   
    public class CloseDiaryUI : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] GameObject canvas;
        [SerializeField]
        private TMP_InputField inputField;
        [SerializeField]
        private TextMeshProUGUI text;
        [SerializeField] GameObject openButtonCanvas;

        public void OnPointerDown(PointerEventData eventData)
        {
            canvas.SetActive(false);
            inputField.text = "";
            openButtonCanvas.SetActive(true);
        }
        
    }
}
