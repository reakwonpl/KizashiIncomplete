﻿#pragma checksum "..\..\Kizashi.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1B327ACFC4C255D5FE5190FBCBBEB40"
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


namespace Kizashi {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboKierunek;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSpecjalizacja;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSemestr;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PZ;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PW;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_wybierz;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_zatwierdz;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_usun;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Etykieta;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Kizashi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_przedmioty;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication21;component/kizashi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Kizashi.xaml"
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
            this.ComboKierunek = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\Kizashi.xaml"
            this.ComboKierunek.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboKierunek_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboSpecjalizacja = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboSemestr = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.PZ = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.PW = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.btn_wybierz = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Kizashi.xaml"
            this.btn_wybierz.Click += new System.Windows.RoutedEventHandler(this.btn_wybierz_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_zatwierdz = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Kizashi.xaml"
            this.btn_zatwierdz.Click += new System.Windows.RoutedEventHandler(this.btn_zatwierdz_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_usun = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Kizashi.xaml"
            this.btn_usun.Click += new System.Windows.RoutedEventHandler(this.btn_usun_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Etykieta = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_przedmioty = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\Kizashi.xaml"
            this.btn_przedmioty.Click += new System.Windows.RoutedEventHandler(this.btn_przedmioty_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

