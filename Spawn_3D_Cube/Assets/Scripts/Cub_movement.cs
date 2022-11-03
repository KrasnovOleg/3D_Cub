using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cub_movement : MonoBehaviour
{
     float speedCub ;
    float Drop;
     public Text Speed;
    public Text DropText;

    public GameObject Cub;


    
    void Update()
    {
        Speed = GameObject.Find("SpeedText").GetComponent<Text>();
        DropText = GameObject.Find("DropText").GetComponent<Text>();

        speedCub = float.Parse( Speed.text);
        Drop = float.Parse(DropText.text);



        if (transform.position.z > 44|| transform.position.z >Drop)// Удаление объекта
            Destroy(Cub);
        Cub.transform.Translate(0, 0, speedCub * Time.deltaTime);

    }
}
