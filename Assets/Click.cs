using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    Vector3 clickPosition;

    void OnMouseDown()
    {
        Debug.Log("mouse click");
        clickPosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        transform.Translate((Input.mousePosition - clickPosition));
        clickPosition = Input.mousePosition;
    }
}
