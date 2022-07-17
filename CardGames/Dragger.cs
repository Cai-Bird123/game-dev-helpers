using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{

    private GameObject selectedObject;
    public Camera assignedCamera;
    public float cardLiftHeight;
    private float fixedPosY; // This variable is used to lock the elevation of a selected object at the first instance, such that the card only moves in left / right (x,z)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selectedObject == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider)
                {
                    if (!hit.collider.CompareTag("Draggable")) // if we didnt click on a draggable then do nadda
                    {
                        return;
                    }
                    selectedObject = hit.collider.gameObject; // assgined the selected object to the selected obj variable
                    Cursor.visible = false;
                    Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, assignedCamera.WorldToScreenPoint(selectedObject.transform.position).z);
                    Vector3 worldPosition = assignedCamera.ScreenToWorldPoint(position);
                    selectedObject.transform.position = new Vector3(worldPosition.x, worldPosition.y + cardLiftHeight, worldPosition.z);
                    fixedPosY = worldPosition.y + cardLiftHeight;

                    Debug.Log("item selected and lifted");
                }
            }
            else
            {
                // this should probably be a function
                // set it down 
                Debug.Log("Item Deselected");
                Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, assignedCamera.WorldToScreenPoint(selectedObject.transform.position).z);
                Vector3 worldPosition = assignedCamera.ScreenToWorldPoint(position);

                selectedObject.transform.position = new Vector3(worldPosition.x, fixedPosY, worldPosition.z);
                //selectedObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
                selectedObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None; //release constraints to allow drop
                selectedObject = null;
                Cursor.visible = true;

            }
        }
        if (selectedObject != null)
        {
            // if we are dragging a selected object, now move it
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, assignedCamera.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = assignedCamera.ScreenToWorldPoint(position);
            selectedObject.transform.position = new Vector3(worldPosition.x, fixedPosY, worldPosition.z);
            selectedObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY; // make it such that it cant go higher or lower until unclick
            selectedObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation; //prevent rotations

        }

    }
    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            assignedCamera.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            assignedCamera.nearClipPlane);

        Vector3 worldMousePosFar = assignedCamera.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = assignedCamera.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);
        return hit;
    }
}
