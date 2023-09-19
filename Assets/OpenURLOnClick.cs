using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class OpenURLOnClick : MonoBehaviour, IPointerClickHandler
{
    public string urlToOpen = "https://www.google.com";

    // Called when the GameObject is clicked
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the left mouse button or a touch event is used
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // Open the URL in a web browser
            Application.OpenURL(urlToOpen);
        }
    }
}
