using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PruebaSantiManuel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   void awake()
   {
    int variable = 2 + 1;
   }

   void start()
   {
      Debug.Log("Hola");
      int x = 5;
      Debug.Log(x);
   }

   void update()
   {

   }
}






