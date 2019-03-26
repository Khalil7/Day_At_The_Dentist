// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using DG.Tweening;
using UnityEngine;



namespace HoloToolkit.Unity.InputModule.Examples.Grabbables
{
    /// <summary>
    /// This type of grab makes the grabbed object a child of the grabber.
    /// This ensures a grabbed object perfectly follows the position and rotation of the grabbing object
    /// </summary>
    public class GrabbableChild : BaseGrabbable
    {
        public AudioClip audioClip;
        public AudioSource source;
        public bool isToothbrush;
        public string tool;
        public GameObject toolTaskScript;
        public Vector3 origPosition;
        public Quaternion origRotation;

        protected override void StartGrab(BaseGrabber grabber)
        {
            origPosition = transform.position;
            origRotation = transform.rotation;

            if (!isToothbrush)
            {
                AudioClipSet();
                source.spatialBlend = 1;
                source.Play();
                transform.DOShakeRotation(30f, 3f, 20, 90f).Loops();
            }
    
            base.StartGrab(grabber);
            transform.SetParent(GrabberPrimary.transform);
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            toolTaskScript.GetComponent<ToolTaskScript>().doTask(tool);
        }

        protected override void EndGrab()
        {
            if (!isToothbrush)
            {
                source.Stop();
                source.spatialBlend = 0;
                DOTween.Clear();
            }
            transform.SetParent(null);
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            base.EndGrab();
            transform.position = origPosition;
            transform.rotation = origRotation;
        }

        protected override void AttachToGrabber(BaseGrabber grabber)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            if (!activeGrabbers.Contains(grabber))
                activeGrabbers.Add(grabber);
        }

        protected override void DetachFromGrabber(BaseGrabber grabber)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
        }

        public void AudioClipSet()
        {
            source.clip = audioClip;
            source.loop = true;
        }

    }
}
