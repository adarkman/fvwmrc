#! /bin/bash
# Usage: 
# 	$1 - $[THUMB_DIR]
# 	$2 - $[w.id]

if [ -f $1/icon.tmp.$2.snap.png ]; then
	echo "SendToModule WindowSnap ChangeButton WindowSnapBtn Icon $1/icon.tmp.$2.snap.png"
else
	if [ -f $1/icon.tmp.$2.base.png ]; then 
		echo "SendToModule WindowSnap ChangeButton WindowSnapBtn Icon $1/icon.tmp.$2.base.png"
	else
		echo "SendToModule WindowSnap ChangeButton WindowSnapBtn Icon $HOME/bmp/fvwm/Irix/cde-icon-base.png"
	fi
fi
exit 0

