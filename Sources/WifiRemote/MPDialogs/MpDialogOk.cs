﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaPortal.Dialogs;
using MediaPortal.GUI.Library;

namespace WifiRemote.MPDialogs
{
    public class MpDialogOk : MpDialog
    {
        private GUIDialogOK dialogMenu;
        public MpDialogOk(MediaPortal.Dialogs.GUIDialogOK menu)
            : base(menu)
        {
            this.dialogMenu = menu;
            this.DialogType = menu.GetModuleName();
            this.DialogId = menu.GetID;
            this.AvailableActions.Add("ok");
            this.AvailableActions.Add("cancel");

            GetHeading(menu, 1);
            GetText(menu, 2, 3, 4, 5);
        }

        /// <summary>
        /// Handle actions which are available on this dialog
        /// </summary>
        /// <param name="action">Action to execute</param>
        /// <param name="index">Index (e.g. needed for lists)</param>
        public override void HandleAction(String action, int index)
        {
            base.HandleAction(action, index);
            if (action.Equals("ok"))
            {
                GUIMessage msg = new GUIMessage(GUIMessage.MessageType.GUI_MSG_CLICKED, 0, 10, 10, 0, 0, null);
                dialogMenu.OnMessage(msg);
            }
        }
    }
}
