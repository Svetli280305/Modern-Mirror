using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool IsInContact = false;
    bool mouseIsOver = false;

    // Start is called before the first frame update
    GameObject lastTouched;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CleanUp")
        {
            lastTouched = collision.gameObject;
            IsInContact = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "CleanUp")
        {
            lastTouched = null;
            IsInContact = false;
        }
    }

    public void Clicked()
    {
        if (IsInContact && (lastTouched != null))
        {
            Destroy(lastTouched);
            FindObjectOfType<ScoreBoard>().AddPoint();
        }
    }
}
