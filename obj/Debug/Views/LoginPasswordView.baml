   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   C ?StaffWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StaffWpf.ViewsStaffWpf.Views 5   	   &    StaffWpf.Views.LoginPasswordView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   .localclr-namespace:StaffWpf.Views     5   	   -   5        $��LoginPasswordWindow��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 	Logowanie��5   	   $	��350��6   $	��300��6(   .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $:��4https://s18670.pcdn.co/wp-content/uploads/team-1.jpg��6   $	��300��6N   $��2��6Z   6q   �� 5   
   $��Login��6   $��1��6    �� 5   
   $��1��6)   $��1��66   $��5q�6F   ��6   �� *Login+6F   �� 5   
   $��Hasło��6   $��2��6    �� 5   
   $��2��6,   $��1��69   $��5q�6I   ��6   �� *
Password+6I   �� 5    
   $��3��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Right=�6O   .+�5!      �� $��Anuluj��5#      $��30��6&   $	��125��62   $��5q�6>   ��5!      �� *CloseCommand+��5"      ��  �� ElementName$ LoginPasswordWindow��5#   >   �� 5$      $��
Zatwierdź��5&      $��30��6)   $	��125��65   $��5q�6A   ��5$      �� *ConfirmCommand+��5%      �� $ LoginPasswordWindow��5&   A   5'      5(      5)      