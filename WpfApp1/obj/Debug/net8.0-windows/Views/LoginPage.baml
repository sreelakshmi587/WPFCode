   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5      C&clr-namespace:WpfApp1.common.ResourcesWpfApp1.common.Resources  5      1clr-namespace:WpfApp1.HelpersWpfApp1.Helpers  5      7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5	          WpfApp1.Views.LoginPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      7resx&clr-namespace:WpfApp1.common.Resources     5      1helpersclr-namespace:WpfApp1.Helpers     5      7
viewmodels clr-namespace:WpfApp1.ViewModels     5	      $	��600��5      $	��800��6,   
�������.��5      � .+�5   
   ��    MainBackgroundBrush#��[  6   $��1q�6D     �� CornerRadius$  5��6X   $��Center=�6j   $��Center=�6�   $	��530��6�   $	��400��6�   ._�5      �� .+�5      �� $+��%../common/assets/Logo_MicrosoftAD.png��6   $
��0 10q�6G   $��40��6U   $��40��6a   $��Center=�6l   $��Center=�6�   �� 5      	 �� X1$ 0��6   	 �� X2$	 400��6   #��[  6(   $��2��6V   $��Center=�6j   $��	0,10,0,20q�6�   �� 5      (   "WpfApp1.common.Resources.Resources   	LoginText#��Z 6    �� Padding$
 20 0q�6G   $��15(�6V   $
��Bold"�6d   �� 5         WelcomeText#��Z 6   $
 20 6q�6I   $��12(�6X   �� 5        RoundedButtonStyle#��[ 6   $��40��6E   $��50 15q�6Q   
�������
�������$��1q�6�    � Cursor$
 Hand��6�   .��5      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�5      �� $+��%../common/assets/Logo_MicrosoftAD.png��6    $��30��6O   $��40��6[   �� 5      $��Microsft AD��6$   $��Center=�67   $ 3q�6R   $��DemiBold"�6^   6v   5      5      � 5      $��	0,10,0,10q�6   .+�5      �� $	 200��6   
�������$��1��62   $��Center=�6F   $��Center=�6a   �� 5      
�������$��Center=�60    �� Padding$	 5,0q�6M   $  10��6[   ._�5       �� $��or��6$   $��14(�6.   
�������6<   5!      5"      �� 5#      	   UsernameOrEmail#��Z	 6   $��DemiBold"�6M   $ 	20 10 0 0q�6c   $��10(�6w   �� 5$        RoundedTextBoxStyle#��[ 6   $��30��6I   $��	20,5,20,0q�6U   ��6h   �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5%      
�������$��0q�6,   $
 Hand��6@   $��Right=�6N   $��5 1 4 10q�6j   $��25��6|   .��5&      ��    ForgotPassword#��Z 6    $��DemiBold"�6P   $ 	10 8 15 8q�6f   $��Right=�6z   $��10(�6�   5'      �� 5(         Password#��Z 6   $��DemiBold"�6F   $
 20 0q�6\   $��10(�6k   G� 5*        RoundedPasswordBoxStyle#��[ 6   $��30��5+      $��	20,5,20,0q�6   '   !WpfApp1.Helpers.PasswordBoxHelper   BindPassword$
 True��5,         BoundPassword 5-      �� *
Password+ �� Mode$ TwoWay=�$
 PropertyChanged=��� 5/      #��[ 6   $��40��6F   $��20,55,20,30q�6R   ��6g   �� *LoginCommand+.��50      �� $ 
Horizontal=�6!   $��Center=�6:   .+�52      ��    LoginButtonText#��Z 6$   $��Center=�6U   $��15(�6p   53      54      55      56      57      58      