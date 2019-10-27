using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUper : MonoBehaviour
{
    Vector3 startPos, startDir;
    const float RAY_DIST_MAX = 3.0f;

    public void Init ()
    {
        startPos = this.transform.position;
        startDir = this.transform.forward;
    }

    public void ManagedUpdate ()
    {
        startPos = this.transform.position;
        startDir = this.transform.forward;

        Debug.DrawRay(startPos,startDir * RAY_DIST_MAX,Color.green,0.5f);

        if (Input.GetKeyDown (KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            RayCheck ();
        }
    }

    void RayCheck ()
    {
        RaycastHit hit;
        if (Physics.Raycast (startPos, startDir, out hit, RAY_DIST_MAX))
        {
            GameObject obj = hit.collider.gameObject;
            if (obj.GetComponent<Grabable> () != null)
            {
                PickUp (obj);
            }
        }
    }

    void PickUp (GameObject obj)
    {
        obj.GetComponent<Grabable> ().Grabable ();
        Debug.Log ("Grabed!");
    }

}