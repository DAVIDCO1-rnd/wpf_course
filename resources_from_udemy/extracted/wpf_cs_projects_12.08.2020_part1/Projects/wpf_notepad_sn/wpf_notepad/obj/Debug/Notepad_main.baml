   M S B A M L   `   `   `  ����J  Fwpf_notepad, Version=2020.8.12.2, Culture=neutral, PublicKeyToken=null)clr-namespace:wpf_notepadwpf_notepad  5   	       wpf_notepad.Notepad_main   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:wpf_notepad     5   	     � Title$  WPF Notepad Application��5   	   $��452.132��6)   $��623.605��6:   ���	#FFF1F1F1 � WindowStartupLocation$ CenterScreen=�6a    � 
ResizeMode$ CanResizeWithGrip=�6�    � Icon$% Images/About_us/notepad_128.png��6�   .��5	      � .+�5
   
   �� -   5         ��Name$ tbox_ctl��5
      $��
10,42,7,10q�6$    �� TextWrapping$
 Wrap=�68   $l��fHi,
I'm the WPF Notepad with the C#!
I'm Developed by Musavi as the final project!
Regards,
Musavi��6L   " �� VerticalScrollBarVisibility$ Visible=�6�    �� AcceptsReturn . $��15(�6  o� 5   
   $��37��6   $	��Top=�6   ���	#FFE2DEDE.@�5      m� $��_File��6   $��37��6&   $��72��62    � Cursor$
 Hand��6=   $��10,0,6,0q�6K   	 m� Icon	 5      �� 5      $ ��Images/Notepad/file_32.png��6   $��-4,-10,-6,-8q�6@   6X   .@�5      m� -   5        
 m�Name$
 new_butt��5      $	��New��6-   $
��Left=�6:   $��37��6U   $	��140��6a   	 5      �� 5      $ ��Images/Notepad/edit_32.png��6    $��-4,-10,-6,-2q�6D   6\   5      m� 5      -   5        $
 	open_butt��5      $
��Open��6.   $
��Left=�6<   $��37��6W   $	��140��6c   6o   m� 5      -   5        $
 	save_butt��5      $��Save As��6.   $
��Left=�6?   $��37��6Z   $	��140��6f   6r   m� 5      -   5        $
 	exit_butt��5      $
��Exit��6.   $
��Left=�6<   $��37��6W   $	��140��6c   6o   5      m� 5      $��_Edit��6   $��37��6&   $	��100��62   $
 Hand��6>   	 5      �� 5      $ ��Images/Notepad/edit_32.png��6   $��-4,-10,-6,-8q�6@   6X   .@�5      m� -   5        $
 	undo_butt��5      $
��Undo��6.   $
��Left=�6<   $��37��6W   $	��140��6c   6o   m� 5      -   5        $
 	redo_butt��5      $
��Redo��6.   $
��Left=�6<   $��37��6W   $	��140��6c   6o   m� 5      -   5        $
 cut_butt��5      $	��Cut��6-   $
��Left=�6:   $��37��6U   $	��140��6a   6m   m� 5       -	   5        $
 	copy_butt��5       $
��Copy��6.   $
��Left=�6<   $��37��6W   $	��140��6c   6o   m� 5!      -
   5        $
 
paste_butt��5!      $��Paste��6/   $
��Left=�6>   $��37��6Y   $	��140��6e   6q   m� 5"      -   5        $
 sel_all_butt��5"      $��
Select All��61   $
��Left=�6E   $��37��6`   $	��140��6l   6x   5#      m� 5$      $��F_ormat��6   $��37��6(   $	��100��64   $
 Hand��6@   	 5%      �� 5&      $"��Images/Notepad/format_32.png��6   $��-4,-10,-6,-8q�6B   6Z   .@�5(      m� -   5        $
 word_wrap_butt��5(      $��	Word Wrap��63   $
��Left=�6F   $��37��6a   $	��150��6m    m� IsCheckable .  m� 	IsChecked . 6�   5)      m� 5*      $��_View��6   $��37��6&   $	��100��62   $
 Hand��6>   	 5+      �� 5,      $ ��Images/Notepad/view_32.png��6   $��-4,-10,-6,-8q�6@   6X   .@�5.      m� -   5        $
 zoom_in_butt��5.      $��	Zoom In +��61   $
��Left=�6D   $��37��6_   $	��160��6k   6w   m� 5/      -   5        $
 zoom_out_butt��5/      $��
Zoom Out -��62   $
��Left=�6F   $��37��6a   $	��160��6m   6y   m� 50      -   5        $
 default_zoom_butt��50      $��Default Zoom��66   $
��Left=�6L   $��37��6g   $	��160��6s   6   51      m� 52      $��_Help��6   $��37��6&   $	��100��62   $
 Hand��6>   	 53      �� 54      $ ��Images/Notepad/help_32.png��6   $��-4,-10,-6,-8q�6@   6X   .@�56      m� -   5        $
 
about_butt��56      $��About Us��6/   $
��Left=�6A   $��37��6\   $	��140��6h   6t   57      58      5:      5;      