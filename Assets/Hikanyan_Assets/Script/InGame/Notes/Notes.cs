using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hikanyan.Core
{
    public class Notes : MonoBehaviour
    {
        public float NotesTime;
        public int _block = 0;
        public bool _visible = false;
        public bool _disable = false;
        public void SetVisible(bool visible)
        {
            if (visible)
            {
                this.gameObject.SetActive(true);
                _visible = true;
            }
            else
            {
                this.gameObject.SetActive(false);
                _visible = false;
                transform.position = new(-10, 0, 0);
            }
        }
        public void SetNotesPos(float posz)
        {
            this.transform.position = new Vector3(posz, transform.position.y, transform.position.z);
        }
    }
}