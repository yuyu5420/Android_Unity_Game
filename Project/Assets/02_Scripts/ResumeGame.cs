﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeGame : MonoBehaviour
{
    public Transform canvas;
    public Transform canvas2;

    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Debug.Log("Button Clicked. ClickHandler.");
        resume();
    }
    public void resume()
    {
      
            canvas.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(false);
            Time.timeScale = 1;
            //UnityChan.GetComponent<CharacterController>().enabled = true;
        
    }
}