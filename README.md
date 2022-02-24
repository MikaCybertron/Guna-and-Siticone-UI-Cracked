## CrackedUI
Developed by Verity with Anger towards Guna & Siticone License Managers.

### What does CrackedUI Do?

Its main function is to detect when one of Guna's or Siticone's license managers pop up and to then dispose of them for you.
You would usually have to wait 15 seconds before it lets you close it, what this application does is hide it for you so that its no longer in the way.
Due to the fact that it is hidden and not actually closed it never pop's up again until you re-open your IDE.

It also adds itself to startup so you never have to run it again.

### Performance

I tried to make sure it wasn't eating up computer resources while also making the patching as fast a possible.
It uses 2-4% CPU usage while running which tbh is to high for me and I want to lower it in the future.
Every 300MS it will search for Rider/VS and attempt to patch Guna or Siticone if they're found.
