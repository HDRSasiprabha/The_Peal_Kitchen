   M S B A M L   `   `   `  ????I  EThePealKitchen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ThePealKitchenThePealKitchen  5   	       ThePealKitchen.AdminLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ThePealKitchen     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2054, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          ?Name$  AdminLoginWindow??5   	   $	??500??5      $	??350??6'    ? 
ResizeMode$ NoResize=?63    ? WindowStartupLocation$ CenterScreen=?6I    ? Icon$' !Icons and images/profile_48px.png??6n   .??5	      ? .+?5
   
   ?? $	??280??6   $	??Top=?6!   ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5      ?  ? Color$ 	#FF008AFF??6#   ? 5      $ 	#FF110848??6#    ? Offset$ 1Q?65   ? 5      $ 	#FF33288B??6#   $ 0.546Q?65   5      5      ?? 5   
   $
??Left=?6   $	??110??6+   $??105,126,0,0q?68   $	??Top=?6M   $	??118??6e   $L??FIcons and images/health-wellness_health-centers_children_-1024x768.jpg??6q   $??UniformToFill=?6?   ? 5   
   $??2,280,-1,2.4q?6   .+?5      ?? -   5         ??Name$ txt_username??5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Enter Username??5      
   
Foreground

 ?  ??.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ?  ?? %  !MaterialDesignFloatingHintTextBox#??[  5      $??18,10,34,128q?6>   $??MV Boli)?6T   G? 5      -   5         G?Name$ 	txt_pswrd??5      $	 Enter Password??5      

 ??  ?
 ??  ? ) %MaterialDesignFloatingHintPasswordBox#??[ 5       $??18,77,34,68q?6P   $??MV Boli)?6e   ?? 5!      -   5         ??Name$ 	btn_login??5!       & "MaterialDesignFloatingActionButton#??[ 5"      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   IsIndicatorVisible .    Value$ -1Q?5$         IsIndeterminate . $??Log In??5&      $??135,133,161,8q?6   $
??Auto??6+   $
??Auto??69   ???	#FF06375D$??11(?6]   $??SimSun)?6k   6   5'      ?? 5(   
   $
??Left=?6   $??	42,20,0,0q?6/   $
??Wrap=?6B   $!??Welcome To The Admin Panel!??6V   $	??Top=?6y   $??79??6?   $	??258??6?   $
??Bold"?6?   $??Source Sans Pro Black)?6?   $??20(?6?    ?? TextAlignment$ Center=?6?   ???	#FFF0DEDE6  5)      5*      