using System;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private float TimeBetweenEnemies = 5f;
    private float TimeSpan = 0f;
    [SerializeField] private GameObject enemy;
    private float timeInterval;

    public Stack<GameObject> EnemiesStack = new Stack<GameObject>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= TimeSpan)
        {
            if(EnemiesStack.Count == 0)
            {
                GameObject enem = Instantiate(enemy);
                enem.GetComponent<enemy>()._spawner = this;
            }
            else
            {
                GameObject enem = EnemiesStack.Pop();
                Debug.Log("Reusing enemy from stack");
                enem.SetActive(true);
                enem.transform.position = transform.position;
            }
            
            TimeSpan = Time.time + TimeBetweenEnemies;
            Debug.Log(Time.time);
        }
    }

    // Enemies stack

}