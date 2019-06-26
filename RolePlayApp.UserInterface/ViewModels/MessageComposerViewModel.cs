using RolePlayApp.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayApp.UserInterface.ViewModels
{
    class MessageComposerViewModel
    {
        public MessageComposerViewModel (MessageComposer composer)
        {
            Composer = composer;
        }

        public MessageComposer Composer { get; private set; }
    }
}
