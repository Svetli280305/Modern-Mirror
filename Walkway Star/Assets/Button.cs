using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool IsInContact = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInContact = true && Input.GetMouseButtonDown(0))
        {
            Debug.Log("www");
            //Destroy(col.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        IsInContact = true;
        Debug.Log("aaa");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("www");
            Destroy(col.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        IsInContact = false;
    }
}
