using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExercisesClass9Library
{
    public delegate void DelegateMessage(string message);
    public class Trainer
    {
        
        public event DelegateMessage EventHandler;
        
        public void SendMessage(string message)
        {
            EventHandler?.Invoke(message);
        }

        public void ComposeMessage(string trainerName, int groupNum, string message)
        {
            Thread.Sleep(3000);
            SendMessage($"{trainerName} informs G{groupNum}: {message}");
        }
    }
}
