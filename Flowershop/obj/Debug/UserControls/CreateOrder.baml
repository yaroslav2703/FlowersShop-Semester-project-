   M S B A M L   `   `   `  ����E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Flowershop.UserControlsFlowershop.UserControls  5   	   )    #Flowershop.UserControls.CreateOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Flowershop.UserControls     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��620��5
      $	��700��6   .��5      � 
�������  � RowDefinitions  5   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.2* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5       $
��0.5* �6   �� 5!      $
��0.2* �6   .+�5'   
   �� $��1��6   $��2��6$    �� TextAlignment$ Center=�68   Ассортимент5)      �� 5+   
   $��1��6   $��2��6$   $��Center=�61   $��Center=�6N   Название заказа5-      �� 5/   
   -   5         ��Name$ 	NameOrder��5/      $��2��6%   $��2��65   $��40q�6C    �� TextAlignment$ Center=�6O   .��6f   51      �� 53   
   -   5         ��Name$ createOrder��53      $��1��6'   $��3��67   $��2��6D   $��170 0 170 0q�6X   .��54      �� $��Center=�6   $��Center=�65   Создать заказ56      57      �� 58   
   $��1��6   $��4��6$   $��2��61   $��Center=�6E   $��Center=�6b   ZXДобавление в заказ цветка со своими параметрами5:      �� 5<   
   $��1��6   $��5��6$   $��Center=�61   $��Center=�6N   Выберите цветок5>      �� 5@   
   $��1��6   $��6��6$   $��Center=�61   $��Center=�6N   !Выберите оттенок5B      �� 5D   
   -   5         ��Name$ flawer��5D      $��2��6#   $��5��63   5F      �� 5G   
   -   5        $ color��5G      $��2��6#   $��6��63   5I      �� 5K   
   -   5        $ Create��5K      $��1��6"   $��7��62   $��2��6?   $��160 0 160 0q�6S   .��5L      �� $��Center=�6   $��Center=�65   $"Добавить в корзину5N      5O      5Q      5R      