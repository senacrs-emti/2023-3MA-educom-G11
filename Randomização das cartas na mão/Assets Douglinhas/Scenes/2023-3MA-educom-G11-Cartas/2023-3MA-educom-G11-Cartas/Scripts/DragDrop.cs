using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropzone = false;
    private Vector2 startPosition;
    private GameObject Dropzone;
    // Update is called once per frame
    void Update()
    {
       if (isDragging)
       {
        transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       }  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropzone= true;
        Dropzone = collision.gameObject;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropzone= false;
        Dropzone = null;
    }
    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }
    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropzone)
        {

        transform.SetParent(Dropzone.transform, false);
        
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
