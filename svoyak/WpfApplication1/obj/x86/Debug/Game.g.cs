﻿#pragma checksum "..\..\..\Game.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4F4F1DE5281FC836FED65203A9E81FDEECFA23FA"
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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AnswerBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image playerAvatar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scorelabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ingamename;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cost;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement audioquest;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image questimage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox siq;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar PG;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/game.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Game.xaml"
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
            
            #line 4 "..\..\..\Game.xaml"
            ((WpfApplication1.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.AnswerBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Game.xaml"
            this.AnswerBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.AnswerBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.playerAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.scorelabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ingamename = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cost = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.questionbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.audioquest = ((System.Windows.Controls.MediaElement)(target));
            
            #line 24 "..\..\..\Game.xaml"
            this.audioquest.MediaEnded += new System.Windows.RoutedEventHandler(this.audioquest_MediaEnded);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Game.xaml"
            this.audioquest.MediaOpened += new System.Windows.RoutedEventHandler(this.audioquest_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 10:
            this.questimage = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.siq = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\..\Game.xaml"
            this.siq.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.siq_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.PG = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

