﻿#pragma checksum "..\..\FormMsgWPF.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4E00BED793E0774C499CA3C4E5C1FDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WTA_MECH;


namespace WTA_MECH {
    
    
    /// <summary>
    /// FormMsgWPF
    /// </summary>
    public partial class FormMsgWPF : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\FormMsgWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MsgLabelTop;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FormMsgWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MsgLabelBot;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FormMsgWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MsgTextBlockMainMsg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WTA_MECH;component/formmsgwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormMsgWPF.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\FormMsgWPF.xaml"
            ((WTA_MECH.FormMsgWPF)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 11 "..\..\FormMsgWPF.xaml"
            ((WTA_MECH.FormMsgWPF)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 14 "..\..\FormMsgWPF.xaml"
            ((WTA_MECH.FormMsgWPF)(target)).LocationChanged += new System.EventHandler(this.Window_LocationChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\FormMsgWPF.xaml"
            ((System.Windows.Controls.DockPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DockPanel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 18 "..\..\FormMsgWPF.xaml"
            ((System.Windows.Controls.DockPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.DockPanel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MsgLabelTop = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MsgLabelBot = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MsgTextBlockMainMsg = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

