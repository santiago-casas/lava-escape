using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
	
public class playerRespawn : MonoBehaviour
{
	public Animator animator;
	public GameObject[] hearts;
	private int life;
    private float checkPointPositionX, checkPointPoisitionY;
	public LifeCounter lifesLeft;
	void Start(){
	life = hearts.Length;	
	
	if(PlayerPrefs.GetFloat("checkPointPositionX")!=0)
		{
		transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPoisitionY")));
		}
	}
	private void CheckLife(){
		//animator.SetBool("Hit", true);
		Debug.Log("hit");
		if(life<1){
		
		Destroy(hearts[0].gameObject);
		//Destroy(GameObject.FindWithTag("Player"));
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		lifesLeft.MinusLife();
		
		//lifesLeft.GetComponent<LifeCounter>().MinusLife();
		}
		else if(life<2)
		{
		Destroy(hearts[1].gameObject);
		
		}
		else if(life<3)
		{
			
		Destroy(hearts[2].gameObject);
		
		}
		//animator.SetBool("Hit", false);
}

	public void ReachedCheckPoint(float x, float y){
	PlayerPrefs.SetFloat("checkPointPositionX",x);
	PlayerPrefs.SetFloat("checkPointPoisitionY",y);
	//poner el de la laba
}
	public void PlayerDamaged(){
	life--;
	CheckLife();
	
}

	public void PlayerInstaDead(){
	life=0;
	Destroy(hearts[0].gameObject);	
	Destroy(hearts[1].gameObject);
	Destroy(hearts[2].gameObject);
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
