using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour 
{
	[SerializeField] private GameObject escapeMenu;

	private void Start ()
	{
		escapeMenu.SetActive(false);
		Time.timeScale = 1;
	}

	private void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (escapeMenu.activeInHierarchy == false)
			{
				escapeMenu.SetActive(true);
				Time.timeScale = 0;
			}
			else
			{
				escapeMenu.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}

	public void ResumeGame ()
	{
		escapeMenu.SetActive(false);
		Time.timeScale = 1;
	}

	public void GoToMainMenu ()
	{
		SceneManager.LoadScene(0);
	}
}