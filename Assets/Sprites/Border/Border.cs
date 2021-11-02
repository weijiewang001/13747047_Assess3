using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Border : MonoBehaviour
{
    private Image borderImage = default;
    public Sprite[] borderSprites = default;
    private float borderTimer = 0;
    private float borderSpeed = 0.3f;
    int a = 0;
    void Start()
    {
        borderImage = GameObject.FindGameObjectWithTag("border").GetComponent<Image>();
    }

    void Update()
    {
        if (borderTimer > 0)
            borderTimer -= Time.deltaTime;
        if (borderTimer == 0)
        {
            borderImageChange();
            borderTimer = borderSpeed;
        }
        if (borderTimer < 0)
            borderTimer = 0;
    }
    public void borderImageChange()
    {
        if (a < 4)
        {
            borderImage.sprite = borderSprites[a];
            a++;
        }
        else
        {
            a = 0;
            borderImage.sprite = borderSprites[a];
            a++;
        }
    }
}
