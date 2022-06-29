using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
        Invoke("LoadMenu", 5f);
    }

    void Update()
    {
        if (Time.time > 1)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1f, 1f, 1f),
            speed * Time.deltaTime);
        }
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}