using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade2 : MonoBehaviour
{
    /*public Text myText;
    void Start()
    {
        myText.text = "This is my text";
    }*/
    public float max = 1f;
    public float speed = 5.0f;

    public SpriteRenderer sprite;

    void Update()
    {
        sprite.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time * speed, max));
    }
}