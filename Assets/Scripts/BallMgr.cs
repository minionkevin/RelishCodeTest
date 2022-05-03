using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMgr : MonoBehaviour
{
    [SerializeField]
    private int amount;
    [SerializeField]
    private GameObject ballPre;
    [SerializeField]
    private Material purpleMat;
    private GameObject[] ballArr;
    // Start is called before the first frame update
    void Start()
    {
        ballArr = new GameObject[amount];
        for(int i = 0; i< amount;i++)
        {
            int holder = i + 1;
            GameObject temp = GameObject.Instantiate(ballPre,new Vector3(Random.Range(-20, 20), Random.Range(10, 30), Random.Range(-20, 20)),this.transform.rotation);
            temp.name = "Ball" + holder;

            temp.GetComponent<Ball>().setID(holder);

            if(holder%3 == 0)
            {
                temp.GetComponent<Renderer>().material.color = Color.red;
            }
            if(holder%5 ==0)
            {
                temp.GetComponent<Renderer>().material.color = Color.blue;
            }
            if(holder%15==0)
            {
                temp.GetComponent<Renderer>().material = purpleMat;
            }
        }
    }
}
