﻿#pragma checksum "..\..\..\Views\WeeklyTimetable.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "683B7D05777ADD125AF79860F27A7364"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Class_Management.Views;
using MahApps.Metro.Controls;
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


namespace Class_Management.Views {
    
    
    /// <summary>
    /// WeeklyTimetable
    /// </summary>
    public partial class WeeklyTimetable : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 46 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox teachersList;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid manualTimetable;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Eraser;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Views\WeeklyTimetable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DialogSpace;
        
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
            System.Uri resourceLocater = new System.Uri("/Class Management;component/views/weeklytimetable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\WeeklyTimetable.xaml"
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
            
            #line 9 "..\..\..\Views\WeeklyTimetable.xaml"
            ((Class_Management.Views.WeeklyTimetable)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Views\WeeklyTimetable.xaml"
            ((Class_Management.Views.WeeklyTimetable)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\Views\WeeklyTimetable.xaml"
            this.searchBox.AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.searchBox_Drop));
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\Views\WeeklyTimetable.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.teachersList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.manualTimetable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.Eraser = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\Views\WeeklyTimetable.xaml"
            this.Eraser.Click += new System.Windows.RoutedEventHandler(this.Eraser_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DialogSpace = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseMoveEvent;
            
            #line 15 "..\..\..\Views\WeeklyTimetable.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.Drag);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.DragDrop.DropEvent;
            
            #line 19 "..\..\..\Views\WeeklyTimetable.xaml"
            eventSetter.Handler = new System.Windows.DragEventHandler(this.Cell_Drop);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

