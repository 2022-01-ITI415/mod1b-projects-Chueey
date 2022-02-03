using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Start is called before the first frame update
    public GameObject applePrefab;
    
    public float    speed = 1f;
   
    public float    leftAndRightEdge = 10f;
    
    public float    chanceToChangeDirections = 0.1f;
    
    public float    secondsBetweenAppleDrops = 1f;

void Update () {
    Vector3 pos = transform.position;
    pos.x += speed * Time.deltaTime;
    transform.position = pos;
}
}
