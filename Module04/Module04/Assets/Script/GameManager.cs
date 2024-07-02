using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static GameManager instance = null;
    public static GameManager Instance => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

	public int			playerHP;
	private int			playerHPMax;
	public GameObject	camera;
	public GameObject	player;
	private Vector3		vectCamera;
	private Animator	animPlayer;
	public bool			alive;
	public bool			toBlack;

	void Start() {
		alive = true;
		playerHPMax = playerHP;
		vectCamera = new Vector3(0, 2, -5);
		animPlayer = player.transform.GetChild(0).GetComponent<Animator>();
	}

	void Update() {
		camera.transform.position = player.transform.position + vectCamera;
		if (toBlack) {
			toBlack = false;
			camera.transform.GetChild(0).GetComponent<Animator>().SetTrigger("toBlack");
		}
	}

	public void	atkPlayer(int atk) {
		playerHP -= atk;
		animPlayer.SetTrigger("takeDamage");
		if (playerHP <= 0) {
			animPlayer.SetTrigger("isDead");
			alive = false;
		}
	}

	public int	getHpMax() {
		return (playerHPMax);
	}
}
