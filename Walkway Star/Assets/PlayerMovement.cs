using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator anim;

    public float movementSpeed = 5.0f;
    public float clockwise = 1000.0f;
    public float counterClockwise = -5.0f;

    public bool fallen = false;
    public bool stumbling = false;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;

            // velocity.y += gravity * Time.deltaTime;

            //controller.Move(velocity * Time.deltaTime);

        }
    }

    public void Move()
    {
        if (fallen) return;
        transform.position += transform.forward * movementSpeed * 0.1f;
        StartCoroutine(MoveAnim());
    }

    public void Rotate(int direction = 1)
    {
        transform.Rotate(0, direction * 90, 0);
    }

    public IEnumerator MoveAnim()
    {
        anim.SetFloat("Speed", 1.0f);
        yield return new WaitForSeconds(0.5f);
        anim.SetFloat("Speed", 0.0f);
    }

    public IEnumerator Stumble()
    {
        stumbling = true;
        Debug.Log("started stumbling");
        anim.SetTrigger("Stumble");

        yield return new WaitForSeconds(1.0f);

        if (!fallen)
        {
            Debug.Log("finished stumbling");
        }
        stumbling = false;
    }


    public IEnumerator Fall()
    {
        fallen = true;
        anim.SetTrigger("Fall");
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
