   M S B A M L   `   `   `  ????I  EThePealKitchen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ThePealKitchenThePealKitchen  5   	   (    "ThePealKitchen.Foodselectionwindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ThePealKitchen     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2054, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	??600??5	      $
??1080??6'     ? 
ResizeMode$  CanMinimize=?64    ? WindowStartupLocation$ CenterScreen=?6M    ? WindowStyle$
 None=?6r   
???????.??5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide??5
   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6M   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *FadeIn+   Duration$ 0:0:9.0X?.??5   
   ? $
??1080??6   $	??600??6   .+?5      ? $
??Left=?6   $	??301??6.   $	??Top=?6;   $	??540??6S   .+?5      ? $
??Left=?6   $	??300??62   $	??Top=?6?   $	??540??6W   $??539,0,-539,0q?6c   .+?5      ?? $
??Left=?6   $	??247??67   $??	26,26,0,0q?6D   $	??Top=?6W   $	??271??6o   $,??&sub menu images/pasta for sub menu.jpg??6{   $??UniformToFill=?6?   ?? 5      $
??Left=?6    $??
324,63,0,0q?6;   $
??Wrap=?6O   $????Pasta is a type of food typically made from an unleavened dough of wheat flour mixed with water or eggs, and formed into sheets or other shapes, then cooked by boiling or baking.??6c   $	??Top=?6  $	??157??65  $	??206??6B  $
??Bold"?6N  ?? 5      -   5         "  MaterialDesignRaisedDarkButton#??[  5      $
??Auto??5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25??5       ? ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners??5      $??342,235,37,9.2q?6Q   ???	#FFC00000.??5      ?? $??
Check Menu??5      5      5      ? 5      $
??Left=?6   $	??300??62   $	??Top=?6?   $	??540??6W   $??539,300,-539,-300q?6c    ? ColumnDefinitions 5      ?? 5      $
??121* ?6+   ?? 5      $	??14* ?6+   .+?5      ?? $
??Left=?6   $	??247??67   $??	26,26,0,0q?6D   $	??Top=?6W   $	??271??6o   $,??&sub menu images/kottu for sub menu.jpg??6{   $??UniformToFill=?6?   ?? 5       $
??Left=?6    $??
324,64,0,0q?6;   $
??Wrap=?6O   $????Kottu is a Sri Lankan dish made from godhamba roti and vegetables, egg and/or meat, and spices. The bread is described as very similar to the type found in the south Indian kothu parotta and Roti canai.??6c   $	??Top=?65  $	??156??6M  $	??206??6Z  $
??Bold"?6f  $??2??6x  ?? 5!      -   5        #??[  5"      $
??Auto??5#      $ 25??5$      $7 1MaterialDesignRaisedDarkButton with Round Corners??5%      $??342,235,37,9q?6Q   $??2??6?   ???	#FFC00000$??
Check Menu??6?   '  !MaterialDesignThemes.Wpf.PackIcon  5&      	   Kind$	 ArrowLeftBoldCircle=?6.   $??1??6I   $
??Left=?6Y   $??
24,273,0,0q?6t   $	??Top=?6?   $??27??6?   $??32??6?   ?? 5'      -   5        $?? ??5'      $??1??6(   $??
24,273,0,0q?68   $
??Auto??6?   ??6L   Z? ??6b   Z? ??6y   Z? 6?   5(      ?? 5)      $
??Left=?6   $	??247??63   $??	26,26,0,0q?6@   $	??Top=?6S   $	??271??6k   $+??%sub menu images/rice for sub menu.jpg??6w   $??UniformToFill=?6?   ?? 5*      $
??Left=?6   $??
324,64,0,0q?67   $
??Wrap=?6K   $????Rice is the seed of the grass species Oryza glaberrima or Oryza sativa. As a cereal grain, it is the most widely consumed staple food for a large part of the world's human population, especially in Asia and Africa. It is the agricultural commodity with the third-highest worldwide production, after sugarcane and maize.??6_   $	??Top=?6?  $	??156??6?  $	??206??6?  $
??Bold"?6?  ?? 5+      -   5        #??[  5,      $
??Auto??5-      $ 25??5.      $7 1MaterialDesignRaisedDarkButton with Round Corners??5/      $??342,235,37,10q?6A   ???	#FFC00000.??50      ?? $??
Check Menu??51      52      ?? 53      $
??Left=?6   $??
324,10,0,0q?67   $
??Wrap=?6K   $??	Rice Menu??6_   $	??Top=?6p   $??33??6?   $	??206??6?   $
??Bold"?6?   $??20(?6?   
 ?? TextAlignment$
 Center=?6?   ???	#FF001FFF6?   ?? 54      $
??Left=?6   $??324,323,0,-55q?67   $
??Wrap=?6N   $??Noodless Menu??6b   $	??Top=?6w   $??33??6?   $	??206??6?   $
??Bold"?6?   $??20(?6?   $
 Center=?6?   ???	#FF001FFF6?   ?? 55      $
??Left=?6   $??857,13,-523,0q?67   $
??Wrap=?6N   $??
Pasta Menu??6b   $	??Top=?6t   $??33??6?   $	??206??6?   $
??Bold"?6?   $??20(?6?   $
 Center=?6?   ???	#FF001FFF6?   ?? 56      $
??Left=?6   $??857,323,-523,-55q?67   $
??Wrap=?6Q   $??
Kottu Menu??6e   $	??Top=?6w   $??33??6?   $	??206??6?   $
??Bold"?6?   $??20(?6?   $
 Center=?6?   ???	#FF001FFF6?   57      ? 59      $
??Left=?6   $	??300??6.   $	??Top=?6;   $	??540??6S   $??
0,301,0,-1q?6_   .+?5:      ?? $
??Left=?6   $	??247??63   $??	26,26,0,0q?6@   $	??Top=?6S   $	??271??6k   $.??(sub menu images/noodles for sub menu.jpg??6w   $??UniformToFill=?6?   ?? 5;      $
??Left=?6   $??
324,61,0,0q?67   $
??Wrap=?6K   $????Noodles are a type of food made from unleavened dough which is rolled flat and cut, stretched or extruded, into long strips or strings. Noodles can be refrigerated for short-term storage or dried and stored for future use. Noodles are usually cooked in boiling water, sometimes with cooking oil or salt added??6_   $	??Top=?6?  $	??159??6?  $	??206??6?  $
??Bold"?6?  ?? 5<      -   5        #??[  5=      $
??Auto??5>      $ 25??5?      $7 1MaterialDesignRaisedDarkButton with Round Corners??5@      $??342,235,37,9.2q?6M   ???	#FFC00000.??5A      ?? $??
Check Menu??5B      5C      5D      5J      5K      5L      