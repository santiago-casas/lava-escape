using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoin : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision){
	if(collision.CompareTag("Player"))
	{		
	collision.GetComponent<playerRespawn>().ReachedCheckPoint(transform.position.x, transform.position.y);
}
}
}
