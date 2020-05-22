using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private Vector2 mouseDragStartPosition;
    private Vector3 currentMousePoint;
    private Vector3 mouseDownPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClickOnDrag();
    }


    private void ClickOnDrag(){
        Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity )){
            
            currentMousePoint = hit.point;
            if(Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift)){
                Debug.Log("Excecute DRAG VALUES");
                mouseDownPoint = hit.point;
                mouseDragStartPosition = Input.mousePosition;
                if(hit.collider.gameObject.tag == "Unit"){

                    Debug.Log("Select Unit");

                }


            }

        }


    }
}
