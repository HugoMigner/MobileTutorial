using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject levelButtonPrefab;
	public GameObject levelButtonContainer;

	private void Start() {
		Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
		foreach(Sprite t in thumbnails){
			GameObject button = Instantiate(levelButtonPrefab) as GameObject;
			button.GetComponent<Image>().sprite = t;
			button.transform.SetParent(levelButtonContainer.transform, false);

			string sceneName = t.name;
			button.GetComponent<Button>().onClick.AddListener(() => LoadLevel(sceneName));
		}
	}

	private void LoadLevel(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
