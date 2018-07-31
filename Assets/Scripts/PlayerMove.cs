using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
   // [SerializeField] private GameObject restartPosition;
    //[SerializeField] private bool resetLevel = false;

    private Rigidbody2D rbd;

    private void Start()
    {
        rbd = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveDir = new Vector2(moveX, moveY);

        rbd.AddForce(moveDir * moveSpeed);
    }

    /*private void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Reset")
        {
            if (resetLevel == false)
            {
                transform.position = restartPosition.transform.position;
                rbd.Sleep();
            }
            else
            {
                SceneManager.LoadScene(0);
            }

        }
    }*/
}
