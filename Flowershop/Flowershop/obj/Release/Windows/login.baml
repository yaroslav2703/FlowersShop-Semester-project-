   M S B A M L   `   `   `  ���� E  AFlowershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Flowershop.WindowsFlowershop.Windows      Flowershop.Windows.login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Flowershop.Windows     V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��500��$	��400��  � 
ResizeMode$  NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ /images/login.jpg��.��� .+��  J� Opacity$	 0.5Q�
�������.+��� -    ��Name$ btnClose��$	��Top=�$��Right=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=����	#FFA2A2A2$��30��$��30����  �� Orientation$ 
Horizontal=�$��Center=�$	��Top=�$��60��$��30q�.+��� $��Вход��
���   �$��40(�$��0 0 10 0q��� $��/��$��40(��� -    ��Name$ formRegister��$��Регистрация��$��25(�	 � Cursor$
	 Hand�����	#FF0062D8$��5 15 0 0q��� $ Vertical=�$	��300��$	��130��$��Center=�$��0 0 0 0q�.+��� $��50��
 �� CornerRadius$
 5��
�������$��1q�$��Center=� � UseLayoutRounding . ._��� -    ��Name$ txbLogin��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��$��25(�$��5 0 0 2q�$��0q��� $��50��$
 5��
�������$��1q�$��Center=� . $��0 30 0 0q�._�G� -    G�Name$ txbPassword��$ Пароль��$��25(�$��5 0 0 2q�$��0q��� -   $ btnLogin��$��
Войти�� �� 	IsDefault . $��Bottom=�$��Center=�$��0 0 0 50q�$	��200��$��45��$��25(��� $�� ��$��Bottom=�$��Center=�$��0 0 0 10q�$��15(�