/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 控制层--> 陆地移动
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
using SUIFW;
using UnityEngine;

namespace PureMVCDemo
{
	public class Ctrl_LandMoving : MonoBehaviour
	{
	    public float floMovingSpeed = 1F;                   //陆地移动速度
	    private Vector2 _VecOriginalPostion;                //陆地原始位置
        //测试
	    //private int intTestNumber = 0;

		void Start ()
		{
            //Log.Write("普通脚本LandMoving=" + this.GetHashCode());
			//保存陆地原始位置
		    _VecOriginalPostion = this.gameObject.transform.position;
		}

        void Update()
        {
            //intTestNumber++;
            //Log.Write("LandMoving.cs/Update() intTestNumber" + intTestNumber);

            //陆地循环移动，到了“临界值”，回复原始方位
            if (this.gameObject.transform.position.x<-5F)
            {
                this.gameObject.transform.position = _VecOriginalPostion;
            }
            //移动
            this.gameObject.transform.Translate(Vector2.left*Time.deltaTime*floMovingSpeed);
        }

        
		
	}
}