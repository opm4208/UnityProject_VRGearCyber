using PM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM
{
    public class Lazer : MonoBehaviour
    {
        Terminal terminal;

        private void Start()
        {
            GetTerminal();
        }
        private void GetTerminal()
        {
            terminal = transform.parent.GetComponentInChildren<Terminal>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                if (terminal != null)
                    StartCoroutine(terminal.CallSecurity(other.transform.position));
            }
        }
    }

}
