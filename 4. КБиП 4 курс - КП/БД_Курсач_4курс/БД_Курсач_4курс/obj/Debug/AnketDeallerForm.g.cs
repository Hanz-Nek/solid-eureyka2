﻿#pragma checksum "..\..\AnketDeallerForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5FF398DC732386C5B8790A9DCFC80131AEE413A73104C856720253966D835C23"
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
using БД_Курсач_4курс;


namespace БД_Курсач_4курс {
    
    
    /// <summary>
    /// AnketDeallerForm
    /// </summary>
    public partial class AnketDeallerForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Ankets_DG;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Ankets_LB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindAnkets_B;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateNew_B;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MakeDeal_B;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_B;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AnketDeallerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAll_B;
        
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
            System.Uri resourceLocater = new System.Uri("/БД_Курсач_4курс;component/anketdeallerform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AnketDeallerForm.xaml"
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
            this.Ankets_DG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Ankets_LB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.FindAnkets_B = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\AnketDeallerForm.xaml"
            this.FindAnkets_B.Click += new System.Windows.RoutedEventHandler(this.FindAnkets_B_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CreateNew_B = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AnketDeallerForm.xaml"
            this.CreateNew_B.Click += new System.Windows.RoutedEventHandler(this.CreateNew_B_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MakeDeal_B = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AnketDeallerForm.xaml"
            this.MakeDeal_B.Click += new System.Windows.RoutedEventHandler(this.MakeDeal_B_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Back_B = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AnketDeallerForm.xaml"
            this.Back_B.Click += new System.Windows.RoutedEventHandler(this.Back_B_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ShowAll_B = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AnketDeallerForm.xaml"
            this.ShowAll_B.Click += new System.Windows.RoutedEventHandler(this.ShowAll_B_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

