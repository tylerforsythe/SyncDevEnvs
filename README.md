# SyncDevEnvs
Tool I wrote to shuttle database backups between my laptop and desktop with a couple button clicks.

# Longer Summary
I use a laptop and desktop for development. Mostly my desktop but sometimes laptop. While git allows me to move code between the two extremely easily, the database is another story. This allows me to shuffle between the two very easily.

# Details
My laptop is called BLACKBELT and my desktop is called GTX. I can set one of them to "overlord" (database source) and one "minion" (database destination). The code will then execute a couple Windows batch scripts that do the rest security with an encrypted 7z file and BitTorrent Sync. 99% of the time these files should transmit locally in my network, but I encrypt everything that could possibly go out over the internet.

I have config settings in code and do a find-replace in the batch scripts to allow flexibility. I choose batch scripts over straight .NET code because it was so much faster to write and does eveything I need.

# Future Features
* App living in the system tray
* App fires on a schedule. That is, it would wake every night and check a value to see if it should run that night or skip. (I don't need or want it to run every single night.)
* Multiple databases possible
* Form cleanup
* Batch file executed line by line and a progress bar and status updated on the form

# Requirements
* Microsoft SQL Server
* Ability to execute .NET code
* 7-zip
* BitTorrent Sync (or some other data move mechanism--could be a network share)
