﻿#pragma checksum "..\..\..\Pages\Add_InvoicePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43D1EDBC88857C1D5325B1315CA7E0B0143A3444"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using WpfApp2.Pages;


namespace WpfApp2.Pages {
    
    
    /// <summary>
    /// Add_InvoicePage
    /// </summary>
    public partial class Add_InvoicePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox invoice;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox netAmount;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox grossAmount;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox percent;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox companyId;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock employeeText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox employeeId;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateOfReturn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\Add_InvoicePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submit_add_invoice;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/pages/add_invoicepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Add_InvoicePage.xaml"
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
            this.invoice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.netAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.grossAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.percent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.companyId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 61 "..\..\..\Pages\Add_InvoicePage.xaml"
            this.companyId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeeId_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.employeeText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.employeeId = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.dateOfReturn = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.submit_add_invoice = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Pages\Add_InvoicePage.xaml"
            this.submit_add_invoice.Click += new System.Windows.RoutedEventHandler(this.Submit_add_invoice_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

