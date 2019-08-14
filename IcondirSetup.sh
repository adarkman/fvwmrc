#! /bin/bash
#
# /etc/fstab:
#	tmpfs           /ramdisk        tmpfs   size=256M,noexec,gid=1002,mode=770      0       0
#
# Usage: $0 USER DEST_DIR_IN_HOME

ICD=/ramdisk/$USER-icons
mkdir -p $ICD
if [ -d $ICD ]; then 
	rm -f $ICD/*
	ln -sf $ICD $1
fi

exit 0


