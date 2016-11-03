
del /Q "D:\Sync\BT-GT\SyncDevEnvs_SYNC\STATUS_{DATE}.txt"

"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE" -S GTX -d IMPrintingLucy -Q "BACKUP DATABASE IMPrintingLucy TO DISK = 'D:\temp\SyncDevEnvs_TEMP\IMPrinting_{DATETIME}.BAK'"

"C:\Program Files\7-Zip\7z" a -mmt -t7z -mx7 "D:\Sync\BT-GT\SyncDevEnvs_SYNC\IMPrinting_{DATETIME}.7z" D:\temp\SyncDevEnvs_TEMP\IMPrinting_{DATETIME}.BAK -pNWSpOspawxHjTkc6FOByjtjky9RP6CSmc96J7qtflxf8qhv1qfANogDLXRss3A9U1mFG9V8DmVrhaYc5qjlyTp93MG4TKe2DxxOcwJ4zO6NYMqXOmcn1OWqsg9mn60o35OnWQmBBaF4SvJu66usx6nfzMIBCm4nCNuDvsaSFqyw6ijptT99QLIeny7g3nu0aMmSY6OGpq3Qc9aFApJBecjf8fmmQozFg5Gxz7hzijRGpM8UWuWTZp13ctKGkZxzYb5KfwkbBaVRS3SyeTi34VEZvxvHcTRONIBryhZ2aYPIwbuAHlMWzubfnTk

@echo COMPLETE {DATETIME}> "D:\Sync\BT-GT\SyncDevEnvs_SYNC\STATUS_{DATE}.txt"

del /Q "D:\temp\SyncDevEnvs_TEMP\IMPrinting_{DATETIME}.BAK"
