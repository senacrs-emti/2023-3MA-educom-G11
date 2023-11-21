using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    // Start is called before the first frame update
    
    private GameObject Canvas;
    private bool isDragging = false;
    private bool isOverDropzone = false; 
    private GameObject Dropzone;
    private GameObject startParent;
    private Vector2 startPosition;

    private void Awake(){
        Canvas = GameObject.Find("Canvas");
    }

    void Start()
    {
        if(isDragging)
  {
    transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
  }
    }

    // Update is called once per frame
    void Update()
    {
       if (isDragging)
       {
        transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y + 50) ;
        transform.SetParent(Canvas.transform, true);
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
       startParent = transform.parent.gameObject;
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
            transform.SetParent(startParent.transform, false);
        }
    }
}
