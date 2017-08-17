using UnityEngine;

public class Interactable : MonoBehaviour {

    //How close the player needs to be to interact with object
    public float radius = 3f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);


    }
}
