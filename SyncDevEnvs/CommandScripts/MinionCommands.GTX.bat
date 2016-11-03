

"C:\Program Files\7-Zip\7z" -y x "D:\Sync\BT-GT\SyncDevEnvs_SYNC\IMPrinting_{FILE_TIMESTAMP}.7z" -o"D:\temp\SyncDevEnvs_TEMP" -pNWSpOspawxHjTkc6FOByjtjky9RP6CSmc96J7qtflxf8qhv1qfANogDLXRss3A9U1mFG9V8DmVrhaYc5qjlyTp93MG4TKe2DxxOcwJ4zO6NYMqXOmcn1OWqsg9mn60o35OnWQmBBaF4SvJu66usx6nfzMIBCm4nCNuDvsaSFqyw6ijptT99QLIeny7g3nu0aMmSY6OGpq3Qc9aFApJBecjf8fmmQozFg5Gxz7hzijRGpM8UWuWTZp13ctKGkZxzYb5KfwkbBaVRS3SyeTi34VEZvxvHcTRONIBryhZ2aYPIwbuAHlMWzubfnTk

"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE" -S BLACKBELT -d IMPrintingLucy -Q "ALTER DATABASE IMPrintingLucy SET SINGLE_USER WITH ROLLBACK AFTER 5"

"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE" -S BLACKBELT -d IMPrintingLucy -Q "RESTORE DATABASE IMPrintingLucy FROM DISK = 'D:\temp\SyncDevEnvs_TEMP\IMPrinting_{FILE_TIMESTAMP}.BAK'"

"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE" -S BLACKBELT -d IMPrintingLucy -Q "ALTER DATABASE IMPrintingLucy SET MULTI_USER"

"C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE" -S BLACKBELT -d IMPrintingLucy -Q "USE IMPrintingLucy; EXEC sp_addrolemember N'db_owner', N'sa-dbo'"

del /Q "D:\temp\SyncDevEnvs_TEMP\IMPrinting_{FILE_TIMESTAMP}.BAK"
