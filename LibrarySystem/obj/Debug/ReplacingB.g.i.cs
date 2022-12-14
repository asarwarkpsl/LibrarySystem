#pragma checksum "..\..\ReplacingB.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "298D7D510A637D8C41524119DC5812773BA8775D85752082A095C022B17B0C65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibrarySystem;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LibrarySystem {
    
    
    /// <summary>
    /// ReplacingBooks
    /// </summary>
    public partial class ReplacingBooks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstSortedList;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstAvailableBooks;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRight;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeft;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUp;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDown;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValidate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ReplacingB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
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
            System.Uri resourceLocater = new System.Uri("/LibrarySystem;component/replacingb.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReplacingB.xaml"
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
            
            #line 16 "..\..\ReplacingB.xaml"
            ((LibrarySystem.ReplacingBooks)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstSortedList = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.lstAvailableBooks = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.btnRight = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ReplacingB.xaml"
            this.btnRight.Click += new System.Windows.RoutedEventHandler(this.btnRight_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLeft = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ReplacingB.xaml"
            this.btnLeft.Click += new System.Windows.RoutedEventHandler(this.btnLeft_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUp = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ReplacingB.xaml"
            this.btnUp.Click += new System.Windows.RoutedEventHandler(this.btnUp_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDown = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ReplacingB.xaml"
            this.btnDown.Click += new System.Windows.RoutedEventHandler(this.btnDown_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ReplacingB.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnValidate = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\ReplacingB.xaml"
            this.btnValidate.Click += new System.Windows.RoutedEventHandler(this.btnValidate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ReplacingB.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

