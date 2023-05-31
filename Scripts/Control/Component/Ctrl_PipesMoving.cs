/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 控制层—> 管道组(道具)移动脚本
 *    Description: 
 *           功能：
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVCDemo
{
	public class Ctrl_PipesMoving : MonoBehaviour {
        public float floMovingSpeed = 1F;                   //移动速度
        private Vector2 _VecOriginalPostion;                //原始位置
	    private bool _IsStartGame = false;                  //是否开始游戏


        //游戏开始
	    public void StartGame()
	    {
	        _IsStartGame = true;
	    }

	    //游戏结束
	    public void StopGame()
	    {
            _IsStartGame = false;
            //管道复位
	        ResetPipesPosition();
	    }

	    void Start()
        {
            //保存原始位置
            _VecOriginalPostion = this.gameObject.transform.position;
        }

        void Update()
        {
            if (_IsStartGame)
            {
                //陆地循环移动，到了“临界值”，回复原始方位
                if (this.gameObject.transform.position.x < -20F)
                {
                    this.gameObject.transform.position = _VecOriginalPostion;
                }
                //移动
                this.gameObject.transform.Translate(Vector2.left * Time.deltaTime * floMovingSpeed);            
            }
        }

        /// <summary>
        /// 管道复位
        /// </summary>
	    private void ResetPipesPosition()
        {
            this.gameObject.transform.position = _VecOriginalPostion;
        }

	}
}