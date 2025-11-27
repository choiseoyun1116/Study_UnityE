using System.Runtime.CompilerServices;
using UnityEngine;

public class Study : MonoBehaviour
{
    public string say = "";
    public char text;
    string newsay = "Hello Maple";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(newsay);
        Debug.Log(this.say);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
