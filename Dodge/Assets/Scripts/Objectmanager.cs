using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmanager : MonoBehaviour
{
    public static Objectmanager instance;
    public GameObject enemy;
    List<GameObject> bullets = new List<GameObject>();

    private void Awake()
    {
        if(Objectmanager.instance == null)
        {
            Objectmanager.instance = this;
        }
    }
    // Start is called before the first frame update
    void Start() => CreateBullets(4);
    void CreateBullets(int bulletcount)
    {
        for(int i=0;i<bulletcount;i++)
        {
            GameObject bullet = Instantiate(enemy) as GameObject;

            bullet.transform.parent = transform;
            bullet.SetActive(false);

            bullets.Add(bullet);
        }
    }
    public GameObject GetBullet(Vector3 pos)
    {
        GameObject reqBullet = null;
        for(int i=0;i<bullets.Count;i++)
        {
            if (bullets[i].activeSelf == false)
            {
                reqBullet = bullets[i];

                break;
            }
        }
        if(reqBullet == null)
        {
            GameObject newBullet = Instantiate(enemy) as GameObject;
            newBullet.transform.parent = transform;
            bullets.Add(newBullet);
            reqBullet = newBullet;
        }
        reqBullet.SetActive(true);
        reqBullet.transform.position = pos;
        return reqBullet;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
