   M S B A M L   `   `   `  ????I  EThePealKitchen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ThePealKitchenThePealKitchen  5   	       ThePealKitchen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ThePealKitchen     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2054, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	??600??5      $
??1080??6'     ? 
ResizeMode$  NoResize=?64    ? WindowStartupLocation$ CenterScreen=?6J    ? WindowStyle$
 None=?6o   .??5	      ? $??
0,0,0,-9.4q?6   $	??600??6    ? RowDefinitions 5
   
   ?? 5      .+?5   
   ? $??-1,-4,0,550q?6   .+?5      ?? $??Center=?6    ?? Orientation$ 
Horizontal=?66   ?? 5      $ 
Horizontal=?6   $??Right=?62   $
??10 0q?6N   .+?5      ?? -   5         ??Name$ 
AdminLogin??5      $??30??6-   $
??Auto??68   $??0q?6s   
???????$??
0,2,10,1.6q?6?   ??6F   Z? ??6\   Z? .??5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=?6.   5      ?? 5      -   5        $ PowerOff??5      $??30??6+   $??30??66   $??0q?6o   
?????????6B   Z? ??6X   Z? .??5        $ Power=?6.   5      5      $   ThePealKitchen.UserControlHome  5      $
??Left=?6$   $??35??6?   $??871,0,0,-0.4q?6K   $	??Top=?6a   $	??100??6y   5      ? 5   
   $??
160,36,0,0q?6   .+?5      ? -   5         ?Name$ GridPrincipal??5      $??Center=?6*   $??Center=?6G   5      ? 5   
   $
??Left=?6   $	??607??6*   $??0,-8,0,0q?67   $	??Top=?6I   $	??160??6a   ???	#FF000156.+?5      ?? $
??Left=?6   $	??160??6/   $	??Top=?6<   $	??160??6T   $??Logo white.png??6`   $??UniformToFill=?6x   5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5   
   -   5          Name$ TrainsitionigContentSlide??5   .   $??	0,-5,0,10q?6?   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X?6?   ? 5    
   -   5        $ 
GridCursor??5       $??	0 165 0 0q?6#   ???	#FF0069C0$??10??6M   $
??Left=?6X   $??60??6s   $	??Top=?6   ?? 5!   
   -   5         ??Name$ ListViewMenu??5!      $??0,160,920,9q?6)   
???????$??Champagne & Limousines)?6U   $??18(?6}    ?? SelectedIndex$ 0??6?   .@?5"      ?? $??60??6   .??5#      ?? $ 
Horizontal=?6   .+?5$        $
 Home=?6.   $??30??6:   $??30??6E   $??Center=?6Q   $??5q?6l   ?? 5%      $
??Home??6    $??17(?6,   $??Center=?6:   $
??20 0q?6U   5&      5'      ?? 5(      $??60??6   .??5)      ?? $ 
Horizontal=?6   .+?5*        $ FoodForkDrink=?6.   $??30??6C   $??30??6N   $??Center=?6Z   $??5q?6u   ?? 5+      $
??Menu??6    $??17(?6,   $??Center=?6:   $
??20 0q?6U   5,      5-      ?? 5.      $??60??6   .??5/      ?? $ 
Horizontal=?6   .+?50        $ UserAdd=?6.   $??30??6=   $??30??6H   $??Center=?6T   $??5q?6o   ?? 51      $
??Join??6    $??17(?6,   $??Center=?6:   $
??20 0q?6U   52      53      ?? 54      $??60??6   .??55      ?? $ 
Horizontal=?6   .+?56        $ Discount=?6.   $??30??6>   $??30??6I   $??Center=?6U   $??5q?6p   ?? 57      $??Offers??6    $??17(?6.   $??Center=?6<   $
??20 0q?6W   58      59      5:      5;      5<      