﻿#pragma checksum "..\..\..\Page_program\Page_main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A48CEDFE0FBCB30F87AAC7DC445F46D8B5563A282973EECE709C99FB5B642C81"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practicum2020.Page_program;
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


namespace Practicum2020.Page_program {
    
    
    /// <summary>
    /// Page_main
    /// </summary>
    public partial class Page_main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _main;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _create;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _edit;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _delete;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button expres;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Page_program\Page_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _search;
        
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
            System.Uri resourceLocater = new System.Uri("/Practicum2020;component/page_program/page_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page_program\Page_main.xaml"
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
            this._main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._create = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this._edit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this._delete = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.expres = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this._search = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Page_program\Page_main.xaml"
            this._search.GotFocus += new System.Windows.RoutedEventHandler(this._search_GotFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Page_program\Page_main.xaml"
            this._search.LostFocus += new System.Windows.RoutedEventHandler(this._search_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
