   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?StaffWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StaffWpfStaffWpf 5   	      StaffWpf.Views.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (localclr-namespace:StaffWpf     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Kadry��5
   	   $	��750��6   $	��900��6$   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $	��150 �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Dodaj��5      $��30��6%   $	��125��61   $��5q�6=   ��5      �� *AddEmployeeCommand+5   =   �� 5      $��Edytuj��5      $��30��6&   $	��125��62   $��5q�6>   ��5      �� *EditEmployeeCommand+��5      �� *SelectedEmployee+5   >   �� 5      $��Zwolnij/Przywróć��5      $��30��60   $	��125��6<   $��5q�6H   ��5      �� *DismissRestoreEmployeeCommand+��5      �� *SelectedEmployee+5   H   �� 5      $��	Odśwież��5      $��30��6'   $	��125��63   $��5q�6?   ��5      �� *RefreshStaffCommand+5   ?   5      �� 5   
   $��3��6   $ 
Horizontal=�6"   .+�5      �� $��Filtruj dane��5       $��30��6,   $	��125��68   $��5q�6D   ��5      �� *FilterDataCommand+5    D   �� 5!      $��Usuń filtr��5"      $��30��6*   $	��125��66   $��5q�6B   ��5!      �� *DeleteFilterCommand+5"   B   5#      &   System.Windows.Controls.DataGrid  5$   
   $��1��5%      $��5q�6      CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5*         AutoGenerateColumns .  ��5&      �� *	Employees+ �� SelectedItem 5'      �� *SelectedEmployee+	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   
Visibility$
 Hidden=�6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6<     5.         Header$ Imię��6C    6%   �� *	FirstName+6C     5/      $ Nazwisko��6B    6%   �� *
LastName+6B     50      $ Dział��6L    6%   �� *EmpDepartment.Name+6L     51      $ Data zatrudnienia��6g    6%   �� *EmploymentDate+ �� StringFormat$ {0:dd.MM.yyyy}��6g     52      $ Data zwolnienia��6f    6%   �� *DismissalDate+$ {0:dd.MM.yyyy}��6f     53      $ Zarobki��6@    6%   �� *Salary+6@   4  .System.Windows.Controls.DataGridCheckBoxColumn  54      $ Zatrudniony��6G    6)   �� *	IsWorking+6G   56      �� 58   
   $��Księgowość��65   $
��Left=�59      $��	26,68,0,0q�6.   $��2��6A   $	��Top=�6N    d� 	IsChecked 58      �� *Accountancy+59   N   �� 5:   
   $��IT��6,   $
��Left=�5;      $��
26,101,0,0q�6.   $��2��6B   $	��Top=�6O    5:      �� *It+5;   O   �� 5<   
   $��Zarząd��64   $
��Left=�5=      $��
169,68,0,0q�6.   $��2��6B   $	��Top=�6O    5<      �� *
Management+5=   O   �� 5>   
   $��	Marketing��63   $
��Left=�5?      $��169,101,0,0q�6.   $��2��6C   $	��Top=�6P    5>      �� *	Marketing+5?   P   *   $MahApps.Metro.Controls.NumericUpDown  5A   
   $
��Left=�6;   $��
369,68,0,0q�6V   $��2��6j   $	��Top=�6w   $	��129��6�      Value 6   �� *MinimumValue+6�     5B   
   $
��Left=�6;   $��369,101,0,0q�6V   $��2��6k   $	��Top=�6x   $	��129��6�    6   �� *MaximumValue+6�   	� 5C   
   $��Wszyscy��69   $
��Left=�6K   $��
707,44,0,0q�6f   $��2��6z   $	��Top=�6�    6   �� *AllEmployees+6�   	� 5D   
   $��Pracujący aktualnie��6=   $
��Left=�6[   $��
707,80,0,0q�6v   $��2��6�   $	��Top=�6�    6   �� *CurrentlyWorking+6�   	� 5E   
   $ ��Pracujący w przeszłości��6=   $
��Left=�6_   $��707,116,0,0q�6z   $��2��6�   $	��Top=�6�    6   �� *WorkingInThePast+6�   �� 5F   
   $��Przedział zarobków��6   $
��Left=�6-   $��
369,26,0,0q�6H   $��2��6\   $	��Top=�6i    J� RenderTransformOrigin$ 0.513,0.577&�6�   5G      5H      