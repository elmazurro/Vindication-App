   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.PagesWpfApp2.Pages  5           WpfApp2.Pages.InvoicesPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp2.Pages     5        N� Title$  RepresentativesPage��5	      .��5      &   System.Windows.Controls.DataGrid  -   5        $��Invoices_Grid��5   	      AutoGenerateColumns .  $��22(�5   	    J� Opacity$	 0.9Q�5   	      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserAddRows .     
IsReadOnly . ��5   	   �� 	   Columns	 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6!      Header$ Nazwa��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	invoice+5"        5#      $	
 210 6!   $ Wartość NETTO��6-    6D   �� *	netAmount+5%        5&      $	
 230 6!   $ Wartość BRUTTO��6-    6E   �� *grossAmount+5(        5)      $	
 150 6!   $ Zarobek��6-    6>   �� *
interest+5+        5,      $	
 130 6!   $ Procent��6-    6>   �� *	percent+5.        5/      $	
 282 6!   $
 Data��6-    6;   �� *dateOfReturn+51      55      56      