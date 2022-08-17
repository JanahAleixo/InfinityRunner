using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    public float positionPlayer;
    private float timer = 0f;
    public List <GameObject> prefabs;
    public List <GameObject> prefabsCoin;
    
    void Start()
    {
   
    }

    
    void Update()
    {
        timer += Time.deltaTime;

      if(GameObject.FindGameObjectWithTag("Player") != null && timer > 1.5f)
       {
            List<int> listY = new List<int>(){0,1,2};
            int index = Random.Range(0,2);
            int yprefab = Random.Range(0,3);
            float randomY = 0f;

            if(yprefab == 0)
            {
                randomY = prefabs[index].GetComponent<PrefabPositions>().ymin;
            }
            else if(yprefab == 1)
            {
                randomY = prefabs[index].GetComponent<PrefabPositions>().ymax;
            }
            else if(yprefab == 2)
            {
                randomY = prefabs[index].GetComponent<PrefabPositions>().ymid;
            }
            listY.RemoveAt(yprefab);
            int indexCoin = Random.Range(0,2);
            int yCoin = Random.Range(0,listY.Count);
            yCoin = listY[yCoin];
            float randomYCoin = 0f;
            if(yCoin == 0)
            {
                randomYCoin = prefabsCoin[indexCoin].GetComponent<PrefabPositions>().ymin;
            }
            else if(yCoin == 1)
            {
                randomYCoin = prefabsCoin[indexCoin].GetComponent<PrefabPositions>().ymax;
            }
            else if(yCoin == 2)
            {
                randomYCoin = prefabsCoin[indexCoin].GetComponent<PrefabPositions>().ymid;
            }
            positionPlayer = GameObject.FindGameObjectWithTag("Player").transform.position.x;
            Instantiate(prefabsCoin[indexCoin], new Vector3(positionPlayer+20f, randomYCoin, 1f), prefabsCoin[indexCoin].transform.rotation);
            Instantiate(prefabs[index], new Vector3(positionPlayer+20f, randomY, 1f), prefabs[index].transform.rotation);
            timer = 0f;
        }
        
    }
}
