   M S B A M L   `   `   `  ����D  @Hi_wpf, Version=2020.8.9.3, Culture=neutral, PublicKeyToken=null3clr-namespace:hello_wpf.CsCodehello_wpf.CsCode  5   	   )    #hello_wpf.CsCode.textbox_adv_topics   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:hello_wpf.CsCode     5   	     � Title$  TextBox Advance Topics��5   	   $��398.335��6(   $��719.502��69    � WindowStartupLocation$ CenterScreen=�6I   ���	#FFECEAEA � 
ResizeMode$ CanResizeWithGrip=�6�   .��5	      � .+�5
   
   �� -   5         ��Name$ tbox_ctl��5
      $��21,63,20,22q�6$    �� TextWrapping$
 Wrap=�69   $����<Button x:Name="sel_all_butt" Content="Select All" HorizontalAlignment="Left" <Button x:Name="sel_all_butt" Content="Select All" HorizontalAlignment="Left" <Button x:Name="sel_all_butt" Content="Select All" HorizontalAlignment="Left" ��6M    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6�  $��20(�6�  �� 5   
   -   5         ��Name$ zoom_in_butt��5      $��Zoom +��6'   $
��Left=�68   $��	34,27,0,0q�6S   $	��Top=�6f   $��57��6~   6�   �� 5   
   -   5        $ zoom_out_butt��5      $��Zoom -��6(   $
��Left=�69   $��	98,27,0,0q�6T   $	��Top=�6g   $��57��6   6�   �� 5   
   -   5        $ sel_all_butt��5      $��
Select All��6'   $
��Left=�6<   $��
171,27,0,0q�6W   $	��Top=�6k   $��61��6�   6�   �� 5   
   -   5        $ 	undo_butt��5      $
��Undo��6$   $
��Left=�63   $��
246,28,0,0q�6N   $	��Top=�6b   $��43��6z   6�   �� 5   
   -   5        $ 	redo_butt��5      $
��Redo��6$   $
��Left=�63   $��
294,28,0,0q�6N   $	��Top=�6b   $��43��6z   6�   �� 5   
   -   5        $ 	copy_butt��5      $
��Copy��6$   $
��Left=�63   $��
364,28,0,0q�6N   $	��Top=�6b   $��43��6z   6�   �� 5   
   -   5        $ cut_butt��5      $	��Cut��6#   $
��Left=�61   $��
412,28,0,0q�6L   $	��Top=�6`   $��43��6x   6�   �� 5   
   -	   5        $ 
paste_butt��5      $��Paste��6%   $
��Left=�65   $��
470,28,0,0q�6P   $	��Top=�6d   $��43��6|   6�   �� 5   
   -
   5        $ enable_wrap_butt��5      $��Enable Word Warp��6+   $
��Left=�6F   $��
554,10,0,0q�6a   $	��Top=�6u   $	��122��6�   6�   �� 5   
   -   5        $ disable_wrap_butt��5      $��Disable Word Warp��6,   $
��Left=�6H   $��
554,35,0,0q�6c   $	��Top=�6w   $	��122��6�   6�   5      5      