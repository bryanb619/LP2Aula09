using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float cooldown = 4f;
    private IEnumerable<Superpower> superpowers;

    // Awake is called once before the first execution of Update
    void Awake()
    {
        superpowers = GetComponents<Superpower>();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartMagic());
    }

    private IEnumerator StartMagic()
    {
        YieldInstruction wfs = new WaitForSeconds(cooldown);

        while (true)
        {
            foreach (Superpower sp in superpowers)
            {
                sp.Activate();
            }

            yield return wfs;
            
        }
    }
}