   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages       WpfApp2.Pages.InvoicesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:WpfApp2.Pages       N� Title$  RepresentativesPage��.��&   System.Windows.Controls.DataGrid  -   $��Invoices_Grid��   AutoGenerateColumns .  $��22(� J� Opacity$	 0.9Q�   CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserAddRows .     
IsReadOnly . ���� 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 230    Header$ Nazwa��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	invoice+   ElementStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=�  $	
 210 $ Wartość NETTO�� �� *	netAmount+ �� " ��.���  � ��$ Center=�  $	
 230 $ Wartość BRUTTO�� �� *grossAmount+ �� " ��.���  � ��$ Center=�  $	
 150 $ Zarobek�� �� *
interest+ �� " ��.���  � ��$ Center=�  $	
 130 $ Procent�� �� *	percent+ �� " ��.���  � ��$ Center=�  $	
 282 $
 Data�� �� *dateOfReturn+ �� " ��.���  � ��$ Center=�