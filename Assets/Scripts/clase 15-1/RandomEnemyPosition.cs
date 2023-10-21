using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemyPosition : MonoBehaviour
{
    public GameObject prefabEnemy;
    public int numberOfEnemies = 4;
       
    
    // Start is called before the first frame update
    void Start()
    {
        RandomPosition();
        Destroy(gameObject);
    }

   void RandomPosition()
    {

        for (int i = 0; i < numberOfEnemies; i++)
        {
            float incrementoPosicionX = Random.Range(-10f, 10f);
            float incrementoPosicionZ = Random.Range(-10f, 10f);

            Vector3 origenEnemigoModificado = new Vector3(transform.position.x + incrementoPosicionX, transform.position.y, transform.position.z + incrementoPosicionZ);
            Instantiate(prefabEnemy, origenEnemigoModificado, transform.rotation);
        }
    }
}
