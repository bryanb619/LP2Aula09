using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{
    [SerializeField] 
    private float scaleSpeed = 10f;

    public void Animate()
    {
        transform.localScale = Vector3.one * Mathf.Cos(scaleSpeed * Time.time);
    }
}
