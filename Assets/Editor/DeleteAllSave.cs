using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class DeleteAllSave : MonoBehaviour
{
   [MenuItem("Window/Delete PlayerPrefs (All)")]

   static void DeleteAllPlayerPrefs()
   {
        PlayerPrefs.DeleteAll();
   }
}
