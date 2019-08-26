using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timecount = 0;
    int count = 0;
    int ctr=0;
    // Update is called once per frame
    void Update()
    {
        ctr = GameObject.Find("Gamemanager").GetComponent<Gamemanager>().ctr;
        timecount += Time.deltaTime;
            if (timecount > 1)
            {
                //Objectmanager.instance.GetBullet(transform.position);
                Instantiate(enemy, transform.position, Quaternion.identity);
                timecount = 0;
                count++;
            }
            if (count == 3 && ctr<20)
            {
                count = 0;
            if (ctr > 10)
                timecount = -1;
            else
                timecount = -3;
            }
            else if(count == 5 && ctr<20)
            {
            count = 0;
            timecount = -1;
          
            }
        
    }
}
