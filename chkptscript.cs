using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chkptscript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroyZombies());
    }
    IEnumerator DestroyZombies()
    {
        yield return new WaitForSeconds(5f);
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
        foreach(GameObject g in zombies)
        {
            Destroy(g);
        }
    }
}
