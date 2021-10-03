﻿using Roomies.API.Domain.Models;
using Supermarket.API.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomies.API.Domain.Services.Communications
{
    public class ConversationResponse : BaseResponse<Conversation>
    {
        public ConversationResponse(Conversation resource) : base(resource)
        {
        }

        public ConversationResponse(string message) : base(message)
        {
        }
    }
}
