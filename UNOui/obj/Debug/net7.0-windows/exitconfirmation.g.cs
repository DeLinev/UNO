﻿#pragma checksum "..\..\..\exitconfirmation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB1F26836D5E416EA33A9124414925C6354EC2ED"
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
using System.Windows.Controls.Ribbon;
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
using UNOui;


namespace UNOui {
    
    
    /// <summary>
    /// exitconfirmation
    /// </summary>
    public partial class exitconfirmation : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\exitconfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock maintextblock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\exitconfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelbutton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\exitconfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbutton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UNOui;component/exitconfirmation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\exitconfirmation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\exitconfirmation.xaml"
            ((UNOui.exitconfirmation)(target)).Loaded += new System.Windows.RoutedEventHandler(this.loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.maintextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cancelbutton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\exitconfirmation.xaml"
            this.cancelbutton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.mouseleave);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\exitconfirmation.xaml"
            this.cancelbutton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.mouseenter);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\exitconfirmation.xaml"
            this.cancelbutton.Click += new System.Windows.RoutedEventHandler(this.cancel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exitbutton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\exitconfirmation.xaml"
            this.exitbutton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.mouseleave);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\exitconfirmation.xaml"
            this.exitbutton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.mouseenter);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\exitconfirmation.xaml"
            this.exitbutton.Click += new System.Windows.RoutedEventHandler(this.exit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

