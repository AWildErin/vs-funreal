﻿using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace FUnreal
{
    public partial class AddSourceFileDialog : DialogWindow
    {
        public Func<Task> OnConfirmAsync { get; set; }
        public Func<Task> OnFileNameChangeAsync { get; set; }
        
        public AddSourceFileDialog()
            : base()
        {
            InitializeComponent();

            fileNameTbx.IsEnabled = true;

            addButton.IsEnabled = false;
            cancelButton.IsEnabled = true;
            HideError();

            taskProgressPanel.IsRendered = false;
            taskProgressPanel.IsExpanded = false;
        }

        private void okButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OnConfirmAsync?.Invoke().FireAndForget();
        }

        private void classNameTbxChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            OnFileNameChangeAsync?.Invoke().FireAndForget();
        }

        private void inputText_Validation(object sender, System.Windows.Input.TextCompositionEventArgs e) 
            => XDialogLib.TextBox_FileNameWithExt_InputValidation(sender, e);

        public void HideError()
        {
            errorMsgLbl.Content = "";
            errorMsgLbl.Visibility = System.Windows.Visibility.Hidden;
        }

        public void EditModeEnabled(bool enabled)
        {
            fileNameTbx.IsEnabled = enabled;
            addButton.IsEnabled = enabled;
            cancelButton.IsEnabled = enabled;
        }

        public void ShowActionInProgress()
        {
            EditModeEnabled(false);

            taskProgressPanel.IsRendered = true;
            taskProgressPanel.IsExpanded = false;
        }

        public void ShowActionInError()
        {

            EditModeEnabled(true);

            ShowError(XDialogLib.ErrorMsg_SomethingWentWrong);

            taskProgressPanel.IsRendered = true;
            taskProgressPanel.IsExpanded = true;
        }

        public void SetProgressMessage(FUnrealNotifier.MessageType Type, string headMessage, string traceMessage)
        {
            string prefix = $"[{Type}]";
            string trace = $"{prefix} {traceMessage}";
            taskProgressPanel.AddMessage(headMessage, trace);
        }

        public void ShowError(string msg)
        {
            errorMsgLbl.Content = msg;
            errorMsgLbl.Visibility = System.Windows.Visibility.Visible;
        }

    }
}
