﻿#pragma checksum "..\..\Connect.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C7AB69CD273CAB69065AAF44585649B65DC151BB905003E983DC44C3D5EEB07"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Connect
    /// </summary>
    public partial class Connect : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp1.Connect Form2;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button joinButton;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button regButton;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowPassword;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\Connect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordTXTBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/connect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Connect.xaml"
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
            this.Form2 = ((WpfApp1.Connect)(target));
            
            #line 8 "..\..\Connect.xaml"
            this.Form2.Closing += new System.ComponentModel.CancelEventHandler(this.Form2_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\Connect.xaml"
            this.LoginBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.LoginBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 107 "..\..\Connect.xaml"
            this.LoginBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LoginBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.joinButton = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\Connect.xaml"
            this.joinButton.Click += new System.Windows.RoutedEventHandler(this.joinButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.regButton = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\Connect.xaml"
            this.regButton.Click += new System.Windows.RoutedEventHandler(this.regButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ShowPassword = ((System.Windows.Controls.CheckBox)(target));
            
            #line 113 "..\..\Connect.xaml"
            this.ShowPassword.Checked += new System.Windows.RoutedEventHandler(this.ShowPassword_Checked);
            
            #line default
            #line hidden
            
            #line 113 "..\..\Connect.xaml"
            this.ShowPassword.Unchecked += new System.Windows.RoutedEventHandler(this.ShowPassword_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.passwordTXTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
