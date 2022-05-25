using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {

    void Start () {}
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        Destroy(gameObject);
        ScoreTextScript.coinAmount += 3;
    }
    // Update is called once per frame
    void Update () {
}
}