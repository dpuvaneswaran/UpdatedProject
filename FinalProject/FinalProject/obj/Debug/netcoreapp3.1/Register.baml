   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject  5   	       FinalProject.Register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FinalProject     5   	   c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  Register��5	   	   $	��450��6   $	��380��6'    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #0ee3f1��6'    � Offset$	 0.2Q�67   � 5      $ #63ff00��6'   $	 1.2Q�67   5      5      �� 5      .+�5       �� -   5         ��Name$ 
Homebutton��5       $	��100��6-   $��35��69   $
��HOME��6E   $��0,20,0,0q�6T   6�   5!      �� 5#      $��Center=�6   .+�5$      �� $��Images/Icon.png��6   $��70��61   �� 5%      $��REGISTERATION FORM��6   $��Light"�66   $��	Helvetica)�6I   $��22(�6`   
�������$��Center=�6�   5'      �� 5)      -   5        	 ��Name$	 ErrorMessage��5)   /   $��	Helvetica)�6   $��Center=�6F   $��20��6c   $	��198��6o   $��	0,150,0,0q�6{   $	��Top=�6�   
 J� OpacityMask

 �<�����	#FFE5572C6�   �� 5+      $��1��6   .+�5,      ��  �� Orientation$ 
Horizontal=�6   .+�5-      �� -   5         ��Name$ registerUsername��5-      $��	Helvetica)�68   $��Light"�6O   $��Username��6b   $��20(�6r   $��Center=�6�   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�    J� Opacity$	 0.9Q�6  $��63,0,0,0q�6  .  (MahApps.Metro.IconPacks.PackIconMaterial  5.         Kind$ Account=�61   $��Center=�6@   $��Center=�6[   
�������6x   5/      �� 50      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 52      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�53      G� -   5         G�Name$ registerPassword��53   "   $��	Helvetica)�6<   $��Light"�6S    G� Password$ Password��6f   $��20(�6z   $��Center=�6�   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   $	 0.9Q�6  $��63,0,0,0q�6!    54      $ TextboxPassword=�61   $��Center=�6H   $��Center=�6c   
�������6�   55      �� 56      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 58      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�59      G� -   5        $ RetypePassword��59   "   $��	Helvetica)�6:   $��Light"�6Q   $ Password��6d   $��20(�6x   $��Center=�6�   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   $	 0.9Q�6  $��63,0,0,0q�6    5:      $ TextboxPassword=�61   $��Center=�6H   $��Center=�6c   
�������6�   5;      �� 5<      $	��250��6   $��2��6%   
�������$	 0.5Q�6C   �� 5>      .+�5?      �� -   5        $	��100��5?      $��35��6)   $��REGISTER��65   $��0,20,0,0q�6H   6z   5@      5B      5C      5D      5E      