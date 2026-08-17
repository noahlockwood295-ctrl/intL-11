using UnityEngine;

public abstract class Interactable : MonoBehaviour {
    Collider trigger;

    public abstract void Fire();
}