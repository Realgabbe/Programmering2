   M S B A M L   `   `   `  ����R  NFlappy Bird slutprojekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Flappy_Bird_slutprojektFlappy_Bird_slutprojekt  5   	   (    "Flappy_Bird_slutprojekt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Flappy_Bird_slutprojekt     5   	     � Title$  Flappy Bird slutprojekt��5   	   $	��490��6)   $	��525��66   .��5	      �� -   5        $��MyCanvas��5	      |�. 
����ح�.+�5   
   �� $	��145��6   $	��200��6   $��images/clouds.png��6)    �� Left$	 296��6D   
 �� Top$ 46��6V   
 � Tag$ cloud��6f   �� 5   
   $	��145��6   $	��200��6   $��images/clouds2.png��6)   $ 52��6E   $	 144��6V   $ cloud��6g   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs1��6G   $ 33��6R   $	 334��6c   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs1��6D   $ 33��6O   $
 -211��6`   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs2��6G   $	 242��6R   $	 191��6d   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs2��6D   $	 242��6O   $
 -354��6a   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs3��6G   $	 430��6R   $	 334��6d   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs3��6D   $	 430��6O   $
 -211��6a   �� 5    
   -   5        $��
flappyBird��5       $��36��6"   $��50��6.   $��images/flappybird.png��69   $
��Fill=�6X   $ 19��6g   $	 240��6x   �� 5#   
   -   5        $��txtScore��5#      $��22(�6    $��	ExtraBold"�6.   $��Score: 0��6E   5%      5&      