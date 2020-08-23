using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 0;
    int num ;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(200, 250);



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
            
        }
        if (gameObject.tag == "Blue" && i == num)
        {

            gameObject.GetComponentInChildren<Renderer>().enabled = false;
        }


    }

}
