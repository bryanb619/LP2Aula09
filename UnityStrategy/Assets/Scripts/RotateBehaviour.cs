using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{

    [SerializeField] 
    private float rotSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Animate()
    {
        transform.Rotate(Time.deltaTime * rotSpeed * Vector3.one);
    }
}
