using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrelationDataMiner.bus
{
    public class Frame
    {
        int position;
        double corrSignal, sigOne, sigTwo;
        bool meetsCSReq, meetsS1Req, meetsS2Req;

        public Frame()
        {
            this.position = 0;
            this.corrSignal = 0.0d;
            this.sigOne = 0.0d;
            this.sigTwo = 0.0d;
            this.meetsCSReq = false;
            this.meetsS1Req = false;
            this.meetsS2Req = false;
        }

        /*-------------------------------------------------------------------------------------*/

        public int Position { get => position; set => position = value; }
        public double CorrSignal { get => corrSignal; set => corrSignal = value; }
        public double SigOne { get => sigOne; set => sigOne = value; }
        public double SigTwo { get => sigTwo; set => sigTwo = value; }
        public bool MeetsCSReq { get => meetsCSReq; set => meetsCSReq = value; }
        public bool MeetsS1Req { get => meetsS1Req; set => meetsS1Req = value; }
        public bool MeetsS2Req { get => meetsS2Req; set => meetsS2Req = value; }
    }

}
