using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEditor;

public static class Extensoes 
{
   
    public static void EscalarObjeto(this Transform t, float tamanho = 1.2f)
    {
        t.localScale = Vector3.one * tamanho;
    }

    public static item RandomizarItem<item>(this List<item> list)
    {
       return list[Random.Range(0,list.Count)];
        
    }

}
