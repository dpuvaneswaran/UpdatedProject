   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject  5   	       FinalProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FinalProject     5   	   c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��380��6)    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #0ee3f1��6'    � Offset$	 0.2Q�67   � 5      $ #63ff00��6'   $	 1.2Q�67   5      5      �� 5       $��Center=�6   .+�5!      �� $��Images/Icon.png��6   $��80��61   �� 5"      $��GAMEADEX��6   $��Light"�6,   $��	Helvetica)�6?   $��22(�6V   
�������$��Center=�6w   5#      �� 5%      -   5         ��Name$ ErrorMessage��5%   /   $��	Helvetica)�6   $��Center=�6F   $��20��6c   $��	0,180,0,0q�6o   $	��Top=�6�   ���	#FFE5572C6�   �� 5'      $��1��6   .+�5(      �� 	 �� Orientation$	 
Horizontal=�6   .+�5)      �� -   5        
 ��Name$
 UsernameTxt��5)      $��	Helvetica)�63   $��Light"�6J   $��Username��6]   $��20(�6m   $��Center=�6{   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�    J� Opacity$	 0.9Q�6  $��63,0,0,0q�6  .  (MahApps.Metro.IconPacks.PackIconMaterial  5*         Kind$ Account=�61   $��Center=�6@   $��Center=�6[   
�������6x   5+      �� 5,      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 5.      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5/      G� -   5         G�Name$ PasswordBox��5/   "   $��	Helvetica)�67   $��Light"�6N    G� Password$ Password��6a   $��20(�6u   $��Center=�6�   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   $	 0.9Q�6  $��63,0,0,0q�6    50      $ TextboxPassword=�61   $��Center=�6H   $��Center=�6c   
�������6�   51      �� 52      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 54      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�55      �� -   5        $	��100��55      $��35��6)   $��LOGIN��65   $��	60,0,60,0q�6E   6t   �� 56      -   5        $	��100��56      $��35��6)   $��REGISTER��65   6h   57      58      5:      5;      5<      