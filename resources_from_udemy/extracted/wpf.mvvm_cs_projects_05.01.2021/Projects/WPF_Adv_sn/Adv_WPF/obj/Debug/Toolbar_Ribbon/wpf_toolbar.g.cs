﻿#pragma checksum "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA80CCB999736A9170FD67C3A80EE8864B05EAEE9205B9AE757BB56BFAB37650"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Adv_WPF.Toolbar_Ribbon;
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


namespace Adv_WPF.Toolbar_Ribbon {
    
    
    /// <summary>
    /// wpf_toolbar
    /// </summary>
    public partial class wpf_toolbar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button undo_butt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button copy_butt;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cut_butt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button paste_butt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button img_copy_butt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button img_cut_butt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button img_paste_butt;
        
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
            System.Uri resourceLocater = new System.Uri("/Adv_WPF;component/toolbar_ribbon/wpf_toolbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
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
            this.undo_butt = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
            this.undo_butt.Click += new System.Windows.RoutedEventHandler(this.undo_butt_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.copy_butt = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
            this.copy_butt.Click += new System.Windows.RoutedEventHandler(this.copy_butt_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cut_butt = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
            this.cut_butt.Click += new System.Windows.RoutedEventHandler(this.cut_butt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.paste_butt = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Toolbar_Ribbon\wpf_toolbar.xaml"
            this.paste_butt.Click += new System.Windows.RoutedEventHandler(this.paste_butt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.img_copy_butt = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.img_cut_butt = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.img_paste_butt = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
