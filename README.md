![QUTMS_Banner](https://raw.githubusercontent.com/Technosasquach/QUTMS_Master/master/src/qutmsBanner.jpg)

# QUT Motorsport - Configuration Program V1

## THIS PROJECT HAS BEEN DEPRECATED, PLEASE CONTINUE WORK AT [QUTMS_ConfigurationSoftware](https://github.com/Technosasquach/QUTMS_ConfigurationSoftware "QUTMS_ConfigurationSoftware")

### What
The C# Software is a program that will take and interpet the various serial packets from the car. They will then be displayed and made editable in an extensive ui.
### Why
The car has hundreds of various variables and settings that need to be fine tuned over time, to reach optimal performance. Constantly flashing the chips with hardset changes is not only in-efficent but it also requires a high level of knowlage to simply change the total power output for instance. It will make this process fast, easy and friendly (over a block of C code) that even a mechanical member wont have issues.
### How
The program works like a client dose in the internet. Every time it wants new information, or wants to update something, it will send a request to the main [ChassisController](https://github.com/Technosasquach/QUTMS_ChassisController "QUTMS_ChassisController"), which in turn send back the relevant information that had been requested. If this inital request contains data that is different to whats on the system, it will change the value accordingly.
### Where
This system will be made avaliable to the entire QUTMS team, as its just software. It will sit on a computer and be used when ever it needs to be.

# Software Structure

