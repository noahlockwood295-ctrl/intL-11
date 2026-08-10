using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractivity : MonoBehaviour {
    bool inTriggerArea;
    InputAction context;

    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        var interactable = other.GetComponent<Interactable>();

        if (interactable) {
            interactable.Fire();
        }
    }
}