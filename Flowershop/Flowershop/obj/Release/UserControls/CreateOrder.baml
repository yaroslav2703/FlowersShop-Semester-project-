   M S B A M L   `   `   `  ���� E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Flowershop.UserControlsFlowershop.UserControls  )    #Flowershop.UserControls.CreateOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:Flowershop.UserControls     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $
��auto��$	��700��.��� .+���   �� Orientation$  
Horizontal=�$��60��$	��Top=�
���   �.+��� -    ��Name$ btnSave��$"��Автосохранение��$	��165��$��40��$
��Left=�$��10q��� $'��!Оформление заказа�� �� TextAlignment$ Center=�
�������$��Center=�$��Impact)�$��30(�$��85,12,15,11q��� $��0 60 0 0q�.��� 
������� � RowDefinitions �� $	��300 ��� $	��300 ��� $	��330 � � ColumnDefinitions �� $	��55* ��� $	��12* ��� $
��275* ��� $	��36* ��� $
��305* �.+��� $��0��$��0��$��10q�$��3��.+��� $!��1. Наименование��$��Center=�$��30(�$��Impact)��� -    ��Name$ txbTheme��
���   �$	��200��$��30��
�������$��10, 20q�.@��� .��
Розы�� .��Тюльпаны�� .��
Лилии�� .��Гвоздики�� -   $ btnAddTheme�� &  "MaterialDesignFloatingActionButton#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q� �� CornerRadius$ 5��._��� -    ��Name$ 
listThemes��
���   ��� $��0��$��3��$��10q�$��2��.+��� $ ��2. Выбрать цвет��$��Center=�$��30(�$��Impact)��� -   $ txbTest��
���   �$	��200��$��30��
�������$��10, 20q�.@��� .��Красные�� .��
Белые�� .��Желтые�� .��Розовые�� -   $ 
btnAddTest��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q�$ 5��._��� -   $ 	listTests��
���   ��� $��1��$��5��$��10q�.+��� $:��43. Количество цветов в наборе��$��Center=�$��30(�$��Impact)��� $��50��$ 5��
�������$��1q� � UseLayoutRounding . $��10q�._��� -   	 ��Name$	 txbQuestion��)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$:
 4Введите нечетное количество��$��25(�$��5 0 0 2q�$��0q��� -	   $ btnAddQuestion��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q�$ 5��._��� -
   $ listQuestions��
���   ��� $��2��$��5��$��10q�.+��� $3��-4. Пожелания для упаковки��$��Center=�$��30(�$��Impact)��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $	 
txbAnswer1��$C
 =Например,посыпать белой стружкой��$��25(�$��5 0 0 2q�$��0q��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $	 
txbAnswer2��$;
 5Упаковать в крафтовую бумагу��$��25(�$��5 0 0 2q�$��0q��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $	 
txbAnswer3��$%
 Цветы больше 40 см��$��25(�$��5 0 0 2q�$��0q��� -   $ btnAddAnswer��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q�