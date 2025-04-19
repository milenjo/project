using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 6f;
    public Transform[] checkpoints;
    private int checkpointId = 0;
    float step;
    // Start is called before the first frame update
    void Start()
    {
        step = speed * Time.deltaTime;
        // checkpoints = GameObject.FindGameObjectsWithTag("checkPoint");
    }
    void Update()
    {
        if (checkpointId < checkpoints.Length)
        {
            Transform currentCheckpoint = checkpoints[checkpointId];
            transform.position = Vector3.MoveTowards(transform.position, currentCheckpoint.position, step);
            transform.LookAt(currentCheckpoint.position);

            if (Vector3.Distance(transform.position, currentCheckpoint.position) < 0.25f)
            {
                checkpointId++;
            }
        }
        else
        {
            checkpointId = checkpoints.Length;
            //нанесение урона
            //эффект
            //перемещение к замку 
            //проигрывание анимации
        }
    }
}
