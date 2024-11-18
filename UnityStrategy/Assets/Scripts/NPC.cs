using UnityEngine;

public class NPC : MonoBehaviour
{   

    // instance variable of IAimateBehaviour
    private IAnimateBehaviour behaviour;

    // Get the IAnimateBehaviour component
    private void Awake()
    {   
        // works with reflexion
        behaviour = GetComponent<IAnimateBehaviour>();
    }

    // Update is called once per frame
    private void Update()
    {
        behaviour?.Animate();
    }
}
