﻿#pragma checksum "..\..\ToolButton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "464EBEF83D399CF5248F430CAE3DFBD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
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


namespace LongBar {
    
    
    /// <summary>
    /// ToolButton
    /// </summary>
    public partial class ToolButton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\ToolButton.xaml"
        internal System.Windows.Media.TranslateTransform Transfrom;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ToolButton.xaml"
        internal System.Windows.Controls.Grid BgGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ToolButton.xaml"
        internal System.Windows.Shapes.Rectangle Rect1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ToolButton.xaml"
        internal System.Windows.Shapes.Rectangle Rect2;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ToolButton.xaml"
        internal System.Windows.Controls.Image Icon;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ToolButton.xaml"
        internal System.Windows.Controls.TextBlock Caption;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LongBar;component/toolbutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToolButton.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 3 "..\..\ToolButton.xaml"
            ((LongBar.ToolButton)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 3 "..\..\ToolButton.xaml"
            ((LongBar.ToolButton)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Transfrom = ((System.Windows.Media.TranslateTransform)(target));
            return;
            case 3:
            this.BgGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Rect1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.Rect2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.Icon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Caption = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

