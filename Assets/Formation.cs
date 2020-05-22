using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formation : MonoBehaviour
{

    private Shape shape;
    private List<Unit> units;
    private int spawnCount;



    // Start is called before the first frame update
    void Start()
    {
        
    }



    void StartFormation(List<Unit> units, bool new_units ){
        if(new_units){
            //Se juega una nueva carta de invocacion en donde todas las unidades arrancan
            // en algun punto del shape, comenzando desde el primero al ultimo

        }else{
            //recorrer uno por uno cada uno de los puntos
            //recorrer uno a uno cada una de las unidades 
            //verificar 

            


        }

    }




    // Update is called once per frame
    void Update()
    {
        
    }


    void ClearUnits(int position){
        units.RemoveAt(position);
        RearrengeUnits();
    }

    void RearrengeUnits(){
        //Si la cantidad de unidades del ultimo recuento es menor a la cantidad que quedan en la lista , 
        //reordeno las unidades .
        if(spawnCount < units.Count){
            

        }
    }
}
