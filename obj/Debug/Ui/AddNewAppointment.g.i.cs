﻿#pragma checksum "..\..\..\Ui\AddNewAppointment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A9851B7EB5135062455FCAFB2EEE0FC05D1C4C9F457DE1B6E32AF2E3124FF52"
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;
using Zadanie_4.Ui;


namespace Zadanie_4.Ui {
    
    
    /// <summary>
    /// AddNewAppointment
    /// </summary>
    public partial class AddNewAppointment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Localizations;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Specializations;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Specialists;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DateTimePicker OccurenceDate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AvailableAppointments;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Ui\AddNewAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAppointment;
        
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
            System.Uri resourceLocater = new System.Uri("/Zadanie_4;component/ui/addnewappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ui\AddNewAppointment.xaml"
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
            this.Localizations = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\Ui\AddNewAppointment.xaml"
            this.Localizations.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Localizations_OnSelected);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Specializations = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Ui\AddNewAppointment.xaml"
            this.Specializations.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Specializations_OnSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Specialists = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Ui\AddNewAppointment.xaml"
            this.Specialists.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Specialists_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OccurenceDate = ((Xceed.Wpf.Toolkit.DateTimePicker)(target));
            
            #line 29 "..\..\..\Ui\AddNewAppointment.xaml"
            this.OccurenceDate.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.OccurenceDate_OnSelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AvailableAppointments = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.AddAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Ui\AddNewAppointment.xaml"
            this.AddAppointment.Click += new System.Windows.RoutedEventHandler(this.AddAppointment_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

