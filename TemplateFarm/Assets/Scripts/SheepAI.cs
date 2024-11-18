using System;
using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move() => Debug.Log("Sheep is moving");


    protected override void TryEat() => Debug.Log("Sheep is eating");
  

    protected override void TryReproduce() => Debug.Log("Sheep is reproducing");
}
