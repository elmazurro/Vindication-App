   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2      WpfApp2.CompaniesPage   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp2       N� Title$  CompaniesPage��.��&   System.Windows.Controls.DataGrid  -   $��Companies_Grid��   AutoGenerateColumns .  $��22(� J� Opacity$	 0.9Q�   CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserAddRows .     
IsReadOnly . ���� 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 250    Header$ Nazwa��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *companyName+  $	
 130 $	 Nip�� �� *nip+  $	
 200 $
 Kraj�� �� *	country+  $	
 180 $ Miasto�� �� *city+  $	
 310 $ Adres�� �� *	address+4  .System.Windows.Controls.DataGridTemplateColumn  $ Przedstawiciele��$	
 162    CellTemplate �� .R��� -   $��Pokaż��
 � Tag �� *id+