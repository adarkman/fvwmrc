# CrystalZono colorset
# Written by: domi.no (domi.no@terra.es)

SetEnv Colorset-Name "CrystalZono"
SetEnv Colorset-Author "domi.no (domi.no@terra.es)"

# What colorsets do we use?
Read $./colorset-definition

# -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
# QuakeConsole, thumbnailed windows
Colorset $[cs-quakeconsole] \
Foreground "black", Background "black", \
Hilight "black", Shadow "black", \
IconAlpha 50


Colorset $[cs-panel-inactive] \
Foreground "black", Background "white", \
Tint "white" 0, RootTransparent, \
fgTint, IconAlpha, IconTint

Colorset $[cs-panel-active] \
Foreground "white", Background "darkgray", \
Hilight "darkgray", Shadow "darkgray", \
Tint "gray" 50, RootTransparent

Colorset $[cs-panel-wininactive] \
Foreground "#555555", Background "#777777", \
Hilight "gray", Shadow "gray", \
Tint "white" 0, RootTransparent

Colorset $[cs-panel-winactive] \
Foreground "black", Background "#777777", \
Hilight "black", Shadow "black", \
Tint "white" 0, RootTransparent

Colorset $[cs-panel-border] \
Background "#777777"

Colorset $[cs-menu-inactive] \
Foreground "white", Background "#777777", \
Hilight "#777777", Shadow "#777777", \
Tint "white" 0, RootTransparent, Tint black 50

Colorset $[cs-menu-active] \
Foreground "black", Background "gray", \
Hilight "black", Shadow "gray"

Colorset $[cs-window-inactive] \
			 fg black, bg black, hi black, sh gray, RootTransparent, Tint black 60

Colorset $[cs-window-active] \
			 fg white, bg gray, hi gray, sh gray, RootTransparent, Tint black 60

# -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
# Additional variables
SetEnv ThumbBorderColor "gray"
SetEnv ExternalFontColor "gray40"

SetEnv TrayerTint "0xFFFFFF"
SetEnv TrayerAlpha "256"

