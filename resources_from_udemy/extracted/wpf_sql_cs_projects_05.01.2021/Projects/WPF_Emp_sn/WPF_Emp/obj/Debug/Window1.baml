   M S B A M L   `   `   `  ����B  >WPF_Emp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_EmpWPF_Emp  5   	   /clr-namespace:WPF_Emp.MainDsWPF_Emp.MainDs  5   	       WPF_Emp.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_Emp     5   	   /MainDsclr-namespace:WPF_Emp.MainDs     5   	     � Title$  Window1��5	   	   $	��450��6   $	��800��6&    � 	Resources 5
         WPF_Emp.MainDs.EmpDs   MyDs  emp_InfoViewSource �� Source �� Source��%Y   &	        &	      7     5   
   6   �� 5   
    6:   �� *
Emp_Info+8   5      .��5      �  � DataContext# �  6   .+�5   
   &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��170��6.   $��	25,45,0,0q�6;   $	��Top=�6N   $	��345��6f   ��6r   ��  �� Mode$ OneWay=��� 5   
   $
��Left=�6   $��23��6-   $��
560,75,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *id+$ OneWay=�6�   �� 5   
   $��Id��6   $
��Left=�6   $��
505,72,0,0q�68   $	��Top=�6L   �� 5   
   $��Label��6   $
��Left=�6    $��505,120,0,0q�6;   $	��Top=�6P   �� 5   
   $
��Left=�6   $��23��6-   $��560,120,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��120��6�   ��6b   �� *	Surname+$ TwoWay=�6�   5      5      