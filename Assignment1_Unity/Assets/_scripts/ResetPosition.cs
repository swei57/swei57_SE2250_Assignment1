using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {
    Vector3 initialPosition;
    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
   
  }
    void OnMouseOver()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (Input.GetMouseButtonDown(1)) {
                transform.position = initialPosition;
            }
        }
    }
}
