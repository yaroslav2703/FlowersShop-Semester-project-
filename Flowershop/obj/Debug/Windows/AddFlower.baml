   M S B A M L   `   `   `  ����E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Flowershop
Flowershop  5   	       Flowershop.AddFlower   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Flowershop     5   	     � Title$*  $Информация о заказе��5   	   $	��450��5	   	   $	��800��6    � 
ResizeMode$ CanMinimize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��2.5* �6   �� 5      $
��0.2* �6   .+�5"   
   �� $��1��6   $��0��6$   $��2��61    �� TextAlignment$ Center=�6E   #!Добавление цветка5$      �� 5%   
   $��1��6   $��1��6$   $��2��61   $ Center=�6E   20Выберите параметры цветка5'      �� 5(   
   $��1��6   $��2��6$   $ Right=�62   Название5*      �� 5+   
   $��1��6   $��3��6$   $ Right=�62   
Цена5-      �� 5.   
   -   5         ��Name$ 
flowername��5.      $��2��6&   $��2��66    �� TextAlignment$ Center=�6D   $��
5 0 170 40q�6[   .��6o   50      �� 51   
   -   5        $ 
flowercost��51      $��2��6&   $��3��66   $ Center=�6D   $��
5 0 170 40q�6\   .��6p   53      �� 55   
   -   5         ��Name$ 	addflower��55      $��1��6%   $��5��65   $��2��6C   $��280 60 280 20q�6Y   .��6�   Добавить57      58      59      