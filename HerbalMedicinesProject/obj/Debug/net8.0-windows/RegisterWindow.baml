   M S B A M L   `   `   `  ����Q  MHerbalMedicinesProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HerbalMedicinesProjectHerbalMedicinesProject  5   	   +    %HerbalMedicinesProject.RegisterWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:HerbalMedicinesProject     5   	     � Title$.  (Medicinal Plants Sales Management System��5   	   $	��450��6:   $	��800��6G    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ CanMinimize=�6.    � WindowStyle$
 None=�6G   .��5      � .+�5   
   �� $/��)/Image/istockphoto-1189407772-612x612.jpg��6   $
��Fill=�6C    J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ 	#FF1AB30E��6#    � Offset$ 1Q�65   5      5      �� 5   
   -   5        $��btnClosRegister��5      $��X��6(   $��30��64   $��30��6?   $��Right=�6K   $	��Top=�6g   $��5q�6   ���	#FF63F3156�   �� 5   
   $��Registration��6   $��32(�6(   $
��Bold"�66   $��Center=�5      $��0,10,0,0q�60   $��Monotype Corsiva)�6B   �� 5   
   $��20,50,20,20q�6   $	��300��6*   $
��Left=�66   .+�5      �� $��First Name:��6   $
��Bold"�6+   $��5,5,0,0q�6=   �� 5      -   5        	 ��Name$	 txtFirstName��5      $��5,0,0,15q�6,   �� 5      $��
Last Name:��6   $
��Bold"�6*   $	��5,0q�6<   �� 5      -   5        $	 txtLastName��5      $��5,0,0,15q�6+   �� 5!      $��National Code:��6   $
��Bold"�6.   $	��5,0q�6@   �� 5"      -   5        $	 txtNationalCode��5"      $��5,0,0,15q�6/   �� 5$      $��Gender:��6   $
��Bold"�6'   $	��5,0q�69   �� 5%      -   5        
 ��Name$
 	cmbGender��5%      $��5,0,0,15q�6*    �� SelectedIndex$ 0��6<   .@�5&      �� $	��Man��6   
 � Tag$ 0��6-   �� 5'      $��Woman��6   $ 1��6/   5(      �� 5*      $��Role:��6   $
��Bold"�6%   $	��5,0q�67   �� 5+      -   5        $
 cmbRole��5+      $��5,0,0,15q�6(   $ 0��6:   .@�5,      �� $��Owner��6   $ 0��6/   �� 5-      $��Seller��6   $ 1��60   5.      �� 5/      $��Phone Number:��6   $
��Bold"�6-   $	��5,0q�6?   �� 50      -   5        $	 txtPhoneNumber��50      $��5,0,0,15q�6.   53      �� 54   
   $��20,50,20,20q�6   $	��300��6*   $��Right=�66   .+�55      �� $��	Address :��6   $
��Bold"�6)   $	��5,0q�6;   �� 56      -   5        $��
txtaddress��56       �� AcceptsReturn$
 True��6(    �� TextWrapping$
 Wrap=�6=   $��50��6Q   6a   �� 58      $��Email :��6   $
��Bold"�6'   $	��5,0q�69   �� 59      -	   5        $	 txtEmail��59      $��5,0,0,15q�6(   $��
(Optional)��6:   �� 5:      $��Birth Date :��6   $
��Bold"�6,   $	��5,0q�6>   (  "System.Windows.Controls.DatePicker  5;      -
   5        $��dpBirthDate��5;         SelectedDateFormat$ Short=�6,      FirstDayOfWeek$ Saturday=�6G      DisplayDateStart 1/1/19006a      DisplayDateEnd 6}   �� *Today+   SelectedDate 6�   �� *	BirthDate+ �� Mode$ TwoWay=�6�   �� 5<      $��
Password :��6   $
��Bold"�6*   $	��5,0q�6<   G� 5=      -   5        $��txtPassword��5=      60   �� 5>      $��Repeat Password :��6   $
��Bold"�61   $	��5,0q�6C   G� 5?      -   5        $��txtRepeatPassword��5?      66   �� 5@      -   5        $��Register��5@      $��20,60q�6(   $	��100��67   $��Center=�6C   $��20(�6`   $��Monotype Corsiva)�6n   ��5A      �� 5B      5D      5E      5G      5H      