using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBoxAngle : MonoBehaviour {

    // Use this for initialization
    void Start () {
       // transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void OnMouseOver() {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            if (Input.GetMouseButtonDown(0))
            {
                //rotate the box in random coordinates when click on by the mouse
                transform.eulerAngles = new Vector3(Random.Range(180.0f, 188.0f), Random.Range(0.0f, 360.0f), Random.Range(180.0f, 188.0f));
            }
        }
    }
}
