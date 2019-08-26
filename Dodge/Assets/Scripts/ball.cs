using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector3 pos = Input.GetTouch(0).position;
                Vector3 direction = pos - transform.position;
                transform.position = transform.position + 0.1f * direction.normalized;
            }
        }
        else

        {
            transform.Rotate(1, 0, 1);
            float newX, newY;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                newX = transform.position.x - 0.1f;
                transform.position = new Vector3(newX, transform.position.y, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                newX = transform.position.x + 0.1f;
                transform.position = new Vector3(newX, transform.position.y, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                newY = transform.position.y + 0.1f;
                transform.position = new Vector3(transform.position.x, newY, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                newY = transform.position.y - 0.1f;
                transform.position = new Vector3(transform.position.x, newY, 0);
            }
        }


    }
}
