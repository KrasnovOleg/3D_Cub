using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Spawn_Cub : MonoBehaviour
{
    public GameObject Cub;
  //  [SerializeField] private float SpeedSpawn = 6;
    [SerializeField] private Text  SpeedSpawntext;
     float SpeedSpawncount ;



    void Start()//спавн предметов
    {


        // SpeedSpawncount = float.Parse(SpeedSpawntext.text);

        // StartCoroutine(SpawnCD());
        StartCoroutine(SpawnCD());
    }




    void Repeat()
    {

        if (float.TryParse(SpeedSpawntext.text, out SpeedSpawncount))
        {
            SpeedSpawncount = float.Parse(SpeedSpawntext.text);
           
        }
 StartCoroutine(SpawnCD());

    }
    IEnumerator SpawnCD()
    {
        

        if (float.TryParse(SpeedSpawntext.text, out SpeedSpawncount))
        {
            Instantiate(Cub, new Vector3(0f, 3f, -11f), Quaternion.identity);
        }            yield return new WaitForSeconds(SpeedSpawncount);// Время задержки спавна

        Repeat();








    }



    private void Update()
    {

        
           
        


    }







}