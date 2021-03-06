﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public string currentMapName; // transferMap 스크립트에 있는 transferMapName 변수의 값을 저장

    public float speed;

    private Vector3 vector;

    public float runSpeed;
    private float applyRunSpeed;
    private bool applyRunFlag = false;

    public int walkCount;
    private int currentWalkCount;

    private bool canMove = true;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    IEnumerator MoveCoroutine()
    {
        
        
         if (Input.GetKey(KeyCode.LeftShift))
         {
             applyRunSpeed = runSpeed;
             applyRunFlag = true;

         }
         else
         {
             applyRunSpeed = 0;
             applyRunFlag = false;
         }

         vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

         while (currentWalkCount < walkCount)
         {
             if (vector.x != 0)
             {
                 transform.Translate(vector.x * (speed + applyRunSpeed), 0, 0);
             }
             else if (vector.y != 0)
             {
                 transform.Translate(0, vector.y * (speed + applyRunSpeed), 0);
             }
             if (applyRunFlag)
                 currentWalkCount++;
             currentWalkCount++;

             yield return new WaitForSeconds(0.01f);
         }
         currentWalkCount = 0;
         canMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());
            }
        }
        
    }
}
