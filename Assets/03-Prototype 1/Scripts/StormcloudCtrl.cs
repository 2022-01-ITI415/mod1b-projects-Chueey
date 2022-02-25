using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormcloudCtrl : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject snowballPrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenSnowballDrops = 1f;

    void Start () {
        Invoke( "DropSnowball", 2f );
    }
    void DropSnowball() {
        GameObject snowball = Instantiate<GameObject>( snowballPrefab );
        snowball.transform.position = transform.position;
        Invoke( "DropSnowball", secondsBetweenSnowballDrops );
    }

    void Update () {
    Vector3 pos = transform.position;
    pos.x += speed * Time.deltaTime;
    transform.position = pos;

   if ( pos.x < -leftAndRightEdge ) {
        speed = Mathf.Abs(speed);
    } else if ( pos.x > leftAndRightEdge ) {
        speed = -Mathf.Abs(speed);
    } else if ( Random.value < chanceToChangeDirections ) {
        speed *= -10;
    }
    } 
    void FixedUpdate () {
        if ( Random.value < chanceToChangeDirections ) {
            speed *= -1;
        }
    }     
}