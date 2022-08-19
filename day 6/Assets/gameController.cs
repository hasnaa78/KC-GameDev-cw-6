using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public Transform spwn;
    public Transform spwnLeft;
    public Transform spwnRight;
    public GameObject Enemy;

    public float delay;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("spwnEnemy", 0f , delay);    
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spwnEnemy()
    {
        int rendNum = Random.Range(1, 4); //1 or 2 or 3
        if (rendNum == 1)
        {
            Instantiate(Enemy, spwnLeft);
        }
        else if (rendNum == 2)
        {
            Instantiate(Enemy, spwn);
        }
        else
        {
            Instantiate(Enemy, spwnRight);
        }
    }
}
