using UnityEngine;
using System.Collections;
public class PrimaryTrigger : MonoBehaviour {
    SecondaryTrigger SecondaryTrigger;
    private void OnTriggerEnter(Collider collider)
    {
        //print(collider.gameObject.name);
        if (collider.gameObject.name == "ball(Clone)")
        {
            SecondaryTrigger = GetComponentInChildren<SecondaryTrigger>();
            SecondaryTrigger.expectCollision(collider.gameObject.GetInstanceID());
        }
    }
}