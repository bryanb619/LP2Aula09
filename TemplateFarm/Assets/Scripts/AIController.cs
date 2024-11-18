using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private IEnumerable<AnimalsAI> animalsAI;

    /// <summary>
    /// Start is called once before the first execution of Update after the MonoBehaviour is created
    /// </summary>
    private void Start()
    {
        animalsAI = new AnimalsAI[] { new WolvesAI(), new SheepAI() };

        // corontna no unity chama o método move next
        
        StartCoroutine(TakeTurns());
    }

    private IEnumerator TakeTurns()
    {

        YieldInstruction wait = new WaitForSeconds(2f); 

        while (true)
        {
            foreach (AnimalsAI ai in animalsAI)
            {
                ai.TakeTurn();
            }

            yield return wait;
        }
    }
}
