   M S B A M L   `   `   `  ���� E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Flowershop.UserControlsForAdminFlowershop.UserControlsForAdmin  3    -Flowershop.UserControlsForAdmin.Formalization   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  9local-clr-namespace:Flowershop.UserControlsForAdmin  $
��auto��$	��700��.��� .+���   �� Orientation$  
Horizontal=�$��60��$	��Top=�
���   �.+��� -    ��Name$ btnSave��$��Сохранить��$	��105��$��40��$
��Left=�$
��10 0q��� $#��Создание тестов��
�������$��Center=�$��Impact)�$��30(�$
��15 0q��� $��0 60 0 0q�.��� 
������� � RowDefinitions �� $	��300 ��� $	��300 ��� $	��330 � � ColumnDefinitions �� �� .+��� $��0��$��0��$��10q�.+��� $"��1. Добавить тему��$��Center=�$��30(�$��Impact)��� -    ��Name$ txbTheme��
���   �$	��200��$��30��
�������$��10, 20q�.@��� .��Времена�� .��Артикли�� .�� Существительные�� .��Прилагательные�� -   $ btnAddTheme�� &  "MaterialDesignFloatingActionButton#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q� �� CornerRadius$ 5��._��� -    ��Name$ 
listThemes��
���   ��� $��0��$��1��$��10q�.+��� $"��2. Добавить тест��$��Center=�$��30(�$��Impact)��� $��50��$ 5��
�������$��1q� � UseLayoutRounding . $��10q�._��� -    ��Name$ txbTest��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$0	 *Введите название теста��$��25(�$��5 0 0 2q�$��0q��� -   $ 
btnAddTest��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q�$ 5��._��� -   $ 	listTests��
���   ��� $��1��$��2��$��10q�.+��� $&�� 3. Добавить вопрос��$��Center=�$��30(�$��Impact)��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $ txbQuestion��$!	 Введите вопрос��$��25(�$��5 0 0 2q�$��0q��� -	   $ btnAddQuestion��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q��� $	��110��$
��10 5q�
���   �$��1q�$ 5��._��� -
   $ listQuestions��
���   ��� $��2��$��2��$��10q�.+��� $8��24. Добавить ответы на вопрос��$��Center=�$��30(�$��Impact)��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $ 
txbAnswer1��$4	 .Введите правильный ответ��$��25(�$��5 0 0 2q�$��0q��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $ 
txbAnswer2��$8	 2Введите неправильный ответ��$��25(�$��5 0 0 2q�$��0q��� $��50��$ 5��
�������$��1q� . $��10q�._��� -   $ 
txbAnswer3��$8	 2Введите неправильный ответ��$��25(�$��5 0 0 2q�$��0q��� -   $ btnAddAnswer��#��[  .���� $��+��$��40(�$��Center=�$��Center=�$��0 0 0 10q�