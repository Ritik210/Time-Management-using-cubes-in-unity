using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3 : MonoBehaviour
{
   // public GameObject cube;
    public Material material;
    MinuteTimer time;

    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        time = FindObjectOfType<MinuteTimer>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (time.timer.text == 2.ToString())
        {
            Debug.Log("Working");
            //material.SetColor("color", Color.blue);
            rend.material.color = Color.red;
        }
        else
        {
            rend.material.color = Color.blue;
        }
    }
}
