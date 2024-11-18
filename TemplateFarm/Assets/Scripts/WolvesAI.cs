using UnityEngine;

public class WolvesAI : AnimalsAI
{
    protected override void SelectTarget()
    {
        Debug.Log("Wolf is selecting target");
    }

    protected override void Move() => Debug.Log("Wolf is moving");

    protected override void TryEat() => Debug.Log("Wolf is eating");

    protected override void TryReproduce() => Debug.Log("Wolf is reproducing");

}
