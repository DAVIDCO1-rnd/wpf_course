   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Adv_WPF.WPF_BindingAdv_WPF.WPF_Binding  5   	   ,    &Adv_WPF.WPF_Binding.wpf_twoway_binding   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Adv_WPF.WPF_Binding     5   	     � Title$  wpf_twoway_binding��5   	   $��294.9��6$   $��453.758��63   .��5	      � .+�5
   
   �� -   5         ��Name$ 	my_slider��5
      $
��Left=�6$   $��	22,24,0,0q�6?   $	��Top=�6R   $	��211��5       � Maximum$	 100Q�6    �� TickPlacement$ TopLeft=�6+    �� TickFrequency$ 5Q�6C    � Value$ 50Q�6U   �� 5   
   -   5         ��Name$ my_tbox��5      $
��Left=�6#   $��23��6>   $��
238,27,0,0q�5       �� TextWrapping$
 Wrap=�6!   $	��Top=�5   �   $��56��6�   ��6   �� *Value+ �� ElementName$ 	my_slider��	 �� Mode$	 TwoWay=�
 �� NotifyOnTargetUpdated
 .  �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��23��6-   $��
238,74,0,0q�69   $
 Wrap=�6M   $��TextBox��6a   $	��Top=�6p   $	��120��6�   �� 5   
   -   5         ��Name$ update_butt��5      $��Update��6&   $
��Left=�67   $��
323,27,0,0q�6R   $	��Top=�6f   $��75��6~   6�   5      5      