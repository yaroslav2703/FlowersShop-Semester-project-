   M S B A M L   `   `   `  ����E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Flowershop
Flowershop  5   	       Flowershop.AddColor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Flowershop     5   	     � Title$%  Добавление цвета��5	   	   $	��250��5
   
   $	��400��6    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��2.5* �6   �� 5      $
��0.2* �6   .+�5#   
   �� $��1��6   $��0��6$   $��2��61    �� TextAlignment$ Center=�6E   %#Добавление оттенка5%      �� 5&   
   $��1��6   $��1��6$   $��2��61   $ Center=�6E   42Выберите параметры оттенка5(      �� 5)   
   $��1��6   $��3��6$   $ Right=�62   Название5+      �� 5-   
   -   5         ��Name$ 	colorname��5-      $��2��6%   $��3��65    �� TextAlignment$ Center=�6C   $��	10 0 50 5q�6Z   .��6m   5/      �� 52   
   -   5         ��Name$ addcolor��52      $��1��6$   $��5��64   $��2��6B   $��80 20 80 20q�6V   .��6�   Добавить54      55      56      