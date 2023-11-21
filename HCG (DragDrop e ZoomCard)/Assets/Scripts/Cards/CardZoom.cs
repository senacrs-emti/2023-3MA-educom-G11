using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;

    private GameObject zoomCard;

       public void OnHouverEnter()
    {
        zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 250), Quaternion.identity);
        zoomCard.transform.SetParent(Canvas.transform, false);

        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(101, 160);
    }
    public void OnHouverExit()
    {
        Destroy(zoomCard);
    }
}
