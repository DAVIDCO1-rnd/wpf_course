   M S B A M L   `   `   `  ����B  >Adv_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Adv_WPF.MVVM.ViewAdv_WPF.MVVM.View  5   	   ?$clr-namespace:Adv_WPF.MVVM.ViewModelAdv_WPF.MVVM.ViewModel  5   	   $    Adv_WPF.MVVM.View.AdvCustomers   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Adv_WPF.MVVM.View     5   	   :	ViewModel$clr-namespace:Adv_WPF.MVVM.ViewModel     5   	     � Title$  AdvCustomers��5	   	   $	��437��6   $	��469��6+   .��5
      � .+�5   
   �� -   5         ��Name$ adv_lv��5      $
��Left=�6#   $	��240��6>   $��
15,150,0,0q�6K   $	��Top=�6_   $	��435��6w   ��6�   �� *Add_Cu_List+ �� View 5      �� 5      .P�5      ��  �� Width$ 70��6%    �� CellTemplate 5      �� 5      .R�5   "   �� $��64��6(   ��64   �� *Photo+5      5      �� 5      $��Id��6%   $ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��
First Name��6%   $	 100��69    6E   �� *Fname+�� 5      $��	Last Name��6%   $	 120��68    6D   �� *Lname+�� 5      $��Gender��6%   $ 80��65    6@   �� *Gender+5       � DataContext 5      2   ,Adv_WPF.MVVM.ViewModel.AdvCustomersViewModel  5      5       �� 5!   
   $��GroupBox��6   $
��Left=�6%   $	��145��6@   $��15,0,0,0q�6M   $	��Top=�6_   $	��435��6w   .��5"      �� .+�5#      �� $	��Id:��6   $
��Left=�6&   $	��Top=�6A    �� Left$ 79��6Y   �� 5$      -   5         ��Name$ id_tb��5$      $
��Left=�6)   $��23��6D   	 �� TextWrapping$
	 Wrap=�6P   $	��Top=�6�   $	��208��6�   $	 101��6�   

 �� Top$
 3��6�   ��6d   �� *SelectedItem.Id+ �� ElementName$ adv_lv��6�   �� 5%      $��First Name:��6   $ 29��6.   $
 27��6?   �� 5&      -   5        $ fname_tb��5&      $��23��6,   $	 101��68   $
	 Wrap=�6J   $
 33��6�   $	��208��6�   ��6^   �� *SelectedItem.Fname+$ adv_lv��6�   �� 5'      $��
Last Name:��6   $ 29��6-   $
 61��6>   �� 5(      -   5        $ lname_tb��5(      $��23��6,   $	 101��68   $
	 Wrap=�6J   $
 65��6�   $	��208��6�   ��6^   �� *SelectedItem.Lname+$ adv_lv��6�   �� 5)      $��Gender:��6   $ 43��6*   $
 92��6;   �� 5*      -   5        $ 	gender_tb��5*      $��23��6-   $	 101��69   $
	 Wrap=�6K   $
 95��6�   $	��208��6�   ��6_   �� *SelectedItem.Gender+$ adv_lv��6�   �� 5+      
���   �$��1q�6-   $��80��6A   $	 324��6M   $
 18��6_   $��85��6o   ._�5,      �� -   5         ��Name$ 	photo_img��5,      ��6/   �� *SelectedItem.Photo+$ adv_lv��5-      5.      5/      51      52      