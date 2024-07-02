using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnim : MonoBehaviour
{
	public void	deathToAlive() {
		GameManager.Instance.toBlack = true;
	}

	public void aliveToIdle() {
		GameManager.Instance.playerHP = GameManager.Instance.getHpMax();
		GameManager.Instance.alive = true;
	}
}
