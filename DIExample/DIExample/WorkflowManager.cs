using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{

    interface ICardReader
    {
        string Getcard();
    }
    interface IFaceManager
    {
        bool isFaceValid();
    }
    interface IGateManager
    {
        void OpenGate();
        void CloseGate();

    }
    class WorkflowManager
    {

        private IFaceManager faceManager;
        private IGateManager gateManager;
        private ICardReader cardReader;

        public void Start()
        {
            while (true)
            {
                string card = cardReader.GetCard();
                gateManager.OpenGate();
                // read card
                //validate card
                //validate face        
                //validate fingerprint
                //open gate
            }
        }

        public WorkflowManager( IFaceManager faceManager,IGateManager gateManager,ICardReader cardReader)
        {
            this.faceManager = faceManager;
            this.gateManager = gateManager;
            this.cardReader = cardReader;
        }
    }
}
