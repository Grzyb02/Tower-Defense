using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject kafel;
    public float krawedz;
    void Start()
    {
      StworzPlansze(); 
    }

    void Update()
    {
        
    }

    private void StworzPlansze()
    {
        krawedz = kafel.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        for (int y = 0; y<5; y++)
        {

            for (int x = 0; x<5; x++)
            {
                Vector3 siatka_budowa = new Vector3 (krawedz * x, krawedz * y, 0);
                Instantiate(kafel, siatka_budowa, Quaternion.identity);
            }
        }
    }  
}
