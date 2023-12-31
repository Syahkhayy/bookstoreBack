﻿using Xamarin.Forms.Internals;

namespace PlaygroundDemo.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}