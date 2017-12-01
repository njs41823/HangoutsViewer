﻿using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class VoicemailEvent : HangoutEvent, IVoicemailEvent
    {
        public VoicemailEvent(DateTime timeStamp, IParticipant sender, string text, string attachment) : base(timeStamp, sender, text, attachment)
        {
        }
    }
}
