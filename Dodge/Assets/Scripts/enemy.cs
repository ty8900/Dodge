using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    Vector3 target;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.tag == "wall")
        {
            Vector3 incomingVector = target;
            incomingVector = incomingVector.normalized;
            Vector3 normalVector = new Vector3(0, 0, 0);
            if (collision.gameObject.name == "Cube")
                normalVector = Vector3.right;
            else if (collision.gameObject.name == "Cube (1)")
                normalVector = Vector3.down;
            else if (collision.gameObject.name == "Cube (2)")
                normalVector = Vector3.up;
            else if (collision.gameObject.name == "Cube (3)")
                normalVector = Vector3.left;
            Vector3 reflectVector = Vector3.Reflect(incomingVector, normalVector);
            target = reflectVector.normalized;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.position-transform.position;
        target = target.normalized;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
            //gameObject.SetActive(false);
            Destroy(gameObject,10f);
            transform.position = transform.position + target * 0.2f;
        //Vector3.MoveTowards(transform.position, target, 0.13f);
    }

}
