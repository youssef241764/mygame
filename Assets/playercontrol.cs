using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{


    public float movespeed;
    public float jumpheight;

    public Keycode spacebar;

    public keycode L;
    public Keycode R;
    public Transform groundcheck;
    public float groundcheckRadius;

    public layerMask whatIsGround ;
    private bool grounded;



    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.Getkeydown(spacebar)&& grounded){
            Jump();
        }

        if(Input.Getkey(L)){
            Getcomponent<Rigidbody2D>().velocity = new vector2(movepeed, Getcomponent<Rigidbody2D>().velocity.y);

            if(input.Getkey(R)){
                Getcomponent<Rigidbody2D>.velocity=new vector2(movespeed,Getcomponent<Rigidbody2D>().velocity.y);


            }

            if(Getcomponent<spriterenderer()!=null){
                Getcomponent<spriterenderer().flipx=false;
            }





        }
       
    }

    void felxupdate(){
        grounded=physic2d.overlapcircle(groundcheck.postion,groundcheckRadius,whatIsGround);
    }
    void Jump(){
        Getcomponent<Rigidbody2D>().velocity=new vector2(Getcomponent<Rigidbody2D>().velocity.x, jumpheight);
    }
}
