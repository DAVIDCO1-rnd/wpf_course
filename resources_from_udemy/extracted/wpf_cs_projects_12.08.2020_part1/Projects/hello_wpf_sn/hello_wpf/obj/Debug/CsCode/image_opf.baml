   M S B A M L   `   `   `  ����D  @Hi_wpf, Version=2020.8.9.3, Culture=neutral, PublicKeyToken=null3clr-namespace:hello_wpf.CsCodehello_wpf.CsCode  5   	        hello_wpf.CsCode.image_opf   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:hello_wpf.CsCode     5   	     � Title$  	image_opf��5   	   $��402.285��6   $��459.875��6,    � WindowStartupLocation$ CenterScreen=�6<   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��66* �6   �� 5      $
��305* �6   .+�5   
   �� -   5         ��Name$ 	image_ctl��5      $��koala_resized.jpg��6#   $��1��6>   $
��Fill=�6K   �� 5   
   -   5         ��Name$ load_image_butt��5      $��
Load Image��6*   $
��Left=�6?   $��94,4,0,0q�6Z   $	��Top=�6l   $��79��6�   $��29��6�   6�   �� 5   
   -   5        $ 	fill_butt��5      $
��Fill��6$   $
��Left=�63   $��	238,4,0,0q�6N   $	��Top=�6a   $��79��6y   $��29��6�   6�   �� 5   
   -   5        $ 	zoom_butt��5      $
��Zoom��6$   $
��Left=�63   $��	322,4,0,0q�6N   $	��Top=�6a   $��79��6y   $��29��6�   6�   �� 5   
   -   5        $ browse_butt��5      $��Browse��6&   $
��Left=�67   $��10,4,0,0q�6R   $	��Top=�6d   $��79��6|   $��29��6�   6�   �� 5   
   -   5         ��Name$ file_name_lbl��5      $�� ��6'   $��	10,38,6,0q�62   $	��Top=�6E   $��25��6]   ���	#FF838383$��1q�6�   ���	#FFF3F3F36�   5      5      