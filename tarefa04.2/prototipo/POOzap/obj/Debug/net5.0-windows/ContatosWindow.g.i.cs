﻿#pragma checksum "..\..\..\ContatosWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FB7F2E14174FFF8E402EE31A230C7B28EF27310"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using POOzap;
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


namespace POOzap {
    
    
    /// <summary>
    /// ContatosWindow
    /// </summary>
    public partial class ContatosWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomeC;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telefoneC;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recadoC;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox todosC;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button inserirC;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button atualizarC;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button excluirC;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ContatosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listarC;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/POOzap;component/contatoswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ContatosWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nomeC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.telefoneC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.recadoC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.todosC = ((System.Windows.Controls.ListBox)(target));
            
            #line 34 "..\..\..\ContatosWindow.xaml"
            this.todosC.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.todosC_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.inserirC = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ContatosWindow.xaml"
            this.inserirC.Click += new System.Windows.RoutedEventHandler(this.inserirC_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.atualizarC = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ContatosWindow.xaml"
            this.atualizarC.Click += new System.Windows.RoutedEventHandler(this.atualizarC_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.excluirC = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ContatosWindow.xaml"
            this.excluirC.Click += new System.Windows.RoutedEventHandler(this.excluirC_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listarC = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\ContatosWindow.xaml"
            this.listarC.Click += new System.Windows.RoutedEventHandler(this.listarC_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

