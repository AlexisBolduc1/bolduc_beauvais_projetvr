using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chargementscene : MonoBehaviour
{
    public Animator canvas;

    public void onPress(){
        StartCoroutine("chargerNiveau");
    }

    IEnumerator chargerNiveau(){

    canvas.SetTrigger("debut");
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene(1);
    yield break;
}

}