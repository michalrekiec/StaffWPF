   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?StaffWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StaffWpfStaffWpf 5   	   (   "StaffWpf.Views.AddEditEmployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   (localclr-namespace:StaffWpf     5   	   -   5        $��AddEditEmployeeWindow��5
   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Dane pracownika��5   	   $	��400��6!   $	��500��6.   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $	��Id:��5      $��5q�6   y�5      �� *
IsUpdate+    BooleanToVisibilityConverter �� 	Converter# [  5      �� 5   
   $��1��5!   *   $��5q�6:   y�5       �� *
IsUpdate+# [  ��5!      �� *Employee.Id+6:   �� 5#   
   $��Imię:��6   $��1��6    $��5q�6-   �� 5$   
   $��1��66   $��1��6C   $��5q�6S   ��6   �� *Employee.FirstName+6S   �� 5&   
   $��	Nazwisko:��6   $��2��6$   $��5q�61   �� 5'   
   $��2��65   $��1��6B   $��5q�6R   ��6   �� *Employee.LastName+6R   �� 5)   
   $��Dział:��6   $��3��6!   $��5q�6.   �� 5*   
   $��3��6   $��1��6    $��5q�60    �� DisplayMemberPath$
 Name��5-       �� SelectedValuePath$ Id��5.      ��5+      �� *Departments+ �� SelectedValue 5,      �� *Employee.EmpDepartment.Id+5.      �� 51   
   $��Data przyjęcia:��6   $��4��6*   $��5q�67   (  "System.Windows.Controls.DatePicker  52   
   $��4��6F   $��1��6S   $��5q�6c      SelectedDate 6   �� *Employee.EmploymentDate+6c   �� 54   
   $��Data zwolnienia:��6   $��5��6+   $��5q�68     55   
   $��5��6E   $��1��6R   $��5q�6b    6   �� *Employee.DismissalDate+{�6m   �� *CanDismissalDateEdit+�� 57   
   $��Zarobki:��6   $��6��6#   $��5q�60   �� 58   
   $��6��63   $��1��6@   $��5q�6P   ��6   �� *Employee.Salary+6P   �� 5:   
   	 �� Orientation$	 
Horizontal=�6   $��7��6.   $��1��6;   $��Right=�6K   .+�5;      �� $��Anuluj��5=      $��30��6&   $	��125��62   $��5q�6>   ��5;      �� *CloseCommand+��5<      �� 
 �� ElementName$
 AddEditEmployeeWindow��5=   >   �� 5>      $��
Zatwierdź��5@      $��30��6)   $	��125��65   $��5q�6A   ��5>      �� *ConfirmCommand+��5?      �� $
 AddEditEmployeeWindow��5@   A   5A      5C      5D      