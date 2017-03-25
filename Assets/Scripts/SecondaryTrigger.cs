using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SecondaryTrigger : MonoBehaviour {
    public int points = 1;
    List<int> basketBalls = new List<int>(); //hold the IDs of the basketballs expected
    
    public void expectCollision(int instanceID)
    {
        basketBalls.Add(instanceID);
    }
    void OnTriggerEnter(Collider collider)
    {
        int basketBall = collider.gameObject.GetInstanceID();
        if (basketBalls.Contains(basketBall))
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(points);
        }
        else
        {
            print("Ball Unkown");
        }
    }
}

